Public Class frmLogin
    Dim ExisteFestival As Boolean

    Private Sub btnOK_Click(sender As System.Object, e As System.EventArgs) Handles btnOK.Click
        If Not ValidarForm() Then
            Exit Sub
        End If

        If cboTipoAcceso.Text = "Juez" Then
            Using TaFestival As New DataSetFestivalTableAdapters.FestivalTableAdapter
                Dim DtFestival As DataTable = TaFestival.GetDataByEstadoFestival
                If DtFestival.Rows.Count = 1 Then
                    ExisteFestival = True
                Else
                    ExisteFestival = False
                End If
            End Using

            If ExisteFestival Then
                Using TaLogin As New DataSetSeguridadTableAdapters.JuecesTableAdapter
                    Dim DtLogin As New DataSetSeguridad.JuecesDataTable
                    DtLogin = TaLogin.GetDataByLogin(txtUser.EditValue, SHA1(txtPass.EditValue))

                    If DtLogin.Rows.Count = 1 Then
                        With JuezActivo
                            .IDJuez = DtLogin(0)(0)
                            .Usuario = DtLogin(0)(1).ToString
                            .Nombre = DtLogin(0)(3).ToString
                            .Apellido = DtLogin(0)(4).ToString
                            .TipoAcceso = 1
                        End With
                        DialogResult = Windows.Forms.DialogResult.OK
                    Else
                        MsgBox("El usuario y/o contraseña no son validos", MsgBoxStyle.Critical, "Error")
                    End If
                End Using
            Else
                MsgBox("No puede iniciar sesión en este momento porque aun no se inicia ningún festival", MsgBoxStyle.Information, "No hay festival")
            End If
        Else
            Using TaLogin As New DataSetSeguridadTableAdapters.AdministradoresTableAdapter
                Dim DtLogin As New DataSetSeguridad.AdministradoresDataTable
                DtLogin = TaLogin.GetDataByLogin(txtUser.EditValue, SHA1(txtPass.EditValue))

                If DtLogin.Rows.Count = 1 Then
                    With JuezActivo
                        .IDJuez = DtLogin(0)(0)
                        .Usuario = DtLogin(0)(2).ToString
                        .Nombre = DtLogin(0)(1).ToString
                        .TipoAcceso = 2
                    End With
                    DialogResult = Windows.Forms.DialogResult.OK
                Else
                    MsgBox("El usuario y/o contraseña no son validos", MsgBoxStyle.Critical, "Error")
                End If
            End Using
        End If
    End Sub

    Private Function ValidarForm() As Boolean
        If txtUser.Text.Trim = "" Then
            txtUser.Focus()
            Return False
        End If

        If txtPass.Text.Trim = "" Then
            txtPass.Focus()
            Return False
        End If

        If cboTipoAcceso.Text.Trim = "" Then
            cboTipoAcceso.Focus()
            Return False
        End If

        Return True
    End Function

    Private Sub frmLogin_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Application.EnableVisualStyles()
    End Sub
End Class
