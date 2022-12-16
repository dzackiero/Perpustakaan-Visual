Public Class HapusKoleksi
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        Label1.Text = Perpustakaan.SelectedTableNama
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Perpustakaan.ListBoxKoleksi.Items.Remove(Perpustakaan.ListBoxKoleksi.SelectedItem())
        Perpustakaan.DataPerpus.DeleteDataKoleksiByIdDatabase(Perpustakaan.SelectedTableId)
        Me.Close()
    End Sub
End Class