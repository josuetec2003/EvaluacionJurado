Public Class RFormPrincipal

    Private Sub RFormPrincipal_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If MsgBox("¿Desea salir de la aplicación?", MsgBoxStyle.Question + vbYesNo, "Confirme") = MsgBoxResult.No Then
            e.Cancel = True
        End If
    End Sub

    Private Sub RFormPrincipal_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        ObtenerInfoFestival()
        gestionarPanel()
        ValidarAcceso()
    End Sub

    Sub HabilitarBotones(ByVal TF As Boolean)
        'Para admin
        BarButtonJueces.Enabled = TF
        BarButtonCanciones.Enabled = TF
        BarButtonParticipantes.Enabled = TF
        BarButtonInstitutos.Enabled = TF
        BarButtonResultados.Enabled = TF
        BarButtonResultadosTotales.Enabled = TF
        BarButtonFestival.Enabled = TF

        ' Para el Juez
        BarButtonCalificar.Enabled = Not TF
    End Sub

    Sub ObtenerInfoFestival()
        Using TaFestival As New DataSetFestivalTableAdapters.FestivalTableAdapter
            Dim DtFestival As New DataSetFestival.FestivalDataTable
            DtFestival = TaFestival.GetDataByEstadoFestival

            If DtFestival.Rows.Count = 1 Then
                Text = String.Format("{0} {1}", DtFestival(0)(1), DtFestival(0)(3))
                FestivalActivo.IDFestival = DtFestival(0)(0)
                FestivalActivo.Anio = DtFestival(0)(3)
            Else
                Text = "No hay festival activo"
                FestivalActivo.IDFestival = 0
                FestivalActivo.Anio = 0
            End If
        End Using
    End Sub

    Sub gestionarPanel()
        If XtraTabbedMdiManager1.Pages.Count = 0 Then
            ClientPanel.Visible = True
        Else
            ClientPanel.Visible = False
        End If
    End Sub

    Private Sub XtraTabbedMdiManager1_PageAdded(sender As Object, e As DevExpress.XtraTabbedMdi.MdiTabPageEventArgs) Handles XtraTabbedMdiManager1.PageAdded
        gestionarPanel()
    End Sub

    Private Sub XtraTabbedMdiManager1_PageRemoved(sender As Object, e As DevExpress.XtraTabbedMdi.MdiTabPageEventArgs) Handles XtraTabbedMdiManager1.PageRemoved
        gestionarPanel()
    End Sub

    Private Sub BarButtonParticipantes_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonParticipantes.ItemClick
        With XFormParticipantes
            .MdiParent = Me
            .Show()
            .Focus()
        End With
    End Sub

    Private Sub BarButtonInstitutos_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonInstitutos.ItemClick
        With XFormIntitutos
            .MdiParent = Me
            .Show()
            .Focus()
        End With
    End Sub

    Private Sub BarButtonCanciones_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonCanciones.ItemClick
        With XFormCanciones
            .MdiParent = Me
            .Show()
            .Focus()
        End With
    End Sub

    Private Sub BarButtonJueces_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonJueces.ItemClick
        With XFormJueces
            .MdiParent = Me
            .Show()
            .Focus()
        End With
    End Sub

    Private Sub BarButtonCalificar_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonCalificar.ItemClick
        With XFormCalifParticipantes
            .MdiParent = Me
            .Show()
            .Focus()
        End With
    End Sub

    Private Sub BarButtonItem1_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        If BarButtonItem1.Caption = "Cambiar sesión" Then
            If MsgBox("Confirma cambiar de sesión?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirme") = MsgBoxResult.Yes Then
                ProcesarSesion()
            End If
        ElseIf BarButtonItem1.Caption = "Entrar" Then
            ProcesarSesion()
        End If

    End Sub

    Sub ProcesarSesion()
        Try
            Dim Forms() As Form
            Forms = Me.MdiChildren

            For Each form As Form In Forms
                form.Close()
            Next
        Catch ex As Exception
        End Try

        BarButtonItem1.Caption = "Entrar"
        BarStaticItem1.Caption = "No hay sesión activa"
        RPGAdmin.Visible = False
        RPGConfig.Visible = False
        RPGJuez.Visible = False

        Using modalFormLogin As New frmLogin
            modalFormLogin.ShowDialog()
            If modalFormLogin.DialogResult = Windows.Forms.DialogResult.OK Then
                BarButtonItem1.Caption = "Cambiar sesión"
                RPGAdmin.Visible = True
                RPGConfig.Visible = True
                RPGJuez.Visible = True
                ObtenerInfoFestival()
                ValidarAcceso()
            End If
        End Using
    End Sub

    Sub ValidarAcceso()
        If JuezActivo.TipoAcceso = 1 Then
            BarStaticItem1.Caption = String.Format("Juez: {0} {1}", JuezActivo.Nombre, JuezActivo.Apellido)
            HabilitarBotones(False)
        Else
            BarStaticItem1.Caption = String.Format("Admin: {0} {1}", JuezActivo.Nombre, JuezActivo.Apellido)
            HabilitarBotones(True)
        End If
    End Sub

    Private Sub BarButtonResultados_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonResultados.ItemClick
        With XFormResultados
            .MdiParent = Me
            .Show()
            .Focus()
        End With
    End Sub


    Private Sub BarButtonResultadosTotales_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonResultadosTotales.ItemClick
        With XFormResultadosTotales
            .MdiParent = Me
            .Show()
            .Focus()
        End With
    End Sub

    Private Sub BarButtonFestival_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonFestival.ItemClick
        With XFormFestival
            .MdiParent = Me
            .Show()
            .Focus()
        End With
    End Sub

    Private Sub BarButtonItem2_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem2.ItemClick
        If MsgBox("¿Desea salir de la aplicación?", MsgBoxStyle.Question + vbYesNo, "Confirme") = MsgBoxResult.Yes Then
            End
        End If
    End Sub
End Class