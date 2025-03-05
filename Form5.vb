Imports MySql.Data.MySqlClient
Public Class Form5
    Sub tampildatagrid()
        DA = New MySqlDataAdapter("select * from kasir", CONN)
        DS = New DataSet
        DA.Fill(DS, "kasir")
        dgvkasir.DataSource = (DS.Tables("kasir"))
    End Sub
    Sub aturlebarcolomgrid()
        dgvkasir.Columns(0).Width = 60
        dgvkasir.Columns(1).Width = 100
        dgvkasir.Columns(2).Width = 100
        dgvkasir.Columns(3).Width = 100
        dgvkasir.Columns(4).Width = 150
        dgvkasir.Columns(5).Width = 70
        dgvkasir.Columns(6).Width = 100
        dgvkasir.Columns(7).Width = 150
        dgvkasir.Columns(8).Width = 50
        dgvkasir.Columns(9).Width = 50
        dgvkasir.Columns(10).Width = 50
    End Sub
    Sub bersih()
        Txt_meja.Text = ""
        Txt_nama.Text = ""
        Txt_kasir.Text = ""
        DateTimePicker1.Text = ""
        Txt_jumlah1.Text = ""
        Txt_total1.Text = ""
        Txt_jumlah2.Text = ""
        Txt_total2.Text = ""
        Txt_seluruh.Text = ""
        Txt_bayar.Text = ""
        Txt_kembali.Text = ""
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Txt_jumlah1.Text = Form2.Txt_jumlah.Text
        Txt_total1.Text = Form2.Txt_total.Text
        Txt_jumlah2.Text = Form3.Txt_jumlah.Text
        Txt_total2.Text = Form3.Txt_total.Text


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Txt_seluruh.Text = Val(Txt_total1.Text) + Val(Txt_total2.Text)
        Button2.Hide()
        Button3.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Txt_kembali.Text = Val(Txt_bayar.Text) - Val(Txt_seluruh.Text)
    End Sub

    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call koneksi()
        Call tampildatagrid()
        Call aturlebarcolomgrid()
        dgvkasir.ReadOnly = True

        dgvkasir.Hide()
        Button2.Show()
        Button3.Hide()
    End Sub

    Private Sub tb_simpan_Click(sender As Object, e As EventArgs) Handles tb_simpan.Click
        If Txt_meja.Text = "" Or Txt_nama.Text = "" Or Txt_kasir.Text = "" Or Txt_jumlah1.Text = "" Or Txt_total1.Text = "" Or Txt_jumlah2.Text = "" Or Txt_total2.Text = "" Or Txt_seluruh.Text = "" Or Txt_kembali.Text = "" Then

            MessageBox.Show("Data Harus Diisi", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            Dim sqlForm1 As String = "insert into kasir(no_meja,nama_pelanggan,nama_kasir,tanggal,jumlah_makanan,bayar_makanan,jumlah_minuman,bayar_minuman,total_keseluruhan,bayaran,kembalian) values( '" & Txt_meja.Text & "','" & Txt_nama.Text & "','" & Txt_kasir.Text & "','" & DateTimePicker1.Text & "','" & Txt_jumlah1.Text & "','" & Txt_total1.Text & "','" & Txt_jumlah2.Text & "','" & Txt_total2.Text & "','" & Txt_seluruh.Text & "','" & Txt_bayar.Text & "','" & Txt_kembali.Text & "')"
            CMD = New MySqlCommand(sqlForm1, CONN)
            CMD.ExecuteNonQuery()

            MessageBox.Show("Data Telah Disimpan", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Call tampildatagrid()
            Call aturlebarcolomgrid()
            Call bersih()


        End If
    End Sub
    Private Sub dgvkasir_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvkasir.CellContentClick
        Dim baris As Integer
        With dgvkasir
            baris = .CurrentRow.Index
            Txt_meja.Text = .Item(0, baris).Value
            Txt_nama.Text = .Item(1, baris).Value
            Txt_kasir.Text = .Item(2, baris).Value
            DateTimePicker1.Text = .Item(3, baris).Value
            Txt_jumlah1.Text = .Item(4, baris).Value
            Txt_total1.Text = .Item(5, baris).Value
            Txt_jumlah2.Text = .Item(6, baris).Value
            Txt_total2.Text = .Item(7, baris).Value
            Txt_seluruh.Text = .Item(8, baris).Value
            Txt_bayar.Text = .Item(9, baris).Value
            Txt_kembali.Text = .Item(10, baris).Value
        End With

    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs)
        Form6.Show()
        Me.Hide()
    End Sub

    Private Sub tb_print_Click(sender As Object, e As EventArgs) Handles tb_print.Click
        MessageBox.Show("No. Meja:" & Txt_meja.Text + vbCrLf & "Nama Pelanggan:" & Txt_nama.Text + vbCrLf & "Nama Kasir:" & Txt_kasir.Text + vbCrLf & "Tanggal:" & DateTimePicker1.Text + vbCrLf & "Jumlah Makanan:" & Txt_jumlah1.Text + vbCrLf & "Bayar Makanan:" & Txt_total1.Text + vbCrLf & "Jumlah Minuman:" & Txt_jumlah2.Text + vbCrLf & "Bayar Minuman:" & Txt_total2.Text + vbCrLf & "Total Keseluruhan:" & Txt_seluruh.Text + vbCrLf & "Bayaran:" & Txt_bayar.Text + vbCrLf & "Kembalian:" & Txt_kembali.Text + vbCrLf, "Hasil Pengisian Data", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    
End Class