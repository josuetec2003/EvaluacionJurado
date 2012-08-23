Imports System.Data.SqlClient

Public Class XFormConfigConexion

    Private Function Mandar_a_ProbarConexionAplicacion() As Boolean
        Try
            Dim _cadena As String

            If chkUser.Checked Then
                _cadena = String.Format("Data Source={0};Initial Catalog={1};User ID={2};Password={3}", cboServidor.EditValue, txtDB.EditValue, txtUser.EditValue, txtPass.EditValue)
            Else
                _cadena = String.Format("Data Source={0};Initial Catalog={1};Integrated Security=True", cboServidor.EditValue, txtDB.EditValue)
                '_cadena = New SqlConnectionStringBuilder(My.Settings.JuradoFestivalConnectionString) With {.DataSource = cboServidor.EditValue, .InitialCatalog = txtDB.EditValue}
            End If

            If ValidarConexion(_cadena) Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            Dim _st As New System.Diagnostics.StackTrace()
            Dim _miFuncion As String = _st.GetFrame(0).GetMethod().Name
            Return False
        End Try
    End Function

    Private Sub XFormConfigConexion_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim _cadenaaplicacion As New SqlConnectionStringBuilder(My.Settings.MiConexion)

        txtUser.Enabled = False
        txtPass.Enabled = False

        cboServidor.EditValue = String.Format("{0}\SQLEXPRESS", My.Computer.Name)
        txtDB.EditValue = _cadenaaplicacion.InitialCatalog
    End Sub

    Private Sub btnProbarConexion_Click(sender As System.Object, e As System.EventArgs) Handles btnProbarConexion.Click
        If Mandar_a_ProbarConexionAplicacion() Then
            MsgBox("Conexión correcta a la base de datos", MsgBoxStyle.Information, "Correcto")
        Else
            MsgBox("No se puede conectar a la base de datos", MsgBoxStyle.Exclamation, "Error")
        End If
    End Sub

    Private Sub btnOK_Click(sender As System.Object, e As System.EventArgs) Handles btnOK.Click
        If Mandar_a_ProbarConexionAplicacion() Then
            Dim _cadena As String
            If chkUser.Checked Then
                _cadena = String.Format("Data Source={0};Initial Catalog={1};User ID={2};Password={3}", cboServidor.EditValue, txtDB.EditValue, txtUser.EditValue, txtPass.EditValue)
            Else
                _cadena = String.Format("Data Source={0};Initial Catalog={1};Integrated Security=True", cboServidor.EditValue, txtDB.EditValue)
                '_cadena = New SqlConnectionStringBuilder(My.Settings.JuradoFestivalConnectionString) With {.DataSource = cboServidor.EditValue, .InitialCatalog = txtDB.EditValue}
            End If
            My.Settings.MiConexion = _cadena
            My.Settings.Save()

            MsgBox("Nueva conexión configurada correctamente", MsgBoxStyle.Information, "Listo")
            DialogResult = Windows.Forms.DialogResult.OK
            My.Settings.SetConnectionString(My.Settings.MiConexion)
            Close()
        Else
            MsgBox("No se puede conectar a la base de datos", MsgBoxStyle.Exclamation, "Error")
        End If
    End Sub

    Private Sub chkUser_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkUser.CheckedChanged
        If chkUser.Checked Then
            txtUser.Enabled = True
            txtPass.Enabled = True
        Else
            txtUser.Enabled = False
            txtPass.Enabled = False
        End If
    End Sub
End Class