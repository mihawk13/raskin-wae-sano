<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUser_Tambah
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
        Me.btnSimpan = New System.Windows.Forms.Button()
        Me.btnBatal = New System.Windows.Forms.Button()
        Me.cboHakAkses = New System.Windows.Forms.ComboBox()
        Me.txtPass = New System.Windows.Forms.TextBox()
        Me.txtUser = New System.Windows.Forms.TextBox()
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
        Me.panUp.Size = New System.Drawing.Size(278, 71)
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
        Me.lblJudul.Size = New System.Drawing.Size(250, 48)
        Me.lblJudul.TabIndex = 2
        Me.lblJudul.Text = "Tambah User"
        Me.lblJudul.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'panDown
        '
        Me.panDown.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panDown.Controls.Add(Me.btnSimpan)
        Me.panDown.Controls.Add(Me.btnBatal)
        Me.panDown.Controls.Add(Me.cboHakAkses)
        Me.panDown.Controls.Add(Me.txtPass)
        Me.panDown.Controls.Add(Me.txtUser)
        Me.panDown.Controls.Add(Me.Label4)
        Me.panDown.Controls.Add(Me.Label3)
        Me.panDown.Controls.Add(Me.Label2)
        Me.panDown.Controls.Add(Me.Label1)
        Me.panDown.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panDown.Location = New System.Drawing.Point(0, 71)
        Me.panDown.Name = "panDown"
        Me.panDown.Size = New System.Drawing.Size(278, 170)
        Me.panDown.TabIndex = 0
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
        Me.btnSimpan.Location = New System.Drawing.Point(49, 133)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(89, 26)
        Me.btnSimpan.TabIndex = 3
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
        Me.btnBatal.Location = New System.Drawing.Point(144, 133)
        Me.btnBatal.Name = "btnBatal"
        Me.btnBatal.Size = New System.Drawing.Size(89, 26)
        Me.btnBatal.TabIndex = 4
        Me.btnBatal.Text = "Batal"
        Me.btnBatal.UseVisualStyleBackColor = False
        '
        'cboHakAkses
        '
        Me.cboHakAkses.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboHakAkses.FormattingEnabled = True
        Me.cboHakAkses.Items.AddRange(New Object() {"Admin", "Kepala Desa", ""})
        Me.cboHakAkses.Location = New System.Drawing.Point(110, 97)
        Me.cboHakAkses.Name = "cboHakAkses"
        Me.cboHakAkses.Size = New System.Drawing.Size(123, 21)
        Me.cboHakAkses.TabIndex = 2
        '
        'txtPass
        '
        Me.txtPass.Location = New System.Drawing.Point(110, 68)
        Me.txtPass.Name = "txtPass"
        Me.txtPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPass.Size = New System.Drawing.Size(123, 20)
        Me.txtPass.TabIndex = 1
        '
        'txtUser
        '
        Me.txtUser.Location = New System.Drawing.Point(110, 42)
        Me.txtUser.Name = "txtUser"
        Me.txtUser.Size = New System.Drawing.Size(123, 20)
        Me.txtUser.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(45, 100)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Hak Akses"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(45, 71)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Password"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(45, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(188, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "SILAHKAN MASUKKAN DATA USER"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(45, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Username"
        '
        'frmUser_Tambah
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(278, 241)
        Me.ControlBox = False
        Me.Controls.Add(Me.panDown)
        Me.Controls.Add(Me.panUp)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmUser_Tambah"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tambah User"
        Me.TopMost = True
        Me.panUp.ResumeLayout(False)
        Me.panDown.ResumeLayout(False)
        Me.panDown.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents panUp As System.Windows.Forms.Panel
    Friend WithEvents lblJudul As System.Windows.Forms.Label
    Friend WithEvents panDown As System.Windows.Forms.Panel
    Friend WithEvents cboHakAkses As System.Windows.Forms.ComboBox
    Friend WithEvents txtPass As System.Windows.Forms.TextBox
    Friend WithEvents txtUser As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnSimpan As System.Windows.Forms.Button
    Friend WithEvents btnBatal As System.Windows.Forms.Button
End Class
