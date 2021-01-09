Public Class frmSubKriteria
    Dim dtSubKriteria As DataTable
    Dim conn As New Database
    Dim bdSource As New BindingSource

    Public Sub LoadData()
        dtSubKriteria = conn.getQuery("SELECT a.No,b.Nama 'Kriteria',a.Sub_Kriteria,a.Bobot FROM Sub_Kriteria a " _
                                      & "INNER JOIN kriteria b ON a.Kriteria_ID =b.No_Kriteria")
        bdSource.DataSource = dtSubKriteria
        GridControl.DataSource = bdSource
    End Sub

    Private Sub frmSubKriteria_Load(sender As Object, e As EventArgs) Handles Me.Load
        LoadData()
    End Sub

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        frmSubKriteria_Tambah.Clear()
        frmSubKriteria_Tambah.ShowDialog()
    End Sub

    Private Sub GridView_Click(sender As Object, e As EventArgs) Handles GridView.Click
        frmSubKriteria_Tambah.loadKriteria()
        frmSubKriteria_Tambah.Text = "Ubah Data SubKriteria"
        frmSubKriteria_Tambah.lblJudul.Text = "Ubah Data SubKriteria"
        frmSubKriteria_Tambah.idSubKriteria = GridView.GetRowCellValue(GridView.FocusedRowHandle, "No")
        frmSubKriteria_Tambah.txtBobot.Text = GridView.GetRowCellValue(GridView.FocusedRowHandle, "Bobot")
        frmSubKriteria_Tambah.txtSub.Text = GridView.GetRowCellValue(GridView.FocusedRowHandle, "Sub_Kriteria")
        frmSubKriteria_Tambah.cboKriteria.Text = GridView.GetRowCellValue(GridView.FocusedRowHandle, "Kriteria")
        frmSubKriteria_Tambah.edit = True
        btnUbah.Enabled = True
    End Sub

    Private Sub GridView_DoubleClick(sender As Object, e As EventArgs) Handles GridView.DoubleClick
        frmSubKriteria_Tambah.loadKriteria()
        frmSubKriteria_Tambah.Text = "Ubah Data SubKriteria"
        frmSubKriteria_Tambah.lblJudul.Text = "Ubah Data SubKriteria"
        frmSubKriteria_Tambah.idSubKriteria = GridView.GetRowCellValue(GridView.FocusedRowHandle, "No")
        frmSubKriteria_Tambah.txtBobot.Text = GridView.GetRowCellValue(GridView.FocusedRowHandle, "Bobot")
        frmSubKriteria_Tambah.txtSub.Text = GridView.GetRowCellValue(GridView.FocusedRowHandle, "Sub_Kriteria")
        frmSubKriteria_Tambah.cboKriteria.Text = GridView.GetRowCellValue(GridView.FocusedRowHandle, "Kriteria")
        frmSubKriteria_Tambah.edit = True
        btnUbah.Enabled = True
        frmSubKriteria_Tambah.ShowDialog()
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