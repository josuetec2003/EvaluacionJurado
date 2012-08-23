Public Class XFormFestival 

    Private Sub XFormFestival_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        CargarDatos()
    End Sub

    Sub CargarDatos()
        Dim DtFestival As DataTable = FestivalTableAdapter.GetDataByEstadoFestival
        If DtFestival.Rows.Count = 1 Then
            FestivalTableAdapter.FillByEstadoFestival(DataSetFestival.Festival)

            MdiParent.Text = String.Format("{0} {1}", DtFestival(0)(1), DtFestival(0)(3))
            FestivalActivo.IDFestival = DtFestival(0)(0)
            FestivalActivo.Anio = DtFestival(0)(3)

            BloquearControles(True)
            btnOK.Text = "Finalizar festival"
        Else
            FestivalBindingSource.AddNew()
            BloquearControles(False)
            AñoTextEdit.EditValue = Microsoft.VisualBasic.Year(Now)
            DescripcionTextEdit.Focus()
            btnOK.Text = "Comenzar nuevo festival"
        End If
    End Sub

    Sub BloquearControles(ByVal TF As Boolean)
        DescripcionTextEdit.Properties.ReadOnly = TF
        HomenajeadoTextEdit.Properties.ReadOnly = TF
        AñoTextEdit.Properties.ReadOnly = TF
    End Sub

    Private Sub btnOK_Click(sender As System.Object, e As System.EventArgs) Handles btnOK.Click
        If btnOK.Text = "Finalizar festival" Then
            If MsgBox("Está seguro de finalizar el festival?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirme") = vbYes Then
                FestivalTableAdapter.UpdateEstadoFestival(False, FestivalActivo.IDFestival)
                MdiParent.Text = "No hay festival activo"
                CargarDatos()
                FestivalActivo.IDFestival = 0
                Try
                    XFormParticipantes.Close()
                    XFormJueces.Close()
                Catch ex As Exception
                End Try
            End If
        ElseIf btnOK.Text = "Comenzar nuevo festival" Then
            FestivalTableAdapter.Insert(DescripcionTextEdit.EditValue, HomenajeadoTextEdit.EditValue, AñoTextEdit.EditValue, True)
            CargarDatos()
            Try
                XFormParticipantes.Close()
                XFormJueces.Close()
            Catch ex As Exception
            End Try
        End If
    End Sub

End Class