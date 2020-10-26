<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProsesSPK
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
        Me.btnProses = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GCMatriks = New DevExpress.XtraGrid.GridControl()
        Me.GVMatriks = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.GCNormal = New DevExpress.XtraGrid.GridControl()
        Me.GVNormal = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.GCMatriks, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVMatriks, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.GCNormal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVNormal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnProses
        '
        Me.btnProses.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnProses.BackColor = System.Drawing.Color.DarkOrange
        Me.btnProses.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnProses.FlatAppearance.BorderSize = 0
        Me.btnProses.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrange
        Me.btnProses.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange
        Me.btnProses.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProses.ForeColor = System.Drawing.SystemColors.Control
        Me.btnProses.Location = New System.Drawing.Point(1201, 7)
        Me.btnProses.Name = "btnProses"
        Me.btnProses.Size = New System.Drawing.Size(89, 26)
        Me.btnProses.TabIndex = 2
        Me.btnProses.Text = "Proses"
        Me.btnProses.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnClear)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.GCMatriks)
        Me.Panel1.Controls.Add(Me.btnProses)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1302, 359)
        Me.Panel1.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 24)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Matriks"
        '
        'GCMatriks
        '
        Me.GCMatriks.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GCMatriks.Location = New System.Drawing.Point(0, 36)
        Me.GCMatriks.MainView = Me.GVMatriks
        Me.GCMatriks.Name = "GCMatriks"
        Me.GCMatriks.Size = New System.Drawing.Size(1302, 323)
        Me.GCMatriks.TabIndex = 3
        Me.GCMatriks.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVMatriks})
        '
        'GVMatriks
        '
        Me.GVMatriks.GridControl = Me.GCMatriks
        Me.GVMatriks.Name = "GVMatriks"
        Me.GVMatriks.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.GVMatriks.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.GVMatriks.OptionsBehavior.Editable = False
        Me.GVMatriks.OptionsView.ShowGroupPanel = False
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.GCNormal)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 359)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1302, 357)
        Me.Panel2.TabIndex = 3
        '
        'GCNormal
        '
        Me.GCNormal.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GCNormal.Location = New System.Drawing.Point(0, 37)
        Me.GCNormal.MainView = Me.GVNormal
        Me.GCNormal.Name = "GCNormal"
        Me.GCNormal.Size = New System.Drawing.Size(1302, 320)
        Me.GCNormal.TabIndex = 5
        Me.GCNormal.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVNormal})
        '
        'GVNormal
        '
        Me.GVNormal.GridControl = Me.GCNormal
        Me.GVNormal.Name = "GVNormal"
        Me.GVNormal.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.GVNormal.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.GVNormal.OptionsBehavior.Editable = False
        Me.GVNormal.OptionsView.ShowGroupPanel = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(118, 24)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Normalisasi"
        '
        'btnClear
        '
        Me.btnClear.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClear.BackColor = System.Drawing.Color.OrangeRed
        Me.btnClear.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClear.Enabled = False
        Me.btnClear.FlatAppearance.BorderSize = 0
        Me.btnClear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.OrangeRed
        Me.btnClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClear.ForeColor = System.Drawing.SystemColors.Control
        Me.btnClear.Location = New System.Drawing.Point(1056, 7)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(139, 26)
        Me.btnClear.TabIndex = 5
        Me.btnClear.Text = "Hapus Hasil Sebelumnya"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'frmProsesSPK
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1302, 716)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MinimizeBox = False
        Me.Name = "frmProsesSPK"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ProsesSPK"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.GCMatriks, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVMatriks, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.GCNormal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVNormal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnProses As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents GCMatriks As DevExpress.XtraGrid.GridControl
    Friend WithEvents GVMatriks As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GCNormal As DevExpress.XtraGrid.GridControl
    Friend WithEvents GVNormal As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnClear As System.Windows.Forms.Button
End Class
