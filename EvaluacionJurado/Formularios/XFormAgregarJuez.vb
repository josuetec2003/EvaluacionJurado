Public Class XFormAgregarJuez

    Private Sub XFormAgregarJuez_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        JuecesBindingSource.CancelEdit()
    End Sub
    Private Sub XFormAgregarJuez_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'JuecesTableAdapter.Fill(Me.DataSetFestival.Jueces)
        JuecesBindingSource.AddNew()
        AnioParticipacionTextEdit.EditValue = FestivalActivo.Anio
        AnioParticipacionTextEdit.Properties.ReadOnly = True

        'Label2.Text = FestivalActivo.Anio
    End Sub

    Private Sub btnAgregarJuez_Click(sender As System.Object, e As System.EventArgs) Handles btnAgregarJuez.Click
        If Not ValidarFormulario() Then
            Exit Sub
        End If

        JuecesTableAdapter.Insert(UsuarioTextEdit.EditValue, SHA1(ContrasenaTextEdit.EditValue), NombreTextEdit.EditValue, ApellidoTextEdit.EditValue, CInt(AnioParticipacionTextEdit.EditValue))

        With XFormJueces
            .cargarDatos()
            .Show()
            .Focus()
        End With

        Close()
    End Sub

    Private Function ValidarFormulario() As Boolean
        If NombreTextEdit.EditValue Is DBNull.Value Then
            MsgBox("Debes agregar el nombre del Juez")
            Return False
        End If

        If ApellidoTextEdit.EditValue Is DBNull.Value Then
            MsgBox("Debes agregar el apellido del Juez")
            Return False
        End If

        If UsuarioTextEdit.EditValue Is DBNull.Value Then
            MsgBox("Debes agregar el usuario del Juez")
            Return False
        End If

        If ContrasenaTextEdit.EditValue Is DBNull.Value Then
            MsgBox("Debes agregar la contraseña del Juez")
            Return False
        End If

        If RepContrasenaTextEdit.EditValue Is DBNull.Value Then
            MsgBox("Debes repetir la contraseña")
            Return False
        End If

        If RepContrasenaTextEdit.EditValue <> ContrasenaTextEdit.EditValue Then
            MsgBox("Las contraseñas no coinciden")
            Return False
        End If

        Return True
    End Function
End Class