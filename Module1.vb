Imports MySql.Data.MySqlClient
Module Module1
    Public CONN As MySqlConnection
    Public CMD As MySqlCommand
    Public RD As MySqlDataReader
    Public DA As MySqlDataAdapter
    Public DS As DataSet

    Sub koneksi()
        Try
            Dim str As String = "server=localhost;user id=root;password=;database=dbkasir"
            CONN = New MySqlConnection(str)

            If CONN.State = ConnectionState.Closed Then
                CONN.Open()
            End If
        Catch ex As Exception
        End Try
    End Sub
End Module
