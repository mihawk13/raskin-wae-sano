Public Class frmLogin
    Dim dtLogin As New DataTable, conn As New Database

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        Close()
    End Sub

    Private Sub txtUser_KeyDown(sender As Object, e As KeyEventArgs) Handles txtUser.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtPass.Focus()
        End If
    End Sub

    Private Sub txtPass_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPass.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnLogin.PerformClick()
        End If
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        dtLogin = conn.getQuery("SELECT * FROM user WHERE Username = '" & txtUser.Text & "' AND Password = '" & txtPass.Text & "'")
        If dtLogin.Rows.Count = 0 Then
            MessageBox.Show("Maaf!, username dan password yang anda masukkan tidak sesuai!", "Login Salah", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        Else
            txtUser.Clear()
            txtPass.Clear()
            txtUser.Focus()
            Me.Hide()
            If dtLogin.Rows(0).Item("Hak_Akses") = "Admin" Then
                frmUtama.btnUser.Visible = True
                frmUtama.btnPenduduk.Visible = True
                frmUtama.btnKriteria.Visible = True
                frmUtama.btnSubKriteria.Visible = True
                frmUtama.btnProses.Visible = True
                frmUtama.btnHasil.Visible = True
                frmUtama.btnHome.Location = New System.Drawing.Point(252, 77)
                frmUtama.btnLaporan.Location = New System.Drawing.Point(994, 77)
                frmHome.Label1.Text = "SISTEM PENDUKUNG KEPUTUSAN SELEKSI PENERIMAN RASKIN DI KELURAHAN WAE SANO"
            Else
                frmUtama.btnUser.Visible = False
                frmUtama.btnPenduduk.Visible = False
                frmUtama.btnKriteria.Visible = False
                frmUtama.btnSubKriteria.Visible = False
                frmUtama.btnProses.Visible = False
                frmUtama.btnHasil.Visible = False
                frmUtama.btnHome.Location = New System.Drawing.Point(570, 77)
                frmUtama.btnLaporan.Location = New System.Drawing.Point(676, 77)
                frmHome.Label1.Text = "ANDA LOGIN SEBAGAI KEPALA DESA WAE SANO"
            End If
            frmUtama.Show()
            frmUtama.ActiveMenu(frmUtama.btnHome, frmUtama.panUp, frmHome, frmUtama.panForm)
        End If
    End Sub
End Class