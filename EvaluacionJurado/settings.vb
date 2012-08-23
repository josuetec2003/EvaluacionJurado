Namespace My
    Partial Friend NotInheritable Class MySettings
        Public Sub SetConnectionString(ByVal oConn As System.Data.SqlClient.SqlConnection)
            My.Settings.Item("JuradoFestivalConnectionString") = oConn.ConnectionString
        End Sub

        Public Sub SetConnectionString(ByVal strConnection As String)
            My.Settings.Item("JuradoFestivalConnectionString") = strConnection
        End Sub

        Public contador As Integer = 0

        Private Sub MySettings_SettingsLoaded(ByVal sender As Object, ByVal e As System.Configuration.SettingsLoadedEventArgs) Handles Me.SettingsLoaded
            If My.Settings.MiConexion.Trim.Length > 0 Then
                Me("JuradoFestivalConnectionString") = My.Settings.MiConexion
                My.Settings.Save()
            End If
        End Sub
    End Class
End Namespace
