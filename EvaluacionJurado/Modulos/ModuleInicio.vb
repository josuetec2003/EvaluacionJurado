Module ModuleInicio
    Public Sub Main()
        Application.EnableVisualStyles()
        'If My.Forms.frmLogin.ShowDialog = DialogResult.OK Then
        '    Application.DoEvents()
        '    Application.Run(New RFormPrincipal)
        'End If

        If Mandar_a_ProbarConexion() Then
            If My.Forms.frmLogin.ShowDialog = DialogResult.OK Then
                Application.DoEvents()
                Application.Run(New RFormPrincipal)
            End If
        Else
            If XFormConfigConexion.ShowDialog = DialogResult.OK Then
                If My.Forms.frmLogin.ShowDialog = DialogResult.OK Then
                    Application.DoEvents()
                    Application.Run(New RFormPrincipal)
                End If
            End If
        End If
    End Sub

    Public Structure JuezUsuario
        Public IDJuez As Integer
        Public Usuario As String
        Public Nombre As String
        Public Apellido As String
        Public TipoAcceso As Integer '1 para juez y 2 para admin
    End Structure

    Public Structure Festival
        Public IDFestival As Integer
        Public Anio As Integer
    End Structure

    Public JuezActivo As JuezUsuario
    Public FestivalActivo As Festival

End Module
