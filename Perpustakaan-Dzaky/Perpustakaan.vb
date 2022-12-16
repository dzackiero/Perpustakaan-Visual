Imports System.ComponentModel.Design
Imports System.Diagnostics.Eventing.Reader
Imports System.Text

Public Class Perpustakaan
    Public Shared DataPerpus As DataPerpus
    Public SelectedTableId As Integer = -1
    Public SelectedTableNama As String


    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        DataPerpus = New DataPerpus()
        ReloadDataTableDatabase()
    End Sub

    Public Sub ReloadDataTableDatabase()
        DataGridView1.DataSource = DataPerpus.GetDataKoleksiDatabase()
    End Sub

    Public Sub UpdateDataTableArrayList()
        'DataGridView1.Rows.Clear()
        For Each rowKoleksi In DataPerpus.getKoleksiDataTable()
            Dim dataTable As String() = {
                rowKoleksi(1),
                rowKoleksi(2),
                rowKoleksi(3),
                rowKoleksi(4),
                rowKoleksi(5),
                rowKoleksi(6),
                rowKoleksi(7),
                rowKoleksi(8),
                rowKoleksi(9),
                rowKoleksi(10)
            }
            DataGridView1.Rows.Add(dataTable)
        Next
    End Sub

    Private Sub ButtonAddKoleksi_Click(sender As Object, e As EventArgs) Handles ButtonAddKoleksi.Click
        Dim AddKoleksi = New AddKoleksi()
        AddKoleksi.Show()
    End Sub

    Private Sub ButtonDeleteKoleksi_Click(sender As Object, e As EventArgs) Handles ButtonDeleteKoleksi.Click
        If ListBoxKoleksi.SelectedItem Is Nothing Then
            MessageBox.Show("Pilih buku yang akan dihapus!")
        Else
            Dim HapusKoleksi = New HapusKoleksi()
            HapusKoleksi.Show()
        End If

    End Sub

    Private Sub Perpustakaan_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        If DataPerpus.GSNama <> "" Then
            ListBoxKoleksi.Items.Add(DataPerpus.GSNama)
            DataPerpus.ClearData()
            'UpdateDataTableArrayList()
        End If
        ReloadDataTableDatabase()
    End Sub

    Private Sub TambahKoleksiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TambahKoleksiToolStripMenuItem.Click
        Dim AddKoleksi = New AddKoleksi()
        AddKoleksi.Show()
    End Sub

    Private Sub ButtonShowGridView_Click(sender As Object, e As EventArgs) Handles ButtonShowGridView.Click
        Dim dataSelected = DataPerpus.GetDataKoleksiByIdDatabase(SelectedTableId)

        DataPerpus.GSFoto = dataSelected(2)
        DataPerpus.GSNama = dataSelected(1)
        DataPerpus.GSjenis = dataSelected(5)
        DataPerpus.GSdeskripsi = dataSelected(3)
        DataPerpus.GSpenerbit = dataSelected(4)
        DataPerpus.GStahunTerbit = dataSelected(6)
        DataPerpus.GSlokasiRak = dataSelected(7)
        DataPerpus.GStanggalMasuk = dataSelected(8)
        DataPerpus.GSstock = dataSelected(9)
        DataPerpus.GSbahasa = dataSelected(10)

        Dim dataKoleksi As List(Of String) = DataPerpus.convertStringToKoleksi(dataSelected(11))
        DataPerpus.GSKategori = dataKoleksi

        Dim FormAddedKoleksi = New AddedKoleksi()
        SelectedTableId = -1
        FormAddedKoleksi.Show()
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        'SelectedTableIndex = DataGridView1.CurrentRow.Index
        Dim index As Integer = e.RowIndex
        Dim selectedRow As DataGridViewRow
        selectedRow = DataGridView1.Rows(index)

        SelectedTableId = selectedRow.Cells(0).Value
        SelectedTableNama = selectedRow.Cells(1).Value
    End Sub

    Private Sub ButtonUpdateKoleksi_Click(sender As Object, e As EventArgs) Handles ButtonUpdateKoleksi.Click
        Dim selectedKoleksi As List(Of String) = DataPerpus.GetDataKoleksiByIdDatabase(SelectedTableId)

        DataPerpus.GSFoto = selectedKoleksi(2)

        DataPerpus.GSNama = selectedKoleksi(1)
        DataPerpus.GSjenis = selectedKoleksi(5)
        DataPerpus.GSdeskripsi = selectedKoleksi(3)
        DataPerpus.GSpenerbit = selectedKoleksi(4)
        DataPerpus.GStahunTerbit = selectedKoleksi(6)
        DataPerpus.GSlokasiRak = selectedKoleksi(7)
        DataPerpus.GStanggalMasuk = selectedKoleksi(8)
        DataPerpus.GSstock = selectedKoleksi(9)
        DataPerpus.GSbahasa = selectedKoleksi(10)

        DataPerpus.GSKategori = DataPerpus.convertStringToKoleksi(selectedKoleksi(11))

        Dim formUpdate = New UpdateKoleksi()
        formUpdate.Show()

    End Sub

    Private Sub ButtonDelete_Click(sender As Object, e As EventArgs) Handles ButtonDelete.Click
        Dim formHapus = New HapusKoleksi()
        formHapus.Show()

    End Sub
End Class
