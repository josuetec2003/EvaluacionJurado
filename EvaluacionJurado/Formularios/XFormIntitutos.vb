Public Class XFormIntitutos

    Private Sub XFormIntitutos_Activated(sender As Object, e As System.EventArgs) Handles Me.Activated
        cargarDatos()
    End Sub

    Private Sub XFormIntitutos_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        cargarDatos()
    End Sub

    Sub cargarDatos()
        InstitutoTableAdapter.Fill(DataSetFestival.Instituto)
    End Sub

    Private Sub btnAgregarInstituto_Click(sender As System.Object, e As System.EventArgs) Handles btnAgregarInstituto.Click
        With XFormAgregarInstituto
            .ShowDialog()
        End With

    End Sub
End Class