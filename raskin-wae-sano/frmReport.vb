Imports DevExpress.XtraReports.UI

Public Class frmReport

    Public Sub loadReport(data As List(Of lap_hasil_spk))
        Dim lapSPK As New reportHasilSPK
        For Each p As DevExpress.XtraReports.Parameters.Parameter In lapSPK.Parameters
            p.Visible = False
        Next

        'printNota.pPelanggan.Value = Pelanggan
        'printNota.pNoMeja.Value = NoMeja
        'printNota.pDateTime.Value = DateTime
        'printNota.pInv.Value = Inv
        'printNota.pCashier.Value = namaKasir
        'printNota.pGrandTotal.Value = GrandTotal
        'printNota.pCash.Value = Cash
        'printNota.pChange.Value = Change
        lapSPK.ObjectDataSource1.DataSource = data

        DocumentViewer.DocumentSource = lapSPK
        lapSPK.CreateDocument()
    End Sub
End Class