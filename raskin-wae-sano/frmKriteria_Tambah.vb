Public Class frmKriteria_Tambah
    Dim conn As New Database
    Dim hasil As Boolean
    Public idKriteria As Integer = 0

    Private Sub Clear()
        Me.Text = "Tambah Data Kriteria"
        lblJudul.Text = "Tambah Data Kriteria"
        txtNama.Clear()
        txtBobot.Clear()
        idKriteria = 0
        Close()
    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        Clear()
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        If String.IsNullOrEmpty(txtNama.Text) Or String.IsNullOrEmpty(txtBobot.Text) Then
            MessageBox.Show("Mohon lengkapi data dulu sebelum disimpan!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If Me.Text = "Tambah Data Kriteria" Then
            hasil = conn.setQuery("INSERT INTO Kriteria(Nama,Bobot) VALUES('" & txtNama.Text & "','" & txtBobot.Text & "')")
            If hasil <> True Then
                MessageBox.Show("Terjadi kesalahan!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            MessageBox.Show("Data berhasil disimpan!", "Tersimpan", MessageBoxButtons.OK, MessageBoxIcon.Information)
            frmKriteria.LoadData()
            Clear()
        Else
            hasil = conn.setQuery("UPDATE Kriteria SET Nama = '" & txtNama.Text & "', Bobot = '" & txtBobot.Text & "' WHERE No_Kriteria = '" & idKriteria & "'")
            If hasil <> True Then
                MessageBox.Show("Terjadi kesalahan!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            MessageBox.Show("Data berhasil diupdate!", "Tersimpan", MessageBoxButtons.OK, MessageBoxIcon.Information)
            frmKriteria.LoadData()
            Clear()
        End If

    End Sub

    Private Sub txtBobot_KeyDown(sender As Object, e As KeyEventArgs) Handles txtBobot.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnSimpan.PerformClick()
        End If
    End Sub
End Class