Public Class frmKriteria
    Dim dtKriteria As DataTable
    Dim conn As New Database
    Dim bdSource As New BindingSource

    Public Sub LoadData()
        dtKriteria = conn.getQuery("SELECT * FROM Kriteria")
        bdSource.DataSource = dtKriteria
        GridControl.DataSource = bdSource
    End Sub

    Private Sub frmKriteria_Load(sender As Object, e As EventArgs) Handles Me.Load
        LoadData()
    End Sub

    Private Sub GridView_Click(sender As Object, e As EventArgs) Handles GridView.Click
        frmKriteria_Tambah.Text = "Ubah Data Kriteria"
        frmKriteria_Tambah.lblJudul.Text = "Ubah Data Kriteria"
        frmKriteria_Tambah.idKriteria = GridView.GetRowCellValue(GridView.FocusedRowHandle, "No_Kriteria")
        frmKriteria_Tambah.txtNama.Text = GridView.GetRowCellValue(GridView.FocusedRowHandle, "Nama")
        frmKriteria_Tambah.txtBobot.Text = GridView.GetRowCellValue(GridView.FocusedRowHandle, "Bobot")
        frmKriteria_Tambah.cboAttr.Text = GridView.GetRowCellValue(GridView.FocusedRowHandle, "Atribut")
    End Sub

    Private Sub GridView_DoubleClick(sender As Object, e As EventArgs) Handles GridView.DoubleClick
        frmKriteria_Tambah.Text = "Ubah Data Kriteria"
        frmKriteria_Tambah.lblJudul.Text = "Ubah Data Kriteria"
        frmKriteria_Tambah.idKriteria = GridView.GetRowCellValue(GridView.FocusedRowHandle, "No_Kriteria")
        frmKriteria_Tambah.txtNama.Text = GridView.GetRowCellValue(GridView.FocusedRowHandle, "Nama")
        frmKriteria_Tambah.txtBobot.Text = GridView.GetRowCellValue(GridView.FocusedRowHandle, "Bobot")
        frmKriteria_Tambah.cboAttr.Text = GridView.GetRowCellValue(GridView.FocusedRowHandle, "Atribut")
        frmKriteria_Tambah.ShowDialog()
    End Sub

    Private Sub btnUbah_Click(sender As Object, e As EventArgs) Handles btnUbah.Click
        If frmKriteria_Tambah.idKriteria = 0 Then
            MessageBox.Show("Pilih data sebelum klik ubah!", "Data Kosong", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        frmKriteria_Tambah.ShowDialog()
    End Sub

    Private Sub txtCari_TextChanged(sender As Object, e As EventArgs) Handles txtCari.TextChanged
        bdSource.Filter = "Nama LIKE '%" & txtCari.Text & "%'"
    End Sub

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        frmKriteria_Tambah.ShowDialog()
    End Sub
End Class