Public Class AddKoleksi

    Public Shared jenis As New List(Of String) From {"Buku", "Majalah", "Peta", "Komik"}

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        ComboBoxJenisKoleksi.DataSource = jenis
        DateTimePickerTanggalMasuk.Format = DateTimePickerFormat.Custom
        DateTimePickerTanggalMasuk.CustomFormat = "yyyy/MM/dd"
    End Sub
    Private Sub ButtonUploadPhoto_Click(sender As Object, e As EventArgs) Handles ButtonUploadPhoto.Click
        OpenFileDialog1.Title = "Upload Photo"
        OpenFileDialog1.Filter = "Image|*.bmp|Image JPG|*.jpg|Image JPEG|*.jpeg|Image PNG|*.png|Image GIF|*.gif|All Format|*.*"
        OpenFileDialog1.ShowDialog()
        PictureBoxKoleksi.Load(OpenFileDialog1.FileName)
        PictureBoxKoleksi.SizeMode = PictureBoxSizeMode.StretchImage
    End Sub

    Private Sub ButtonTambahKoleksi_Click(sender As Object, e As EventArgs) Handles ButtonTambahKoleksi.Click
        Perpustakaan.DataPerpus.GSNama = TextBoxNama.Text
        Perpustakaan.DataPerpus.GSjenis = ComboBoxJenisKoleksi.SelectedItem
        Perpustakaan.DataPerpus.GSdeskripsi = RichTextBoxDeskripsi.Text
        Perpustakaan.DataPerpus.GSpenerbit = TextBoxPenerbit.Text
        Perpustakaan.DataPerpus.GStahunTerbit = TextBoxTahunTerbit.Text
        Perpustakaan.DataPerpus.GSlokasiRak = TextBoxLokasiRak.Text
        Perpustakaan.DataPerpus.GStanggalMasuk = DateTimePickerTanggalMasuk.Value.ToShortDateString
        Perpustakaan.DataPerpus.GSstock = TextBoxStock.Text

        If RadioButtonInggris.Checked Then
            Perpustakaan.DataPerpus.GSbahasa = "Bahasa Inggris"
        ElseIf RadioButtonIndonesia.Checked Then
            Perpustakaan.DataPerpus.GSbahasa = "Bahasa Indonesia"
        End If

        Dim kategori = New List(Of String)
        If CheckBoxBudaya.Checked() Then
            kategori.Add("Budaya")
        End If
        If CheckBoxSosial.Checked() Then
            kategori.Add("Sosial")
        End If
        If CheckBoxTeknologi.Checked() Then
            kategori.Add("Teknologi")
        End If
        If CheckBoxSains.Checked() Then
            kategori.Add("Sains")
        End If

        Perpustakaan.DataPerpus.GSKategori = kategori

        Perpustakaan.DataPerpus.GSFoto = OpenFileDialog1.FileName.ToString()
        Perpustakaan.DataPerpus.GSFoto = Perpustakaan.DataPerpus.GSFoto.Replace("\", "/")

        Dim convertedKoleksi = Perpustakaan.DataPerpus.ConvertKoleksiToString(Perpustakaan.DataPerpus.GSKategori)
        Perpustakaan.DataPerpus.addDataKoleksiDatabase(
                                                    Perpustakaan.DataPerpus.GSFoto,
                                                    Perpustakaan.DataPerpus.GSNama,
                                                    Perpustakaan.DataPerpus.GSjenis,
                                                    Perpustakaan.DataPerpus.GSpenerbit,
                                                    Perpustakaan.DataPerpus.GSdeskripsi,
                                                    Perpustakaan.DataPerpus.GStahunTerbit,
                                                    Perpustakaan.DataPerpus.GSlokasiRak,
                                                    Perpustakaan.DataPerpus.GStanggalMasuk,
                                                    Perpustakaan.DataPerpus.GSstock,
                                                    Perpustakaan.DataPerpus.GSbahasa,
                                                    convertedKoleksi
                                                    )

        Dim AddedKoleksi = New AddedKoleksi()

        Me.Close()
        AddedKoleksi.Show()
    End Sub

    Private Sub onlyNumberTextBox(sender As Object, e As KeyPressEventArgs) Handles TextBoxTahunTerbit.KeyPress, TextBoxStock.KeyPress
        If Char.IsLetter(e.KeyChar) Or Char.IsPunctuation(e.KeyChar) Then
            e.Handled = True
            MessageBox.Show("Hanya Menerima Angka")
        End If
    End Sub
End Class