<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddedKoleksi
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.PictureBoxKoleksi = New System.Windows.Forms.PictureBox()
        Me.ButtonTutup = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.NamaKoleksi = New System.Windows.Forms.Label()
        Me.JenisKoleksi = New System.Windows.Forms.Label()
        Me.Deskripsi = New System.Windows.Forms.Label()
        Me.Penerbit = New System.Windows.Forms.Label()
        Me.TahunTerbit = New System.Windows.Forms.Label()
        Me.LokasiRak = New System.Windows.Forms.Label()
        Me.TanggalMasukKoleksi = New System.Windows.Forms.Label()
        Me.Stock = New System.Windows.Forms.Label()
        Me.Bahasa = New System.Windows.Forms.Label()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        CType(Me.PictureBoxKoleksi, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBoxKoleksi
        '
        Me.PictureBoxKoleksi.Location = New System.Drawing.Point(18, 10)
        Me.PictureBoxKoleksi.Name = "PictureBoxKoleksi"
        Me.PictureBoxKoleksi.Size = New System.Drawing.Size(100, 110)
        Me.PictureBoxKoleksi.TabIndex = 50
        Me.PictureBoxKoleksi.TabStop = False
        '
        'ButtonTutup
        '
        Me.ButtonTutup.Location = New System.Drawing.Point(179, 482)
        Me.ButtonTutup.Name = "ButtonTutup"
        Me.ButtonTutup.Size = New System.Drawing.Size(123, 23)
        Me.ButtonTutup.TabIndex = 49
        Me.ButtonTutup.Text = "Tutup"
        Me.ButtonTutup.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(138, 293)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(44, 15)
        Me.Label11.TabIndex = 38
        Me.Label11.Text = "Bahasa"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(138, 373)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(51, 15)
        Me.Label10.TabIndex = 37
        Me.Label10.Text = "Kategori"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(138, 264)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(36, 15)
        Me.Label8.TabIndex = 36
        Me.Label8.Text = "Stock"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(138, 235)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(126, 15)
        Me.Label9.TabIndex = 35
        Me.Label9.Text = "Tanggal Masuk Koleksi"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(138, 207)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(62, 15)
        Me.Label6.TabIndex = 34
        Me.Label6.Text = "Lokasi Rak"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(138, 178)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(71, 15)
        Me.Label5.TabIndex = 33
        Me.Label5.Text = "Tahun Terbit"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(138, 148)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 15)
        Me.Label3.TabIndex = 32
        Me.Label3.Text = "Penerbit"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(138, 63)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 15)
        Me.Label4.TabIndex = 31
        Me.Label4.Text = "Deskripsi"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(138, 39)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 15)
        Me.Label2.TabIndex = 30
        Me.Label2.Text = "Jenis Koleksi"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(138, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 15)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "Nama Koleksi"
        '
        'NamaKoleksi
        '
        Me.NamaKoleksi.AutoSize = True
        Me.NamaKoleksi.Location = New System.Drawing.Point(290, 10)
        Me.NamaKoleksi.Name = "NamaKoleksi"
        Me.NamaKoleksi.Size = New System.Drawing.Size(12, 15)
        Me.NamaKoleksi.TabIndex = 51
        Me.NamaKoleksi.Text = "-"
        '
        'JenisKoleksi
        '
        Me.JenisKoleksi.AutoSize = True
        Me.JenisKoleksi.Location = New System.Drawing.Point(290, 39)
        Me.JenisKoleksi.Name = "JenisKoleksi"
        Me.JenisKoleksi.Size = New System.Drawing.Size(12, 15)
        Me.JenisKoleksi.TabIndex = 52
        Me.JenisKoleksi.Text = "-"
        '
        'Deskripsi
        '
        Me.Deskripsi.AutoSize = True
        Me.Deskripsi.Location = New System.Drawing.Point(290, 63)
        Me.Deskripsi.Name = "Deskripsi"
        Me.Deskripsi.Size = New System.Drawing.Size(12, 15)
        Me.Deskripsi.TabIndex = 53
        Me.Deskripsi.Text = "-"
        '
        'Penerbit
        '
        Me.Penerbit.AutoSize = True
        Me.Penerbit.Location = New System.Drawing.Point(290, 148)
        Me.Penerbit.Name = "Penerbit"
        Me.Penerbit.Size = New System.Drawing.Size(12, 15)
        Me.Penerbit.TabIndex = 54
        Me.Penerbit.Text = "-"
        '
        'TahunTerbit
        '
        Me.TahunTerbit.AutoSize = True
        Me.TahunTerbit.Location = New System.Drawing.Point(290, 178)
        Me.TahunTerbit.Name = "TahunTerbit"
        Me.TahunTerbit.Size = New System.Drawing.Size(12, 15)
        Me.TahunTerbit.TabIndex = 55
        Me.TahunTerbit.Text = "-"
        '
        'LokasiRak
        '
        Me.LokasiRak.AutoSize = True
        Me.LokasiRak.Location = New System.Drawing.Point(290, 207)
        Me.LokasiRak.Name = "LokasiRak"
        Me.LokasiRak.Size = New System.Drawing.Size(12, 15)
        Me.LokasiRak.TabIndex = 56
        Me.LokasiRak.Text = "-"
        '
        'TanggalMasukKoleksi
        '
        Me.TanggalMasukKoleksi.AutoSize = True
        Me.TanggalMasukKoleksi.Location = New System.Drawing.Point(290, 235)
        Me.TanggalMasukKoleksi.Name = "TanggalMasukKoleksi"
        Me.TanggalMasukKoleksi.Size = New System.Drawing.Size(12, 15)
        Me.TanggalMasukKoleksi.TabIndex = 57
        Me.TanggalMasukKoleksi.Text = "-"
        '
        'Stock
        '
        Me.Stock.AutoSize = True
        Me.Stock.Location = New System.Drawing.Point(290, 264)
        Me.Stock.Name = "Stock"
        Me.Stock.Size = New System.Drawing.Size(12, 15)
        Me.Stock.TabIndex = 58
        Me.Stock.Text = "-"
        '
        'Bahasa
        '
        Me.Bahasa.AutoSize = True
        Me.Bahasa.Location = New System.Drawing.Point(290, 293)
        Me.Bahasa.Name = "Bahasa"
        Me.Bahasa.Size = New System.Drawing.Size(12, 15)
        Me.Bahasa.TabIndex = 59
        Me.Bahasa.Text = "-"
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 15
        Me.ListBox1.Location = New System.Drawing.Point(290, 373)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(138, 94)
        Me.ListBox1.TabIndex = 60
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'AddedKoleksi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(448, 517)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.Bahasa)
        Me.Controls.Add(Me.Stock)
        Me.Controls.Add(Me.TanggalMasukKoleksi)
        Me.Controls.Add(Me.LokasiRak)
        Me.Controls.Add(Me.TahunTerbit)
        Me.Controls.Add(Me.Penerbit)
        Me.Controls.Add(Me.Deskripsi)
        Me.Controls.Add(Me.JenisKoleksi)
        Me.Controls.Add(Me.NamaKoleksi)
        Me.Controls.Add(Me.PictureBoxKoleksi)
        Me.Controls.Add(Me.ButtonTutup)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "AddedKoleksi"
        Me.Text = "Koleksi Baru"
        CType(Me.PictureBoxKoleksi, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBoxKoleksi As PictureBox
    Friend WithEvents ButtonTutup As Button
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents NamaKoleksi As Label
    Friend WithEvents JenisKoleksi As Label
    Friend WithEvents Deskripsi As Label
    Friend WithEvents Penerbit As Label
    Friend WithEvents TahunTerbit As Label
    Friend WithEvents LokasiRak As Label
    Friend WithEvents TanggalMasukKoleksi As Label
    Friend WithEvents Stock As Label
    Friend WithEvents Bahasa As Label
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
End Class
