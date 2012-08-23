Public Class XFormAgregarCancion

    Private Sub XFormAgregarCancion_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        CancionBindingSource.CancelEdit()
    End Sub

    Private Sub XFormAgregarCancion_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        CancionBindingSource.AddNew()
    End Sub

    Private Sub btnAgregarCancion_Click(sender As System.Object, e As System.EventArgs) Handles btnAgregarCancion.Click
        If Not ValidarFormulario() Then
            Exit Sub
        End If


        Me.Validate()
        Me.CancionBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSetFestival)

        With XFormCanciones
            .cargarDatos()
            .Show()
            .Focus()
        End With

        Close()
    End Sub

    Private Function ValidarFormulario() As Boolean

        If NombreTextEdit.EditValue Is DBNull.Value Then
            MsgBox("Debes agregar el nombre de la cancion")
            Return False
        End If

        If InterpreteTextEdit.EditValue Is DBNull.Value Then
            MsgBox("Debes agregar el nombre del interprete")
            Return False
        End If

        If GeneroTextEdit.EditValue Is DBNull.Value Then
            MsgBox("Debes agregar el genero de la cancion")
            Return False
        End If

        Return True
    End Function

End Class