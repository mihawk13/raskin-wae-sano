Public Class frmSubKriteria
    Dim dtSubKriteria As DataTable
    Dim conn As New Database
    Dim bdSource As New BindingSource

    Public Sub LoadData()
        dtSubKriteria = conn.getQuery("SELECT * FROM Sub_Kriteria")
        bdSource.DataSource = dtSubKriteria
        GridControl.DataSource = bdSource
    End Sub

    Private Sub frmSubKriteria_Load(sender As Object, e As EventArgs) Handles Me.Load
        LoadData()
    End Sub

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        frmSubKriteria_Tambah.ShowDialog()
    End Sub

    Private Sub GridView_Click(sender As Object, e As EventArgs) Handles GridView.Click
        'frmSubKriteria_Tambah.Text = "Ubah Data SubKriteria"
        'frmSubKriteria_Tambah.lblJudul.Text = "Ubah Data SubKriteria"
        'frmSubKriteria_Tambah.idSubKriteria = GridView.GetRowCellValue(GridView.FocusedRowHandle, "ID")
        'frmSubKriteria_Tambah.txtBobot.Text = GridView.GetRowCellValue(GridView.FocusedRowHandle, "No_KK")
        'frmSubKriteria_Tambah.txtSub.Text = GridView.GetRowCellValue(GridView.FocusedRowHandle, "No_KTP")
        'frmSubKriteria_Tambah.txtNama.Text = GridView.GetRowCellValue(GridView.FocusedRowHandle, "Nama")
        'frmSubKriteria_Tambah.txtDesa.Text = GridView.GetRowCellValue(GridView.FocusedRowHandle, "Desa")
        'frmSubKriteria_Tambah.txtKec.Text = GridView.GetRowCellValue(GridView.FocusedRowHandle, "Kecamatan")
        'frmSubKriteria_Tambah.txtRT.Text = GridView.GetRowCellValue(GridView.FocusedRowHandle, "RT_RW")
        'frmSubKriteria_Tambah.txtAlamat.Text = GridView.GetRowCellValue(GridView.FocusedRowHandle, "Alamat")
        'btnUbah.Enabled = True
    End Sub

    Private Sub GridView_DoubleClick(sender As Object, e As EventArgs) Handles GridView.DoubleClick
        'frmSubKriteria_Tambah.Text = "Ubah Data SubKriteria"
        'frmSubKriteria_Tambah.lblJudul.Text = "Ubah Data SubKriteria"
        'frmSubKriteria_Tambah.idSubKriteria = GridView.GetRowCellValue(GridView.FocusedRowHandle, "ID")
        'frmSubKriteria_Tambah.txtBobot.Text = GridView.GetRowCellValue(GridView.FocusedRowHandle, "No_KK")
        'frmSubKriteria_Tambah.txtSub.Text = GridView.GetRowCellValue(GridView.FocusedRowHandle, "No_KTP")
        'frmSubKriteria_Tambah.txtNama.Text = GridView.GetRowCellValue(GridView.FocusedRowHandle, "Nama")
        'frmSubKriteria_Tambah.txtDesa.Text = GridView.GetRowCellValue(GridView.FocusedRowHandle, "Desa")
        'frmSubKriteria_Tambah.txtKec.Text = GridView.GetRowCellValue(GridView.FocusedRowHandle, "Kecamatan")
        'frmSubKriteria_Tambah.txtRT.Text = GridView.GetRowCellValue(GridView.FocusedRowHandle, "RT_RW")
        'frmSubKriteria_Tambah.txtAlamat.Text = GridView.GetRowCellValue(GridView.FocusedRowHandle, "Alamat")
        'btnUbah.Enabled = True
        'frmSubKriteria_Tambah.ShowDialog()
    End Sub

    Private Sub btnUbah_Click(sender As Object, e As EventArgs) Handles btnUbah.Click
        If frmSubKriteria_Tambah.idSubKriteria = 0 Then
            MessageBox.Show("Pilih data sebelum klik ubah!", "Data Kosong", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        frmSubKriteria_Tambah.ShowDialog()
    End Sub

    Private Sub txtCari_TextChanged(sender As Object, e As EventArgs) Handles txtCari.TextChanged
        bdSource.Filter = "Nama LIKE '%" & txtCari.Text & "%' OR No_KK LIKE '%" & txtCari.Text & "%' OR Desa LIKE '%" & txtCari.Text & "%' OR Kecamatan LIKE '%" & txtCari.Text & "%'"
    End Sub
End Class