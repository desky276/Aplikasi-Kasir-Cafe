Public Class Form8

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If TxtNewUsername.Text = "" Or TxtNewPassword.Text = "" Then
            MsgBox("Username & Password tidak boleh kosong!", MsgBoxStyle.Exclamation, "Isi Username & Password")
        Else
            ' Baca semua baris dari file teks yang berisi daftar pengguna terdaftar
            Dim lines() As String = System.IO.File.ReadAllLines("UserAccounts.txt")

            ' Periksa apakah nama pengguna sudah terdaftar
            For Each line As String In lines
                Dim parts() As String = line.Split(","c)
                If parts(0) = TxtNewUsername.Text Then
                    MsgBox("Username sudah terdaftar!", MsgBoxStyle.Critical, "Registrasi Gagal")
                    Return
                End If
            Next

            ' Tambahkan data pengguna baru ke file teks
            Dim newAccount As String = TxtNewUsername.Text & "," & TxtNewPassword.Text
            System.IO.File.AppendAllText("UserAccounts.txt", newAccount & vbCrLf)

            MsgBox("Registrasi berhasil!", MsgBoxStyle.Information, "Registrasi Berhasil")
            ' Bersihkan input setelah registrasi berhasil
            TxtNewUsername.Text = ""
            TxtNewPassword.Text = ""
        End If
    End Sub

    Private Sub Form8_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TxtNewUsername.Focus()
        TxtNewPassword.UseSystemPasswordChar = True
    End Sub

    Private Sub TxtNewPassword_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtNewPassword.KeyPress
        If Asc(e.KeyChar) = 13 Then
        End If
    End Sub
End Class