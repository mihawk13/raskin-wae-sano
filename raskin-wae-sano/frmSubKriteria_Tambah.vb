Public Class frmSubKriteria_Tambah
    Dim conn As New Database
    Dim hasil As Boolean, dtKriteria As New DataTable
    Public idSubKriteria As Integer = 0

    Private Sub Clear()
        Me.Text = "Tambah Data Sub Kriteria"
        lblJudul.Text = "Tambah Data Sub Kriteria"
        txtSub.Clear()
        txtBobot.Clear()
        idSubKriteria = 0
        Close()
    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        Clear()
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        If String.IsNullOrEmpty(cboKriteria.Text) Or String.IsNullOrEmpty(txtSub.Text) Or String.IsNullOrEmpty(txtBobot.Text) Then
            MessageBox.Show("Mohon lengkapi data dulu sebelum disimpan!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If Me.Text = "Tambah Data Sub Kriteria" Then
            hasil = conn.setQuery("INSERT INTO Sub_Kriteria(Kriteria,Sub_Kriteria,Bobot) VALUES('" & cboKriteria.Text & "','" & txtSub.Text & "','" & txtBobot.Text & "')")
            If hasil <> True Then
                MessageBox.Show("Terjadi kesalahan!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            MessageBox.Show("Data berhasil disimpan!", "Tersimpan", MessageBoxButtons.OK, MessageBoxIcon.Information)
            frmSubKriteria.LoadData()
            Clear()
        Else
            hasil = conn.setQuery("UPDATE SubKriteria SET No_Kriteria = '" & cboKriteria.Text & "', Sub_Kriteria = '" & txtSub.Text & "', Bobot = '" & txtBobot.Text & "' WHERE No = '" & idSubKriteria & "'")
            If hasil <> True Then
                MessageBox.Show("Terjadi kesalahan!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            MessageBox.Show("Data berhasil diupdate!", "Tersimpan", MessageBoxButtons.OK, MessageBoxIcon.Information)
            frmSubKriteria.LoadData()
            Clear()
        End If

    End Sub

    Private Sub txtBobot_KeyDown(sender As Object, e As KeyEventArgs) Handles txtBobot.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnSimpan.PerformClick()
        End If
    End Sub

    Private Sub frmSubKriteria_Tambah_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtKriteria = conn.getQuery("SELECT * FROM Kriteria")
        cboKriteria.Items.Clear()
        For i = 0 To dtKriteria.Rows.Count - 1
            cboKriteria.Items.Add(dtKriteria.Rows(i).Item(1))
        Next
        cboKriteria.Items.Add("")
    End Sub
End Class