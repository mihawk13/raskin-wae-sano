Public Class frmUser_Tambah
    Dim conn As New Database
    Dim hasil As Boolean
    Public idUser As Integer = 0

    Private Sub Clear()
        Me.Text = "Tambah User"
        lblJudul.Text = "Tambah User"
        txtUser.Clear()
        txtPass.Clear()
        cboHakAkses.Text = ""
        idUser = 0
        'frmUser.btnUbah.Enabled = False
        Close()
    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        Clear()
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        If String.IsNullOrEmpty(txtUser.Text) Or String.IsNullOrEmpty(txtPass.Text) Or String.IsNullOrEmpty(cboHakAkses.Text) Then
            MessageBox.Show("Mohon lengkapi data dulu sebelum disimpan!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If Me.Text = "Tambah User" Then
            hasil = conn.setQuery("INSERT INTO User(Username,Password,Hak_Akses) VALUES('" & txtUser.Text & "','" & txtPass.Text & "','" & cboHakAkses.Text & "')")
            If hasil <> True Then
                MessageBox.Show("Terjadi kesalahan!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            MessageBox.Show("Data berhasil disimpan!", "Tersimpan", MessageBoxButtons.OK, MessageBoxIcon.Information)
            frmUser.LoadData()
            Clear()
        Else
            hasil = conn.setQuery("UPDATE User SET Hak_Akses = '" & cboHakAkses.Text & "', Username = '" & txtUser.Text & "', Password = '" & txtPass.Text & "' WHERE id = '" & idUser & "'")
            If hasil <> True Then
                MessageBox.Show("Terjadi kesalahan!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            MessageBox.Show("Data berhasil diupdate!", "Tersimpan", MessageBoxButtons.OK, MessageBoxIcon.Information)
            frmUser.LoadData()
            Clear()
        End If

    End Sub

    Private Sub txtPass_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPass.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnSimpan.PerformClick()
        End If
    End Sub
End Class