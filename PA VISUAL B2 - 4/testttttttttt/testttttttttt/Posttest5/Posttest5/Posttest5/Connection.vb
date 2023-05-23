Imports System.Data.Common
Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient
Module koneksion
    Public CONN As New MySqlConnection
    Public CMD As MySqlCommand
    Public RD As MySqlDataReader
    Public DA As MySqlDataAdapter
    Public DS As DataSet
    Public STR As String
    Public QUERY As String

    Sub koneksi()
        Try
            CONN.Close()
            CONN.ConnectionString = "server=Localhost; user id=root; password=; database=db_pesawat"
            CONN.Open()
        Catch ex As Exception
            MsgBox(ErrorToString)
        End Try
    End Sub
End Module