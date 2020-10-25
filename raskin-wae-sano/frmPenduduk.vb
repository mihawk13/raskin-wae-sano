Public Class frmPenduduk
    Dim dtPenduduk As DataTable
    Dim conn As New Database
    Dim bdSource As New BindingSource

    Public Sub LoadData()
        dtPenduduk = conn.getQuery("SELECT * FROM penduduk")
        bdSource.DataSource = dtPenduduk
        GridControl.DataSource = bdSource
        GridView.Columns(7).Visible = False
        GridView.Columns(8).Visible = False
        GridView.Columns(9).Visible = False
        GridView.Columns(10).Visible = False
    End Sub

    Private Sub frmPenduduk_Load(sender As Object, e As EventArgs) Handles Me.Load
        LoadData()
        'frmPenduduk_Tambah.LoadKriteria()
    End Sub

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        frmPenduduk_Tambah.Clear()
        frmPenduduk_Tambah.ShowDialog()
    End Sub

    Private Sub GridView_Click(sender As Object, e As EventArgs) Handles GridView.Click
        frmPenduduk_Tambah.Text = "Ubah Data Penduduk"
        frmPenduduk_Tambah.lblJudul.Text = "Ubah Data Penduduk"
        frmPenduduk_Tambah.idPenduduk = GridView.GetRowCellValue(GridView.FocusedRowHandle, "ID")
        frmPenduduk_Tambah.txtKK.Text = GridView.GetRowCellValue(GridView.FocusedRowHandle, "No_KK")
        frmPenduduk_Tambah.txtKTP.Text = GridView.GetRowCellValue(GridView.FocusedRowHandle, "No_KTP")
        frmPenduduk_Tambah.txtNama.Text = GridView.GetRowCellValue(GridView.FocusedRowHandle, "Nama")
        frmPenduduk_Tambah.txtDesa.Text = GridView.GetRowCellValue(GridView.FocusedRowHandle, "Desa")
        frmPenduduk_Tambah.txtKec.Text = GridView.GetRowCellValue(GridView.FocusedRowHandle, "Kecamatan")
        frmPenduduk_Tambah.txtRT.Text = GridView.GetRowCellValue(GridView.FocusedRowHandle, "RT_RW")
        frmPenduduk_Tambah.cboK1.Text = GridView.GetRowCellValue(GridView.FocusedRowHandle, "K_1")
        frmPenduduk_Tambah.cboK2.Text = GridView.GetRowCellValue(GridView.FocusedRowHandle, "K_2")
        frmPenduduk_Tambah.cboK3.Text = GridView.GetRowCellValue(GridView.FocusedRowHandle, "K_3")
        frmPenduduk_Tambah.cboK4.Text = GridView.GetRowCellValue(GridView.FocusedRowHandle, "K_4")
        btnUbah.Enabled = True
    End Sub

    Private Sub GridView_DoubleClick(sender As Object, e As EventArgs) Handles GridView.DoubleClick
        frmPenduduk_Tambah.Text = "Ubah Data Penduduk"
        frmPenduduk_Tambah.lblJudul.Text = "Ubah Data Penduduk"
        frmPenduduk_Tambah.idPenduduk = GridView.GetRowCellValue(GridView.FocusedRowHandle, "ID")
        frmPenduduk_Tambah.txtKK.Text = GridView.GetRowCellValue(GridView.FocusedRowHandle, "No_KK")
        frmPenduduk_Tambah.txtKTP.Text = GridView.GetRowCellValue(GridView.FocusedRowHandle, "No_KTP")
        frmPenduduk_Tambah.txtNama.Text = GridView.GetRowCellValue(GridView.FocusedRowHandle, "Nama")
        frmPenduduk_Tambah.txtDesa.Text = GridView.GetRowCellValue(GridView.FocusedRowHandle, "Desa")
        frmPenduduk_Tambah.txtKec.Text = GridView.GetRowCellValue(GridView.FocusedRowHandle, "Kecamatan")
        frmPenduduk_Tambah.txtRT.Text = GridView.GetRowCellValue(GridView.FocusedRowHandle, "RT_RW")
        frmPenduduk_Tambah.cboK1.Text = GridView.GetRowCellValue(GridView.FocusedRowHandle, "K_1")
        frmPenduduk_Tambah.cboK2.Text = GridView.GetRowCellValue(GridView.FocusedRowHandle, "K_2")
        frmPenduduk_Tambah.cboK3.Text = GridView.GetRowCellValue(GridView.FocusedRowHandle, "K_3")
        frmPenduduk_Tambah.cboK4.Text = GridView.GetRowCellValue(GridView.FocusedRowHandle, "K_4")
        btnUbah.Enabled = True
        frmPenduduk_Tambah.ShowDialog()
    End Sub

    Private Sub btnUbah_Click(sender As Object, e As EventArgs) Handles btnUbah.Click
        If frmPenduduk_Tambah.idPenduduk = 0 Then
            MessageBox.Show("Pilih data sebelum klik ubah!", "Data Kosong", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        frmPenduduk_Tambah.ShowDialog()
    End Sub

    Private Sub txtCari_TextChanged(sender As Object, e As EventArgs) Handles txtCari.TextChanged
        bdSource.Filter = "Nama LIKE '%" & txtCari.Text & "%' OR No_KK LIKE '%" & txtCari.Text & "%' OR Desa LIKE '%" & txtCari.Text & "%' OR Kecamatan LIKE '%" & txtCari.Text & "%'"
    End Sub
End Class