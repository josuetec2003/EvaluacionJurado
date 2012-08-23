Public Class XFormListadoInstitutos 

    Private Sub XFormListadoInstitutos_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.InstitutoTableAdapter.Fill(Me.DataSetFestival.Instituto)
    End Sub

    Private Sub TextEdit1_EditValueChanged(sender As System.Object, e As System.EventArgs) Handles TextEdit1.EditValueChanged
        InstitutoTableAdapter.FillByNombre(DataSetFestival.Instituto, String.Format("{0}%", TextEdit1.EditValue))
    End Sub

    Private Function DameIDInstituto() As Integer
        Try
            Return GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "ID")
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Private Function DameNombreInstituto() As String
        Try
            Return GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "Nombre")
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Private Sub InstitutoGridControl_DoubleClick(sender As System.Object, e As System.EventArgs) Handles InstitutoGridControl.DoubleClick
        Dim ID As Integer = DameIDInstituto()
        Dim Nombre As String = DameNombreInstituto()

        With XFormAgregarParticipante
            .lblInstituto.Text = Nombre
            .IdInstitutoTextEdit.EditValue = ID
            .Show()
            .Focus()
        End With
        Close()
    End Sub
End Class