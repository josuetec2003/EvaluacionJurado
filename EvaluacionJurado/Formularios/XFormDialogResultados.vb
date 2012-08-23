Public Class XFormDialogResultados 
    Private IDParticipante As Integer

    Public Property IDParticipante1() As Integer
        Get
            Return IDParticipante
        End Get
        Set(value As Integer)
            IDParticipante = Value
        End Set
    End Property

    Private Sub XFormDialogResultados_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        EvaluacionPorJuezTableAdapter.Fill(DataSetFestival.EvaluacionPorJuez, IDParticipante)
    End Sub
End Class