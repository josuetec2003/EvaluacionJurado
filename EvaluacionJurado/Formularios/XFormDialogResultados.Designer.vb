<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class XFormDialogResultados
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.DataSetFestival = New EvaluacionJurado.DataSetFestival()
        Me.EvaluacionPorJuezBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EvaluacionPorJuezTableAdapter = New EvaluacionJurado.DataSetFestivalTableAdapters.EvaluacionPorJuezTableAdapter()
        Me.TableAdapterManager = New EvaluacionJurado.DataSetFestivalTableAdapters.TableAdapterManager()
        Me.EvaluacionPorJuezGridControl = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colNombre = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coleval1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coleval2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coleval3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coleval4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coleval5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coleval6 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coleval7 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTotal = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.DataSetFestival, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EvaluacionPorJuezBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EvaluacionPorJuezGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataSetFestival
        '
        Me.DataSetFestival.DataSetName = "DataSetFestival"
        Me.DataSetFestival.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'EvaluacionPorJuezBindingSource
        '
        Me.EvaluacionPorJuezBindingSource.DataMember = "EvaluacionPorJuez"
        Me.EvaluacionPorJuezBindingSource.DataSource = Me.DataSetFestival
        '
        'EvaluacionPorJuezTableAdapter
        '
        Me.EvaluacionPorJuezTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CancionTableAdapter = Nothing
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.EvaluacionTableAdapter = Nothing
        Me.TableAdapterManager.FestivalTableAdapter = Nothing
        Me.TableAdapterManager.InstitutoTableAdapter = Nothing
        Me.TableAdapterManager.JuecesTableAdapter = Nothing
        Me.TableAdapterManager.ParticipanteTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = EvaluacionJurado.DataSetFestivalTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'EvaluacionPorJuezGridControl
        '
        Me.EvaluacionPorJuezGridControl.AllowRestoreSelectionAndFocusedRow = DevExpress.Utils.DefaultBoolean.[Default]
        Me.EvaluacionPorJuezGridControl.DataSource = Me.EvaluacionPorJuezBindingSource
        Me.EvaluacionPorJuezGridControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EvaluacionPorJuezGridControl.EmbeddedNavigator.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.[Default]
        Me.EvaluacionPorJuezGridControl.EmbeddedNavigator.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.EvaluacionPorJuezGridControl.EmbeddedNavigator.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.EvaluacionPorJuezGridControl.EmbeddedNavigator.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.EvaluacionPorJuezGridControl.EmbeddedNavigator.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.EvaluacionPorJuezGridControl.EmbeddedNavigator.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.EvaluacionPorJuezGridControl.EmbeddedNavigator.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.EvaluacionPorJuezGridControl.EmbeddedNavigator.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.[Default]
        Me.EvaluacionPorJuezGridControl.EmbeddedNavigator.TextLocation = DevExpress.XtraEditors.NavigatorButtonsTextLocation.Center
        Me.EvaluacionPorJuezGridControl.EmbeddedNavigator.ToolTipIconType = DevExpress.Utils.ToolTipIconType.None
        Me.EvaluacionPorJuezGridControl.Location = New System.Drawing.Point(0, 0)
        Me.EvaluacionPorJuezGridControl.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin
        Me.EvaluacionPorJuezGridControl.MainView = Me.GridView1
        Me.EvaluacionPorJuezGridControl.Name = "EvaluacionPorJuezGridControl"
        Me.EvaluacionPorJuezGridControl.Size = New System.Drawing.Size(1022, 427)
        Me.EvaluacionPorJuezGridControl.TabIndex = 2
        Me.EvaluacionPorJuezGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Appearance.ColumnFilterButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.GridView1.Appearance.ColumnFilterButton.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.GridView1.Appearance.ColumnFilterButton.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.GridView1.Appearance.ColumnFilterButton.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.GridView1.Appearance.ColumnFilterButton.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.GridView1.Appearance.ColumnFilterButton.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.GridView1.Appearance.ColumnFilterButtonActive.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.GridView1.Appearance.ColumnFilterButtonActive.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.GridView1.Appearance.ColumnFilterButtonActive.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.GridView1.Appearance.ColumnFilterButtonActive.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.GridView1.Appearance.ColumnFilterButtonActive.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.GridView1.Appearance.ColumnFilterButtonActive.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.GridView1.Appearance.CustomizationFormHint.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.GridView1.Appearance.CustomizationFormHint.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.GridView1.Appearance.CustomizationFormHint.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.GridView1.Appearance.CustomizationFormHint.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.GridView1.Appearance.CustomizationFormHint.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.GridView1.Appearance.CustomizationFormHint.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.GridView1.Appearance.DetailTip.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.GridView1.Appearance.DetailTip.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.GridView1.Appearance.DetailTip.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.GridView1.Appearance.DetailTip.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.GridView1.Appearance.DetailTip.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.GridView1.Appearance.DetailTip.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.GridView1.Appearance.Empty.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.GridView1.Appearance.Empty.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.GridView1.Appearance.Empty.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.GridView1.Appearance.Empty.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.GridView1.Appearance.Empty.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.GridView1.Appearance.Empty.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.GridView1.Appearance.EvenRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.GridView1.Appearance.EvenRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.GridView1.Appearance.EvenRow.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.GridView1.Appearance.EvenRow.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.GridView1.Appearance.EvenRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.GridView1.Appearance.EvenRow.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.GridView1.Appearance.FilterCloseButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.GridView1.Appearance.FilterCloseButton.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.GridView1.Appearance.FilterCloseButton.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.GridView1.Appearance.FilterCloseButton.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.GridView1.Appearance.FilterCloseButton.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.GridView1.Appearance.FilterCloseButton.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.GridView1.Appearance.FilterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.GridView1.Appearance.FilterPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.GridView1.Appearance.FilterPanel.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.GridView1.Appearance.FilterPanel.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.GridView1.Appearance.FilterPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.GridView1.Appearance.FilterPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.GridView1.Appearance.FixedLine.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.GridView1.Appearance.FixedLine.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.GridView1.Appearance.FixedLine.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.GridView1.Appearance.FixedLine.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.GridView1.Appearance.FixedLine.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.GridView1.Appearance.FixedLine.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.GridView1.Appearance.FocusedCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.GridView1.Appearance.FocusedCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.GridView1.Appearance.FocusedCell.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.GridView1.Appearance.FocusedCell.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.GridView1.Appearance.FocusedCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.GridView1.Appearance.FocusedCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.GridView1.Appearance.FocusedRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.GridView1.Appearance.FocusedRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.GridView1.Appearance.FocusedRow.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.GridView1.Appearance.FocusedRow.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.GridView1.Appearance.FocusedRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.GridView1.Appearance.FocusedRow.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.GridView1.Appearance.FooterPanel.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.GridView1.Appearance.FooterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.GridView1.Appearance.FooterPanel.Options.UseFont = True
        Me.GridView1.Appearance.FooterPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.GridView1.Appearance.FooterPanel.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.GridView1.Appearance.FooterPanel.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.GridView1.Appearance.FooterPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.GridView1.Appearance.FooterPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.GridView1.Appearance.GroupButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.GridView1.Appearance.GroupButton.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.GridView1.Appearance.GroupButton.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.GridView1.Appearance.GroupButton.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.GridView1.Appearance.GroupButton.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.GridView1.Appearance.GroupButton.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.GridView1.Appearance.GroupFooter.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.GridView1.Appearance.GroupFooter.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.GridView1.Appearance.GroupFooter.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.GridView1.Appearance.GroupFooter.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.GridView1.Appearance.GroupFooter.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.GridView1.Appearance.GroupFooter.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.GridView1.Appearance.GroupPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.GridView1.Appearance.GroupPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.GridView1.Appearance.GroupPanel.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.GridView1.Appearance.GroupPanel.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.GridView1.Appearance.GroupPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.GridView1.Appearance.GroupPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.GridView1.Appearance.GroupRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.GridView1.Appearance.GroupRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.GridView1.Appearance.GroupRow.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.GridView1.Appearance.GroupRow.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.GridView1.Appearance.GroupRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.GridView1.Appearance.GroupRow.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.GridView1.Appearance.HeaderPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.GridView1.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.GridView1.Appearance.HeaderPanel.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.GridView1.Appearance.HeaderPanel.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.GridView1.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.GridView1.Appearance.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.GridView1.Appearance.HideSelectionRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.GridView1.Appearance.HideSelectionRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.GridView1.Appearance.HideSelectionRow.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.GridView1.Appearance.HideSelectionRow.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.GridView1.Appearance.HideSelectionRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.GridView1.Appearance.HideSelectionRow.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.GridView1.Appearance.HorzLine.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.GridView1.Appearance.HorzLine.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.GridView1.Appearance.HorzLine.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.GridView1.Appearance.HorzLine.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.GridView1.Appearance.HorzLine.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.GridView1.Appearance.HorzLine.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.GridView1.Appearance.OddRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.GridView1.Appearance.OddRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.GridView1.Appearance.OddRow.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.GridView1.Appearance.OddRow.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.GridView1.Appearance.OddRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.GridView1.Appearance.OddRow.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.GridView1.Appearance.Preview.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.GridView1.Appearance.Preview.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.GridView1.Appearance.Preview.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.GridView1.Appearance.Preview.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.GridView1.Appearance.Preview.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.GridView1.Appearance.Preview.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.GridView1.Appearance.Row.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.GridView1.Appearance.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.GridView1.Appearance.Row.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.GridView1.Appearance.Row.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.GridView1.Appearance.Row.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.GridView1.Appearance.Row.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.GridView1.Appearance.RowSeparator.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.GridView1.Appearance.RowSeparator.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.GridView1.Appearance.RowSeparator.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.GridView1.Appearance.RowSeparator.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.GridView1.Appearance.RowSeparator.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.GridView1.Appearance.RowSeparator.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.GridView1.Appearance.SelectedRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.GridView1.Appearance.SelectedRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.GridView1.Appearance.SelectedRow.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.GridView1.Appearance.SelectedRow.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.GridView1.Appearance.SelectedRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.GridView1.Appearance.SelectedRow.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.GridView1.Appearance.TopNewRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.GridView1.Appearance.TopNewRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.GridView1.Appearance.TopNewRow.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.GridView1.Appearance.TopNewRow.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.GridView1.Appearance.TopNewRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.GridView1.Appearance.TopNewRow.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.GridView1.Appearance.VertLine.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.GridView1.Appearance.VertLine.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.GridView1.Appearance.VertLine.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.GridView1.Appearance.VertLine.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.GridView1.Appearance.VertLine.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.GridView1.Appearance.VertLine.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.GridView1.Appearance.ViewCaption.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.GridView1.Appearance.ViewCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.GridView1.Appearance.ViewCaption.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.GridView1.Appearance.ViewCaption.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.GridView1.Appearance.ViewCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.GridView1.Appearance.ViewCaption.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.GridView1.AppearancePrint.EvenRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.GridView1.AppearancePrint.EvenRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.GridView1.AppearancePrint.EvenRow.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.GridView1.AppearancePrint.EvenRow.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.GridView1.AppearancePrint.EvenRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.GridView1.AppearancePrint.EvenRow.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.GridView1.AppearancePrint.FilterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.GridView1.AppearancePrint.FilterPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.GridView1.AppearancePrint.FilterPanel.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.GridView1.AppearancePrint.FilterPanel.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.GridView1.AppearancePrint.FilterPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.GridView1.AppearancePrint.FilterPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.GridView1.AppearancePrint.FooterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.GridView1.AppearancePrint.FooterPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.GridView1.AppearancePrint.FooterPanel.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.GridView1.AppearancePrint.FooterPanel.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.GridView1.AppearancePrint.FooterPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.GridView1.AppearancePrint.FooterPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.GridView1.AppearancePrint.GroupFooter.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.GridView1.AppearancePrint.GroupFooter.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.GridView1.AppearancePrint.GroupFooter.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.GridView1.AppearancePrint.GroupFooter.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.GridView1.AppearancePrint.GroupFooter.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.GridView1.AppearancePrint.GroupFooter.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.GridView1.AppearancePrint.GroupRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.GridView1.AppearancePrint.GroupRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.GridView1.AppearancePrint.GroupRow.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.GridView1.AppearancePrint.GroupRow.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.GridView1.AppearancePrint.GroupRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.GridView1.AppearancePrint.GroupRow.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.GridView1.AppearancePrint.HeaderPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.GridView1.AppearancePrint.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.GridView1.AppearancePrint.HeaderPanel.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.GridView1.AppearancePrint.HeaderPanel.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.GridView1.AppearancePrint.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.GridView1.AppearancePrint.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.GridView1.AppearancePrint.Lines.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.GridView1.AppearancePrint.Lines.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.GridView1.AppearancePrint.Lines.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.GridView1.AppearancePrint.Lines.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.GridView1.AppearancePrint.Lines.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.GridView1.AppearancePrint.Lines.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.GridView1.AppearancePrint.OddRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.GridView1.AppearancePrint.OddRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.GridView1.AppearancePrint.OddRow.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.GridView1.AppearancePrint.OddRow.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.GridView1.AppearancePrint.OddRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.GridView1.AppearancePrint.OddRow.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.GridView1.AppearancePrint.Preview.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.GridView1.AppearancePrint.Preview.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.GridView1.AppearancePrint.Preview.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.GridView1.AppearancePrint.Preview.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.GridView1.AppearancePrint.Preview.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.GridView1.AppearancePrint.Preview.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.GridView1.AppearancePrint.Row.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.GridView1.AppearancePrint.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.GridView1.AppearancePrint.Row.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.GridView1.AppearancePrint.Row.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.GridView1.AppearancePrint.Row.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.GridView1.AppearancePrint.Row.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.GridView1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.[Default]
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colNombre, Me.coleval1, Me.coleval2, Me.coleval3, Me.coleval4, Me.coleval5, Me.coleval6, Me.coleval7, Me.colTotal})
        Me.GridView1.DetailTabHeaderLocation = DevExpress.XtraTab.TabHeaderLocation.Top
        Me.GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.CellFocus
        Me.GridView1.GridControl = Me.EvaluacionPorJuezGridControl
        Me.GridView1.GroupFooterShowMode = DevExpress.XtraGrid.Views.Grid.GroupFooterShowMode.VisibleIfExpanded
        Me.GridView1.GroupPanelText = "Evaluaciones por juez"
        Me.GridView1.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.[Auto]
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[Default]
        Me.GridView1.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[Default]
        Me.GridView1.OptionsBehavior.CacheValuesOnRowUpdating = DevExpress.Data.CacheRowValuesMode.CacheAll
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.[Default]
        Me.GridView1.OptionsCustomization.AllowGroup = False
        Me.GridView1.OptionsDetail.SmartDetailExpandButtonMode = DevExpress.XtraGrid.Views.Grid.DetailExpandButtonMode.[Default]
        Me.GridView1.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect
        Me.GridView1.OptionsView.AnimationType = DevExpress.XtraGrid.Views.Base.GridAnimationType.[Default]
        Me.GridView1.OptionsView.GroupDrawMode = DevExpress.XtraGrid.Views.Grid.GroupDrawMode.[Default]
        Me.GridView1.OptionsView.HeaderFilterButtonShowMode = DevExpress.XtraEditors.Controls.FilterButtonShowMode.[Default]
        Me.GridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.None
        Me.GridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.[Default]
        Me.GridView1.OptionsView.ShowFooter = True
        Me.GridView1.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowForFocusedCell
        Me.GridView1.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.[Auto]
        '
        'colNombre
        '
        Me.colNombre.AppearanceCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.colNombre.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.colNombre.AppearanceCell.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.colNombre.AppearanceCell.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.colNombre.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.colNombre.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.colNombre.AppearanceHeader.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.colNombre.AppearanceHeader.Options.UseTextOptions = True
        Me.colNombre.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colNombre.AppearanceHeader.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.colNombre.AppearanceHeader.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.colNombre.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.colNombre.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.colNombre.Caption = "Nombre del Juez"
        Me.colNombre.FieldName = "Nombre"
        Me.colNombre.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.Value
        Me.colNombre.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.None
        Me.colNombre.GroupInterval = DevExpress.XtraGrid.ColumnGroupInterval.[Default]
        Me.colNombre.ImageAlignment = System.Drawing.StringAlignment.Near
        Me.colNombre.Name = "colNombre"
        Me.colNombre.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colNombre.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colNombre.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colNombre.OptionsColumn.ReadOnly = True
        Me.colNombre.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.[Default]
        Me.colNombre.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.[Default]
        Me.colNombre.OptionsFilter.ImmediateUpdatePopupDateFilterOnCheck = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colNombre.OptionsFilter.ImmediateUpdatePopupDateFilterOnDateChange = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colNombre.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.[Default]
        Me.colNombre.SortMode = DevExpress.XtraGrid.ColumnSortMode.[Default]
        Me.colNombre.UnboundType = DevExpress.Data.UnboundColumnType.Bound
        Me.colNombre.Visible = True
        Me.colNombre.VisibleIndex = 0
        '
        'coleval1
        '
        Me.coleval1.AppearanceCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.coleval1.AppearanceCell.Options.UseTextOptions = True
        Me.coleval1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.coleval1.AppearanceCell.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.coleval1.AppearanceCell.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.coleval1.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.coleval1.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.coleval1.AppearanceHeader.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.coleval1.AppearanceHeader.Options.UseTextOptions = True
        Me.coleval1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.coleval1.AppearanceHeader.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.coleval1.AppearanceHeader.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.coleval1.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.coleval1.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.coleval1.Caption = "Calidad de voz"
        Me.coleval1.FieldName = "eval1"
        Me.coleval1.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.Value
        Me.coleval1.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.None
        Me.coleval1.GroupInterval = DevExpress.XtraGrid.ColumnGroupInterval.[Default]
        Me.coleval1.ImageAlignment = System.Drawing.StringAlignment.Near
        Me.coleval1.Name = "coleval1"
        Me.coleval1.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.[Default]
        Me.coleval1.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.[Default]
        Me.coleval1.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[Default]
        Me.coleval1.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.[Default]
        Me.coleval1.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.[Default]
        Me.coleval1.OptionsFilter.ImmediateUpdatePopupDateFilterOnCheck = DevExpress.Utils.DefaultBoolean.[Default]
        Me.coleval1.OptionsFilter.ImmediateUpdatePopupDateFilterOnDateChange = DevExpress.Utils.DefaultBoolean.[Default]
        Me.coleval1.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.[Default]
        Me.coleval1.SortMode = DevExpress.XtraGrid.ColumnSortMode.[Default]
        Me.coleval1.UnboundType = DevExpress.Data.UnboundColumnType.Bound
        Me.coleval1.Visible = True
        Me.coleval1.VisibleIndex = 1
        '
        'coleval2
        '
        Me.coleval2.AppearanceCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.coleval2.AppearanceCell.Options.UseTextOptions = True
        Me.coleval2.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.coleval2.AppearanceCell.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.coleval2.AppearanceCell.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.coleval2.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.coleval2.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.coleval2.AppearanceHeader.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.coleval2.AppearanceHeader.Options.UseTextOptions = True
        Me.coleval2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.coleval2.AppearanceHeader.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.coleval2.AppearanceHeader.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.coleval2.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.coleval2.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.coleval2.Caption = "Dificultad canción"
        Me.coleval2.FieldName = "eval2"
        Me.coleval2.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.Value
        Me.coleval2.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.None
        Me.coleval2.GroupInterval = DevExpress.XtraGrid.ColumnGroupInterval.[Default]
        Me.coleval2.ImageAlignment = System.Drawing.StringAlignment.Near
        Me.coleval2.Name = "coleval2"
        Me.coleval2.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.[Default]
        Me.coleval2.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.[Default]
        Me.coleval2.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[Default]
        Me.coleval2.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.[Default]
        Me.coleval2.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.[Default]
        Me.coleval2.OptionsFilter.ImmediateUpdatePopupDateFilterOnCheck = DevExpress.Utils.DefaultBoolean.[Default]
        Me.coleval2.OptionsFilter.ImmediateUpdatePopupDateFilterOnDateChange = DevExpress.Utils.DefaultBoolean.[Default]
        Me.coleval2.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.[Default]
        Me.coleval2.SortMode = DevExpress.XtraGrid.ColumnSortMode.[Default]
        Me.coleval2.UnboundType = DevExpress.Data.UnboundColumnType.Bound
        Me.coleval2.Visible = True
        Me.coleval2.VisibleIndex = 2
        '
        'coleval3
        '
        Me.coleval3.AppearanceCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.coleval3.AppearanceCell.Options.UseTextOptions = True
        Me.coleval3.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.coleval3.AppearanceCell.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.coleval3.AppearanceCell.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.coleval3.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.coleval3.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.coleval3.AppearanceHeader.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.coleval3.AppearanceHeader.Options.UseTextOptions = True
        Me.coleval3.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.coleval3.AppearanceHeader.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.coleval3.AppearanceHeader.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.coleval3.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.coleval3.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.coleval3.Caption = "Afinación"
        Me.coleval3.FieldName = "eval3"
        Me.coleval3.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.Value
        Me.coleval3.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.None
        Me.coleval3.GroupInterval = DevExpress.XtraGrid.ColumnGroupInterval.[Default]
        Me.coleval3.ImageAlignment = System.Drawing.StringAlignment.Near
        Me.coleval3.Name = "coleval3"
        Me.coleval3.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.[Default]
        Me.coleval3.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.[Default]
        Me.coleval3.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[Default]
        Me.coleval3.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.[Default]
        Me.coleval3.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.[Default]
        Me.coleval3.OptionsFilter.ImmediateUpdatePopupDateFilterOnCheck = DevExpress.Utils.DefaultBoolean.[Default]
        Me.coleval3.OptionsFilter.ImmediateUpdatePopupDateFilterOnDateChange = DevExpress.Utils.DefaultBoolean.[Default]
        Me.coleval3.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.[Default]
        Me.coleval3.SortMode = DevExpress.XtraGrid.ColumnSortMode.[Default]
        Me.coleval3.UnboundType = DevExpress.Data.UnboundColumnType.Bound
        Me.coleval3.Visible = True
        Me.coleval3.VisibleIndex = 3
        '
        'coleval4
        '
        Me.coleval4.AppearanceCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.coleval4.AppearanceCell.Options.UseTextOptions = True
        Me.coleval4.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.coleval4.AppearanceCell.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.coleval4.AppearanceCell.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.coleval4.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.coleval4.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.coleval4.AppearanceHeader.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.coleval4.AppearanceHeader.Options.UseTextOptions = True
        Me.coleval4.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.coleval4.AppearanceHeader.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.coleval4.AppearanceHeader.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.coleval4.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.coleval4.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.coleval4.Caption = "Dicción"
        Me.coleval4.FieldName = "eval4"
        Me.coleval4.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.Value
        Me.coleval4.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.None
        Me.coleval4.GroupInterval = DevExpress.XtraGrid.ColumnGroupInterval.[Default]
        Me.coleval4.ImageAlignment = System.Drawing.StringAlignment.Near
        Me.coleval4.Name = "coleval4"
        Me.coleval4.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.[Default]
        Me.coleval4.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.[Default]
        Me.coleval4.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[Default]
        Me.coleval4.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.[Default]
        Me.coleval4.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.[Default]
        Me.coleval4.OptionsFilter.ImmediateUpdatePopupDateFilterOnCheck = DevExpress.Utils.DefaultBoolean.[Default]
        Me.coleval4.OptionsFilter.ImmediateUpdatePopupDateFilterOnDateChange = DevExpress.Utils.DefaultBoolean.[Default]
        Me.coleval4.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.[Default]
        Me.coleval4.SortMode = DevExpress.XtraGrid.ColumnSortMode.[Default]
        Me.coleval4.UnboundType = DevExpress.Data.UnboundColumnType.Bound
        Me.coleval4.Visible = True
        Me.coleval4.VisibleIndex = 4
        '
        'coleval5
        '
        Me.coleval5.AppearanceCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.coleval5.AppearanceCell.Options.UseTextOptions = True
        Me.coleval5.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.coleval5.AppearanceCell.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.coleval5.AppearanceCell.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.coleval5.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.coleval5.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.coleval5.AppearanceHeader.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.coleval5.AppearanceHeader.Options.UseTextOptions = True
        Me.coleval5.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.coleval5.AppearanceHeader.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.coleval5.AppearanceHeader.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.coleval5.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.coleval5.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.coleval5.Caption = "Expresión"
        Me.coleval5.FieldName = "eval5"
        Me.coleval5.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.Value
        Me.coleval5.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.None
        Me.coleval5.GroupInterval = DevExpress.XtraGrid.ColumnGroupInterval.[Default]
        Me.coleval5.ImageAlignment = System.Drawing.StringAlignment.Near
        Me.coleval5.Name = "coleval5"
        Me.coleval5.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.[Default]
        Me.coleval5.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.[Default]
        Me.coleval5.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[Default]
        Me.coleval5.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.[Default]
        Me.coleval5.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.[Default]
        Me.coleval5.OptionsFilter.ImmediateUpdatePopupDateFilterOnCheck = DevExpress.Utils.DefaultBoolean.[Default]
        Me.coleval5.OptionsFilter.ImmediateUpdatePopupDateFilterOnDateChange = DevExpress.Utils.DefaultBoolean.[Default]
        Me.coleval5.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.[Default]
        Me.coleval5.SortMode = DevExpress.XtraGrid.ColumnSortMode.[Default]
        Me.coleval5.UnboundType = DevExpress.Data.UnboundColumnType.Bound
        Me.coleval5.Visible = True
        Me.coleval5.VisibleIndex = 5
        '
        'coleval6
        '
        Me.coleval6.AppearanceCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.coleval6.AppearanceCell.Options.UseTextOptions = True
        Me.coleval6.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.coleval6.AppearanceCell.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.coleval6.AppearanceCell.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.coleval6.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.coleval6.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.coleval6.AppearanceHeader.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.coleval6.AppearanceHeader.Options.UseTextOptions = True
        Me.coleval6.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.coleval6.AppearanceHeader.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.coleval6.AppearanceHeader.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.coleval6.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.coleval6.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.coleval6.Caption = "Métrica"
        Me.coleval6.FieldName = "eval6"
        Me.coleval6.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.Value
        Me.coleval6.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.None
        Me.coleval6.GroupInterval = DevExpress.XtraGrid.ColumnGroupInterval.[Default]
        Me.coleval6.ImageAlignment = System.Drawing.StringAlignment.Near
        Me.coleval6.Name = "coleval6"
        Me.coleval6.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.[Default]
        Me.coleval6.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.[Default]
        Me.coleval6.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[Default]
        Me.coleval6.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.[Default]
        Me.coleval6.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.[Default]
        Me.coleval6.OptionsFilter.ImmediateUpdatePopupDateFilterOnCheck = DevExpress.Utils.DefaultBoolean.[Default]
        Me.coleval6.OptionsFilter.ImmediateUpdatePopupDateFilterOnDateChange = DevExpress.Utils.DefaultBoolean.[Default]
        Me.coleval6.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.[Default]
        Me.coleval6.SortMode = DevExpress.XtraGrid.ColumnSortMode.[Default]
        Me.coleval6.UnboundType = DevExpress.Data.UnboundColumnType.Bound
        Me.coleval6.Visible = True
        Me.coleval6.VisibleIndex = 6
        '
        'coleval7
        '
        Me.coleval7.AppearanceCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.coleval7.AppearanceCell.Options.UseTextOptions = True
        Me.coleval7.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.coleval7.AppearanceCell.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.coleval7.AppearanceCell.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.coleval7.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.coleval7.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.coleval7.AppearanceHeader.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.coleval7.AppearanceHeader.Options.UseTextOptions = True
        Me.coleval7.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.coleval7.AppearanceHeader.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.coleval7.AppearanceHeader.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.coleval7.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.coleval7.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.coleval7.Caption = "Presentación personal"
        Me.coleval7.FieldName = "eval7"
        Me.coleval7.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.Value
        Me.coleval7.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.None
        Me.coleval7.GroupInterval = DevExpress.XtraGrid.ColumnGroupInterval.[Default]
        Me.coleval7.ImageAlignment = System.Drawing.StringAlignment.Near
        Me.coleval7.Name = "coleval7"
        Me.coleval7.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.[Default]
        Me.coleval7.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.[Default]
        Me.coleval7.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[Default]
        Me.coleval7.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.[Default]
        Me.coleval7.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.[Default]
        Me.coleval7.OptionsFilter.ImmediateUpdatePopupDateFilterOnCheck = DevExpress.Utils.DefaultBoolean.[Default]
        Me.coleval7.OptionsFilter.ImmediateUpdatePopupDateFilterOnDateChange = DevExpress.Utils.DefaultBoolean.[Default]
        Me.coleval7.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.[Default]
        Me.coleval7.SortMode = DevExpress.XtraGrid.ColumnSortMode.[Default]
        Me.coleval7.UnboundType = DevExpress.Data.UnboundColumnType.Bound
        Me.coleval7.Visible = True
        Me.coleval7.VisibleIndex = 7
        '
        'colTotal
        '
        Me.colTotal.AppearanceCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.colTotal.AppearanceCell.Options.UseTextOptions = True
        Me.colTotal.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colTotal.AppearanceCell.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.colTotal.AppearanceCell.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.colTotal.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.colTotal.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.colTotal.AppearanceHeader.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.colTotal.AppearanceHeader.Options.UseTextOptions = True
        Me.colTotal.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colTotal.AppearanceHeader.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.colTotal.AppearanceHeader.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.colTotal.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.colTotal.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.colTotal.FieldName = "Total"
        Me.colTotal.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.Value
        Me.colTotal.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.None
        Me.colTotal.GroupInterval = DevExpress.XtraGrid.ColumnGroupInterval.[Default]
        Me.colTotal.ImageAlignment = System.Drawing.StringAlignment.Near
        Me.colTotal.Name = "colTotal"
        Me.colTotal.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colTotal.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colTotal.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colTotal.OptionsColumn.ReadOnly = True
        Me.colTotal.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.[Default]
        Me.colTotal.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.[Default]
        Me.colTotal.OptionsFilter.ImmediateUpdatePopupDateFilterOnCheck = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colTotal.OptionsFilter.ImmediateUpdatePopupDateFilterOnDateChange = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colTotal.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.[Default]
        Me.colTotal.SortMode = DevExpress.XtraGrid.ColumnSortMode.[Default]
        Me.colTotal.SummaryItem.DisplayFormat = "Total general: {0}"
        Me.colTotal.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.colTotal.UnboundType = DevExpress.Data.UnboundColumnType.Bound
        Me.colTotal.Visible = True
        Me.colTotal.VisibleIndex = 8
        '
        'XFormDialogResultados
        '
        Me.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1022, 427)
        Me.Controls.Add(Me.EvaluacionPorJuezGridControl)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "XFormDialogResultados"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Resultados por Juez"
        CType(Me.DataSetFestival, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EvaluacionPorJuezBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EvaluacionPorJuezGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataSetFestival As EvaluacionJurado.DataSetFestival
    Friend WithEvents EvaluacionPorJuezBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EvaluacionPorJuezTableAdapter As EvaluacionJurado.DataSetFestivalTableAdapters.EvaluacionPorJuezTableAdapter
    Friend WithEvents TableAdapterManager As EvaluacionJurado.DataSetFestivalTableAdapters.TableAdapterManager
    Friend WithEvents EvaluacionPorJuezGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colNombre As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coleval1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coleval2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coleval3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coleval4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coleval5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coleval6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coleval7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTotal As DevExpress.XtraGrid.Columns.GridColumn
End Class
