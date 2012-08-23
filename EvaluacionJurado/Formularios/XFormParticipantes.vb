Public Class XFormParticipantes 

    Private Sub XFormParticipantes_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        cargarDatos()

        If FestivalActivo.IDFestival = 0 Then
            btnAgregarParticipante.Enabled = False
        Else
            btnAgregarParticipante.Enabled = True
        End If
    End Sub

    Sub cargarDatos()
        ParticipanteTableAdapter.FillByIDFestival(DataSetFestival.Participante, FestivalActivo.IDFestival)
        CancionTableAdapter.Fill(DataSetFestival.Cancion)
        InstitutoTableAdapter.Fill(DataSetFestival.Instituto)
    End Sub

    Private Sub btnAgregarParticipante_Click(sender As System.Object, e As System.EventArgs) Handles btnAgregarParticipante.Click
        With XFormAgregarParticipante
            .MdiParent = Me.MdiParent
            .EsNuevo1 = True
            .Show()
            .Focus()
        End With
    End Sub

    Private Function DameId() As Integer
        Try
            Return GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "IDParticipante")
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Private Sub ParticipanteGridControl_DoubleClick(sender As System.Object, e As System.EventArgs) Handles ParticipanteGridControl.DoubleClick
        Dim ID As Integer = DameId()
        With XFormAgregarParticipante
            .IDP1 = ID
            .MdiParent = Me.MdiParent
            .EsNuevo1 = False
            .Show()
            .Focus()
        End With
    End Sub
End Class