Public Class Form3
    Private Sub BarangBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.BarangBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSet1)

    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet1.barang' table. You can move, or remove it, as needed.
        Me.BarangTableAdapter.Fill(Me.DataSet1.barang)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        BarangBindingSource.AddNew()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Validate()
        Me.BarangBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSet1)
        MsgBox("Record Saved")
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Validate()
        Me.BarangBindingSource.RemoveCurrent()
        Me.TableAdapterManager.UpdateAll(Me.DataSet1)
        MsgBox("Record Deleted")
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Kode_barangTextBox.Clear()
        Nama_barangTextBox.Clear()
        SatuanComboBox.Text = ""
        JenisComboBox.Text = ""
        Harga_beliTextBox.Clear()
        Harga_JualTextBox.Clear()
        StokTextBox.Clear()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form1.Show()
        Me.Close()
    End Sub

    Private Sub Nama_barangTextBox_TextChanged(sender As Object, e As EventArgs) Handles Nama_barangTextBox.TextChanged

    End Sub

    Private Sub SatuanLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Harga_beliLabel_Click(sender As Object, e As EventArgs)

    End Sub
End Class