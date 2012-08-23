Public Class XFormAgregarInstituto

    Private Sub XFormAgregarInstituto_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        InstitutoBindingSource.CancelEdit()
    End Sub


    Private Sub XFormAgregarInstituto_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        'Me.InstitutoTableAdapter.Fill(Me.DataSetFestival.Instituto)
        InstitutoBindingSource.AddNew()
    End Sub

    Private Sub btnOK_Click(sender As System.Object, e As System.EventArgs) Handles btnOK.Click
        If Not ValidarFormulario() Then
            Exit Sub
        End If

        Validate()
        InstitutoBindingSource.EndEdit()
        TableAdapterManager.UpdateAll(Me.DataSetFestival)

        With XFormIntitutos
            .cargarDatos()
            .Show()
            .Focus()
        End With

        Close()
    End Sub

    Private Function ValidarFormulario() As Boolean

        If NombreTextEdit.EditValue Is DBNull.Value Then
            MsgBox("Debes agregar el nombre del instituto")
            Return False
        End If

        If DireccionMemoEdit.EditValue Is DBNull.Value Then
            MsgBox("Debes agregar la dirección del instituto")
            Return False
        End If


        Return True
    End Function

End Class