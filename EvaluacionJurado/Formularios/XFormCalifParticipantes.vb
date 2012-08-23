Public Class XFormCalifParticipantes 

    Private Sub XFormCalifParticipantes_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        CargarDatos()
    End Sub

    Sub CargarDatos()
        ParticipanteTableAdapter.FillByIDFestival(DataSetFestival.Participante, FestivalActivo.IDFestival)
        CancionTableAdapter.Fill(DataSetFestival.Cancion)
        InstitutoTableAdapter.Fill(DataSetFestival.Instituto)
    End Sub

    Private Function DameID() As Integer
        Try
            Return GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "IDParticipante")
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Private Sub ParticipanteGridControl_DoubleClick(sender As System.Object, e As System.EventArgs) Handles ParticipanteGridControl.DoubleClick
        Dim ID As Integer = DameID()
        With XFormCalifParticipante
            .IDParticipante1 = ID
            .MdiParent = Me.MdiParent
            .Show()
            .Focus()
        End With
    End Sub
End Class