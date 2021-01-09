<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPenduduk_Tambah
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
        Me.panUp = New System.Windows.Forms.Panel()
        Me.lblJudul = New System.Windows.Forms.Label()
        Me.panDown = New System.Windows.Forms.Panel()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.imgKTP = New System.Windows.Forms.PictureBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.imgKK = New System.Windows.Forms.PictureBox()
        Me.btnKTP = New System.Windows.Forms.Button()
        Me.btnKK = New System.Windows.Forms.Button()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.btnSimpan = New System.Windows.Forms.Button()
        Me.btnBatal = New System.Windows.Forms.Button()
        Me.txtRT = New System.Windows.Forms.TextBox()
        Me.txtDesa = New System.Windows.Forms.TextBox()
        Me.txtKTP = New System.Windows.Forms.TextBox()
        Me.txtKec = New System.Windows.Forms.TextBox()
        Me.txtNama = New System.Windows.Forms.TextBox()
        Me.txtKK = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.panUp.SuspendLayout()
        Me.panDown.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.imgKTP, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.imgKK, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'panUp
        '
        Me.panUp.BackColor = System.Drawing.SystemColors.Control
        Me.panUp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panUp.Controls.Add(Me.lblJudul)
        Me.panUp.Dock = System.Windows.Forms.DockStyle.Top
        Me.panUp.Location = New System.Drawing.Point(0, 0)
        Me.panUp.Name = "panUp"
        Me.panUp.Size = New System.Drawing.Size(954, 71)
        Me.panUp.TabIndex = 0
        '
        'lblJudul
        '
        Me.lblJudul.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblJudul.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJudul.Location = New System.Drawing.Point(13, 9)
        Me.lblJudul.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblJudul.Name = "lblJudul"
        Me.lblJudul.Size = New System.Drawing.Size(926, 48)
        Me.lblJudul.TabIndex = 2
        Me.lblJudul.Text = "Tambah Data Penduduk"
        Me.lblJudul.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'panDown
        '
        Me.panDown.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panDown.Controls.Add(Me.GroupBox2)
        Me.panDown.Controls.Add(Me.GroupBox1)
        Me.panDown.Controls.Add(Me.btnKTP)
        Me.panDown.Controls.Add(Me.btnKK)
        Me.panDown.Controls.Add(Me.Label15)
        Me.panDown.Controls.Add(Me.btnSimpan)
        Me.panDown.Controls.Add(Me.btnBatal)
        Me.panDown.Controls.Add(Me.txtRT)
        Me.panDown.Controls.Add(Me.txtDesa)
        Me.panDown.Controls.Add(Me.txtKTP)
        Me.panDown.Controls.Add(Me.txtKec)
        Me.panDown.Controls.Add(Me.txtNama)
        Me.panDown.Controls.Add(Me.txtKK)
        Me.panDown.Controls.Add(Me.Label7)
        Me.panDown.Controls.Add(Me.Label6)
        Me.panDown.Controls.Add(Me.Label5)
        Me.panDown.Controls.Add(Me.Label4)
        Me.panDown.Controls.Add(Me.Label3)
        Me.panDown.Controls.Add(Me.Label10)
        Me.panDown.Controls.Add(Me.Label2)
        Me.panDown.Controls.Add(Me.Label1)
        Me.panDown.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panDown.Location = New System.Drawing.Point(0, 71)
        Me.panDown.Name = "panDown"
        Me.panDown.Size = New System.Drawing.Size(954, 241)
        Me.panDown.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.imgKTP)
        Me.GroupBox2.Location = New System.Drawing.Point(385, 130)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(137, 94)
        Me.GroupBox2.TabIndex = 20
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Gambar KTP"
        '
        'imgKTP
        '
        Me.imgKTP.Location = New System.Drawing.Point(5, 14)
        Me.imgKTP.Name = "imgKTP"
        Me.imgKTP.Size = New System.Drawing.Size(128, 74)
        Me.imgKTP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgKTP.TabIndex = 15
        Me.imgKTP.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.imgKK)
        Me.GroupBox1.Location = New System.Drawing.Point(385, 29)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(137, 94)
        Me.GroupBox1.TabIndex = 19
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Gambar KK"
        '
        'imgKK
        '
        Me.imgKK.Location = New System.Drawing.Point(5, 14)
        Me.imgKK.Name = "imgKK"
        Me.imgKK.Size = New System.Drawing.Size(128, 74)
        Me.imgKK.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgKK.TabIndex = 15
        Me.imgKK.TabStop = False
        '
        'btnKTP
        '
        Me.btnKTP.Location = New System.Drawing.Point(299, 173)
        Me.btnKTP.Name = "btnKTP"
        Me.btnKTP.Size = New System.Drawing.Size(80, 23)
        Me.btnKTP.TabIndex = 18
        Me.btnKTP.Text = "Pilih Gambar"
        Me.btnKTP.UseVisualStyleBackColor = True
        '
        'btnKK
        '
        Me.btnKK.Location = New System.Drawing.Point(299, 71)
        Me.btnKK.Name = "btnKK"
        Me.btnKK.Size = New System.Drawing.Size(80, 23)
        Me.btnKK.TabIndex = 17
        Me.btnKK.Text = "Pilih Gambar"
        Me.btnKK.UseVisualStyleBackColor = True
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(327, 13)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(172, 13)
        Me.Label15.TabIndex = 14
        Me.Label15.Text = "SILAHKAN MASUKKAN GAMBAR"
        '
        'btnSimpan
        '
        Me.btnSimpan.BackColor = System.Drawing.Color.Orange
        Me.btnSimpan.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSimpan.FlatAppearance.BorderSize = 0
        Me.btnSimpan.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Orange
        Me.btnSimpan.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOrange
        Me.btnSimpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSimpan.ForeColor = System.Drawing.SystemColors.Control
        Me.btnSimpan.Location = New System.Drawing.Point(104, 198)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(89, 26)
        Me.btnSimpan.TabIndex = 7
        Me.btnSimpan.Text = "Simpan"
        Me.btnSimpan.UseVisualStyleBackColor = False
        '
        'btnBatal
        '
        Me.btnBatal.BackColor = System.Drawing.Color.Orange
        Me.btnBatal.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBatal.FlatAppearance.BorderSize = 0
        Me.btnBatal.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Orange
        Me.btnBatal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOrange
        Me.btnBatal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBatal.ForeColor = System.Drawing.SystemColors.Control
        Me.btnBatal.Location = New System.Drawing.Point(199, 198)
        Me.btnBatal.Name = "btnBatal"
        Me.btnBatal.Size = New System.Drawing.Size(89, 26)
        Me.btnBatal.TabIndex = 8
        Me.btnBatal.Text = "Batal"
        Me.btnBatal.UseVisualStyleBackColor = False
        '
        'txtRT
        '
        Me.txtRT.Location = New System.Drawing.Point(103, 172)
        Me.txtRT.Name = "txtRT"
        Me.txtRT.Size = New System.Drawing.Size(184, 20)
        Me.txtRT.TabIndex = 5
        '
        'txtDesa
        '
        Me.txtDesa.Location = New System.Drawing.Point(103, 120)
        Me.txtDesa.Name = "txtDesa"
        Me.txtDesa.Size = New System.Drawing.Size(184, 20)
        Me.txtDesa.TabIndex = 3
        '
        'txtKTP
        '
        Me.txtKTP.Location = New System.Drawing.Point(104, 68)
        Me.txtKTP.Name = "txtKTP"
        Me.txtKTP.Size = New System.Drawing.Size(184, 20)
        Me.txtKTP.TabIndex = 1
        '
        'txtKec
        '
        Me.txtKec.Location = New System.Drawing.Point(103, 146)
        Me.txtKec.Name = "txtKec"
        Me.txtKec.Size = New System.Drawing.Size(184, 20)
        Me.txtKec.TabIndex = 4
        '
        'txtNama
        '
        Me.txtNama.Location = New System.Drawing.Point(103, 94)
        Me.txtNama.Name = "txtNama"
        Me.txtNama.Size = New System.Drawing.Size(184, 20)
        Me.txtNama.TabIndex = 2
        '
        'txtKK
        '
        Me.txtKK.Location = New System.Drawing.Point(104, 42)
        Me.txtKK.Name = "txtKK"
        Me.txtKK.Size = New System.Drawing.Size(184, 20)
        Me.txtKK.TabIndex = 0
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(39, 175)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(52, 13)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "RT / RW"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(39, 149)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(61, 13)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Kecamatan"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(39, 123)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(32, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Desa"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(39, 97)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Nama"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(39, 71)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "No KTP"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(642, 14)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(241, 13)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "SILAHKAN SESUAIKAN KRITERIA PENDUDUK"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(58, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(219, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "SILAHKAN MASUKKAN DATA PENDUDUK"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(39, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "No KK"
        '
        'frmPenduduk_Tambah
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(954, 312)
        Me.ControlBox = False
        Me.Controls.Add(Me.panDown)
        Me.Controls.Add(Me.panUp)
        Me.Name = "frmPenduduk_Tambah"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tambah Data Penduduk"
        Me.panUp.ResumeLayout(False)
        Me.panDown.ResumeLayout(False)
        Me.panDown.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.imgKTP, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.imgKK, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents panUp As System.Windows.Forms.Panel
    Friend WithEvents lblJudul As System.Windows.Forms.Label
    Friend WithEvents panDown As System.Windows.Forms.Panel
    Friend WithEvents txtKTP As System.Windows.Forms.TextBox
    Friend WithEvents txtKK As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnSimpan As System.Windows.Forms.Button
    Friend WithEvents btnBatal As System.Windows.Forms.Button
    Friend WithEvents txtRT As System.Windows.Forms.TextBox
    Friend WithEvents txtDesa As System.Windows.Forms.TextBox
    Friend WithEvents txtKec As System.Windows.Forms.TextBox
    Friend WithEvents txtNama As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents btnKTP As System.Windows.Forms.Button
    Friend WithEvents btnKK As System.Windows.Forms.Button
    Friend WithEvents imgKK As System.Windows.Forms.PictureBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents imgKTP As System.Windows.Forms.PictureBox
End Class
