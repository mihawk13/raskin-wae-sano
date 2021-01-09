Public Class frmPenduduk_Tambah
    Dim conn As New Database, dtKriteria, dtSubKriteria, dtPenduduk As New DataTable
    Dim hasil As Boolean
    Public gambarKK, gambarKTP As String
    Public pathKK As String = "C:\GambarWaeSano\KK\"
    Public pathKTP As String = "C:\GambarWaeSano\KTP\"
    Public idPenduduk As String
    Dim posisiLbl As Integer = 18
    Dim posisiCbo As Integer = 15
    Public _loadKriteria As Boolean = False

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
        Close()
    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        Clear()
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        If String.IsNullOrEmpty(txtKK.Text) Or String.IsNullOrEmpty(txtKTP.Text) Or String.IsNullOrEmpty(txtNama.Text) Or String.IsNullOrEmpty(txtDesa.Text) _
            Or String.IsNullOrEmpty(txtKec.Text) Or String.IsNullOrEmpty(txtRT.Text) Or String.IsNullOrEmpty(gambarKK) Or String.IsNullOrEmpty(gambarKTP) Then
            MessageBox.Show("Mohon lengkapi data dulu sebelum disimpan!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        For Each ctrl As Control In panDown.Controls
            If TypeOf ctrl Is ComboBox Then
                Dim value As String = ctrl.Text

                If String.IsNullOrEmpty(value) Then
                    MessageBox.Show("Mohon lengkapi data dulu sebelum disimpan!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Exit Sub
                End If
            End If
        Next

        If Me.Text = "Tambah Data Penduduk" Then
            hasil = conn.setQuery("INSERT INTO Penduduk(No_KK,No_KTP,Nama,Desa,Kecamatan,RT_RW,gambar_KK,gambar_KTP) VALUES('" & txtKK.Text & "','" & txtKTP.Text & "','" & txtNama.Text & "','" & txtDesa.Text _
                                  & "','" & txtKec.Text & "','" & txtRT.Text & "','" & gambarKK & "','" & gambarKTP & "')")
            If hasil <> True Then
                MessageBox.Show("Terjadi kesalahan!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            simpanKriteria()
            MessageBox.Show("Data berhasil disimpan!", "Tersimpan", MessageBoxButtons.OK, MessageBoxIcon.Information)
            frmPenduduk.LoadData()
            Clear()
        Else
            hasil = conn.setQuery("UPDATE Penduduk SET No_KK = '" & txtKK.Text & "', No_KTP = '" & txtKTP.Text & "', Nama = '" & txtNama.Text _
                                  & "', Desa = '" & txtDesa.Text & "', Kecamatan = '" & txtKec.Text & "', RT_RW = '" & txtRT.Text _
                                  & "', gambar_KK = '" & gambarKK & "', gambar_KTP = '" & gambarKTP _
                                  & "' WHERE id = '" & idPenduduk & "'")
            If hasil <> True Then
                MessageBox.Show("Terjadi kesalahan!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            simpanKriteria()
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

    Public Sub LoadKriteria(ByVal pddId As Integer)
        Dim dtPddKrt As New DataTable
        If pddId <> 0 Then
            dtPddKrt = conn.getQuery("SELECT * FROM penduduk_kriteria a " _
                                     & "INNER JOIN sub_kriteria b ON a.sub_kriteria_id = b.No WHERE penduduk_id = '" & pddId & "'")
        End If
        If _loadKriteria = False Then
            dtKriteria = conn.getQuery("SELECT * FROM Kriteria")
            For i = 0 To dtKriteria.Rows.Count - 1
                Dim t1 = New Label
                panDown.Controls.Add(t1)
                t1.Name = "lblK_" + dtKriteria.Rows(i).Item(0).ToString
                t1.AutoSize = True
                t1.Top = posisiLbl + 27
                t1.Left = 546
                t1.Text = dtKriteria.Rows(i).Item(1).ToString
                posisiLbl += 27

                dtSubKriteria = conn.getQuery("SELECT * FROM Sub_Kriteria WHERE Kriteria_ID = '" & dtKriteria.Rows(i).Item(0) & "'")

                Dim t2 = New ComboBox
                panDown.Controls.Add(t2)
                t2.Name = "cboK_" + dtKriteria.Rows(i).Item(0).ToString
                t2.AutoSize = True
                t2.Top = posisiCbo + 27
                t2.Left = 707
                t2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
                t2.Size = New System.Drawing.Size(221, 21)

                posisiCbo += 27
                For j = 0 To dtSubKriteria.Rows.Count - 1
                    t2.Items.Add(dtSubKriteria.Rows(j).Item(2))
                Next
                t2.Items.Add("")

                If pddId <> 0 Then
                    For k = 0 To dtPddKrt.Rows.Count - 1
                        If dtKriteria.Rows(i).Item(0) = dtPddKrt.Rows(k).Item(1) Then
                            t2.Text = dtPddKrt.Rows(k).Item(5)
                        End If
                    Next
                Else
                    t2.Text = ""
                End If
            Next
            _loadKriteria = True
        Else
            If pddId <> 0 Then
                Dim dtsubs As New DataTable
                For Each ctrl As Control In panDown.Controls
                    If TypeOf ctrl Is ComboBox Then
                        Dim name As String = ctrl.Name
                        Dim value As String = ctrl.Text
                        Dim idkrt As String = Replace(name, "cboK_", "")
                        dtsubs = conn.getQuery("SELECT * FROM penduduk_kriteria a INNER JOIN sub_kriteria b ON a.sub_kriteria_id = b.No WHERE a.penduduk_id = '" & pddId & "' AND a.kriteria_id = '" & idkrt & "'")
                        If dtsubs.Rows.Count = 0 Then
                            ctrl.Text = ""
                        Else
                            For i = 0 To dtsubs.Rows.Count - 1
                                ctrl.Text = dtsubs.Rows(i).Item(5)
                            Next
                        End If
                    End If
                Next
            End If
        End If
    End Sub

    Private Sub frmPenduduk_Tambah_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadKriteria(0)
    End Sub

    Private Sub btnKK_Click(sender As Object, e As EventArgs) Handles btnKK.Click
        Dim dt As Date = DateTime.Now
        Dim sTime As String = dt.ToBinary
        Dim namaKK As String = sTime.Substring(5)

        Try
            If String.IsNullOrEmpty(gambarKK) = False Then
                My.Computer.FileSystem.DeleteFile(pathKK + gambarKK)
            End If
        Catch ex As Exception

        End Try

        Dim fdialog As New OpenFileDialog()
        fdialog.FileName = String.Empty
        fdialog.Multiselect = False
        fdialog.Title = "Pilih Gambar KK"
        fdialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp"
        If fdialog.ShowDialog = DialogResult.OK Then
            imgKK.Image = System.Drawing.Image.FromFile(fdialog.FileName)
            gambarKK = namaKK + ".jpg"
            imgKK.Image.Save(pathKK + gambarKK, System.Drawing.Imaging.ImageFormat.Jpeg)
        End If
    End Sub

    Private Sub btnKTP_Click(sender As Object, e As EventArgs) Handles btnKTP.Click
        Dim dt As Date = DateTime.Now
        Dim sTime As String = dt.ToBinary
        Dim namaKTP As String = sTime.Substring(5)

        Try
            If String.IsNullOrEmpty(gambarKTP) = False Then
                My.Computer.FileSystem.DeleteFile(pathKTP + gambarKTP)
            End If
        Catch ex As Exception

        End Try

        Dim fdialog As New OpenFileDialog()
        fdialog.FileName = String.Empty
        fdialog.Multiselect = False
        fdialog.Title = "Pilih Gambar KTP"
        fdialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp"
        If fdialog.ShowDialog = DialogResult.OK Then
            imgKTP.Image = System.Drawing.Image.FromFile(fdialog.FileName)
            gambarKTP = namaKTP + ".jpg"
            imgKTP.Image.Save(pathKTP + gambarKTP, System.Drawing.Imaging.ImageFormat.Jpeg)
        End If
    End Sub

    Private Sub simpanKriteria()
        If String.IsNullOrEmpty(idPenduduk) Then
            dtPenduduk = conn.getQuery("SELECT MAX(id) AS id FROM penduduk")
            idPenduduk = dtPenduduk.Rows(0).Item(0)
            conn.setQuery("DELETE FROM penduduk_kriteria WHERE penduduk_id = '" & idPenduduk & "'")
        End If

        For Each ctrl As Control In panDown.Controls
            If TypeOf ctrl Is ComboBox Then
                Dim name As String = ctrl.Name
                Dim value As String = ctrl.Text
                Dim idCbo As String = name.Replace("cboK_", "")
                dtSubKriteria = conn.getQuery("SELECT * FROM Sub_Kriteria WHERE Sub_Kriteria = '" & value & "'")
                value = dtSubKriteria.Rows(0).Item(0)
                conn.setQuery("INSERT INTO penduduk_kriteria VALUES('" & idPenduduk & "','" & idCbo & "','" & value & "') ON DUPLICATE KEY UPDATE sub_kriteria_id = '" & value & "'")
            End If
        Next
    End Sub

End Class