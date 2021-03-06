﻿Public Class frmUtama
    Dim conn As New Database

    Public Sub ActiveMenu(ByVal btn As Button, contBtn As Control, tab As Form, contForm As Control)
        For Each ctrl As Control In contBtn.Controls
            If TypeOf ctrl Is Button Then
                If ctrl.Name <> btn.Name Then
                    DirectCast(ctrl, Button).BackColor = Color.RoyalBlue
                    'DirectCast(ctrl, Button).IdleBorderColor = Color.FromArgb(0, 24, 85)
                Else
                    DirectCast(ctrl, Button).BackColor = Color.DarkBlue
                    'DirectCast(ctrl, Button).IdleBorderColor = Color.FromArgb(51, 122, 183)

                    DirectCast(tab, Form).TopLevel = False
                    DirectCast(tab, Form).AutoSize = True
                    Me.Text = "SPK Seleksi Penerima Raskin - Wae Sano | " & tab.Text
                    tab.Parent = panForm
                    tab.WindowState = FormWindowState.Maximized
                    tab.Show()
                End If
            End If
        Next

        For Each ctrl As Control In contForm.Controls
            If TypeOf ctrl Is Form Then
                If ctrl.Name <> tab.Name Then
                    DirectCast(ctrl, Form).Close()
                Else
                    DirectCast(tab, Form).TopLevel = False
                    DirectCast(tab, Form).AutoSize = True
                    tab.Parent = contForm
                    tab.WindowState = FormWindowState.Maximized
                    tab.Show()
                End If
            End If
        Next
    End Sub

#Region "    Button"
    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        ActiveMenu(btnHome, panUp, frmHome, panForm)
    End Sub

    Private Sub btnUser_Click(sender As Object, e As EventArgs) Handles btnUser.Click
        ActiveMenu(btnUser, panUp, frmUser, panForm)
    End Sub

    Private Sub btnPenduduk_Click(sender As Object, e As EventArgs) Handles btnPenduduk.Click
        ActiveMenu(btnPenduduk, panUp, frmPenduduk, panForm)
    End Sub

    Private Sub btnKriteria_Click(sender As Object, e As EventArgs) Handles btnKriteria.Click
        ActiveMenu(btnKriteria, panUp, frmKriteria, panForm)
    End Sub

    Private Sub btnSubKriteria_Click(sender As Object, e As EventArgs) Handles btnSubKriteria.Click
        ActiveMenu(btnSubKriteria, panUp, frmSubKriteria, panForm)
    End Sub

    Private Sub btnProses_Click(sender As Object, e As EventArgs) Handles btnProses.Click
        ActiveMenu(btnProses, panUp, frmProsesSPK, panForm)
    End Sub

    Private Sub btnHasil_Click(sender As Object, e As EventArgs) Handles btnHasil.Click
        Dim dtHasil As DataTable = conn.getQuery("SELECT * FROM hasil_spk")
        If dtHasil.Rows.Count = 0 Then
            MessageBox.Show("Belum ada data yang diproses, proses data dahulu!", "Pemberitahuan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        ActiveMenu(btnHasil, panUp, frmHasilSPK, panForm)
    End Sub

    Private Sub btnLaporan_Click(sender As Object, e As EventArgs) Handles btnLaporan.Click
        Dim dtHasil As DataTable = conn.getQuery("SELECT * FROM hasil_spk")
        If dtHasil.Rows.Count = 0 Then
            MessageBox.Show("Belum ada data yang diproses, proses data dahulu!", "Pemberitahuan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        ActiveMenu(btnLaporan, panUp, frmLaporan, panForm)
    End Sub
#End Region

    Private Sub frmUtama_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnHome.PerformClick()
    End Sub

    Private Sub frmUtama_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If MessageBox.Show("Anda yakin mau keluar?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.No Then
            e.Cancel = True
        Else
            frmLogin.Close()
        End If
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Me.Hide()
        frmLogin.Show()
    End Sub
End Class
