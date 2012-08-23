Public Class XFormListadoCanciones 

    Private Sub CancionBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs)
        Me.Validate()
        Me.CancionBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSetFestival)

    End Sub

    Private Sub XFormListadoCanciones_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.CancionTableAdapter.Fill(Me.DataSetFestival.Cancion)
    End Sub

    Private Sub TextEdit1_EditValueChanged(sender As System.Object, e As System.EventArgs) Handles TextEdit1.EditValueChanged
        Me.CancionTableAdapter.FillByNombre(Me.DataSetFestival.Cancion, String.Format("{0}%", TextEdit1.EditValue))
    End Sub

    Private Function DameIdCancion() As Integer
        Try
            Return GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "IDCancion")
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Private Function DameNombreCancion() As String
        Try
            Return GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "Nombre")
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Private Sub CancionGridControl_DoubleClick(sender As System.Object, e As System.EventArgs) Handles CancionGridControl.DoubleClick
        Dim id As Integer = DameIdCancion()
        Dim nombre As String = DameNombreCancion()

        With XFormAgregarParticipante
            .lblCancion.Text = nombre
            .IdCancionTextEdit.EditValue = id
            .Show()
            .Focus()
        End With

        Close()
    End Sub
End Class