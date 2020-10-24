Public Class frmPenduduk
    Dim dtPenduduk As DataTable
    Dim conn As New Database
    Dim bdSource As New BindingSource

    Public Sub LoadData()
        dtPenduduk = conn.getQuery("SELECT * FROM penduduk")
        bdSource.DataSource = dtPenduduk
        GridControl.DataSource = bdSource
    End Sub

    Private Sub frmPenduduk_Load(sender As Object, e As EventArgs) Handles Me.Load
        LoadData()
    End Sub

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
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
        frmPenduduk_Tambah.txtAlamat.Text = GridView.GetRowCellValue(GridView.FocusedRowHandle, "Alamat")
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
        frmPenduduk_Tambah.txtAlamat.Text = GridView.GetRowCellValue(GridView.FocusedRowHandle, "Alamat")
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