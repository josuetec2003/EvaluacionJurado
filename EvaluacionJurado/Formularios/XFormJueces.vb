Public Class XFormJueces 
    Private Sub XFormJueces_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        cargarDatos()
    End Sub

    Sub cargarDatos()
        If FestivalActivo.IDFestival <> 0 Then
            JuecesTableAdapter.FillByAnio(DataSetFestival.Jueces, FestivalActivo.Anio)
        Else
            btnAgregarJuez.Enabled = False
        End If
    End Sub

    Private Sub btnAgregarJuez_Click(sender As System.Object, e As System.EventArgs) Handles btnAgregarJuez.Click
        With XFormAgregarJuez
            .MdiParent = Me.MdiParent
            .Show()
            .Focus()
        End With
    End Sub
End Class