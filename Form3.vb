Public Class Form3
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form5.Show()
        Me.Hide()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Form2.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End
    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PictureBox2.Hide()
        PictureBox3.Hide()
        PictureBox4.Hide()
        PictureBox5.Hide()
        PictureBox6.Hide()
        PictureBox7.Hide()
        PictureBox8.Hide()
        PictureBox9.Hide()
        PictureBox10.Hide()

        Cmb_jminum.Items.Add("Teh")
        Cmb_jminum.Items.Add("Kopi")
        Cmb_jminum.Items.Add("Jus Buah")
    End Sub

    Private Sub Cmb_jminum_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cmb_jminum.SelectedIndexChanged
        Cmb_nminum.Items.Clear()

        Dim selectedCategory As String = Cmb_jminum.SelectedItem.ToString()

        If selectedCategory = "Teh" Then
            Cmb_nminum.Items.Add("Teh Hitam")
            Cmb_nminum.Items.Add("Teh Hijau")
            Cmb_nminum.Items.Add("Teh Putih")
        ElseIf selectedCategory = "Kopi" Then
            Cmb_nminum.Items.Add("Kopi Hitam")
            Cmb_nminum.Items.Add("Kopi Susu")
            Cmb_nminum.Items.Add("Espresso")
        ElseIf selectedCategory = "Jus Buah" Then
            Cmb_nminum.Items.Add("Jus Jeruk")
            Cmb_nminum.Items.Add("Jus Apel")
            Cmb_nminum.Items.Add("Jus Anggur")
        End If
    End Sub

    Private Sub Cmb_nminum_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cmb_nminum.SelectedIndexChanged
        Dim selectedSubCategory As String = Cmb_nminum.SelectedItem.ToString()

        If selectedSubCategory = "Teh Hitam" Then
            Txt_harga.Text = "15000"
            PictureBox2.Show()
            PictureBox3.Hide()
            PictureBox4.Hide()
            PictureBox5.Hide()
            PictureBox6.Hide()
            PictureBox7.Hide()
            PictureBox8.Hide()
            PictureBox9.Hide()
            PictureBox10.Hide()
        ElseIf selectedSubCategory = "Teh Hijau" Then
            Txt_harga.Text = "30000"
            PictureBox3.Show()
            PictureBox2.Hide()
            PictureBox4.Hide()
            PictureBox5.Hide()
            PictureBox6.Hide()
            PictureBox7.Hide()
            PictureBox8.Hide()
            PictureBox9.Hide()
            PictureBox10.Hide()
        ElseIf selectedSubCategory = "Teh Putih" Then
            Txt_harga.Text = "5000"
            PictureBox4.Show()
            PictureBox2.Hide()
            PictureBox3.Hide()
            PictureBox5.Hide()
            PictureBox6.Hide()
            PictureBox7.Hide()
            PictureBox8.Hide()
            PictureBox9.Hide()
            PictureBox10.Hide()
        ElseIf selectedSubCategory = "Kopi Hitam" Then
            Txt_harga.Text = "15000"
            PictureBox5.Show()
            PictureBox2.Hide()
            PictureBox3.Hide()
            PictureBox4.Hide()
            PictureBox6.Hide()
            PictureBox7.Hide()
            PictureBox8.Hide()
            PictureBox9.Hide()
            PictureBox10.Hide()
        ElseIf selectedSubCategory = "Kopi Susu" Then
            Txt_harga.Text = "20000"
            PictureBox6.Show()
            PictureBox2.Hide()
            PictureBox3.Hide()
            PictureBox4.Hide()
            PictureBox5.Hide()
            PictureBox7.Hide()
            PictureBox8.Hide()
            PictureBox9.Hide()
            PictureBox10.Hide()
        ElseIf selectedSubCategory = "Espresso" Then
            Txt_harga.Text = "25000"
            PictureBox7.Show()
            PictureBox2.Hide()
            PictureBox3.Hide()
            PictureBox4.Hide()
            PictureBox5.Hide()
            PictureBox6.Hide()
            PictureBox8.Hide()
            PictureBox9.Hide()
            PictureBox10.Hide()
        ElseIf selectedSubCategory = "Jus Jeruk" Then
            Txt_harga.Text = "20000"
            PictureBox8.Show()
            PictureBox2.Hide()
            PictureBox3.Hide()
            PictureBox4.Hide()
            PictureBox5.Hide()
            PictureBox6.Hide()
            PictureBox7.Hide()
            PictureBox9.Hide()
            PictureBox10.Hide()
        ElseIf selectedSubCategory = "Jus Apel" Then
            Txt_harga.Text = "25000"
            PictureBox9.Show()
            PictureBox2.Hide()
            PictureBox3.Hide()
            PictureBox4.Hide()
            PictureBox5.Hide()
            PictureBox6.Hide()
            PictureBox7.Hide()
            PictureBox8.Hide()
            PictureBox10.Hide()
        ElseIf selectedSubCategory = "Jus Anggur" Then
            Txt_harga.Text = "22000"
            PictureBox10.Show()
            PictureBox2.Hide()
            PictureBox3.Hide()
            PictureBox4.Hide()
            PictureBox5.Hide()
            PictureBox6.Hide()
            PictureBox7.Hide()
            PictureBox8.Hide()
            PictureBox9.Hide()
        End If
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Txt_total.Text = Val(Txt_jumlah.Text) * Val(Txt_harga.Text) + Val(Txt_total.Text)
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Cmb_jminum.Text = ""
        Cmb_nminum.Text = ""
        Txt_harga.Text = ""
        Txt_jumlah.Text = ""
        Txt_total.Text = ""
        PictureBox2.Hide()
        PictureBox3.Hide()
        PictureBox4.Hide()
        PictureBox5.Hide()
        PictureBox6.Hide()
        PictureBox7.Hide()
        PictureBox8.Hide()
        PictureBox9.Hide()
        PictureBox10.Hide()
    End Sub
End Class