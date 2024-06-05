Public Class Form2
    Private Sub UserBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.UserBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSet1)

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet1.user' table. You can move, or remove it, as needed.
        Me.UserTableAdapter.Fill(Me.DataSet1.user)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form1.Show()
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        UserBindingSource.AddNew()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Validate()
        Me.UserBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSet1)
        MsgBox("Record Saved")
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Validate()
        Me.UserBindingSource.RemoveCurrent()
        Me.TableAdapterManager.UpdateAll(Me.DataSet1)
        MsgBox("Record Deleted")
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Kode_UserTextBox.Clear()
        Nama_UserTextBox.Clear()
        Pwd_UserTextBox.Clear()
        Status_UserComboBox.Text = ""
    End Sub

End Class