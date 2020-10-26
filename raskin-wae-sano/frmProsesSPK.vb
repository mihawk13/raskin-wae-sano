Public Class frmProsesSPK
    Dim dtMatriks, dtNormal, dtKriteria, dtHasil As DataTable
    Dim conn As New Database
    Dim bdSource As New BindingSource
    Dim maxK1, minK2, maxK3, maxK4 As Double
    'Bobot Kriteria
    Dim bK1, bK2, bK3, bK4 As Double
    Dim x As Integer

    Public Sub LoadMatriks()
        'Load Matrix
        dtMatriks = conn.getQuery("SELECT a.No_KTP,a.Nama, k1.Bobot 'Surat Keterangan Miskin', k2.Bobot 'Nilai Penghasilan', k3.Bobot 'Tanggungan Anak', k4.Bobot 'Kondisi Rumah' FROM penduduk a " _
                                  & "INNER JOIN sub_kriteria k1 ON a.`K_1`=k1.`Sub_Kriteria`" _
                                  & "INNER JOIN sub_kriteria k2 ON a.`K_2`=k2.`Sub_Kriteria`" _
                                  & "INNER JOIN sub_kriteria k3 ON a.`K_3`=k3.`Sub_Kriteria`" _
                                  & "INNER JOIN sub_kriteria k4 ON a.`K_4`=k4.`Sub_Kriteria`")
        GCMatriks.DataSource = dtMatriks

        x = GVMatriks.RowCount
    End Sub

    Private Sub checkHasil()
        dtHasil = conn.getQuery("SELECT * FROM hasil_spk")
        If dtHasil.Rows.Count > 0 Then
            btnClear.Enabled = True
        Else
            btnClear.Enabled = False
        End If
    End Sub

    Private Sub frmProsesSPK_Load(sender As Object, e As EventArgs) Handles Me.Load
        checkHasil()
        LoadMatriks()
    End Sub

    Private Function getNormalisasi() As DataTable
        Dim table As New DataTable()
        table.TableName = "Penjualan"
        table.Columns.Add(New DataColumn("No_KTP", GetType(String)))
        table.Columns.Add(New DataColumn("Nama", GetType(String)))
        table.Columns.Add(New DataColumn("K1", GetType(Double)))
        table.Columns.Add(New DataColumn("K2", GetType(Double)))
        table.Columns.Add(New DataColumn("K3", GetType(Double)))
        table.Columns.Add(New DataColumn("K4", GetType(Double)))
        table.Columns.Add(New DataColumn("Jumlah", GetType(Double)))
        table.Columns.Add(New DataColumn("Ranking", GetType(Integer)))

        'Cari Min Max dari Matrix
        Dim K1(x), K2(x), K3(x), K4(x), jumlah(x), rank(x - 1) As Double, ranking As String
        Dim listRank, listPenduduk As New SortedList()

        For i = 0 To GVMatriks.RowCount - 1
            K1(i) = GVMatriks.GetRowCellValue(i, "Surat Keterangan Miskin") / maxK1
            K2(i) = minK2 / GVMatriks.GetRowCellValue(i, "Nilai Penghasilan")
            K3(i) = GVMatriks.GetRowCellValue(i, "Tanggungan Anak") / maxK3
            K4(i) = GVMatriks.GetRowCellValue(i, "Kondisi Rumah") / maxK4
            jumlah(i) = (K1(i) * bK1) + (K2(i) * bK2) + (K3(i) * bK3) + (K4(i) * bK4)
            rank(i) = (K1(i) * bK1) + (K2(i) * bK2) + (K3(i) * bK3) + (K4(i) * bK4)
            listPenduduk.Add(Math.Round(rank(i), 2), GVMatriks.GetRowCellValue(i, "No_KTP"))
        Next i
        'Array.Sort(rank)
        x = listPenduduk.Count

        For i = 0 To listPenduduk.Count - 1
            listRank.Add(listPenduduk.GetByIndex(i), x)
            x -= 1
        Next

        For i = 0 To GVMatriks.RowCount - 1
            ranking = listRank(GVMatriks.GetRowCellValue(i, "No_KTP"))
            table.Rows.Add(GVMatriks.GetRowCellValue(i, "No_KTP"), GVMatriks.GetRowCellValue(i, "Nama"), Math.Round(K1(i), 2), Math.Round(K2(i), 2), Math.Round(K3(i), 2), Math.Round(K4(i), 2), Math.Round(jumlah(i), 2), ranking)
        Next i

        Return table
    End Function

    Private Sub insertHasil()
        For i = 0 To GVNormal.RowCount - 1
            conn.setQuery("INSERT INTO hasil_spk VALUES('" & GVNormal.GetRowCellValue(i, "No_KTP") & "','" & GVNormal.GetRowCellValue(i, "Jumlah") & "','" & GVNormal.GetRowCellValue(i, "Ranking") & "')")
        Next i
    End Sub

    Private Sub btnProses_Click(sender As Object, e As EventArgs) Handles btnProses.Click
        If dtHasil.Rows.Count > 0 Then
            MessageBox.Show("Data sudah diproses, hapus hasil jika ingin mengulangi proses!", "Pemberitahuan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        dtNormal = conn.getQuery("SELECT MAX(a.K1) 'maxK1', MIN(k2) 'minK2', MAX(a.K3) 'maxK3', MAX(a.K4) 'maxK4' FROM " _
                                 & "(SELECT a.No_KTP,a.Nama, k1.Bobot 'K1', k2.Bobot 'K2', k3.Bobot 'K3', k4.Bobot 'K4' FROM penduduk a " _
                                 & "INNER JOIN sub_kriteria k1 ON a.K_1=k1.Sub_Kriteria " _
                                 & "INNER JOIN sub_kriteria k2 ON a.K_2=k2.Sub_Kriteria " _
                                 & "INNER JOIN sub_kriteria k3 ON a.K_3=k3.Sub_Kriteria " _
                                 & "INNER JOIN sub_kriteria k4 ON a.K_4=k4.Sub_Kriteria) AS a")

        maxK1 = dtNormal.Rows(0).Item("maxK1")
        minK2 = dtNormal.Rows(0).Item("minK2")
        maxK3 = dtNormal.Rows(0).Item("maxK3")
        maxK4 = dtNormal.Rows(0).Item("maxK4")

        'isi bobot kriteria
        dtKriteria = conn.getQuery("SELECT * FROM Kriteria")
        bK1 = dtKriteria.Rows(0).Item("Bobot")
        bK2 = dtKriteria.Rows(1).Item("Bobot")
        bK3 = dtKriteria.Rows(2).Item("Bobot")
        bK4 = dtKriteria.Rows(3).Item("Bobot")

        'tampilkan data normalisasi ke tabel
        GCNormal.DataSource = getNormalisasi()
        GVNormal.Columns("Ranking").SortOrder = DevExpress.Data.ColumnSortOrder.Ascending

        'insert hasil spk ke database
        insertHasil()
        checkHasil()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        conn.setQuery("TRUNCATE TABLE hasil_spk")
        checkHasil()
    End Sub
End Class