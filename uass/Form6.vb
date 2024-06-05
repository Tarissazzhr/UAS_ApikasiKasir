Imports System.Data.Odbc
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports Microsoft.Reporting.WinForms

Public Class Form6
    Public var_id As String
    Sub kosong()
        txtidb.Clear()
        txtqty.Clear()
        lblhargabeli.Text = ""
        lblhargajual.Text = ""
        lblstok.Text = ""
        txtidb.Focus()
    End Sub

    Sub datagrid()
        da = New OdbcDataAdapter("select * from sementarajual order by Id", koneksi)
        ds = New DataSet1
        da.Fill(ds, "sementarajual")
        DataGridView1.DataSource = ds.Tables("sementarajual")
        DataGridView1.ReadOnly = True

        DataGridView1.Columns("Id").HeaderText = "Id"
        DataGridView1.Columns("Kode_Barang").HeaderText = "Id Barang"
        DataGridView1.Columns("Harga_Jual").HeaderText = "Harga Jual"
        DataGridView1.Columns("Kuantitas").HeaderText = "Kuantitas"
        DataGridView1.Columns("Total_Harga").HeaderText = "Total Harga"


        DataGridView1.Columns("Id").Width = "20"
        DataGridView1.Columns("Kode_Barang").Width = "20"
    End Sub
    Sub MunculNama_barang()
        Call buka_koneksi()
        ComboBox1.Items.Clear()
        dml = New OdbcCommand("select Nama_barang from barang", koneksi)
        dr = dml.ExecuteReader
        Do While dr.Read
            ComboBox1.Items.Add(dr.Item(0))
        Loop
    End Sub

    Sub hitungtotal()
        txttotal.Text = (From row As DataGridViewRow In DataGridView1.Rows
                         Where row.Cells(5).FormattedValue.ToString() <> String.Empty
                         Select Convert.ToInt32(row.Cells(5).FormattedValue)).Sum().ToString()
    End Sub

    Sub nootomatis()
        dml = New OdbcCommand("select * from penjualan where Id in(select(max(Id)) from penjualan)", koneksi)
        dr = dml.ExecuteReader
        dr.Read()
        Dim hitung As Integer
        If Not dr.HasRows Then
            TextBox1.Text = "0000000001"
        Else
            hitung = Val(Microsoft.VisualBasic.Right(dr.Item("Id").ToString, 10)) + 1
            TextBox1.Text = "000000000" & hitung
        End If
    End Sub

    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call MunculNama_barang()
        datagrid()
        nootomatis()
        kosong()
        hitungtotal()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        dml = New OdbcCommand("select * from barang where Nama_barang = '" & ComboBox1.Text & "'", koneksi)
        dr = dml.ExecuteReader
        dr.Read()
        If dr.HasRows Then
            txtidb.Text = dr.Item("Kode_barang")
            lblhargabeli.Text = dr.Item("Harga_beli")
            lblstok.Text = dr.Item("Stok")
            lblhargajual.Text = dr.Item("Harga_Jual")
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim simpan As String
        simpan = "insert into sementarajual (Kode_Barang, Harga_Beli, Harga_Jual, Kuantitas, Total_Harga) values ('" &
            txtidb.Text &
            "','" & lblhargabeli.Text &
            "','" & lblhargajual.Text &
            "','" & txtqty.Text &
            "','" & txtqty.Text * lblhargajual.Text &
            "')"

        dml = New OdbcCommand("Select Stok from barang where Kode_barang = '" & txtidb.Text & "'", koneksi)
        dr = dml.ExecuteReader
        dr.Read()
        If dr.HasRows Then
            Dim ubah As String = "update barang set Stok ='" & dr.Item("Stok") - txtqty.Text &
                "' where Kode_barang='" & txtidb.Text & "'"
            dml = New OdbcCommand(ubah, koneksi)
            dml.ExecuteNonQuery()
        End If

        dml = New OdbcCommand(simpan, koneksi)
        dml.ExecuteNonQuery()

        datagrid()
        hitungtotal()
        kosong()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        var_id = DataGridView1.Rows(e.RowIndex).Cells(0).Value
        txtidb.Text = DataGridView1.Rows(e.RowIndex).Cells(1).Value
        txtqty.Text = DataGridView1.Rows(e.RowIndex).Cells(4).Value
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim hapus As String
        hapus = "delete from sementarajual where id='" & var_id & "'"

        dml = New OdbcCommand("Select Stok from barang where Kode_barang = '" & txtidb.Text & "'", koneksi)
        dr = dml.ExecuteReader
        dr.Read()
        If dr.HasRows Then
            Dim ubah As String = "update barang set Stok = Stok + " & txtqty.Text &
                " where Kode_barang='" & txtidb.Text & "'"
            dml = New OdbcCommand(ubah, koneksi)
            dml.ExecuteNonQuery()
        End If

        dml = New OdbcCommand(hapus, koneksi)
        dml.ExecuteNonQuery()

        datagrid()
        kosong()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        buka_koneksi()
        dml = New OdbcCommand("select * from penjualan where Id='" & TextBox1.Text & "'", koneksi)
        dr = dml.ExecuteReader
        dr.Read()
        If Not dr.HasRows Then
            Dim simpan As String
            simpan = "insert into penjualan (Id, Total_Harga, tgljual) values('" &
                    TextBox1.Text &
                    "','" & txttotal.Text &
                    "','" & Format(Now, "yyyy-MM-dd") &
                    "')"

            For baris As Integer = 0 To DataGridView1.RowCount - 2
                Dim simpandetail As String
                simpandetail = "insert into detailpenjualan (id_penjualan, Kode_barang, Harga_beli, Harga_Jual, Kuantitas, Total_Harga) values('" &
                    TextBox1.Text &
                    "','" & Val(DataGridView1.Rows(baris).Cells(1).Value) &
                    "','" & Val(DataGridView1.Rows(baris).Cells(2).Value) &
                    "','" & Val(DataGridView1.Rows(baris).Cells(3).Value) &
                    "','" & Val(DataGridView1.Rows(baris).Cells(4).Value) &
                    "','" & Val(DataGridView1.Rows(baris).Cells(5).Value) &
                    "')"
                dml = New OdbcCommand(simpandetail, koneksi)
                dml.ExecuteNonQuery()
            Next
            dml = New OdbcCommand(simpan, koneksi)
            dml.ExecuteNonQuery()


            Dim hapus As String = "delete from sementarajual"
            dml = New OdbcCommand(hapus, koneksi)
            dml.ExecuteNonQuery()

            nootomatis()
            datagrid()
            txttotal.Clear()
            kosong()
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        buka_koneksi()
        Dim tbl As New DataTable
        da = New OdbcDataAdapter("SELECT * from sementarajual ORDER BY sementarajual.Id", koneksi)
        da.Fill(tbl)


        Dim parameter(1) As ReportParameter
        parameter(0) = New ReportParameter("transaksi", TextBox1.Text)
        parameter(1) = New ReportParameter("subtotal", txttotal.Text)

        Form8.ReportViewer1.LocalReport.SetParameters(parameter)
        Form8.ReportViewer1.LocalReport.DataSources.Clear()
        Form8.ReportViewer1.LocalReport.DataSources.Add(New ReportDataSource("DataSetJual", tbl))

        Form8.ReportViewer1.LocalReport.Refresh()
        Form8.ShowDialog()
        koneksi.Close()
    End Sub
End Class