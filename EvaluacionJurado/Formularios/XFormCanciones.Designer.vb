<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class XFormCanciones
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
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.btnAgregarCancion = New DevExpress.XtraEditors.SimpleButton()
        Me.CancionGridControl = New DevExpress.XtraGrid.GridControl()
        Me.CancionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSetFestival = New EvaluacionJurado.DataSetFestival()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colIDCancion = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNombre = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colInterprete = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colGenero = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.CancionTableAdapter = New EvaluacionJurado.DataSetFestivalTableAdapters.CancionTableAdapter()
        Me.TableAdapterManager = New EvaluacionJurado.DataSetFestivalTableAdapters.TableAdapterManager()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.CancionGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CancionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSetFestival, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelControl1
        '
        Me.PanelControl1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PanelControl1.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.PanelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.PanelControl1.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.PanelControl1.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.PanelControl1.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.PanelControl1.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.PanelControl1.ContentImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.PanelControl1.Controls.Add(Me.btnAgregarCancion)
        Me.PanelControl1.Controls.Add(Me.CancionGridControl)
        Me.PanelControl1.Location = New System.Drawing.Point(43, 37)
        Me.PanelControl1.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(798, 324)
        Me.PanelControl1.TabIndex = 0
        '
        'btnAgregarCancion
        '
        Me.btnAgregarCancion.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.[Default]
        Me.btnAgregarCancion.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.btnAgregarCancion.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.btnAgregarCancion.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.btnAgregarCancion.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.btnAgregarCancion.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.btnAgregarCancion.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.btnAgregarCancion.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.[Default]
        Me.btnAgregarCancion.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnAgregarCancion.ImageLocation = DevExpress.XtraEditors.ImageLocation.[Default]
        Me.btnAgregarCancion.Location = New System.Drawing.Point(22, 8)
        Me.btnAgregarCancion.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin
        Me.btnAgregarCancion.Name = "btnAgregarCancion"
        Me.btnAgregarCancion.Size = New System.Drawing.Size(111, 28)
        Me.btnAgregarCancion.TabIndex = 1
        Me.btnAgregarCancion.Text = "Agregar canción"
        Me.btnAgregarCancion.ToolTipIconType = DevExpress.Utils.ToolTipIconType.None
        '
        'CancionGridControl
        '
        Me.CancionGridControl.AllowRestoreSelectionAndFocusedRow = DevExpress.Utils.DefaultBoolean.[Default]
        Me.CancionGridControl.DataSource = Me.CancionBindingSource
        Me.CancionGridControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CancionGridControl.EmbeddedNavigator.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.[Default]
        Me.CancionGridControl.EmbeddedNavigator.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.CancionGridControl.EmbeddedNavigator.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.CancionGridControl.EmbeddedNavigator.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.CancionGridControl.EmbeddedNavigator.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.CancionGridControl.EmbeddedNavigator.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.CancionGridControl.EmbeddedNavigator.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.CancionGridControl.EmbeddedNavigator.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.[Default]
        Me.CancionGridControl.EmbeddedNavigator.TextLocation = DevExpress.XtraEditors.NavigatorButtonsTextLocation.Center
        Me.CancionGridControl.EmbeddedNavigator.ToolTipIconType = DevExpress.Utils.ToolTipIconType.None
        Me.CancionGridControl.Location = New System.Drawing.Point(3, 3)
        Me.CancionGridControl.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin
        Me.CancionGridControl.MainView = Me.GridView1
        Me.CancionGridControl.Name = "CancionGridControl"
        Me.CancionGridControl.Size = New System.Drawing.Size(792, 318)
        Me.CancionGridControl.TabIndex = 0
        Me.CancionGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'CancionBindingSource
        '
        Me.CancionBindingSource.DataMember = "Cancion"
        Me.CancionBindingSource.DataSource = Me.DataSetFestival
        '
        'DataSetFestival
        '
        Me.DataSetFestival.DataSetName = "DataSetFestival"
        Me.DataSetFestival.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        Me.GridView1.Appearance.FooterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
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
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colIDCancion, Me.colNombre, Me.colInterprete, Me.colGenero})
        Me.GridView1.DetailTabHeaderLocation = DevExpress.XtraTab.TabHeaderLocation.Top
        Me.GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.CellFocus
        Me.GridView1.GridControl = Me.CancionGridControl
        Me.GridView1.GroupFooterShowMode = DevExpress.XtraGrid.Views.Grid.GroupFooterShowMode.VisibleIfExpanded
        Me.GridView1.GroupPanelText = " "
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
        Me.GridView1.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowForFocusedCell
        Me.GridView1.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.[Auto]
        '
        'colIDCancion
        '
        Me.colIDCancion.AppearanceCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.colIDCancion.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.colIDCancion.AppearanceCell.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.colIDCancion.AppearanceCell.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.colIDCancion.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.colIDCancion.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.colIDCancion.AppearanceHeader.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.colIDCancion.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.colIDCancion.AppearanceHeader.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.colIDCancion.AppearanceHeader.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.colIDCancion.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.colIDCancion.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.colIDCancion.FieldName = "IDCancion"
        Me.colIDCancion.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.Value
        Me.colIDCancion.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.None
        Me.colIDCancion.GroupInterval = DevExpress.XtraGrid.ColumnGroupInterval.[Default]
        Me.colIDCancion.ImageAlignment = System.Drawing.StringAlignment.Near
        Me.colIDCancion.Name = "colIDCancion"
        Me.colIDCancion.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colIDCancion.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colIDCancion.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colIDCancion.OptionsColumn.ReadOnly = True
        Me.colIDCancion.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.[Default]
        Me.colIDCancion.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.[Default]
        Me.colIDCancion.OptionsFilter.ImmediateUpdatePopupDateFilterOnCheck = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colIDCancion.OptionsFilter.ImmediateUpdatePopupDateFilterOnDateChange = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colIDCancion.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.[Default]
        Me.colIDCancion.SortMode = DevExpress.XtraGrid.ColumnSortMode.[Default]
        Me.colIDCancion.UnboundType = DevExpress.Data.UnboundColumnType.Bound
        Me.colIDCancion.Visible = True
        Me.colIDCancion.VisibleIndex = 0
        Me.colIDCancion.Width = 86
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
        Me.colNombre.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.colNombre.AppearanceHeader.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.colNombre.AppearanceHeader.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.colNombre.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.colNombre.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.colNombre.FieldName = "Nombre"
        Me.colNombre.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.Value
        Me.colNombre.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.None
        Me.colNombre.GroupInterval = DevExpress.XtraGrid.ColumnGroupInterval.[Default]
        Me.colNombre.ImageAlignment = System.Drawing.StringAlignment.Near
        Me.colNombre.Name = "colNombre"
        Me.colNombre.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colNombre.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colNombre.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colNombre.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.[Default]
        Me.colNombre.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.[Default]
        Me.colNombre.OptionsFilter.ImmediateUpdatePopupDateFilterOnCheck = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colNombre.OptionsFilter.ImmediateUpdatePopupDateFilterOnDateChange = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colNombre.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.[Default]
        Me.colNombre.SortMode = DevExpress.XtraGrid.ColumnSortMode.[Default]
        Me.colNombre.UnboundType = DevExpress.Data.UnboundColumnType.Bound
        Me.colNombre.Visible = True
        Me.colNombre.VisibleIndex = 1
        Me.colNombre.Width = 211
        '
        'colInterprete
        '
        Me.colInterprete.AppearanceCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.colInterprete.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.colInterprete.AppearanceCell.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.colInterprete.AppearanceCell.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.colInterprete.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.colInterprete.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.colInterprete.AppearanceHeader.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.colInterprete.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.colInterprete.AppearanceHeader.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.colInterprete.AppearanceHeader.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.colInterprete.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.colInterprete.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.colInterprete.FieldName = "Interprete"
        Me.colInterprete.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.Value
        Me.colInterprete.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.None
        Me.colInterprete.GroupInterval = DevExpress.XtraGrid.ColumnGroupInterval.[Default]
        Me.colInterprete.ImageAlignment = System.Drawing.StringAlignment.Near
        Me.colInterprete.Name = "colInterprete"
        Me.colInterprete.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colInterprete.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colInterprete.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colInterprete.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.[Default]
        Me.colInterprete.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.[Default]
        Me.colInterprete.OptionsFilter.ImmediateUpdatePopupDateFilterOnCheck = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colInterprete.OptionsFilter.ImmediateUpdatePopupDateFilterOnDateChange = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colInterprete.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.[Default]
        Me.colInterprete.SortMode = DevExpress.XtraGrid.ColumnSortMode.[Default]
        Me.colInterprete.UnboundType = DevExpress.Data.UnboundColumnType.Bound
        Me.colInterprete.Visible = True
        Me.colInterprete.VisibleIndex = 2
        Me.colInterprete.Width = 211
        '
        'colGenero
        '
        Me.colGenero.AppearanceCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.colGenero.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.colGenero.AppearanceCell.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.colGenero.AppearanceCell.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.colGenero.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.colGenero.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.colGenero.AppearanceHeader.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.colGenero.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.colGenero.AppearanceHeader.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.colGenero.AppearanceHeader.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.colGenero.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.colGenero.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.colGenero.FieldName = "Genero"
        Me.colGenero.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.Value
        Me.colGenero.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.None
        Me.colGenero.GroupInterval = DevExpress.XtraGrid.ColumnGroupInterval.[Default]
        Me.colGenero.ImageAlignment = System.Drawing.StringAlignment.Near
        Me.colGenero.Name = "colGenero"
        Me.colGenero.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colGenero.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colGenero.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colGenero.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.[Default]
        Me.colGenero.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.[Default]
        Me.colGenero.OptionsFilter.ImmediateUpdatePopupDateFilterOnCheck = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colGenero.OptionsFilter.ImmediateUpdatePopupDateFilterOnDateChange = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colGenero.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.[Default]
        Me.colGenero.SortMode = DevExpress.XtraGrid.ColumnSortMode.[Default]
        Me.colGenero.UnboundType = DevExpress.Data.UnboundColumnType.Bound
        Me.colGenero.Visible = True
        Me.colGenero.VisibleIndex = 3
        Me.colGenero.Width = 214
        '
        'CancionTableAdapter
        '
        Me.CancionTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CancionTableAdapter = Me.CancionTableAdapter
        Me.TableAdapterManager.EvaluacionTableAdapter = Nothing
        Me.TableAdapterManager.FestivalTableAdapter = Nothing
        Me.TableAdapterManager.InstitutoTableAdapter = Nothing
        Me.TableAdapterManager.JuecesTableAdapter = Nothing
        Me.TableAdapterManager.ParticipanteTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = EvaluacionJurado.DataSetFestivalTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'XFormCanciones
        '
        Me.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(903, 391)
        Me.Controls.Add(Me.PanelControl1)
        Me.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin
        Me.Name = "XFormCanciones"
        Me.Text = "Canciones"
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        CType(Me.CancionGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CancionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSetFestival, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents DataSetFestival As EvaluacionJurado.DataSetFestival
    Friend WithEvents CancionBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CancionTableAdapter As EvaluacionJurado.DataSetFestivalTableAdapters.CancionTableAdapter
    Friend WithEvents TableAdapterManager As EvaluacionJurado.DataSetFestivalTableAdapters.TableAdapterManager
    Friend WithEvents btnAgregarCancion As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents CancionGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colIDCancion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNombre As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colInterprete As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colGenero As DevExpress.XtraGrid.Columns.GridColumn
End Class
