Public Class Form2
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Form3.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PictureBox2.Hide()
        PictureBox3.Hide()
        PictureBox4.Hide()
        PictureBox5.Hide()
        PictureBox6.Hide()
        PictureBox7.Hide()
        PictureBox8.Hide()
        PictureBox9.Hide()
        PictureBox10.Hide()

        Cmb_jmakan.Items.Add("Daging Hewan")
        Cmb_jmakan.Items.Add("Vegetarian")
        Cmb_jmakan.Items.Add("Makanan Cepat Saji")
    End Sub

    Private Sub Cmb_jmakan_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cmb_jmakan.SelectedIndexChanged
        Cmb_nmakan.Items.Clear()

        Dim selectedCategory As String = Cmb_jmakan.SelectedItem.ToString()

        If selectedCategory = "Daging Hewan" Then
            Cmb_nmakan.Items.Add("Daging Ayam")
            Cmb_nmakan.Items.Add("Daging Sapi")
            Cmb_nmakan.Items.Add("Daging Babi")
            Cmb_nmakan.Items.Add("Ikan")
        ElseIf selectedCategory = "Vegetarian" Then
            Cmb_nmakan.Items.Add("Tahu")
            Cmb_nmakan.Items.Add("Tempe")
        ElseIf selectedCategory = "Makanan Cepat Saji" Then
            Cmb_nmakan.Items.Add("Burger")
            Cmb_nmakan.Items.Add("Kentang Goreng")
            Cmb_nmakan.Items.Add("Pizza")
        End If
    End Sub

    Private Sub Cmb_nmakan_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cmb_nmakan.SelectedIndexChanged
        Dim selectedSubCategory As String = Cmb_nmakan.SelectedItem.ToString()

        If selectedSubCategory = "Daging Ayam" Then
            Txt_harga.Text = "25000"
            PictureBox2.Show()
            PictureBox3.Hide()
            PictureBox4.Hide()
            PictureBox5.Hide()
            PictureBox6.Hide()
            PictureBox7.Hide()
            PictureBox8.Hide()
            PictureBox9.Hide()
            PictureBox10.Hide()
        ElseIf selectedSubCategory = "Daging Sapi" Then
            Txt_harga.Text = "50000"
            PictureBox3.Show()
            PictureBox2.Hide()
            PictureBox4.Hide()
            PictureBox5.Hide()
            PictureBox6.Hide()
            PictureBox7.Hide()
            PictureBox8.Hide()
            PictureBox9.Hide()
            PictureBox10.Hide()
        ElseIf selectedSubCategory = "Daging Babi" Then
            Txt_harga.Text = "50000"
            PictureBox4.Show()
            PictureBox2.Hide()
            PictureBox3.Hide()
            PictureBox5.Hide()
            PictureBox6.Hide()
            PictureBox7.Hide()
            PictureBox8.Hide()
            PictureBox9.Hide()
            PictureBox10.Hide()
        ElseIf selectedSubCategory = "Ikan" Then
            Txt_harga.Text = "9000"
            PictureBox5.Show()
            PictureBox2.Hide()
            PictureBox3.Hide()
            PictureBox4.Hide()
            PictureBox6.Hide()
            PictureBox7.Hide()
            PictureBox8.Hide()
            PictureBox9.Hide()
            PictureBox10.Hide()
        ElseIf selectedSubCategory = "Tahu" Then
            Txt_harga.Text = "5000"
            PictureBox6.Show()
            PictureBox2.Hide()
            PictureBox3.Hide()
            PictureBox4.Hide()
            PictureBox5.Hide()
            PictureBox7.Hide()
            PictureBox8.Hide()
            PictureBox9.Hide()
            PictureBox10.Hide()
        ElseIf selectedSubCategory = "Tempe" Then
            Txt_harga.Text = "5000"
            PictureBox7.Show()
            PictureBox2.Hide()
            PictureBox3.Hide()
            PictureBox4.Hide()
            PictureBox5.Hide()
            PictureBox6.Hide()
            PictureBox8.Hide()
            PictureBox9.Hide()
            PictureBox10.Hide()
        ElseIf selectedSubCategory = "Burger" Then
            Txt_harga.Text = "6000"
            PictureBox8.Show()
            PictureBox2.Hide()
            PictureBox3.Hide()
            PictureBox4.Hide()
            PictureBox5.Hide()
            PictureBox6.Hide()
            PictureBox7.Hide()
            PictureBox9.Hide()
            PictureBox10.Hide()
        ElseIf selectedSubCategory = "Kentang Goreng" Then
            Txt_harga.Text = "10000"
            PictureBox9.Show()
            PictureBox2.Hide()
            PictureBox3.Hide()
            PictureBox4.Hide()
            PictureBox5.Hide()
            PictureBox6.Hide()
            PictureBox7.Hide()
            PictureBox8.Hide()
            PictureBox10.Hide()
        ElseIf selectedSubCategory = "Pizza" Then
            Txt_harga.Text = "100000"
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
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Cmb_jmakan.Text = ""
        Cmb_nmakan.Text = ""
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

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Txt_total.Text = Val(Txt_jumlah.Text) * Val(Txt_harga.Text) + Val(Txt_total.Text)
    End Sub
End Class