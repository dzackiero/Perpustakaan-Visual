<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Perpustakaan
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.ButtonAddKoleksi = New System.Windows.Forms.Button()
        Me.ListBoxKoleksi = New System.Windows.Forms.ListBox()
        Me.ButtonDeleteKoleksi = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.KoleksiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TambahKoleksiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ButtonShowGridView = New System.Windows.Forms.Button()
        Me.ButtonUpdateKoleksi = New System.Windows.Forms.Button()
        Me.ButtonDelete = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtonAddKoleksi
        '
        Me.ButtonAddKoleksi.Location = New System.Drawing.Point(14, 48)
        Me.ButtonAddKoleksi.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ButtonAddKoleksi.Name = "ButtonAddKoleksi"
        Me.ButtonAddKoleksi.Size = New System.Drawing.Size(35, 31)
        Me.ButtonAddKoleksi.TabIndex = 0
        Me.ButtonAddKoleksi.Text = "+"
        Me.ButtonAddKoleksi.UseVisualStyleBackColor = True
        '
        'ListBoxKoleksi
        '
        Me.ListBoxKoleksi.FormattingEnabled = True
        Me.ListBoxKoleksi.ItemHeight = 20
        Me.ListBoxKoleksi.Location = New System.Drawing.Point(14, 87)
        Me.ListBoxKoleksi.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ListBoxKoleksi.Name = "ListBoxKoleksi"
        Me.ListBoxKoleksi.Size = New System.Drawing.Size(475, 484)
        Me.ListBoxKoleksi.TabIndex = 1
        '
        'ButtonDeleteKoleksi
        '
        Me.ButtonDeleteKoleksi.Location = New System.Drawing.Point(56, 48)
        Me.ButtonDeleteKoleksi.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ButtonDeleteKoleksi.Name = "ButtonDeleteKoleksi"
        Me.ButtonDeleteKoleksi.Size = New System.Drawing.Size(35, 31)
        Me.ButtonDeleteKoleksi.TabIndex = 2
        Me.ButtonDeleteKoleksi.Text = "-"
        Me.ButtonDeleteKoleksi.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.KoleksiToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(7, 3, 0, 3)
        Me.MenuStrip1.Size = New System.Drawing.Size(1101, 30)
        Me.MenuStrip1.TabIndex = 3
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'KoleksiToolStripMenuItem
        '
        Me.KoleksiToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TambahKoleksiToolStripMenuItem})
        Me.KoleksiToolStripMenuItem.Name = "KoleksiToolStripMenuItem"
        Me.KoleksiToolStripMenuItem.Size = New System.Drawing.Size(70, 24)
        Me.KoleksiToolStripMenuItem.Text = "Koleksi"
        '
        'TambahKoleksiToolStripMenuItem
        '
        Me.TambahKoleksiToolStripMenuItem.Name = "TambahKoleksiToolStripMenuItem"
        Me.TambahKoleksiToolStripMenuItem.Size = New System.Drawing.Size(195, 26)
        Me.TambahKoleksiToolStripMenuItem.Text = "Tambah Koleksi"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(521, 87)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 29
        Me.DataGridView1.Size = New System.Drawing.Size(551, 188)
        Me.DataGridView1.TabIndex = 4
        '
        'ButtonShowGridView
        '
        Me.ButtonShowGridView.Location = New System.Drawing.Point(521, 296)
        Me.ButtonShowGridView.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ButtonShowGridView.Name = "ButtonShowGridView"
        Me.ButtonShowGridView.Size = New System.Drawing.Size(86, 31)
        Me.ButtonShowGridView.TabIndex = 5
        Me.ButtonShowGridView.Text = "Show"
        Me.ButtonShowGridView.UseVisualStyleBackColor = True
        '
        'ButtonUpdateKoleksi
        '
        Me.ButtonUpdateKoleksi.Location = New System.Drawing.Point(613, 296)
        Me.ButtonUpdateKoleksi.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ButtonUpdateKoleksi.Name = "ButtonUpdateKoleksi"
        Me.ButtonUpdateKoleksi.Size = New System.Drawing.Size(86, 31)
        Me.ButtonUpdateKoleksi.TabIndex = 6
        Me.ButtonUpdateKoleksi.Text = "Update"
        Me.ButtonUpdateKoleksi.UseVisualStyleBackColor = True
        '
        'ButtonDelete
        '
        Me.ButtonDelete.Location = New System.Drawing.Point(705, 296)
        Me.ButtonDelete.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ButtonDelete.Name = "ButtonDelete"
        Me.ButtonDelete.Size = New System.Drawing.Size(86, 31)
        Me.ButtonDelete.TabIndex = 7
        Me.ButtonDelete.Text = "Delete"
        Me.ButtonDelete.UseVisualStyleBackColor = True
        '
        'Perpustakaan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1101, 600)
        Me.Controls.Add(Me.ButtonDelete)
        Me.Controls.Add(Me.ButtonUpdateKoleksi)
        Me.Controls.Add(Me.ButtonShowGridView)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.ButtonDeleteKoleksi)
        Me.Controls.Add(Me.ListBoxKoleksi)
        Me.Controls.Add(Me.ButtonAddKoleksi)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "Perpustakaan"
        Me.Text = "Perpustakaan"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ButtonAddKoleksi As Button
    Friend WithEvents ListBoxKoleksi As ListBox
    Friend WithEvents ButtonDeleteKoleksi As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents KoleksiToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TambahKoleksiToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents NamaKoleksi As DataGridViewTextBoxColumn
    Friend WithEvents JenisKoleksi As DataGridViewTextBoxColumn
    Friend WithEvents Penerbit As DataGridViewTextBoxColumn
    Friend WithEvents Deskripsi As DataGridViewTextBoxColumn
    Friend WithEvents TahunTerbit As DataGridViewTextBoxColumn
    Friend WithEvents LokasiRak As DataGridViewTextBoxColumn
    Friend WithEvents TanggalMasuk As DataGridViewTextBoxColumn
    Friend WithEvents Stok As DataGridViewTextBoxColumn
    Friend WithEvents Bahasa As DataGridViewTextBoxColumn
    Friend WithEvents Kategori As DataGridViewTextBoxColumn
    Friend WithEvents ButtonShowGridView As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents ButtonUpdateKoleksi As Button
    Friend WithEvents ButtonDelete As Button
End Class
