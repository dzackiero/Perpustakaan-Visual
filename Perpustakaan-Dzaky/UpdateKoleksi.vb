Public Class UpdateKoleksi

    Public Shared jenis As New List(Of String) From {"Buku", "Majalah", "Peta", "Komik"}

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        ComboBoxJenisKoleksi.DataSource = jenis

        Dim dataPerpus = Perpustakaan.DataPerpus
        PictureBoxKoleksi.Load(dataPerpus.GSFoto)
        PictureBoxKoleksi.SizeMode = PictureBoxSizeMode.StretchImage

        DateTimePickerTanggalMasuk.Format = DateTimePickerFormat.Custom
        DateTimePickerTanggalMasuk.CustomFormat = "yyyy/MM/dd"

        TextBoxNama.Text = dataPerpus.GSNama
        ComboBoxJenisKoleksi.SelectedItem() = dataPerpus.GSjenis
        RichTextBoxDeskripsi.Text = dataPerpus.GSdeskripsi
        TextBoxPenerbit.Text = dataPerpus.GSpenerbit
        TextBoxLokasiRak.Text = dataPerpus.GSlokasiRak
        DateTimePickerTanggalMasuk.Value = dataPerpus.GStanggalMasuk
        TextBoxStock.Text = dataPerpus.GSstock

        If String.Compare(dataPerpus.GSbahasa, "Indonesia") Then
            RadioButtonIndonesia.Checked = True
        End If
        If String.Compare(dataPerpus.GSbahasa, "Inggris") Then
            RadioButtonInggris.Checked = True
        End If

        For Each kategori In dataPerpus.GSKategori
            If String.Compare(kategori, "Sains") Then
                CheckBoxSains.Checked = True
            ElseIf String.Compare(kategori, "Sosial") Then
                CheckBoxSains.Checked = True
            ElseIf String.Compare(kategori, "Teknologi") Then
                CheckBoxSains.Checked = True
            ElseIf String.Compare(kategori, "Budaya") Then
                CheckBoxSains.Checked = True
            End If
        Next

        dataPerpus.GSKategori.Clear()
    End Sub

    Private Sub ButtonUpdatePhoto_Click(sender As Object, e As EventArgs) Handles ButtonUpdatePhoto.Click
        OpenFileDialog1.Title = "Upload Photo"
        OpenFileDialog1.Filter = "Image|*.bmp|Image JPG|*.jpg|Image JPEG|*.jpeg|Image PNG|*.png|Image GIF|*.gif|All Format|*.*"
        OpenFileDialog1.ShowDialog()
        PictureBoxKoleksi.Load(OpenFileDialog1.FileName)
        PictureBoxKoleksi.SizeMode = PictureBoxSizeMode.StretchImage

        Perpustakaan.DataPerpus.GSFoto = OpenFileDialog1.FileName.ToString()
        Perpustakaan.DataPerpus.GSFoto = Perpustakaan.DataPerpus.GSFoto.Replace("\", "/")
    End Sub

    Private Sub ButtonEditKoleksi_Click(sender As Object, e As EventArgs) Handles ButtonEditKoleksi.Click
        Perpustakaan.DataPerpus.GSNama = TextBoxNama.Text
        Perpustakaan.DataPerpus.GSjenis = ComboBoxJenisKoleksi.SelectedItem
        Perpustakaan.DataPerpus.GSdeskripsi = RichTextBoxDeskripsi.Text
        Perpustakaan.DataPerpus.GSpenerbit = TextBoxPenerbit.Text
        Perpustakaan.DataPerpus.GStahunTerbit = TextBoxTahunTerbit.Text
        Perpustakaan.DataPerpus.GSlokasiRak = TextBoxLokasiRak.Text
        Perpustakaan.DataPerpus.GStanggalMasuk = DateTimePickerTanggalMasuk.Value
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



        Dim convertedKoleksi = Perpustakaan.DataPerpus.ConvertKoleksiToString(Perpustakaan.DataPerpus.GSKategori)

        Perpustakaan.DataPerpus.UpdateDataKoleksiByIdDatabase(
                                                    Perpustakaan.SelectedTableId,
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

        Dim infoTambah = New AddedKoleksi()
        Me.Close()
        infoTambah.Show()

    End Sub
End Class