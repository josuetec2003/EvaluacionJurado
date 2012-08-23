Public Class XReportTotalGeneral
    Public Sub New(ByVal IdF As Integer)
        InitializeComponent()
        TotalGeneralTableAdapter.Fill(DataSetFestival1.TotalGeneral, IdF)
    End Sub
End Class