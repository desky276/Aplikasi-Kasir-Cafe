Imports MySql.Data.MySqlClient
Imports System.Drawing.Printing


Public Class Form6
    Dim WithEvents PD As New PrintDocument
    Dim PPD As New PrintPreviewDialog

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
        dgvkasir.Columns(3).Width = 130
        dgvkasir.Columns(4).Width = 100
        dgvkasir.Columns(5).Width = 100
        dgvkasir.Columns(6).Width = 100
        dgvkasir.Columns(7).Width = 100
        dgvkasir.Columns(8).Width = 100
        dgvkasir.Columns(9).Width = 80
        dgvkasir.Columns(10).Width = 80
    End Sub
    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call koneksi()
        Call tampildatagrid()
        Call aturlebarcolomgrid()
        dgvkasir.ReadOnly = True
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
        tb_hapus.Enabled = True

    End Sub

    Private Sub tb_hapus_Click(sender As Object, e As EventArgs) Handles tb_hapus.Click
        If Txt_meja.Text = "" Then
            MessageBox.Show("Pilih Nomor Meja Dengan Benar",
           "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        Else
            If MessageBox.Show("Yakin Data Akan Dihapus?", "konfirmasi",
           MessageBoxButtons.YesNo) =
            Windows.Forms.DialogResult.Yes Then
                CMD = New MySqlCommand("delete from kasir where no_meja='" &
               Txt_meja.Text & "'", CONN)
                CMD.ExecuteNonQuery()
                Call tampildatagrid()
            Else
                Call tampildatagrid()
            End If
        End If
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form2.Show()
    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles tb_update.Click
        Try
            Call koneksi()
            Dim str As String
            str = "UPDATE kasir SET no_meja=?,nama_pelanggan=?,nama_kasir=?,tanggal=?,jumlah_makanan=?,bayar_makanan=?,jumlah_minuman=?,bayar_minuman=?,total_keseluruhan=?,bayaran=?,kembalian=? where no_meja='" & Txt_meja.Text & "'"
            Dim cmd As New MySqlCommand(str, CONN)
            With cmd
                .Parameters.Clear()
                .Parameters.Add(New MySqlParameter("no_meja", MySqlDbType.VarChar, 11)).Value = Txt_meja.Text
                .Parameters.Add(New MySqlParameter("nama_pelanggan", MySqlDbType.VarChar, 100)).Value = Txt_nama.Text
                .Parameters.Add(New MySqlParameter("nama_kasir", MySqlDbType.VarChar, 100)).Value = Txt_kasir.Text
                .Parameters.Add(New MySqlParameter("tanggal", MySqlDbType.VarChar, 20)).Value = DateTimePicker1.Text
                .Parameters.Add(New MySqlParameter("jumlah_makanan", MySqlDbType.VarChar, 20)).Value = Txt_jumlah1.Text
                .Parameters.Add(New MySqlParameter("bayar_makanan", MySqlDbType.VarChar, 30)).Value = Txt_total1.Text
                .Parameters.Add(New MySqlParameter("jumlah_minuman", MySqlDbType.VarChar, 20)).Value = Txt_jumlah2.Text
                .Parameters.Add(New MySqlParameter("bayar_minuman", MySqlDbType.VarChar, 30)).Value = Txt_total2.Text
                .Parameters.Add(New MySqlParameter("total_keseluruhan", MySqlDbType.VarChar, 50)).Value = Txt_seluruh.Text
                .Parameters.Add(New MySqlParameter("bayaran", MySqlDbType.VarChar, 50)).Value = Txt_bayar.Text
                .Parameters.Add(New MySqlParameter("kembalian", MySqlDbType.VarChar, 50)).Value = Txt_kembali.Text
                .ExecuteNonQuery()
                CONN.Close()
            End With
            MessageBox.Show("update berhasil di lakukan", "PEMBERITAHUAN", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub Txt_kasir_TextChanged(sender As Object, e As EventArgs) Handles Txt_kasir.TextChanged
        Dim tables As DataTableCollection = DS.Tables
        Dim source1 As New BindingSource
        DA = New MySqlDataAdapter("Select * from kasir", CONN)
        DS = New DataSet
        DA.Fill(DS, "kasir")
        Dim tampil As New DataView(tables(0))
        source1.DataSource = tampil
        dgvkasir.DataSource = tampil
        dgvkasir.Refresh()
        tampil.RowFilter = "nama_kasir='" & Txt_kasir.Text & "'"
        dgvkasir.Refresh()
    End Sub

    Private Sub tb_print_Click(sender As Object, e As EventArgs) Handles tb_print.Click
        PPD.Document = PD
        PPD.ShowDialog()
    End Sub

    Private Sub PD_BeginPrint(sender As Object, e As PrintEventArgs) Handles PD.BeginPrint
        Dim pagesetup As New PageSettings
        pagesetup.PaperSize = New PaperSize("custom", 250, 325)
        PD.DefaultPageSettings = pagesetup

    End Sub

    Private Sub PD_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PD.PrintPage
        Dim f10 As New Font("Times New Roman", 10, FontStyle.Regular)
        Dim f10b As New Font("Times New Roman", 10, FontStyle.Bold)
        Dim f14 As New Font("Times New Roman", 14, FontStyle.Bold)

        Dim leftmargin As Integer = PD.DefaultPageSettings.Margins.Left
        Dim centermargin As Integer = PD.DefaultPageSettings.PaperSize.Width / 2
        Dim rightmargin As Integer = PD.DefaultPageSettings.PaperSize.Width

        Dim kanan As New StringFormat
        Dim tengah As New StringFormat
        kanan.Alignment = StringAlignment.Far
        tengah.Alignment = StringAlignment.Center

        Dim garis As String
        Dim gariss As String
        garis = "--------------------------------------------------"
        gariss = "___________________________________________________"
        e.Graphics.DrawString("Cafe Desky", f14, Brushes.Black, centermargin, 5, tengah)
        e.Graphics.DrawString("Jalan Melanthon Siregar, Gg Sipahutar", f10, Brushes.Black, centermargin, 25, tengah)
        e.Graphics.DrawString("Hp. 0823-8238-78233", f10, Brushes.Black, centermargin, 40, tengah)

        e.Graphics.DrawString("Kasir", f10, Brushes.Black, 0, 75)
        e.Graphics.DrawString(":", f10, Brushes.Black, 65, 75)
        e.Graphics.DrawString(Txt_kasir.Text, f10, Brushes.Black, 75, 75)

        e.Graphics.DrawString(DateTimePicker1.Text, f10, Brushes.Black, 0, 90)

        e.Graphics.DrawString(garis, f10, Brushes.Black, 0, 100)

        e.Graphics.DrawString("No. Meja", f10, Brushes.Black, 0, 138)
        e.Graphics.DrawString(":", f10, Brushes.Black, 150, 138)
        e.Graphics.DrawString(Txt_meja.Text, f10, Brushes.Black, 155, 138)

        e.Graphics.DrawString("Nama Pelanggan", f10, Brushes.Black, 0, 158)
        e.Graphics.DrawString(":", f10, Brushes.Black, 150, 158)
        e.Graphics.DrawString(Txt_nama.Text, f10, Brushes.Black, 155, 158)

        e.Graphics.DrawString(garis, f10, Brushes.Black, 0, 100)

        e.Graphics.DrawString("Total Keseluruhan", f10, Brushes.Black, 0, 178)
        e.Graphics.DrawString(":", f10, Brushes.Black, 150, 178)
        e.Graphics.DrawString(Txt_seluruh.Text, f10, Brushes.Black, 155, 178)

        e.Graphics.DrawString("Uang Bayar", f10, Brushes.Black, 0, 198)
        e.Graphics.DrawString(":", f10, Brushes.Black, 150, 198)
        e.Graphics.DrawString(Txt_bayar.Text, f10, Brushes.Black, 155, 198)

        e.Graphics.DrawString(garis, f10, Brushes.Black, 0, 210)

        e.Graphics.DrawString("Kembalian", f10, Brushes.Black, 0, 228)
        e.Graphics.DrawString(":", f10, Brushes.Black, 150, 228)
        e.Graphics.DrawString(Txt_kembali.Text, f10, Brushes.Black, 155, 228)

        e.Graphics.DrawString(gariss, f10, Brushes.Black, 0, 240)

        Dim tinggi As Integer
        e.Graphics.DrawString(" Terimakasih Telah Makan", f10, Brushes.Black, centermargin, 258 + tinggi, tengah)
        e.Graphics.DrawString(" Di Cafe Kami ", f10, Brushes.Black, centermargin, 278 + tinggi, tengah)


    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        Form7.Show()
    End Sub
End Class