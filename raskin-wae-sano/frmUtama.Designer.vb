<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUtama
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.btnLaporan = New System.Windows.Forms.Button()
        Me.btnHome = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnHasil = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnProses = New System.Windows.Forms.Button()
        Me.btnSubKriteria = New System.Windows.Forms.Button()
        Me.btnKriteria = New System.Windows.Forms.Button()
        Me.btnUser = New System.Windows.Forms.Button()
        Me.btnPenduduk = New System.Windows.Forms.Button()
        Me.panForm = New System.Windows.Forms.Panel()
        Me.panUp.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'panUp
        '
        Me.panUp.BackColor = System.Drawing.Color.White
        Me.panUp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panUp.Controls.Add(Me.Panel1)
        Me.panUp.Controls.Add(Me.btnLaporan)
        Me.panUp.Controls.Add(Me.btnHome)
        Me.panUp.Controls.Add(Me.Label2)
        Me.panUp.Controls.Add(Me.btnHasil)
        Me.panUp.Controls.Add(Me.Label1)
        Me.panUp.Controls.Add(Me.btnProses)
        Me.panUp.Controls.Add(Me.btnSubKriteria)
        Me.panUp.Controls.Add(Me.btnKriteria)
        Me.panUp.Controls.Add(Me.btnUser)
        Me.panUp.Controls.Add(Me.btnPenduduk)
        Me.panUp.Dock = System.Windows.Forms.DockStyle.Top
        Me.panUp.Location = New System.Drawing.Point(0, 0)
        Me.panUp.Name = "panUp"
        Me.panUp.Size = New System.Drawing.Size(1350, 122)
        Me.panUp.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.Controls.Add(Me.btnLogout)
        Me.Panel1.Location = New System.Drawing.Point(1239, 8)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(100, 38)
        Me.Panel1.TabIndex = 2
        '
        'btnLogout
        '
        Me.btnLogout.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnLogout.BackColor = System.Drawing.Color.DarkOrange
        Me.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLogout.FlatAppearance.BorderSize = 0
        Me.btnLogout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrange
        Me.btnLogout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Peru
        Me.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogout.ForeColor = System.Drawing.SystemColors.Control
        Me.btnLogout.Location = New System.Drawing.Point(0, 2)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(100, 34)
        Me.btnLogout.TabIndex = 1
        Me.btnLogout.Text = "Logout"
        Me.btnLogout.UseVisualStyleBackColor = False
        '
        'btnLaporan
        '
        Me.btnLaporan.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnLaporan.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnLaporan.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLaporan.FlatAppearance.BorderSize = 0
        Me.btnLaporan.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue
        Me.btnLaporan.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue
        Me.btnLaporan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLaporan.ForeColor = System.Drawing.SystemColors.Control
        Me.btnLaporan.Location = New System.Drawing.Point(994, 77)
        Me.btnLaporan.Name = "btnLaporan"
        Me.btnLaporan.Size = New System.Drawing.Size(100, 34)
        Me.btnLaporan.TabIndex = 1
        Me.btnLaporan.Text = "Laporan"
        Me.btnLaporan.UseVisualStyleBackColor = False
        '
        'btnHome
        '
        Me.btnHome.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnHome.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnHome.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnHome.FlatAppearance.BorderSize = 0
        Me.btnHome.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue
        Me.btnHome.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue
        Me.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHome.ForeColor = System.Drawing.SystemColors.Control
        Me.btnHome.Location = New System.Drawing.Point(252, 77)
        Me.btnHome.Name = "btnHome"
        Me.btnHome.Size = New System.Drawing.Size(100, 34)
        Me.btnHome.TabIndex = 1
        Me.btnHome.Text = "Home"
        Me.btnHome.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(11, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(1326, 31)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Kelurahan Wae Sano"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnHasil
        '
        Me.btnHasil.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnHasil.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnHasil.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnHasil.FlatAppearance.BorderSize = 0
        Me.btnHasil.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue
        Me.btnHasil.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue
        Me.btnHasil.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHasil.ForeColor = System.Drawing.SystemColors.Control
        Me.btnHasil.Location = New System.Drawing.Point(888, 77)
        Me.btnHasil.Name = "btnHasil"
        Me.btnHasil.Size = New System.Drawing.Size(100, 34)
        Me.btnHasil.TabIndex = 1
        Me.btnHasil.Text = "Hasil SPK"
        Me.btnHasil.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(17, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1320, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Sistem Pendukung Keputusan Seleksi Penerima Raskin"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnProses
        '
        Me.btnProses.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnProses.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnProses.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnProses.FlatAppearance.BorderSize = 0
        Me.btnProses.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue
        Me.btnProses.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue
        Me.btnProses.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProses.ForeColor = System.Drawing.SystemColors.Control
        Me.btnProses.Location = New System.Drawing.Point(782, 77)
        Me.btnProses.Name = "btnProses"
        Me.btnProses.Size = New System.Drawing.Size(100, 34)
        Me.btnProses.TabIndex = 1
        Me.btnProses.Text = "Proses SPK"
        Me.btnProses.UseVisualStyleBackColor = False
        '
        'btnSubKriteria
        '
        Me.btnSubKriteria.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnSubKriteria.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnSubKriteria.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSubKriteria.FlatAppearance.BorderSize = 0
        Me.btnSubKriteria.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue
        Me.btnSubKriteria.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue
        Me.btnSubKriteria.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSubKriteria.ForeColor = System.Drawing.SystemColors.Control
        Me.btnSubKriteria.Location = New System.Drawing.Point(676, 77)
        Me.btnSubKriteria.Name = "btnSubKriteria"
        Me.btnSubKriteria.Size = New System.Drawing.Size(100, 34)
        Me.btnSubKriteria.TabIndex = 1
        Me.btnSubKriteria.Text = "Sub Kriteria"
        Me.btnSubKriteria.UseVisualStyleBackColor = False
        '
        'btnKriteria
        '
        Me.btnKriteria.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnKriteria.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnKriteria.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnKriteria.FlatAppearance.BorderSize = 0
        Me.btnKriteria.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue
        Me.btnKriteria.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue
        Me.btnKriteria.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnKriteria.ForeColor = System.Drawing.SystemColors.Control
        Me.btnKriteria.Location = New System.Drawing.Point(570, 77)
        Me.btnKriteria.Name = "btnKriteria"
        Me.btnKriteria.Size = New System.Drawing.Size(100, 34)
        Me.btnKriteria.TabIndex = 1
        Me.btnKriteria.Text = "Data Kriteria"
        Me.btnKriteria.UseVisualStyleBackColor = False
        '
        'btnUser
        '
        Me.btnUser.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnUser.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnUser.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUser.FlatAppearance.BorderSize = 0
        Me.btnUser.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue
        Me.btnUser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue
        Me.btnUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUser.ForeColor = System.Drawing.SystemColors.Control
        Me.btnUser.Location = New System.Drawing.Point(358, 77)
        Me.btnUser.Name = "btnUser"
        Me.btnUser.Size = New System.Drawing.Size(100, 34)
        Me.btnUser.TabIndex = 1
        Me.btnUser.Text = "User"
        Me.btnUser.UseVisualStyleBackColor = False
        '
        'btnPenduduk
        '
        Me.btnPenduduk.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnPenduduk.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnPenduduk.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPenduduk.FlatAppearance.BorderSize = 0
        Me.btnPenduduk.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue
        Me.btnPenduduk.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue
        Me.btnPenduduk.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPenduduk.ForeColor = System.Drawing.SystemColors.Control
        Me.btnPenduduk.Location = New System.Drawing.Point(464, 77)
        Me.btnPenduduk.Name = "btnPenduduk"
        Me.btnPenduduk.Size = New System.Drawing.Size(100, 34)
        Me.btnPenduduk.TabIndex = 1
        Me.btnPenduduk.Text = "Data Penduduk"
        Me.btnPenduduk.UseVisualStyleBackColor = False
        '
        'panForm
        '
        Me.panForm.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panForm.Location = New System.Drawing.Point(0, 122)
        Me.panForm.Name = "panForm"
        Me.panForm.Size = New System.Drawing.Size(1350, 607)
        Me.panForm.TabIndex = 1
        '
        'frmUtama
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1350, 729)
        Me.Controls.Add(Me.panForm)
        Me.Controls.Add(Me.panUp)
        Me.Name = "frmUtama"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SPK Seleksi Penerima Raskin - Wae Sano"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.panUp.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents panUp As System.Windows.Forms.Panel
    Friend WithEvents btnHome As System.Windows.Forms.Button
    Friend WithEvents panForm As System.Windows.Forms.Panel
    Friend WithEvents btnLaporan As System.Windows.Forms.Button
    Friend WithEvents btnHasil As System.Windows.Forms.Button
    Friend WithEvents btnSubKriteria As System.Windows.Forms.Button
    Friend WithEvents btnPenduduk As System.Windows.Forms.Button
    Friend WithEvents btnProses As System.Windows.Forms.Button
    Friend WithEvents btnKriteria As System.Windows.Forms.Button
    Friend WithEvents btnUser As System.Windows.Forms.Button
    Friend WithEvents btnLogout As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel

End Class
