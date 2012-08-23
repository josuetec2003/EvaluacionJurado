Imports System.IO
Imports DevExpress.XtraPrinting
Imports DevExpress.XtraPrinting.Preview

Public Class XFormResultadosTotales
    Private stream As New MemoryStream

    Private Sub XFormResultadosTotales_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        TotalGeneralTableAdapter.Fill(DataSetFestival.TotalGeneral, FestivalActivo.IDFestival)
    End Sub

    Private Sub btnImprimir_Click(sender As System.Object, e As System.EventArgs) Handles btnImprimir.Click
        Dim rpt As New XReportTotalGeneral(FestivalActivo.IDFestival)
        Dim ps As New PrintingSystem
        Dim preview As New PrintPreviewFormEx

        rpt.CreateDocument()
        rpt.PrintingSystem.SaveDocument(stream)

        ps.LoadDocument(stream)

        With preview
            .PrintingSystem = ps
            .Text = "Resultados finales"
            .MdiParent = Me.MdiParent
            .Show()
        End With
    End Sub
End Class