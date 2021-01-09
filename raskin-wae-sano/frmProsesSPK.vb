Public Class krLabel
    Public label As String
    Public minMax As String
End Class

Public Class krMinMax
    Public label As String
    Public nMinMax As Double
End Class

Public Class krBobot
    Public label As String
    Public nBobot As Double
End Class

Public Class frmProsesSPK
    Dim dtMatriks, dtNormal, dtKriteria, dtHasil As DataTable
    Dim conn As New Database
    Dim bdSource As New BindingSource
    'Dim maxK1, minK2, maxK3, maxK4 As Double
    'Bobot Kriteria
    'Dim bK1, bK2, bK3, bK4 As Double
    Dim jmlData As Integer
    Dim Kriteria As New List(Of krLabel)
    Dim KriteriaMinMax As New List(Of krMinMax)
    Dim KriteriaBobot As New List(Of krBobot)

    Public Sub LoadMatriks()
        Dim dtPenduduk, dtKtr, dtPddKtr As New DataTable
        dtPenduduk = conn.getQuery("SELECT * FROM penduduk WHERE Status = 'Aktif'")
        Dim table As New DataTable()
        table.TableName = "Matriks"
        table.Columns.Add(New DataColumn("No_KTP", GetType(String)))
        table.Columns.Add(New DataColumn("Nama", GetType(String)))
        'tambah kriteria
        dtKtr = conn.getQuery("SELECT * FROM kriteria")
        'ReDim Kriteria(dtKtr.Rows.Count - 1)

        For i = 0 To dtKtr.Rows.Count - 1
            table.Columns.Add(New DataColumn(dtKtr.Rows(i).Item(1), GetType(Double)))
            'kriteria(i) = {, dtKtr.Rows(i).Item(1)}
            Kriteria.Add(New krLabel() With {.label = dtKtr.Rows(i).Item(1), .minMax = dtKtr.Rows(i).Item(3)})
        Next

        Dim DataRow(dtKtr.Rows.Count + 1) As Object
        For j = 0 To dtPenduduk.Rows.Count - 1
            DataRow(0) = dtPenduduk.Rows(j).Item(2)
            DataRow(1) = dtPenduduk.Rows(j).Item(3)
            For k = 0 To dtKtr.Rows.Count - 1
                dtPddKtr = conn.getQuery("SELECT * FROM penduduk_kriteria a INNER JOIN sub_kriteria b ON a.sub_kriteria_id=b.no WHERE a.penduduk_id = '" & dtPenduduk.Rows(j).Item(0) & "' AND a.kriteria_id = '" & dtKtr.Rows(k).Item(0) & "'")
                DataRow(2 + k) = dtPddKtr.Rows(0).Item(6)
            Next
            table.Rows.Add(DataRow)
        Next

        GCMatriks.DataSource = table

        jmlData = GVMatriks.RowCount
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
        table.TableName = "Normalisasi"
        table.Columns.Add(New DataColumn("No_KTP", GetType(String)))
        table.Columns.Add(New DataColumn("Nama", GetType(String)))
        For i = 0 To Kriteria.Count - 1
            table.Columns.Add(New DataColumn(Kriteria(i).label, GetType(Double)))
        Next
        table.Columns.Add(New DataColumn("Jumlah", GetType(Double)))
        table.Columns.Add(New DataColumn("Ranking", GetType(Integer)))

        'Cari Min Max dari Matrix
        'Dim K1(jmlData), K2(jmlData), K3(jmlData), K4(jmlData), jumlah(jmlData), rank(jmlData - 1) As Double, ranking As String
        Dim listRank, listPenduduk As New SortedList()
        Dim kKriteria(jmlData, Kriteria.Count), jKriteria(jmlData), jumlah As Double, ranking As String

        For i = 0 To GVMatriks.RowCount - 1
            'K1(i) = GVMatriks.GetRowCellValue(i, "Surat Keterangan Miskin") / maxK1
            'K2(i) = minK2 / GVMatriks.GetRowCellValue(i, "Nilai Penghasilan")
            'K3(i) = GVMatriks.GetRowCellValue(i, "Tanggungan Anak") / maxK3
            'K4(i) = GVMatriks.GetRowCellValue(i, "Kondisi Rumah") / maxK4
            'jumlah(i) = (K1(i) * bK1) + (K2(i) * bK2) + (K3(i) * bK3) + (K4(i) * bK4)
            'rank(i) = (K1(i) * bK1) + (K2(i) * bK2) + (K3(i) * bK3) + (K4(i) * bK4)
            For j = 0 To Kriteria.Count - 1
                If Kriteria(j).minMax = "Biaya" Then
                    kKriteria(i, j) = KriteriaMinMax(j).nMinMax / GVMatriks.GetRowCellValue(i, Kriteria(j).label)
                Else
                    kKriteria(i, j) = GVMatriks.GetRowCellValue(i, Kriteria(j).label) / KriteriaMinMax(j).nMinMax
                End If
                'MsgBox(kKriteria(j))
            Next j
            jumlah = 0
            For k = 0 To Kriteria.Count - 1
                jumlah += kKriteria(i, k) * KriteriaBobot(k).nBobot
            Next k
            jKriteria(i) = jumlah

            'rank(i) = jumlah
            'MsgBox(GVMatriks.GetRowCellValue(i, "No_KTP"))
            'MsgBox(jKriteria(i))
            listPenduduk.Add(i, GVMatriks.GetRowCellValue(i, "No_KTP"))
            'MsgBox(jKriteria(i))
        Next i
        'Array.Sort(rank)
        jmlData = listPenduduk.Count

        For i = 0 To listPenduduk.Count - 1
            listRank.Add(listPenduduk.GetByIndex(i), jmlData)
            jmlData -= 1
        Next

        Dim DataRow(Kriteria.Count + 3) As Object
        For i = 0 To GVMatriks.RowCount - 1
            ranking = listRank(GVMatriks.GetRowCellValue(i, "No_KTP"))
            DataRow(0) = GVMatriks.GetRowCellValue(i, "No_KTP")
            DataRow(1) = GVMatriks.GetRowCellValue(i, "Nama")
            For k = 0 To Kriteria.Count - 1
                DataRow(2 + k) = Math.Round(kKriteria(i, k), 2)
            Next
            DataRow(2 + Kriteria.Count) = Math.Round(jKriteria(i), 2)
            DataRow(2 + Kriteria.Count + 1) = ranking
            table.Rows.Add(DataRow)
            'table.Rows.Add(Math.Round(K1(i), 2), Math.Round(K2(i), 2), Math.Round(K3(i), 2), Math.Round(K4(i), 2), Math.Round(jumlah(i), 2), ranking)
        Next i

        Return table
    End Function

    Private Sub insertHasil()
        For i = 0 To GVNormal.RowCount - 1
            conn.setQuery("INSERT INTO hasil_spk VALUES('" & GVNormal.GetRowCellValue(i, "No_KTP") & "','" & GVNormal.GetRowCellValue(i, "Jumlah") & "','" & GVNormal.GetRowCellValue(i, "Ranking") & "')")
        Next i
    End Sub

    Private Sub btnProses_Click(sender As Object, e As EventArgs) Handles btnProses.Click
        'For i = 0 To Kriteria.Count - 1
        '    MsgBox(Kriteria(i).minMax)
        'Next
        If dtHasil.Rows.Count > 0 Then
            MessageBox.Show("Data sudah diproses, hapus hasil jika ingin mengulangi proses!", "Pemberitahuan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        dtNormal = conn.getQuery("SELECT c.Nama,IF(c.Atribut = 'Keuntungan', MAX(d.Bobot), MIN(d.Bobot)) AS bobot FROM penduduk_kriteria b " _
                                 & "INNER JOIN kriteria c ON c.No_Kriteria=b.kriteria_id " _
                                 & "INNER JOIN sub_kriteria d ON b.sub_kriteria_id=d.No " _
                                 & "GROUP BY b.kriteria_id")

        'maxK1 = dtNormal.Rows(0).Item("maxK1")
        'minK2 = dtNormal.Rows(0).Item("minK2")
        'maxK3 = dtNormal.Rows(0).Item("maxK3")
        'maxK4 = dtNormal.Rows(0).Item("maxK4")
        'MsgBox(dtNormal.Rows.Count)
        For i = 0 To dtNormal.Rows.Count - 1
            KriteriaMinMax.Add(New krMinMax() With {.label = dtNormal.Rows(i).Item(0), .nMinMax = dtNormal.Rows(i).Item(1)})
            'KriteriaMinMax(i).label = dtNormal.Rows(i).Item(0)
            'KriteriaMinMax(i).nMinMax = dtNormal.Rows(i).Item(1)
        Next


        'isi bobot kriteria
        dtKriteria = conn.getQuery("SELECT * FROM Kriteria")
        'bK1 = dtKriteria.Rows(0).Item("Bobot")
        'bK2 = dtKriteria.Rows(1).Item("Bobot")
        'bK3 = dtKriteria.Rows(2).Item("Bobot")
        'bK4 = dtKriteria.Rows(3).Item("Bobot")
        For i = 0 To dtKriteria.Rows.Count - 1
            KriteriaBobot.Add(New krBobot() With {.label = dtKriteria.Rows(i).Item(1), .nBobot = dtKriteria.Rows(i).Item(2)})
            'KriteriaBobot(i).label = dtKriteria.Rows(i).Item(1)
            'KriteriaBobot(i).nBobot = dtKriteria.Rows(i).Item(2)
        Next

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