Public Class AddedKoleksi

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        NamaKoleksi.Text = Perpustakaan.DataPerpus.GSNama
        JenisKoleksi.Text = Perpustakaan.DataPerpus.GSjenis
        Deskripsi.Text = Perpustakaan.DataPerpus.GSdeskripsi
        Penerbit.Text = Perpustakaan.DataPerpus.GSpenerbit
        TahunTerbit.Text = Perpustakaan.DataPerpus.GStahunTerbit
        TanggalMasukKoleksi.Text = Perpustakaan.DataPerpus.GStanggalMasuk
        Stock.Text = Perpustakaan.DataPerpus.GSstock
        Bahasa.Text = Perpustakaan.DataPerpus.GSbahasa

        Try
            PictureBoxKoleksi.Load(Perpustakaan.DataPerpus.GSFoto)
            PictureBoxKoleksi.SizeMode = PictureBoxSizeMode.StretchImage
        Catch ex As Exception

        End Try

        For Each kategori In Perpustakaan.DataPerpus.GSKategori
            ListBox1.Items.Add(kategori)
        Next
    End Sub

    Private Sub ButtonTutup_Click(sender As Object, e As EventArgs) Handles ButtonTutup.Click
        Me.Close()
    End Sub
End Class