Public Class frmPenduduk_Tambah
    Dim conn As New Database, dtKriteria As New DataTable
    Dim hasil As Boolean
    Public idPenduduk As Integer = 0

    Public Sub Clear()
        Me.Text = "Tambah Data Penduduk"
        lblJudul.Text = "Tambah Data Penduduk"
        txtKK.Clear()
        txtKTP.Clear()
        txtNama.Clear()
        txtDesa.Clear()
        txtKec.Clear()
        txtRT.Clear()
        idPenduduk = 0
        cboK1.Text = ""
        cboK2.Text = ""
        cboK3.Text = ""
        cboK4.Text = ""
        Close()
    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        Clear()
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        If String.IsNullOrEmpty(txtKK.Text) Or String.IsNullOrEmpty(txtKTP.Text) Or String.IsNullOrEmpty(txtNama.Text) Or String.IsNullOrEmpty(txtDesa.Text) _
            Or String.IsNullOrEmpty(txtKec.Text) Or String.IsNullOrEmpty(txtRT.Text) Or String.IsNullOrEmpty(cboK1.Text) Or String.IsNullOrEmpty(cboK2.Text) _
             Or String.IsNullOrEmpty(cboK3.Text) Or String.IsNullOrEmpty(cboK4.Text) Then
            MessageBox.Show("Mohon lengkapi data dulu sebelum disimpan!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If Me.Text = "Tambah Data Penduduk" Then
            hasil = conn.setQuery("INSERT INTO Penduduk(No_KK,No_KTP,Nama,Desa,Kecamatan,RT_RW,K_1,K_2,K_3,K_4) VALUES('" & txtKK.Text & "','" & txtKTP.Text & "','" & txtNama.Text & "','" & txtDesa.Text _
                                  & "','" & txtKec.Text & "','" & txtRT.Text & "','" & cboK1.Text & "','" & cboK2.Text & "','" & cboK3.Text & "','" & cboK4.Text & "')")
            If hasil <> True Then
                MessageBox.Show("Terjadi kesalahan!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            MessageBox.Show("Data berhasil disimpan!", "Tersimpan", MessageBoxButtons.OK, MessageBoxIcon.Information)
            frmPenduduk.LoadData()
            Clear()
        Else
            hasil = conn.setQuery("UPDATE Penduduk SET No_KK = '" & txtKK.Text & "', No_KTP = '" & txtKTP.Text & "', Nama = '" & txtNama.Text _
                                  & "', Desa = '" & txtDesa.Text & "', Kecamatan = '" & txtKec.Text & "', RT_RW = '" & txtRT.Text _
                                  & "', K_1 = '" & cboK1.Text & "', K_2 = '" & cboK2.Text & "', K_3 = '" & cboK3.Text & "', K_4 = '" & cboK4.Text _
                                  & "' WHERE id = '" & idPenduduk & "'")
            If hasil <> True Then
                MessageBox.Show("Terjadi kesalahan!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            MessageBox.Show("Data berhasil diupdate!", "Tersimpan", MessageBoxButtons.OK, MessageBoxIcon.Information)
            frmPenduduk.LoadData()
            Clear()
        End If

    End Sub

    Private Sub txtAlamat_KeyDown(sender As Object, e As KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            btnSimpan.PerformClick()
        End If
    End Sub

    Private Sub LoadKriteria()
        dtKriteria = conn.getQuery("SELECT * FROM Sub_Kriteria")
        'cboK1.Items.Clear()
        'cboK2.Items.Clear()
        'cboK3.Items.Clear()
        'cboK4.Items.Clear()

        For i = 0 To dtKriteria.Rows.Count - 1
            If dtKriteria.Rows(i).Item(1) = "Surat Keterangan Miskin" Then
                cboK1.Items.Add(dtKriteria.Rows(i).Item(2))
            ElseIf dtKriteria.Rows(i).Item(1) = "Penghasilan Setiap Bulan" Then
                cboK2.Items.Add(dtKriteria.Rows(i).Item(2))
            ElseIf dtKriteria.Rows(i).Item(1) = "Tanggungan Anak" Then
                cboK3.Items.Add(dtKriteria.Rows(i).Item(2))
            ElseIf dtKriteria.Rows(i).Item(1) = "Kondisi Rumah" Then
                cboK4.Items.Add(dtKriteria.Rows(i).Item(2))
            End If
        Next

        cboK1.Items.Add("")
        cboK2.Items.Add("")
        cboK3.Items.Add("")
        cboK4.Items.Add("")
    End Sub

    Private Sub frmPenduduk_Tambah_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If cboK1.Items.Count = 0 Then
            LoadKriteria()
        End If
    End Sub
End Class