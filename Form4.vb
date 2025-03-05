Public Class Form4
    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Cmb_role.Items.Add("Kasir")
        Cmb_role.Items.Add("Manager")
        Cmb_role.Items.Add("Admin")

        Button2.Hide()
        Button3.Hide()
        Button4.Hide()

        TxtUsername.Focus()
        TxtPassword.UseSystemPasswordChar = True
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If TxtUsername.Text = "" And TxtPassword.Text = "" Then
            MsgBox("Username & Password tidak boleh kosong!", MsgBoxStyle.Exclamation, "Isi Username & Password")
        ElseIf TxtUsername.Text = "Andes" And TxtPassword.Text = "123" Then
            MsgBox("Welcome, Kasir!", MsgBoxStyle.Information, "Akses berhasil")
            Form2.Show()
            Me.Hide()
        Else
            MsgBox("Anda Bukan Kasir", MsgBoxStyle.Critical, "Kombinasi Username & Password Salah!")
            Call Bersih()
            TxtUsername.Focus()
        End If
    End Sub
    Sub Bersih()
        TxtUsername.Text = ""
        TxtPassword.Text = ""
    End Sub

    Private Sub TxtPassword_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtPassword.KeyPress
        If Asc(e.KeyChar) = 13 Then
        End If
    End Sub

    Private Sub Cmb_role_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cmb_role.SelectedIndexChanged
        Dim selectedCategory As String = Cmb_role.SelectedItem.ToString()

        If selectedCategory = "Kasir" Then
            Button2.Show()
            Button1.Hide()
            Button3.Hide()
            Button4.Hide()
        ElseIf selectedCategory = "Manager" Then
            Button3.Show()
            Button1.Hide()
            Button2.Hide()
            Button4.Hide()
        ElseIf selectedCategory = "Admin" Then
            Button4.Show()
            Button1.Hide()
            Button2.Hide()
            Button3.Hide()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TxtUsername.Text = "" And TxtPassword.Text = "" Then
            MsgBox("Pilih Role Yang Tersedia!", MsgBoxStyle.Exclamation, "Anda Siapa?")
        Else
            MsgBox("Pilih Role Yang Tersedia!", MsgBoxStyle.Critical, "Anda Siapa?")
            Call Bersih()
            TxtUsername.Focus()
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If TxtUsername.Text = "" And TxtPassword.Text = "" Then
            MsgBox("Username & Password tidak boleh kosong!", MsgBoxStyle.Exclamation, "Isi Username & Password")
        ElseIf TxtUsername.Text = "Andes" And TxtPassword.Text = "456" Then
            MsgBox("Welcome, Manager!", MsgBoxStyle.Information, "Akses berhasil")
            Form6.Show()
            Me.Hide()
        Else
            MsgBox("Anda Bukan Manager", MsgBoxStyle.Critical, "Kombinasi Username & Password Salah!")
            Call Bersih()
            TxtUsername.Focus()
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If TxtUsername.Text = "" And TxtPassword.Text = "" Then
            MsgBox("Username & Password tidak boleh kosong!", MsgBoxStyle.Exclamation, "Isi Username & Password")
        ElseIf TxtUsername.Text = "Andes" And TxtPassword.Text = "789" Then
            MsgBox("Welcome, Admin!", MsgBoxStyle.Information, "Akses berhasil")
            Form6.Show()
            Me.Hide()
        Else
            MsgBox("Anda Bukan Admin", MsgBoxStyle.Critical, "Kombinasi Username & Password Salah!")
            Call Bersih()
            TxtUsername.Focus()
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

    End Sub
End Class