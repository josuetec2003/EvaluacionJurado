Public Class XFormCalifParticipante 
    Private IDParticipante As Integer

    Public Property IDParticipante1() As Integer
        Get
            Return IDParticipante
        End Get
        Set(value As Integer)
            IDParticipante = Value
        End Set
    End Property

    Private Sub XFormCalifParticipante_Activated(sender As Object, e As System.EventArgs) Handles Me.Activated
        VerificarSiExisteRegistro()
        ObtenerDatosParticipantes()
    End Sub

    Private Sub XFormCalifParticipante_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        VerificarSiExisteRegistro()
        ObtenerDatosParticipantes()
    End Sub

    Sub ObtenerDatosParticipantes()
        Using TaParticipante As New DataSetFestivalTableAdapters.ParticipanteTableAdapter
            Dim DtParticipante As New DataSetFestival.ParticipanteDataTable
            DtParticipante = TaParticipante.GetDataByIDParticipante(IDParticipante)
            TextEditNombre.EditValue = String.Format("{0} {1}", DtParticipante(0)(2), DtParticipante(0)(3))
            Using TaInsCan As New DataSetFestivalTableAdapters.NombreInstitutoCancionTableAdapter
                Dim DtInsCan As New DataSetFestival.NombreInstitutoCancionDataTable
                DtInsCan = TaInsCan.GetData(IDParticipante)
                TextEditInstituto.EditValue = DtInsCan(0)(0)
                TextEditCancion.EditValue = DtInsCan(0)(1)
            End Using
        End Using
        TextEditNombre.Properties.ReadOnly = True
        TextEditInstituto.Properties.ReadOnly = True
        TextEditCancion.Properties.ReadOnly = True
    End Sub

    Sub VerificarSiExisteRegistro()
        Using TaEval As New DataSetFestivalTableAdapters.EvaluacionTableAdapter
            Dim DtEval As New DataSetFestival.EvaluacionDataTable
            DtEval = TaEval.GetDataByIDJP(JuezActivo.IDJuez, IDParticipante)

            If DtEval.Rows.Count = 1 Then
                EvaluacionTableAdapter.FillByIDJP(DataSetFestival.Evaluacion, JuezActivo.IDJuez, IDParticipante)
                If Not DtEval(0)(2) Is DBNull.Value Then
                    Eval1TextEdit.Properties.ReadOnly = True
                Else
                    Eval1TextEdit.Properties.ReadOnly = False
                End If

                If Not DtEval(0)(3) Is DBNull.Value Then
                    Eval2TextEdit.Properties.ReadOnly = True
                Else
                    Eval2TextEdit.Properties.ReadOnly = False
                End If

                If Not DtEval(0)(4) Is DBNull.Value Then
                    Eval3TextEdit.Properties.ReadOnly = True
                Else
                    Eval3TextEdit.Properties.ReadOnly = False
                End If

                If Not DtEval(0)(5) Is DBNull.Value Then
                    Eval4TextEdit.Properties.ReadOnly = True
                Else
                    Eval4TextEdit.Properties.ReadOnly = False
                End If

                If Not DtEval(0)(6) Is DBNull.Value Then
                    Eval5TextEdit.Properties.ReadOnly = True
                Else
                    Eval5TextEdit.Properties.ReadOnly = False
                End If

                If Not DtEval(0)(7) Is DBNull.Value Then
                    Eval6TextEdit.Properties.ReadOnly = True
                Else
                    Eval6TextEdit.Properties.ReadOnly = False
                End If

                If Not DtEval(0)(8) Is DBNull.Value Then
                    Eval7TextEdit.Properties.ReadOnly = True
                Else
                    Eval7TextEdit.Properties.ReadOnly = False
                End If
            Else
                Try
                    EvaluacionTableAdapter.InsertEvaluacion(JuezActivo.IDJuez, IDParticipante)
                    EvaluacionTableAdapter.FillByIDJP(DataSetFestival.Evaluacion, JuezActivo.IDJuez, IDParticipante)
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If
        End Using
    End Sub

    Private Sub Eval1TextEdit_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles Eval1TextEdit.KeyPress, Eval2TextEdit.KeyPress, Eval3TextEdit.KeyPress, Eval4TextEdit.KeyPress, Eval5TextEdit.KeyPress, Eval6TextEdit.KeyPress, Eval7TextEdit.KeyPress
        If e.KeyChar = ChrW(13) Then
            Dim TextEdit As DevExpress.XtraEditors.TextEdit = CType(sender, DevExpress.XtraEditors.TextEdit)

            Select Case TextEdit.Name
                Case "Eval1TextEdit"
                    If TextEdit.EditValue Is DBNull.Value Then
                        TextEdit.Focus()
                        Exit Sub
                    ElseIf TextEdit.EditValue < 0 Or TextEdit.EditValue > 5 Then
                        TextEdit.EditValue = DBNull.Value
                        TextEdit.Focus()
                        Exit Sub
                    End If
                    EvaluacionTableAdapter.UpdateEval1(CInt(TextEdit.EditValue), JuezActivo.IDJuez, IDParticipante)
                    TextEdit.Properties.ReadOnly = True
                    SendKeys.Send("{TAB}")
                Case "Eval2TextEdit"
                    If TextEdit.EditValue Is DBNull.Value Then
                        TextEdit.Focus()
                        Exit Sub
                    ElseIf TextEdit.EditValue < 0 Or TextEdit.EditValue > 5 Then
                        TextEdit.EditValue = DBNull.Value
                        TextEdit.Focus()
                        Exit Sub
                    End If
                    EvaluacionTableAdapter.UpdateEval2(CInt(TextEdit.EditValue), JuezActivo.IDJuez, IDParticipante)
                    TextEdit.Properties.ReadOnly = True
                    SendKeys.Send("{TAB}")
                Case "Eval3TextEdit"
                    If TextEdit.EditValue Is DBNull.Value Then
                        TextEdit.Focus()
                        Exit Sub
                    ElseIf TextEdit.EditValue < 0 Or TextEdit.EditValue > 5 Then
                        TextEdit.EditValue = DBNull.Value
                        TextEdit.Focus()
                        Exit Sub
                    End If
                    EvaluacionTableAdapter.UpdateEval3(CInt(TextEdit.EditValue), JuezActivo.IDJuez, IDParticipante)
                    TextEdit.Properties.ReadOnly = True
                    SendKeys.Send("{TAB}")
                Case "Eval4TextEdit"
                    If TextEdit.EditValue Is DBNull.Value Then
                        TextEdit.Focus()
                        Exit Sub
                    ElseIf TextEdit.EditValue < 0 Or TextEdit.EditValue > 5 Then
                        TextEdit.EditValue = DBNull.Value
                        TextEdit.Focus()
                        Exit Sub
                    End If
                    EvaluacionTableAdapter.UpdateEval4(CInt(TextEdit.EditValue), JuezActivo.IDJuez, IDParticipante)
                    TextEdit.Properties.ReadOnly = True
                    SendKeys.Send("{TAB}")
                Case "Eval5TextEdit"
                    If TextEdit.EditValue Is DBNull.Value Then
                        TextEdit.Focus()
                        Exit Sub
                    ElseIf TextEdit.EditValue < 0 Or TextEdit.EditValue > 5 Then
                        TextEdit.EditValue = DBNull.Value
                        TextEdit.Focus()
                        Exit Sub
                    End If
                    EvaluacionTableAdapter.UpdateEval5(CInt(TextEdit.EditValue), JuezActivo.IDJuez, IDParticipante)
                    TextEdit.Properties.ReadOnly = True
                    SendKeys.Send("{TAB}")
                Case "Eval6TextEdit"
                    If TextEdit.EditValue Is DBNull.Value Then
                        TextEdit.Focus()
                        Exit Sub
                    ElseIf TextEdit.EditValue < 0 Or TextEdit.EditValue > 5 Then
                        TextEdit.EditValue = DBNull.Value
                        TextEdit.Focus()
                        Exit Sub
                    End If
                    EvaluacionTableAdapter.UpdateEval6(CInt(TextEdit.EditValue), JuezActivo.IDJuez, IDParticipante)
                    TextEdit.Properties.ReadOnly = True
                    SendKeys.Send("{TAB}")
                Case "Eval7TextEdit"
                    If TextEdit.EditValue Is DBNull.Value Then
                        TextEdit.Focus()
                        Exit Sub
                    ElseIf TextEdit.EditValue < 0 Or TextEdit.EditValue > 5 Then
                        TextEdit.EditValue = DBNull.Value
                        TextEdit.Focus()
                        Exit Sub
                    End If
                    EvaluacionTableAdapter.UpdateEval7(CInt(TextEdit.EditValue), JuezActivo.IDJuez, IDParticipante)
                    TextEdit.Properties.ReadOnly = True
                    SendKeys.Send("{TAB}")
            End Select
        End If
    End Sub

End Class