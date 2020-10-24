Public Class frmPenduduk_Tambah
    Dim conn As New Database
    Dim hasil As Boolean
    Public idPenduduk As Integer = 0

    Private Sub Clear()
        Me.Text = "Tambah Data Penduduk"
        lblJudul.Text = "Tambah Data Penduduk"
        txtKK.Clear()
        txtKTP.Clear()
        txtNama.Clear()
        txtDesa.Clear()
        txtKec.Clear()
        txtRT.Clear()
        txtAlamat.Clear()
        idPenduduk = 0
        Close()
    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        Clear()
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        If String.IsNullOrEmpty(txtKK.Text) Or String.IsNullOrEmpty(txtKTP.Text) Or String.IsNullOrEmpty(txtNama.Text) Or String.IsNullOrEmpty(txtDesa.Text) Or String.IsNullOrEmpty(txtKec.Text) Or String.IsNullOrEmpty(txtRT.Text) Or String.IsNullOrEmpty(txtAlamat.Text) Then
            MessageBox.Show("Mohon lengkapi data dulu sebelum disimpan!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If Me.Text = "Tambah Data Penduduk" Then
            hasil = conn.setQuery("INSERT INTO Penduduk(No_KK,No_KTP,Nama,Desa,Kecamatan,RT_RW,Alamat) VALUES('" & txtKK.Text & "','" & txtKTP.Text & "','" & txtNama.Text & "','" & txtDesa.Text & "','" & txtKec.Text & "','" & txtRT.Text & "','" & txtAlamat.Text & "')")
            If hasil <> True Then
                MessageBox.Show("Terjadi kesalahan!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            MessageBox.Show("Data berhasil disimpan!", "Tersimpan", MessageBoxButtons.OK, MessageBoxIcon.Information)
            frmPenduduk.LoadData()
            Clear()
        Else
            hasil = conn.setQuery("UPDATE Penduduk SET No_KK = '" & txtKK.Text & "', No_KTP = '" & txtKTP.Text & "', Nama = '" & txtNama.Text & "', Desa = '" & txtDesa.Text & "', Kecamatan = '" & txtKec.Text & "', RT_RW = '" & txtRT.Text & "', Alamat = '" & txtAlamat.Text & "' WHERE id = '" & idPenduduk & "'")
            If hasil <> True Then
                MessageBox.Show("Terjadi kesalahan!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            MessageBox.Show("Data berhasil diupdate!", "Tersimpan", MessageBoxButtons.OK, MessageBoxIcon.Information)
            frmPenduduk.LoadData()
            Clear()
        End If

    End Sub

    Private Sub txtAlamat_KeyDown(sender As Object, e As KeyEventArgs) Handles txtAlamat.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnSimpan.PerformClick()
        End If
    End Sub
End Class