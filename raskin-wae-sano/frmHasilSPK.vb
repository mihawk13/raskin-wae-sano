Public Class frmHasilSPK
    Dim dtHasilSPK As DataTable
    Dim conn As New Database

    Public Sub LoadData()
        dtHasilSPK = conn.getQuery("SELECT b.No_KTP,b.Nama,a.Jumlah, a.Ranking FROM hasil_spk a INNER JOIN penduduk b ON a.No_KTP= b.No_KTP ORDER BY a.Ranking")
        GridControl.DataSource = dtHasilSPK
    End Sub

    Private Sub frmHasilSPK_Load(sender As Object, e As EventArgs) Handles Me.Load
        LoadData()
    End Sub
End Class