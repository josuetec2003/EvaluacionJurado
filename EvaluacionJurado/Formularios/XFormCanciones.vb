Public Class XFormCanciones 


    Private Sub XFormCanciones_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        cargarDatos()

    End Sub

    Sub cargarDatos()
        Me.CancionTableAdapter.Fill(Me.DataSetFestival.Cancion)
    End Sub

    Private Sub btnAgregarCancion_Click(sender As System.Object, e As System.EventArgs) Handles btnAgregarCancion.Click
        With XFormAgregarCancion
            .ShowDialog()
        End With
    End Sub
End Class