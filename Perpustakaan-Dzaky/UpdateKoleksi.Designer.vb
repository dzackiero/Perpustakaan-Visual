<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UpdateKoleksi
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
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.CheckBoxBudaya = New System.Windows.Forms.CheckBox()
        Me.CheckBoxTeknologi = New System.Windows.Forms.CheckBox()
        Me.CheckBoxSosial = New System.Windows.Forms.CheckBox()
        Me.CheckBoxSains = New System.Windows.Forms.CheckBox()
        Me.RadioButtonInggris = New System.Windows.Forms.RadioButton()
        Me.RadioButtonIndonesia = New System.Windows.Forms.RadioButton()
        Me.ButtonUpdatePhoto = New System.Windows.Forms.Button()
        Me.PictureBoxKoleksi = New System.Windows.Forms.PictureBox()
        Me.ButtonEditKoleksi = New System.Windows.Forms.Button()
        Me.DateTimePickerTanggalMasuk = New System.Windows.Forms.DateTimePicker()
        Me.ComboBoxJenisKoleksi = New System.Windows.Forms.ComboBox()
        Me.GroupBoxKategori = New System.Windows.Forms.GroupBox()
        Me.GroupBoxBahasa = New System.Windows.Forms.GroupBox()
        Me.TextBoxStock = New System.Windows.Forms.TextBox()
        Me.TextBoxLokasiRak = New System.Windows.Forms.TextBox()
        Me.TextBoxTahunTerbit = New System.Windows.Forms.TextBox()
        Me.TextBoxPenerbit = New System.Windows.Forms.TextBox()
        Me.RichTextBoxDeskripsi = New System.Windows.Forms.RichTextBox()
        Me.TextBoxNama = New System.Windows.Forms.TextBox()
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
        CType(Me.PictureBoxKoleksi, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBoxKategori.SuspendLayout()
        Me.GroupBoxBahasa.SuspendLayout()
        Me.SuspendLayout()
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'CheckBoxBudaya
        '
        Me.CheckBoxBudaya.AutoSize = True
        Me.CheckBoxBudaya.Location = New System.Drawing.Point(7, 130)
        Me.CheckBoxBudaya.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CheckBoxBudaya.Name = "CheckBoxBudaya"
        Me.CheckBoxBudaya.Size = New System.Drawing.Size(80, 24)
        Me.CheckBoxBudaya.TabIndex = 3
        Me.CheckBoxBudaya.Text = "Budaya"
        Me.CheckBoxBudaya.UseVisualStyleBackColor = True
        '
        'CheckBoxTeknologi
        '
        Me.CheckBoxTeknologi.AutoSize = True
        Me.CheckBoxTeknologi.Location = New System.Drawing.Point(7, 97)
        Me.CheckBoxTeknologi.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CheckBoxTeknologi.Name = "CheckBoxTeknologi"
        Me.CheckBoxTeknologi.Size = New System.Drawing.Size(96, 24)
        Me.CheckBoxTeknologi.TabIndex = 2
        Me.CheckBoxTeknologi.Text = "Teknologi"
        Me.CheckBoxTeknologi.UseVisualStyleBackColor = True
        '
        'CheckBoxSosial
        '
        Me.CheckBoxSosial.AutoSize = True
        Me.CheckBoxSosial.Location = New System.Drawing.Point(7, 64)
        Me.CheckBoxSosial.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CheckBoxSosial.Name = "CheckBoxSosial"
        Me.CheckBoxSosial.Size = New System.Drawing.Size(70, 24)
        Me.CheckBoxSosial.TabIndex = 1
        Me.CheckBoxSosial.Text = "Sosial"
        Me.CheckBoxSosial.UseVisualStyleBackColor = True
        '
        'CheckBoxSains
        '
        Me.CheckBoxSains.AutoSize = True
        Me.CheckBoxSains.Location = New System.Drawing.Point(7, 30)
        Me.CheckBoxSains.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CheckBoxSains.Name = "CheckBoxSains"
        Me.CheckBoxSains.Size = New System.Drawing.Size(65, 24)
        Me.CheckBoxSains.TabIndex = 0
        Me.CheckBoxSains.Text = "Sains"
        Me.CheckBoxSains.UseVisualStyleBackColor = True
        '
        'RadioButtonInggris
        '
        Me.RadioButtonInggris.AutoSize = True
        Me.RadioButtonInggris.Location = New System.Drawing.Point(7, 58)
        Me.RadioButtonInggris.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.RadioButtonInggris.Name = "RadioButtonInggris"
        Me.RadioButtonInggris.Size = New System.Drawing.Size(126, 24)
        Me.RadioButtonInggris.TabIndex = 22
        Me.RadioButtonInggris.TabStop = True
        Me.RadioButtonInggris.Text = "Bahasa Inggris"
        Me.RadioButtonInggris.UseVisualStyleBackColor = True
        '
        'RadioButtonIndonesia
        '
        Me.RadioButtonIndonesia.AutoSize = True
        Me.RadioButtonIndonesia.Location = New System.Drawing.Point(7, 30)
        Me.RadioButtonIndonesia.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.RadioButtonIndonesia.Name = "RadioButtonIndonesia"
        Me.RadioButtonIndonesia.Size = New System.Drawing.Size(145, 24)
        Me.RadioButtonIndonesia.TabIndex = 21
        Me.RadioButtonIndonesia.TabStop = True
        Me.RadioButtonIndonesia.Text = "Bahasa Indonesia"
        Me.RadioButtonIndonesia.UseVisualStyleBackColor = True
        '
        'ButtonUpdatePhoto
        '
        Me.ButtonUpdatePhoto.Location = New System.Drawing.Point(12, 176)
        Me.ButtonUpdatePhoto.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ButtonUpdatePhoto.Name = "ButtonUpdatePhoto"
        Me.ButtonUpdatePhoto.Size = New System.Drawing.Size(114, 31)
        Me.ButtonUpdatePhoto.TabIndex = 51
        Me.ButtonUpdatePhoto.Text = "Update Photo"
        Me.ButtonUpdatePhoto.UseVisualStyleBackColor = True
        '
        'PictureBoxKoleksi
        '
        Me.PictureBoxKoleksi.Location = New System.Drawing.Point(12, 22)
        Me.PictureBoxKoleksi.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PictureBoxKoleksi.Name = "PictureBoxKoleksi"
        Me.PictureBoxKoleksi.Size = New System.Drawing.Size(114, 147)
        Me.PictureBoxKoleksi.TabIndex = 50
        Me.PictureBoxKoleksi.TabStop = False
        '
        'ButtonEditKoleksi
        '
        Me.ButtonEditKoleksi.Location = New System.Drawing.Point(187, 698)
        Me.ButtonEditKoleksi.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ButtonEditKoleksi.Name = "ButtonEditKoleksi"
        Me.ButtonEditKoleksi.Size = New System.Drawing.Size(141, 31)
        Me.ButtonEditKoleksi.TabIndex = 49
        Me.ButtonEditKoleksi.Text = "Update Koleksi"
        Me.ButtonEditKoleksi.UseVisualStyleBackColor = True
        '
        'DateTimePickerTanggalMasuk
        '
        Me.DateTimePickerTanggalMasuk.Location = New System.Drawing.Point(308, 314)
        Me.DateTimePickerTanggalMasuk.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DateTimePickerTanggalMasuk.Name = "DateTimePickerTanggalMasuk"
        Me.DateTimePickerTanggalMasuk.Size = New System.Drawing.Size(186, 27)
        Me.DateTimePickerTanggalMasuk.TabIndex = 48
        '
        'ComboBoxJenisKoleksi
        '
        Me.ComboBoxJenisKoleksi.FormattingEnabled = True
        Me.ComboBoxJenisKoleksi.Location = New System.Drawing.Point(308, 50)
        Me.ComboBoxJenisKoleksi.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ComboBoxJenisKoleksi.Name = "ComboBoxJenisKoleksi"
        Me.ComboBoxJenisKoleksi.Size = New System.Drawing.Size(186, 28)
        Me.ComboBoxJenisKoleksi.TabIndex = 47
        '
        'GroupBoxKategori
        '
        Me.GroupBoxKategori.Controls.Add(Me.CheckBoxBudaya)
        Me.GroupBoxKategori.Controls.Add(Me.CheckBoxTeknologi)
        Me.GroupBoxKategori.Controls.Add(Me.CheckBoxSosial)
        Me.GroupBoxKategori.Controls.Add(Me.CheckBoxSains)
        Me.GroupBoxKategori.Location = New System.Drawing.Point(308, 506)
        Me.GroupBoxKategori.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBoxKategori.Name = "GroupBoxKategori"
        Me.GroupBoxKategori.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBoxKategori.Size = New System.Drawing.Size(186, 165)
        Me.GroupBoxKategori.TabIndex = 46
        Me.GroupBoxKategori.TabStop = False
        Me.GroupBoxKategori.Text = "Kategori"
        '
        'GroupBoxBahasa
        '
        Me.GroupBoxBahasa.Controls.Add(Me.RadioButtonInggris)
        Me.GroupBoxBahasa.Controls.Add(Me.RadioButtonIndonesia)
        Me.GroupBoxBahasa.Location = New System.Drawing.Point(308, 388)
        Me.GroupBoxBahasa.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBoxBahasa.Name = "GroupBoxBahasa"
        Me.GroupBoxBahasa.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBoxBahasa.Size = New System.Drawing.Size(186, 101)
        Me.GroupBoxBahasa.TabIndex = 45
        Me.GroupBoxBahasa.TabStop = False
        Me.GroupBoxBahasa.Text = "Bahasa"
        '
        'TextBoxStock
        '
        Me.TextBoxStock.Location = New System.Drawing.Point(308, 350)
        Me.TextBoxStock.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextBoxStock.Name = "TextBoxStock"
        Me.TextBoxStock.Size = New System.Drawing.Size(186, 27)
        Me.TextBoxStock.TabIndex = 44
        '
        'TextBoxLokasiRak
        '
        Me.TextBoxLokasiRak.Location = New System.Drawing.Point(308, 274)
        Me.TextBoxLokasiRak.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextBoxLokasiRak.Name = "TextBoxLokasiRak"
        Me.TextBoxLokasiRak.Size = New System.Drawing.Size(186, 27)
        Me.TextBoxLokasiRak.TabIndex = 43
        '
        'TextBoxTahunTerbit
        '
        Me.TextBoxTahunTerbit.Location = New System.Drawing.Point(308, 235)
        Me.TextBoxTahunTerbit.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextBoxTahunTerbit.Name = "TextBoxTahunTerbit"
        Me.TextBoxTahunTerbit.Size = New System.Drawing.Size(186, 27)
        Me.TextBoxTahunTerbit.TabIndex = 42
        '
        'TextBoxPenerbit
        '
        Me.TextBoxPenerbit.Location = New System.Drawing.Point(308, 195)
        Me.TextBoxPenerbit.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextBoxPenerbit.Name = "TextBoxPenerbit"
        Me.TextBoxPenerbit.Size = New System.Drawing.Size(186, 27)
        Me.TextBoxPenerbit.TabIndex = 41
        '
        'RichTextBoxDeskripsi
        '
        Me.RichTextBoxDeskripsi.Location = New System.Drawing.Point(308, 88)
        Me.RichTextBoxDeskripsi.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.RichTextBoxDeskripsi.Name = "RichTextBoxDeskripsi"
        Me.RichTextBoxDeskripsi.Size = New System.Drawing.Size(186, 97)
        Me.RichTextBoxDeskripsi.TabIndex = 40
        Me.RichTextBoxDeskripsi.Text = ""
        '
        'TextBoxNama
        '
        Me.TextBoxNama.Location = New System.Drawing.Point(308, 15)
        Me.TextBoxNama.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextBoxNama.Name = "TextBoxNama"
        Me.TextBoxNama.Size = New System.Drawing.Size(186, 27)
        Me.TextBoxNama.TabIndex = 39
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(149, 399)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(56, 20)
        Me.Label11.TabIndex = 38
        Me.Label11.Text = "Bahasa"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(149, 506)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(66, 20)
        Me.Label10.TabIndex = 37
        Me.Label10.Text = "Kategori"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(149, 360)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(45, 20)
        Me.Label8.TabIndex = 36
        Me.Label8.Text = "Stock"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(149, 322)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(158, 20)
        Me.Label9.TabIndex = 35
        Me.Label9.Text = "Tanggal Masuk Koleksi"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(149, 284)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(78, 20)
        Me.Label6.TabIndex = 34
        Me.Label6.Text = "Lokasi Rak"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(149, 246)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(89, 20)
        Me.Label5.TabIndex = 33
        Me.Label5.Text = "Tahun Terbit"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(149, 206)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 20)
        Me.Label3.TabIndex = 32
        Me.Label3.Text = "Penerbit"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(149, 92)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 20)
        Me.Label4.TabIndex = 31
        Me.Label4.Text = "Deskripsi"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(149, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 20)
        Me.Label2.TabIndex = 30
        Me.Label2.Text = "Jenis Koleksi"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(149, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 20)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "Nama Koleksi"
        '
        'UpdateKoleksi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(511, 745)
        Me.Controls.Add(Me.ButtonUpdatePhoto)
        Me.Controls.Add(Me.PictureBoxKoleksi)
        Me.Controls.Add(Me.ButtonEditKoleksi)
        Me.Controls.Add(Me.DateTimePickerTanggalMasuk)
        Me.Controls.Add(Me.ComboBoxJenisKoleksi)
        Me.Controls.Add(Me.GroupBoxKategori)
        Me.Controls.Add(Me.GroupBoxBahasa)
        Me.Controls.Add(Me.TextBoxStock)
        Me.Controls.Add(Me.TextBoxLokasiRak)
        Me.Controls.Add(Me.TextBoxTahunTerbit)
        Me.Controls.Add(Me.TextBoxPenerbit)
        Me.Controls.Add(Me.RichTextBoxDeskripsi)
        Me.Controls.Add(Me.TextBoxNama)
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
        Me.Name = "UpdateKoleksi"
        Me.Text = "UpdateKoleksi"
        CType(Me.PictureBoxKoleksi, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBoxKategori.ResumeLayout(False)
        Me.GroupBoxKategori.PerformLayout()
        Me.GroupBoxBahasa.ResumeLayout(False)
        Me.GroupBoxBahasa.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents CheckBoxBudaya As CheckBox
    Friend WithEvents CheckBoxTeknologi As CheckBox
    Friend WithEvents CheckBoxSosial As CheckBox
    Friend WithEvents CheckBoxSains As CheckBox
    Friend WithEvents RadioButtonInggris As RadioButton
    Friend WithEvents RadioButtonIndonesia As RadioButton
    Friend WithEvents ButtonUploadPhoto As Button
    Friend WithEvents PictureBoxKoleksi As PictureBox
    Friend WithEvents ButtonEditKoleksi As Button
    Friend WithEvents DateTimePickerTanggalMasuk As DateTimePicker
    Friend WithEvents ComboBoxJenisKoleksi As ComboBox
    Friend WithEvents GroupBoxKategori As GroupBox
    Friend WithEvents GroupBoxBahasa As GroupBox
    Friend WithEvents TextBoxStock As TextBox
    Friend WithEvents TextBoxLokasiRak As TextBox
    Friend WithEvents TextBoxTahunTerbit As TextBox
    Friend WithEvents TextBoxPenerbit As TextBox
    Friend WithEvents RichTextBoxDeskripsi As RichTextBox
    Friend WithEvents TextBoxNama As TextBox
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
    Friend WithEvents ButtonUpdatePhoto As Button
End Class
