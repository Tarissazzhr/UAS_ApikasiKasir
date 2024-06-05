Imports System.Data.Odbc

Module Module1
    Public koneksi As OdbcConnection
    Public da As OdbcDataAdapter
    Public ds As DataSet1
    Public dr As OdbcDataReader
    Public dml As OdbcCommand
    Public sql As String
    Public Sub buka_koneksi()
        koneksi = New OdbcConnection("DSN=master;")
        If koneksi.State = ConnectionState.Closed Then
            koneksi.Open()
        End If
    End Sub

End Module
