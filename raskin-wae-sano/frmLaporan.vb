Public Class frmLaporan
    Dim dtLaporan As DataTable
    Dim conn As New Database

    Public Sub LoadData()
        dtLaporan = conn.getQuery("SELECT b.No_KTP,b.Nama, CONCAT('Desa', b.Desa, ' RT/RW ',b.RT_RW, ' Kec. ', b.Kecamatan) AS Alamat, a.Ranking FROM hasil_spk a " _
                                  & "INNER JOIN penduduk b ON a.No_KTP= b.No_KTP ORDER BY a.Ranking")
        GridControl.DataSource = dtLaporan
    End Sub

    Private Sub frmLaporan_Load(sender As Object, e As EventArgs) Handles Me.Load
        LoadData()
    End Sub

    Private Sub btnCetak_Click(sender As Object, e As EventArgs) Handles btnCetak.Click
        Dim data As New List(Of lap_hasil_spk)
        For i As Integer = 0 To dtLaporan.Rows.Count - 1
            Dim lapSPK As New lap_hasil_spk()
            lapSPK.No_KTP = dtLaporan.Rows(i)("No_KTP")
            lapSPK.Nama = dtLaporan.Rows(i)("Nama")
            lapSPK.Alamat = dtLaporan.Rows(i)("Alamat")
            lapSPK.Ranking = dtLaporan.Rows(i)("Ranking")
            data.Add(lapSPK)
        Next
        'Dim dt As String = Now.Date & " " & TimeOfDay.ToString("H:mm tt")
        frmReport.loadReport(data)
        frmReport.Show()
    End Sub
End Class