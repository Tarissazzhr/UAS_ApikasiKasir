Public Class Form4
    Private Sub SupplierBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.SupplierBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSet1)

    End Sub

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet1.supplier' table. You can move, or remove it, as needed.
        Me.SupplierTableAdapter.Fill(Me.DataSet1.supplier)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        SupplierBindingSource.AddNew()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Validate()
        Me.SupplierBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSet1)
        MsgBox("Record Saved")
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Validate()
        Me.SupplierBindingSource.RemoveCurrent()
        Me.TableAdapterManager.UpdateAll(Me.DataSet1)
        MsgBox("Record Deleted")
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Kode_SupplierTextBox.Clear()
        Nama_SupplierTextBox.Clear()
        Alamat_SupplierTextBox.Clear()
        Telepon_SupplierTextBox.Clear()
        Fax_SupplierTextBox.Clear()
        Email_SupplierTextBox.Clear()
        Contact_Person_SupplierTextBox.Clear()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form1.Show()
        Me.Close()
    End Sub

    Private Sub Email_SupplierTextBox_TextChanged(sender As Object, e As EventArgs) Handles Email_SupplierTextBox.TextChanged

    End Sub
End Class