Imports System.Data.Odbc

Public Class Form1

    Private Sub UserToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UserToolStripMenuItem.Click
        Dim f2 As New Form2
        Me.IsMdiContainer = True
        f2.MdiParent = Me
        f2.Show()
    End Sub

    Private Sub SupplierToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SupplierToolStripMenuItem.Click
        Dim f4 As New Form4
        Me.IsMdiContainer = True
        f4.MdiParent = Me
        f4.Show()
    End Sub

    Private Sub BarangToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BarangToolStripMenuItem.Click
        Dim f3 As New Form3
        Me.IsMdiContainer = True
        f3.MdiParent = Me
        f3.Show()
    End Sub

    Private Sub PembelianToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PembelianToolStripMenuItem.Click
        Dim f5 As New Form5
        Me.IsMdiContainer = True
        f5.MdiParent = Me
        f5.Show()
    End Sub

    Private Sub PenjualanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PenjualanToolStripMenuItem.Click
        Dim f6 As New Form6
        Me.IsMdiContainer = True
        f6.MdiParent = Me
        f6.Show()
    End Sub

    Private Sub PembelianToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles PembelianToolStripMenuItem1.Click
        buka_koneksi()
        Dim tbl As New DataTable

        da = New OdbcDataAdapter("SELECT  * FROM pembelian ORDER BY Id", koneksi)

        da.Fill(tbl)

        Form9.ReportViewer1.LocalReport.DataSources.Clear()
        Form9.ReportViewer1.LocalReport.DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("DataSetbltotal", tbl))

        Form9.ReportViewer1.LocalReport.Refresh()
        Form9.ShowDialog()
        koneksi.Close()
    End Sub

    Private Sub PenjualanToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles PenjualanToolStripMenuItem1.Click
        buka_koneksi()
        Dim tbl As New DataTable

        da = New OdbcDataAdapter("SELECT  * FROM penjualan ORDER BY Id", koneksi)

        da.Fill(tbl)

        Form10.ReportViewer1.LocalReport.DataSources.Clear()
        Form10.ReportViewer1.LocalReport.DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("DataSetjualtotal", tbl))

        Form10.ReportViewer1.LocalReport.Refresh()
        Form10.ShowDialog()
        koneksi.Close()
    End Sub
End Class
