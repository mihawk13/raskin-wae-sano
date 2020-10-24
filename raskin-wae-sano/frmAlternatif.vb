Public Class frmAlternatif
    Dim dtAlternatif As DataTable
    Dim conn As New Database
    Dim bdSource As New BindingSource

    Public Sub LoadData()
        dtAlternatif = conn.getQuery("SELECT * FROM Alternatif")
        bdSource.DataSource = dtAlternatif
        GridControl.DataSource = bdSource
    End Sub

    Private Sub frmAlternatif_Load(sender As Object, e As EventArgs) Handles Me.Load
        LoadData()
    End Sub

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        frmAlternatif_Tambah.ShowDialog()
    End Sub

    Private Sub GridView_Click(sender As Object, e As EventArgs) Handles GridView.Click
        frmAlternatif_Tambah.Text = "Ubah Data Alternatif"
        frmAlternatif_Tambah.lblJudul.Text = "Ubah Data Alternatif"
        frmAlternatif_Tambah.txtID.Text = GridView.GetRowCellValue(GridView.FocusedRowHandle, "ID")
        frmAlternatif_Tambah.txtNama.Text = GridView.GetRowCellValue(GridView.FocusedRowHandle, "Nama")
    End Sub

    Private Sub GridView_DoubleClick(sender As Object, e As EventArgs) Handles GridView.DoubleClick
        frmAlternatif_Tambah.Text = "Ubah Alternatif"
        frmAlternatif_Tambah.lblJudul.Text = "Ubah Alternatif"
        frmAlternatif_Tambah.txtID.Text = GridView.GetRowCellValue(GridView.FocusedRowHandle, "ID")
        frmAlternatif_Tambah.txtNama.Text = GridView.GetRowCellValue(GridView.FocusedRowHandle, "Nama")
        frmAlternatif_Tambah.ShowDialog()
    End Sub

    Private Sub btnUbah_Click(sender As Object, e As EventArgs) Handles btnUbah.Click
        If String.IsNullOrEmpty(frmAlternatif_Tambah.txtID.Text) Then
            MessageBox.Show("Pilih data sebelum klik ubah!", "Data Kosong", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        frmAlternatif_Tambah.txtID.ReadOnly = True
        frmAlternatif_Tambah.ShowDialog()
    End Sub

    Private Sub txtCari_TextChanged(sender As Object, e As EventArgs) Handles txtCari.TextChanged
        bdSource.Filter = "Nama LIKE '%" & txtCari.Text & "%'"
    End Sub
End Class