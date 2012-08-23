<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class XFormIntitutos
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
        Me.btnAgregarInstituto = New DevExpress.XtraEditors.SimpleButton()
        Me.InstitutoGridControl = New DevExpress.XtraGrid.GridControl()
        Me.InstitutoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSetFestival = New EvaluacionJurado.DataSetFestival()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNombre = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDireccion = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTel = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNombreContacto = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.InstitutoTableAdapter = New EvaluacionJurado.DataSetFestivalTableAdapters.InstitutoTableAdapter()
        Me.TableAdapterManager = New EvaluacionJurado.DataSetFestivalTableAdapters.TableAdapterManager()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.InstitutoGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InstitutoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.PanelControl1.Controls.Add(Me.btnAgregarInstituto)
        Me.PanelControl1.Controls.Add(Me.InstitutoGridControl)
        Me.PanelControl1.Location = New System.Drawing.Point(27, 26)
        Me.PanelControl1.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(1019, 436)
        Me.PanelControl1.TabIndex = 0
        '
        'btnAgregarInstituto
        '
        Me.btnAgregarInstituto.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.[Default]
        Me.btnAgregarInstituto.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.btnAgregarInstituto.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.btnAgregarInstituto.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.btnAgregarInstituto.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.btnAgregarInstituto.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.btnAgregarInstituto.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.btnAgregarInstituto.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.[Default]
        Me.btnAgregarInstituto.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnAgregarInstituto.ImageLocation = DevExpress.XtraEditors.ImageLocation.[Default]
        Me.btnAgregarInstituto.Location = New System.Drawing.Point(20, 8)
        Me.btnAgregarInstituto.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin
        Me.btnAgregarInstituto.Name = "btnAgregarInstituto"
        Me.btnAgregarInstituto.Size = New System.Drawing.Size(117, 28)
        Me.btnAgregarInstituto.TabIndex = 1
        Me.btnAgregarInstituto.Text = "Agregar instituto"
        Me.btnAgregarInstituto.ToolTipIconType = DevExpress.Utils.ToolTipIconType.None
        '
        'InstitutoGridControl
        '
        Me.InstitutoGridControl.AllowRestoreSelectionAndFocusedRow = DevExpress.Utils.DefaultBoolean.[Default]
        Me.InstitutoGridControl.DataSource = Me.InstitutoBindingSource
        Me.InstitutoGridControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.InstitutoGridControl.EmbeddedNavigator.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.[Default]
        Me.InstitutoGridControl.EmbeddedNavigator.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.InstitutoGridControl.EmbeddedNavigator.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.InstitutoGridControl.EmbeddedNavigator.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.InstitutoGridControl.EmbeddedNavigator.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.InstitutoGridControl.EmbeddedNavigator.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.InstitutoGridControl.EmbeddedNavigator.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.InstitutoGridControl.EmbeddedNavigator.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.[Default]
        Me.InstitutoGridControl.EmbeddedNavigator.TextLocation = DevExpress.XtraEditors.NavigatorButtonsTextLocation.Center
        Me.InstitutoGridControl.EmbeddedNavigator.ToolTipIconType = DevExpress.Utils.ToolTipIconType.None
        Me.InstitutoGridControl.Location = New System.Drawing.Point(3, 3)
        Me.InstitutoGridControl.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin
        Me.InstitutoGridControl.MainView = Me.GridView1
        Me.InstitutoGridControl.Name = "InstitutoGridControl"
        Me.InstitutoGridControl.Size = New System.Drawing.Size(1013, 430)
        Me.InstitutoGridControl.TabIndex = 0
        Me.InstitutoGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'InstitutoBindingSource
        '
        Me.InstitutoBindingSource.DataMember = "Instituto"
        Me.InstitutoBindingSource.DataSource = Me.DataSetFestival
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
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colID, Me.colNombre, Me.colDireccion, Me.colTel, Me.colNombreContacto})
        Me.GridView1.DetailTabHeaderLocation = DevExpress.XtraTab.TabHeaderLocation.Top
        Me.GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.CellFocus
        Me.GridView1.GridControl = Me.InstitutoGridControl
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
        'colID
        '
        Me.colID.AppearanceCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.colID.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.colID.AppearanceCell.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.colID.AppearanceCell.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.colID.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.colID.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.colID.AppearanceHeader.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.colID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.colID.AppearanceHeader.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.colID.AppearanceHeader.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.colID.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.colID.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.colID.FieldName = "ID"
        Me.colID.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.Value
        Me.colID.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.None
        Me.colID.GroupInterval = DevExpress.XtraGrid.ColumnGroupInterval.[Default]
        Me.colID.ImageAlignment = System.Drawing.StringAlignment.Near
        Me.colID.Name = "colID"
        Me.colID.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colID.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colID.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colID.OptionsColumn.ReadOnly = True
        Me.colID.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.[Default]
        Me.colID.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.[Default]
        Me.colID.OptionsFilter.ImmediateUpdatePopupDateFilterOnCheck = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colID.OptionsFilter.ImmediateUpdatePopupDateFilterOnDateChange = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colID.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.[Default]
        Me.colID.SortMode = DevExpress.XtraGrid.ColumnSortMode.[Default]
        Me.colID.UnboundType = DevExpress.Data.UnboundColumnType.Bound
        Me.colID.Visible = True
        Me.colID.VisibleIndex = 0
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
        '
        'colDireccion
        '
        Me.colDireccion.AppearanceCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.colDireccion.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.colDireccion.AppearanceCell.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.colDireccion.AppearanceCell.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.colDireccion.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.colDireccion.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.colDireccion.AppearanceHeader.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.colDireccion.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.colDireccion.AppearanceHeader.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.colDireccion.AppearanceHeader.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.colDireccion.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.colDireccion.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.colDireccion.FieldName = "Direccion"
        Me.colDireccion.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.Value
        Me.colDireccion.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.None
        Me.colDireccion.GroupInterval = DevExpress.XtraGrid.ColumnGroupInterval.[Default]
        Me.colDireccion.ImageAlignment = System.Drawing.StringAlignment.Near
        Me.colDireccion.Name = "colDireccion"
        Me.colDireccion.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colDireccion.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colDireccion.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colDireccion.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.[Default]
        Me.colDireccion.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.[Default]
        Me.colDireccion.OptionsFilter.ImmediateUpdatePopupDateFilterOnCheck = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colDireccion.OptionsFilter.ImmediateUpdatePopupDateFilterOnDateChange = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colDireccion.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.[Default]
        Me.colDireccion.SortMode = DevExpress.XtraGrid.ColumnSortMode.[Default]
        Me.colDireccion.UnboundType = DevExpress.Data.UnboundColumnType.Bound
        Me.colDireccion.Visible = True
        Me.colDireccion.VisibleIndex = 2
        '
        'colTel
        '
        Me.colTel.AppearanceCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.colTel.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.colTel.AppearanceCell.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.colTel.AppearanceCell.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.colTel.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.colTel.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.colTel.AppearanceHeader.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.colTel.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.colTel.AppearanceHeader.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.colTel.AppearanceHeader.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.colTel.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.colTel.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.colTel.FieldName = "Tel"
        Me.colTel.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.Value
        Me.colTel.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.None
        Me.colTel.GroupInterval = DevExpress.XtraGrid.ColumnGroupInterval.[Default]
        Me.colTel.ImageAlignment = System.Drawing.StringAlignment.Near
        Me.colTel.Name = "colTel"
        Me.colTel.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colTel.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colTel.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colTel.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.[Default]
        Me.colTel.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.[Default]
        Me.colTel.OptionsFilter.ImmediateUpdatePopupDateFilterOnCheck = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colTel.OptionsFilter.ImmediateUpdatePopupDateFilterOnDateChange = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colTel.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.[Default]
        Me.colTel.SortMode = DevExpress.XtraGrid.ColumnSortMode.[Default]
        Me.colTel.UnboundType = DevExpress.Data.UnboundColumnType.Bound
        Me.colTel.Visible = True
        Me.colTel.VisibleIndex = 3
        '
        'colNombreContacto
        '
        Me.colNombreContacto.AppearanceCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.colNombreContacto.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.colNombreContacto.AppearanceCell.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.colNombreContacto.AppearanceCell.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.colNombreContacto.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.colNombreContacto.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.colNombreContacto.AppearanceHeader.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.colNombreContacto.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.colNombreContacto.AppearanceHeader.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.colNombreContacto.AppearanceHeader.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.colNombreContacto.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.colNombreContacto.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.colNombreContacto.FieldName = "NombreContacto"
        Me.colNombreContacto.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.Value
        Me.colNombreContacto.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.None
        Me.colNombreContacto.GroupInterval = DevExpress.XtraGrid.ColumnGroupInterval.[Default]
        Me.colNombreContacto.ImageAlignment = System.Drawing.StringAlignment.Near
        Me.colNombreContacto.Name = "colNombreContacto"
        Me.colNombreContacto.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colNombreContacto.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colNombreContacto.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colNombreContacto.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.[Default]
        Me.colNombreContacto.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.[Default]
        Me.colNombreContacto.OptionsFilter.ImmediateUpdatePopupDateFilterOnCheck = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colNombreContacto.OptionsFilter.ImmediateUpdatePopupDateFilterOnDateChange = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colNombreContacto.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.[Default]
        Me.colNombreContacto.SortMode = DevExpress.XtraGrid.ColumnSortMode.[Default]
        Me.colNombreContacto.UnboundType = DevExpress.Data.UnboundColumnType.Bound
        Me.colNombreContacto.Visible = True
        Me.colNombreContacto.VisibleIndex = 4
        '
        'InstitutoTableAdapter
        '
        Me.InstitutoTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CancionTableAdapter = Nothing
        Me.TableAdapterManager.EvaluacionTableAdapter = Nothing
        Me.TableAdapterManager.FestivalTableAdapter = Nothing
        Me.TableAdapterManager.InstitutoTableAdapter = Me.InstitutoTableAdapter
        Me.TableAdapterManager.JuecesTableAdapter = Nothing
        Me.TableAdapterManager.ParticipanteTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = EvaluacionJurado.DataSetFestivalTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'XFormIntitutos
        '
        Me.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1093, 474)
        Me.Controls.Add(Me.PanelControl1)
        Me.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin
        Me.Name = "XFormIntitutos"
        Me.Text = "Institutos"
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        CType(Me.InstitutoGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InstitutoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSetFestival, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents DataSetFestival As EvaluacionJurado.DataSetFestival
    Friend WithEvents InstitutoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents InstitutoTableAdapter As EvaluacionJurado.DataSetFestivalTableAdapters.InstitutoTableAdapter
    Friend WithEvents TableAdapterManager As EvaluacionJurado.DataSetFestivalTableAdapters.TableAdapterManager
    Friend WithEvents InstitutoGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNombre As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDireccion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTel As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNombreContacto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnAgregarInstituto As DevExpress.XtraEditors.SimpleButton
End Class
