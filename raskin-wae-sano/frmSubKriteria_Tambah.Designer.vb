<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSubKriteria_Tambah
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
        Me.cboKriteria = New System.Windows.Forms.ComboBox()
        Me.btnSimpan = New System.Windows.Forms.Button()
        Me.btnBatal = New System.Windows.Forms.Button()
        Me.txtSub = New System.Windows.Forms.TextBox()
        Me.txtBobot = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.panUp.SuspendLayout()
        Me.panDown.SuspendLayout()
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
        Me.panUp.Size = New System.Drawing.Size(329, 71)
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
        Me.lblJudul.Size = New System.Drawing.Size(301, 48)
        Me.lblJudul.TabIndex = 2
        Me.lblJudul.Text = "Tambah Data Sub Kriteria"
        Me.lblJudul.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'panDown
        '
        Me.panDown.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panDown.Controls.Add(Me.cboKriteria)
        Me.panDown.Controls.Add(Me.btnSimpan)
        Me.panDown.Controls.Add(Me.btnBatal)
        Me.panDown.Controls.Add(Me.txtSub)
        Me.panDown.Controls.Add(Me.txtBobot)
        Me.panDown.Controls.Add(Me.Label4)
        Me.panDown.Controls.Add(Me.Label3)
        Me.panDown.Controls.Add(Me.Label2)
        Me.panDown.Controls.Add(Me.Label1)
        Me.panDown.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panDown.Location = New System.Drawing.Point(0, 71)
        Me.panDown.Name = "panDown"
        Me.panDown.Size = New System.Drawing.Size(329, 169)
        Me.panDown.TabIndex = 0
        '
        'cboKriteria
        '
        Me.cboKriteria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboKriteria.FormattingEnabled = True
        Me.cboKriteria.Location = New System.Drawing.Point(121, 41)
        Me.cboKriteria.Name = "cboKriteria"
        Me.cboKriteria.Size = New System.Drawing.Size(184, 21)
        Me.cboKriteria.TabIndex = 9
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
        Me.btnSimpan.Location = New System.Drawing.Point(121, 124)
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
        Me.btnBatal.Location = New System.Drawing.Point(216, 124)
        Me.btnBatal.Name = "btnBatal"
        Me.btnBatal.Size = New System.Drawing.Size(89, 26)
        Me.btnBatal.TabIndex = 8
        Me.btnBatal.Text = "Batal"
        Me.btnBatal.UseVisualStyleBackColor = False
        '
        'txtSub
        '
        Me.txtSub.Location = New System.Drawing.Point(121, 68)
        Me.txtSub.Name = "txtSub"
        Me.txtSub.Size = New System.Drawing.Size(184, 20)
        Me.txtSub.TabIndex = 1
        '
        'txtBobot
        '
        Me.txtBobot.Location = New System.Drawing.Point(121, 94)
        Me.txtBobot.Name = "txtBobot"
        Me.txtBobot.Size = New System.Drawing.Size(184, 20)
        Me.txtBobot.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(45, 97)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Bobot"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(45, 71)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Sub Kriteria"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(54, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(233, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "SILAHKAN MASUKKAN DATA SUB KRITERIA"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(45, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nama Kriteria"
        '
        'frmSubKriteria_Tambah
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(329, 240)
        Me.ControlBox = False
        Me.Controls.Add(Me.panDown)
        Me.Controls.Add(Me.panUp)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmSubKriteria_Tambah"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tambah Data Sub Kriteria"
        Me.TopMost = True
        Me.panUp.ResumeLayout(False)
        Me.panDown.ResumeLayout(False)
        Me.panDown.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents panUp As System.Windows.Forms.Panel
    Friend WithEvents lblJudul As System.Windows.Forms.Label
    Friend WithEvents panDown As System.Windows.Forms.Panel
    Friend WithEvents txtSub As System.Windows.Forms.TextBox
    Friend WithEvents txtBobot As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnSimpan As System.Windows.Forms.Button
    Friend WithEvents btnBatal As System.Windows.Forms.Button
    Friend WithEvents cboKriteria As System.Windows.Forms.ComboBox
End Class
