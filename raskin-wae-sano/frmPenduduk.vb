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
    End Sub

    Private Sub frmPenduduk_Load(sender As Object, e As EventArgs) Handles Me.Load
        LoadData()
    End Sub

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        frmPenduduk_Tambah.Clear()
        frmPenduduk_Tambah.ShowDialog()
    End Sub

    Private Sub GridView_Click(sender As Object, e As EventArgs) Handles GridView.Click
        frmPenduduk_Tambah.Text = "Ubah Data Penduduk"
        frmPenduduk_Tambah.lblJudul.Text = "Ubah Data Penduduk"
        frmPenduduk_Tambah.LoadKriteria(GridView.GetRowCellValue(GridView.FocusedRowHandle, "ID"))
        frmPenduduk_Tambah.idPenduduk = GridView.GetRowCellValue(GridView.FocusedRowHandle, "ID")
        frmPenduduk_Tambah.txtKK.Text = GridView.GetRowCellValue(GridView.FocusedRowHandle, "No_KK")
        frmPenduduk_Tambah.txtKTP.Text = GridView.GetRowCellValue(GridView.FocusedRowHandle, "No_KTP")
        frmPenduduk_Tambah.txtNama.Text = GridView.GetRowCellValue(GridView.FocusedRowHandle, "Nama")
        frmPenduduk_Tambah.txtDesa.Text = GridView.GetRowCellValue(GridView.FocusedRowHandle, "Desa")
        frmPenduduk_Tambah.txtKec.Text = GridView.GetRowCellValue(GridView.FocusedRowHandle, "Kecamatan")
        frmPenduduk_Tambah.txtRT.Text = GridView.GetRowCellValue(GridView.FocusedRowHandle, "RT_RW")

        If IsDBNull(GridView.GetRowCellValue(GridView.FocusedRowHandle, "gambar_KK")) Then
            frmPenduduk_Tambah.imgKK.Image = Nothing
            frmPenduduk_Tambah.imgKTP.Image = Nothing
            frmPenduduk_Tambah.gambarKK = ""
            frmPenduduk_Tambah.gambarKTP = ""
        Else
            Try
                frmPenduduk_Tambah.gambarKK = GridView.GetRowCellValue(GridView.FocusedRowHandle, "gambar_KK")
                frmPenduduk_Tambah.gambarKTP = GridView.GetRowCellValue(GridView.FocusedRowHandle, "gambar_KTP")
                frmPenduduk_Tambah.imgKK.Image = System.Drawing.Image.FromFile(frmPenduduk_Tambah.pathKK + GridView.GetRowCellValue(GridView.FocusedRowHandle, "gambar_KK"))
                frmPenduduk_Tambah.imgKTP.Image = System.Drawing.Image.FromFile(frmPenduduk_Tambah.pathKTP + GridView.GetRowCellValue(GridView.FocusedRowHandle, "gambar_KTP"))
            Catch ex As Exception
                frmPenduduk_Tambah.imgKK.Image = Nothing
                frmPenduduk_Tambah.imgKTP.Image = Nothing
                frmPenduduk_Tambah.gambarKK = ""
                frmPenduduk_Tambah.gambarKTP = ""
            End Try
        End If
        
        btnUbah.Enabled = True
    End Sub

    Private Sub GridView_DoubleClick(sender As Object, e As EventArgs) Handles GridView.DoubleClick
        frmPenduduk_Tambah.Text = "Ubah Data Penduduk"
        frmPenduduk_Tambah.lblJudul.Text = "Ubah Data Penduduk"
        frmPenduduk_Tambah.LoadKriteria(GridView.GetRowCellValue(GridView.FocusedRowHandle, "ID"))
        frmPenduduk_Tambah.idPenduduk = GridView.GetRowCellValue(GridView.FocusedRowHandle, "ID")
        frmPenduduk_Tambah.txtKK.Text = GridView.GetRowCellValue(GridView.FocusedRowHandle, "No_KK")
        frmPenduduk_Tambah.txtKTP.Text = GridView.GetRowCellValue(GridView.FocusedRowHandle, "No_KTP")
        frmPenduduk_Tambah.txtNama.Text = GridView.GetRowCellValue(GridView.FocusedRowHandle, "Nama")
        frmPenduduk_Tambah.txtDesa.Text = GridView.GetRowCellValue(GridView.FocusedRowHandle, "Desa")
        frmPenduduk_Tambah.txtKec.Text = GridView.GetRowCellValue(GridView.FocusedRowHandle, "Kecamatan")
        frmPenduduk_Tambah.txtRT.Text = GridView.GetRowCellValue(GridView.FocusedRowHandle, "RT_RW")

        If IsDBNull(GridView.GetRowCellValue(GridView.FocusedRowHandle, "gambar_KK")) Then
            frmPenduduk_Tambah.imgKK.Image = Nothing
            frmPenduduk_Tambah.imgKTP.Image = Nothing
            frmPenduduk_Tambah.gambarKK = ""
            frmPenduduk_Tambah.gambarKTP = ""
        Else
            Try
                frmPenduduk_Tambah.gambarKK = GridView.GetRowCellValue(GridView.FocusedRowHandle, "gambar_KK")
                frmPenduduk_Tambah.gambarKTP = GridView.GetRowCellValue(GridView.FocusedRowHandle, "gambar_KTP")
                frmPenduduk_Tambah.imgKK.Image = System.Drawing.Image.FromFile(frmPenduduk_Tambah.pathKK + GridView.GetRowCellValue(GridView.FocusedRowHandle, "gambar_KK"))
                frmPenduduk_Tambah.imgKTP.Image = System.Drawing.Image.FromFile(frmPenduduk_Tambah.pathKTP + GridView.GetRowCellValue(GridView.FocusedRowHandle, "gambar_KTP"))
            Catch ex As Exception
                frmPenduduk_Tambah.imgKK.Image = Nothing
                frmPenduduk_Tambah.imgKTP.Image = Nothing
                frmPenduduk_Tambah.gambarKK = ""
                frmPenduduk_Tambah.gambarKTP = ""
            End Try
        End If

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

    Private Sub GridControl_MouseDown(sender As Object, e As MouseEventArgs) Handles GridControl.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Right Then
            If GridView.GetRowCellValue(GridView.FocusedRowHandle, "Status") = "Aktif" Then
                AktifMenuItem.Visible = False
                NonAktifMenuItem.Visible = True
            Else
                AktifMenuItem.Visible = True
                NonAktifMenuItem.Visible = False
            End If
            cmStrip.Show(Cursor.Position)
        End If
    End Sub

    Private Sub AktifMenuItem_Click(sender As Object, e As EventArgs) Handles AktifMenuItem.Click
        conn.setQuery("UPDATE penduduk SET Status = 'Aktif' WHERE ID = '" & GridView.GetRowCellValue(GridView.FocusedRowHandle, "ID") & "'")
        LoadData()
    End Sub

    Private Sub NonAktifMenuItem_Click(sender As Object, e As EventArgs) Handles NonAktifMenuItem.Click
        conn.setQuery("UPDATE penduduk SET Status = 'NonAktif' WHERE ID = '" & GridView.GetRowCellValue(GridView.FocusedRowHandle, "ID") & "'")
        LoadData()
    End Sub
End Class