Public Class frmAlternatif_Tambah
    Dim conn As New Database
    Dim hasil As Boolean

    Private Sub Clear()
        Me.Text = "Tambah Data Alternatif"
        lblJudul.Text = "Tambah Data Alternatif"
        txtID.Clear()
        txtID.ReadOnly = False
        txtNama.Clear()
        Close()
    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        Clear()
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        If String.IsNullOrEmpty(txtID.Text) Or String.IsNullOrEmpty(txtNama.Text) Then
            MessageBox.Show("Mohon lengkapi data dulu sebelum disimpan!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If Me.Text = "Tambah Data Alternatif" Then
            hasil = conn.setQuery("INSERT INTO Alternatif VALUES('" & txtID.Text & "','" & txtNama.Text & "')")
            If hasil <> True Then
                MessageBox.Show("Terjadi kesalahan!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            MessageBox.Show("Data berhasil disimpan!", "Tersimpan", MessageBoxButtons.OK, MessageBoxIcon.Information)
            frmAlternatif.LoadData()
            Clear()
        Else
            hasil = conn.setQuery("UPDATE Alternatif SET Nama = '" & txtNama.Text & "' WHERE ID = '" & txtID.Text & "'")
            If hasil <> True Then
                MessageBox.Show("Terjadi kesalahan!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            MessageBox.Show("Data berhasil diupdate!", "Tersimpan", MessageBoxButtons.OK, MessageBoxIcon.Information)
            frmAlternatif.LoadData()
            Clear()
        End If

    End Sub

    Private Sub txtNama_KeyDown(sender As Object, e As KeyEventArgs) Handles txtNama.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnSimpan.PerformClick()
        End If
    End Sub
End Class