Public Class frmUser
    Dim dtUser As DataTable
    Dim conn As New Database
    Dim bdSource As New BindingSource

    Public Sub LoadData()
        dtUser = conn.getQuery("SELECT * FROM user")
        bdSource.DataSource = dtUser
        GridControl.DataSource = bdSource
        GridView.Columns(2).Visible = False
    End Sub

    Private Sub frmUser_Load(sender As Object, e As EventArgs) Handles Me.Load
        LoadData()
    End Sub

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        frmUser_Tambah.ShowDialog()
    End Sub

    Private Sub GridView_Click(sender As Object, e As EventArgs) Handles GridView.Click
        frmUser_Tambah.Text = "Ubah User"
        frmUser_Tambah.lblJudul.Text = "Ubah User"
        frmUser_Tambah.idUser = GridView.GetRowCellValue(GridView.FocusedRowHandle, "ID")
        frmUser_Tambah.txtUser.Text = GridView.GetRowCellValue(GridView.FocusedRowHandle, "Username")
        frmUser_Tambah.txtPass.Text = GridView.GetRowCellValue(GridView.FocusedRowHandle, "Password")
        frmUser_Tambah.cboHakAkses.Text = GridView.GetRowCellValue(GridView.FocusedRowHandle, "Hak_Akses")
        btnUbah.Enabled = True
    End Sub

    Private Sub GridView_DoubleClick(sender As Object, e As EventArgs) Handles GridView.DoubleClick
        frmUser_Tambah.Text = "Ubah User"
        frmUser_Tambah.lblJudul.Text = "Ubah User"
        frmUser_Tambah.idUser = GridView.GetRowCellValue(GridView.FocusedRowHandle, "ID")
        frmUser_Tambah.txtUser.Text = GridView.GetRowCellValue(GridView.FocusedRowHandle, "Username")
        frmUser_Tambah.txtPass.Text = GridView.GetRowCellValue(GridView.FocusedRowHandle, "Password")
        frmUser_Tambah.cboHakAkses.Text = GridView.GetRowCellValue(GridView.FocusedRowHandle, "Hak_Akses")
        btnUbah.Enabled = True
        frmUser_Tambah.ShowDialog()
    End Sub

    Private Sub btnUbah_Click(sender As Object, e As EventArgs) Handles btnUbah.Click
        If frmUser_Tambah.idUser = 0 Then
            MessageBox.Show("Pilih data sebelum klik ubah!", "Data Kosong", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        frmUser_Tambah.ShowDialog()
    End Sub

    Private Sub txtCari_TextChanged(sender As Object, e As EventArgs) Handles txtCari.TextChanged
        bdSource.Filter = "Username LIKE '%" & txtCari.Text & "%' OR Hak_Akses LIKE '%" & txtCari.Text & "%'"
    End Sub
End Class