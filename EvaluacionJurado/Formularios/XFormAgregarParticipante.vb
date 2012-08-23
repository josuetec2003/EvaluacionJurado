Public Class XFormAgregarParticipante
    Private EsNuevo As Boolean
    Private IDP As Integer
    Dim OrdenActual As Integer

    Private Sub XFormAgregarParticipante_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        ParticipanteBindingSource.CancelEdit()
    End Sub

    Private Sub XFormAgregarParticipante_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        If EsNuevo Then
            ParticipanteBindingSource.AddNew()
            btnAgregarParticipante.Text = "Agregar participante"
        Else
            btnAgregarParticipante.Text = "Actualizar"
            ParticipanteTableAdapter.FillByIDParticipante(DataSetFestival.Participante, IDP)
            OrdenActual = OrdenParticipacionTextEdit.EditValue
            Using TaCancion As New DataSetFestivalTableAdapters.CancionTableAdapter
                lblCancion.Text = TaCancion.ScalarNombreCancion(IdCancionTextEdit.EditValue)
            End Using
            Using TaInstituto As New DataSetFestivalTableAdapters.InstitutoTableAdapter
                lblInstituto.Text = TaInstituto.ScalarNombreInstituto(IdInstitutoTextEdit.EditValue)
            End Using
        End If
    End Sub

    Private Sub btnIntituto_Click(sender As System.Object, e As System.EventArgs) Handles btnIntituto.Click
        With XFormListadoInstitutos
            .ShowDialog()
        End With
    End Sub

    Private Sub btnCancion_Click(sender As System.Object, e As System.EventArgs) Handles btnCancion.Click
        With XFormListadoCanciones
            .ShowDialog()
        End With
    End Sub

    Private Sub btnAgregarParticipante_Click(sender As System.Object, e As System.EventArgs) Handles btnAgregarParticipante.Click
        If Not ValidarFormulario() Then
            Exit Sub
        End If

        If EsNuevo Then
            ParticipanteTableAdapter.Insert(OrdenParticipacionTextEdit.EditValue, NombreTextEdit.EditValue, ApellidoTextEdit.EditValue, FestivalActivo.IDFestival, IdInstitutoTextEdit.EditValue, IdCancionTextEdit.EditValue)
            With XFormParticipantes
                .cargarDatos()
                .Show()
                .Focus()
            End With
            Close()
        Else
            ParticipanteTableAdapter.UpdateParticipante(OrdenParticipacionTextEdit.EditValue, NombreTextEdit.EditValue, ApellidoTextEdit.EditValue, IdInstitutoTextEdit.EditValue, IdCancionTextEdit.EditValue, IDP)
            With XFormParticipantes
                .cargarDatos()
                .Show()
                .Focus()
            End With
            Close()
        End If
    End Sub

    Private Function ValidarFormulario() As Boolean
        If NombreTextEdit.EditValue Is DBNull.Value Then
            MsgBox("Debes agregar el nombre del participante", MsgBoxStyle.Exclamation, "Falta nombre")
            NombreTextEdit.Focus()
            Return False
        End If

        If ApellidoTextEdit.EditValue Is DBNull.Value Then
            MsgBox("Debes agregar el apellido del participante", MsgBoxStyle.Exclamation, "Falta apellido")
            ApellidoTextEdit.Focus()
            Return False
        End If

        If OrdenParticipacionTextEdit.EditValue Is DBNull.Value Then
            MsgBox("Debes definir el orden de participacion", MsgBoxStyle.Exclamation, "Orden")
            OrdenParticipacionTextEdit.Focus()
            Return False
        End If

        If EsNuevo Then
            Using DtParticipantes As DataTable = ParticipanteTableAdapter.GetDataByOrdenParticipacion(OrdenParticipacionTextEdit.EditValue, FestivalActivo.IDFestival)
                If DtParticipantes.Rows.Count = 1 Then
                    MsgBox(String.Format("Este turno de participación ya fué asignado al participante {0} {1}", DtParticipantes(0)(2), DtParticipantes(0)(3)), MsgBoxStyle.Exclamation, "Orden")
                    OrdenParticipacionTextEdit.Focus()
                    Return False
                End If
            End Using
        Else
            Using DtParticipantes As DataTable = ParticipanteTableAdapter.GetDataByOrdenParticipacion2(OrdenParticipacionTextEdit.EditValue, OrdenActual, FestivalActivo.IDFestival)
                If DtParticipantes.Rows.Count = 1 Then
                    MsgBox(String.Format("Este turno de participación ya fué asignado al participante {0} {1}", DtParticipantes(0)(2), DtParticipantes(0)(3)), MsgBoxStyle.Exclamation, "Orden")
                    OrdenParticipacionTextEdit.Focus()
                    Return False
                End If
            End Using
        End If

        If IdInstitutoTextEdit.EditValue Is DBNull.Value Then
            MsgBox("Debes seleccionar el instituto del participante", MsgBoxStyle.Exclamation, "Falta instituto")
            Return False
        End If

        If IdCancionTextEdit.EditValue Is DBNull.Value Then
            MsgBox("Debes seleccionar la cancion del participante", MsgBoxStyle.Exclamation, "Falta canción")
            Return False
        End If

        Return True
    End Function

    Public Property EsNuevo1() As Boolean
        Get
            Return EsNuevo
        End Get
        Set(value As Boolean)
            EsNuevo = Value
        End Set
    End Property

    Public Property IDP1() As Integer
        Get
            Return IDP
        End Get
        Set(value As Integer)
            IDP = Value
        End Set
    End Property
End Class