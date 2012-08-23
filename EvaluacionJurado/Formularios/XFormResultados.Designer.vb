<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class XFormResultados
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
        Dim SerializableAppearanceObject1 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject2 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.ParticipanteGridControl = New DevExpress.XtraGrid.GridControl()
        Me.ParticipanteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSetFestival = New EvaluacionJurado.DataSetFestival()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colIDParticipante = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colOrdenParticipacion = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNombre = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colApellido = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIDFestival = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIdInstituto = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.InstitutoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.colIdCancion = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemLookUpEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.CancionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ParticipanteTableAdapter = New EvaluacionJurado.DataSetFestivalTableAdapters.ParticipanteTableAdapter()
        Me.TableAdapterManager = New EvaluacionJurado.DataSetFestivalTableAdapters.TableAdapterManager()
        Me.CancionTableAdapter = New EvaluacionJurado.DataSetFestivalTableAdapters.CancionTableAdapter()
        Me.InstitutoTableAdapter = New EvaluacionJurado.DataSetFestivalTableAdapters.InstitutoTableAdapter()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.ParticipanteGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ParticipanteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSetFestival, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InstitutoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CancionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.PanelControl1.Controls.Add(Me.ParticipanteGridControl)
        Me.PanelControl1.Location = New System.Drawing.Point(12, 12)
        Me.PanelControl1.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(953, 453)
        Me.PanelControl1.TabIndex = 0
        '
        'ParticipanteGridControl
        '
        Me.ParticipanteGridControl.AllowRestoreSelectionAndFocusedRow = DevExpress.Utils.DefaultBoolean.[Default]
        Me.ParticipanteGridControl.DataSource = Me.ParticipanteBindingSource
        Me.ParticipanteGridControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ParticipanteGridControl.EmbeddedNavigator.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.[Default]
        Me.ParticipanteGridControl.EmbeddedNavigator.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.ParticipanteGridControl.EmbeddedNavigator.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.ParticipanteGridControl.EmbeddedNavigator.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.ParticipanteGridControl.EmbeddedNavigator.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.ParticipanteGridControl.EmbeddedNavigator.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.ParticipanteGridControl.EmbeddedNavigator.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.ParticipanteGridControl.EmbeddedNavigator.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.[Default]
        Me.ParticipanteGridControl.EmbeddedNavigator.TextLocation = DevExpress.XtraEditors.NavigatorButtonsTextLocation.Center
        Me.ParticipanteGridControl.EmbeddedNavigator.ToolTipIconType = DevExpress.Utils.ToolTipIconType.None
        Me.ParticipanteGridControl.Location = New System.Drawing.Point(3, 3)
        Me.ParticipanteGridControl.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin
        Me.ParticipanteGridControl.MainView = Me.GridView1
        Me.ParticipanteGridControl.Name = "ParticipanteGridControl"
        Me.ParticipanteGridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemLookUpEdit1, Me.RepositoryItemLookUpEdit2})
        Me.ParticipanteGridControl.Size = New System.Drawing.Size(947, 447)
        Me.ParticipanteGridControl.TabIndex = 0
        Me.ParticipanteGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'ParticipanteBindingSource
        '
        Me.ParticipanteBindingSource.DataMember = "Participante"
        Me.ParticipanteBindingSource.DataSource = Me.DataSetFestival
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
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colIDParticipante, Me.colOrdenParticipacion, Me.colNombre, Me.colApellido, Me.colIDFestival, Me.colIdInstituto, Me.colIdCancion})
        Me.GridView1.DetailTabHeaderLocation = DevExpress.XtraTab.TabHeaderLocation.Top
        Me.GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.CellFocus
        Me.GridView1.GridControl = Me.ParticipanteGridControl
        Me.GridView1.GroupFooterShowMode = DevExpress.XtraGrid.Views.Grid.GroupFooterShowMode.VisibleIfExpanded
        Me.GridView1.GroupPanelText = " Participantes"
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
        'colIDParticipante
        '
        Me.colIDParticipante.AppearanceCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.colIDParticipante.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.colIDParticipante.AppearanceCell.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.colIDParticipante.AppearanceCell.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.colIDParticipante.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.colIDParticipante.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.colIDParticipante.AppearanceHeader.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.colIDParticipante.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.colIDParticipante.AppearanceHeader.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.colIDParticipante.AppearanceHeader.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.colIDParticipante.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.colIDParticipante.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.colIDParticipante.FieldName = "IDParticipante"
        Me.colIDParticipante.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.Value
        Me.colIDParticipante.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.None
        Me.colIDParticipante.GroupInterval = DevExpress.XtraGrid.ColumnGroupInterval.[Default]
        Me.colIDParticipante.ImageAlignment = System.Drawing.StringAlignment.Near
        Me.colIDParticipante.Name = "colIDParticipante"
        Me.colIDParticipante.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colIDParticipante.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colIDParticipante.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colIDParticipante.OptionsColumn.ReadOnly = True
        Me.colIDParticipante.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.[Default]
        Me.colIDParticipante.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.[Default]
        Me.colIDParticipante.OptionsFilter.ImmediateUpdatePopupDateFilterOnCheck = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colIDParticipante.OptionsFilter.ImmediateUpdatePopupDateFilterOnDateChange = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colIDParticipante.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.[Default]
        Me.colIDParticipante.SortMode = DevExpress.XtraGrid.ColumnSortMode.[Default]
        Me.colIDParticipante.UnboundType = DevExpress.Data.UnboundColumnType.Bound
        '
        'colOrdenParticipacion
        '
        Me.colOrdenParticipacion.AppearanceCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.colOrdenParticipacion.AppearanceCell.Options.UseTextOptions = True
        Me.colOrdenParticipacion.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colOrdenParticipacion.AppearanceCell.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.colOrdenParticipacion.AppearanceCell.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.colOrdenParticipacion.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.colOrdenParticipacion.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.colOrdenParticipacion.AppearanceHeader.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.colOrdenParticipacion.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.colOrdenParticipacion.AppearanceHeader.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.colOrdenParticipacion.AppearanceHeader.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.colOrdenParticipacion.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.colOrdenParticipacion.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.colOrdenParticipacion.Caption = "Orden de participación"
        Me.colOrdenParticipacion.FieldName = "OrdenParticipacion"
        Me.colOrdenParticipacion.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.Value
        Me.colOrdenParticipacion.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.None
        Me.colOrdenParticipacion.GroupInterval = DevExpress.XtraGrid.ColumnGroupInterval.[Default]
        Me.colOrdenParticipacion.ImageAlignment = System.Drawing.StringAlignment.Near
        Me.colOrdenParticipacion.Name = "colOrdenParticipacion"
        Me.colOrdenParticipacion.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colOrdenParticipacion.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colOrdenParticipacion.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colOrdenParticipacion.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.[Default]
        Me.colOrdenParticipacion.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.[Default]
        Me.colOrdenParticipacion.OptionsFilter.ImmediateUpdatePopupDateFilterOnCheck = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colOrdenParticipacion.OptionsFilter.ImmediateUpdatePopupDateFilterOnDateChange = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colOrdenParticipacion.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.[Default]
        Me.colOrdenParticipacion.SortMode = DevExpress.XtraGrid.ColumnSortMode.[Default]
        Me.colOrdenParticipacion.UnboundType = DevExpress.Data.UnboundColumnType.Bound
        Me.colOrdenParticipacion.Visible = True
        Me.colOrdenParticipacion.VisibleIndex = 0
        Me.colOrdenParticipacion.Width = 132
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
        Me.colNombre.Width = 185
        '
        'colApellido
        '
        Me.colApellido.AppearanceCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.colApellido.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.colApellido.AppearanceCell.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.colApellido.AppearanceCell.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.colApellido.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.colApellido.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.colApellido.AppearanceHeader.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.colApellido.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.colApellido.AppearanceHeader.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.colApellido.AppearanceHeader.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.colApellido.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.colApellido.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.colApellido.FieldName = "Apellido"
        Me.colApellido.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.Value
        Me.colApellido.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.None
        Me.colApellido.GroupInterval = DevExpress.XtraGrid.ColumnGroupInterval.[Default]
        Me.colApellido.ImageAlignment = System.Drawing.StringAlignment.Near
        Me.colApellido.Name = "colApellido"
        Me.colApellido.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colApellido.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colApellido.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colApellido.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.[Default]
        Me.colApellido.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.[Default]
        Me.colApellido.OptionsFilter.ImmediateUpdatePopupDateFilterOnCheck = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colApellido.OptionsFilter.ImmediateUpdatePopupDateFilterOnDateChange = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colApellido.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.[Default]
        Me.colApellido.SortMode = DevExpress.XtraGrid.ColumnSortMode.[Default]
        Me.colApellido.UnboundType = DevExpress.Data.UnboundColumnType.Bound
        Me.colApellido.Visible = True
        Me.colApellido.VisibleIndex = 2
        Me.colApellido.Width = 173
        '
        'colIDFestival
        '
        Me.colIDFestival.AppearanceCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.colIDFestival.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.colIDFestival.AppearanceCell.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.colIDFestival.AppearanceCell.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.colIDFestival.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.colIDFestival.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.colIDFestival.AppearanceHeader.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.colIDFestival.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.colIDFestival.AppearanceHeader.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.colIDFestival.AppearanceHeader.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.colIDFestival.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.colIDFestival.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.colIDFestival.FieldName = "IDFestival"
        Me.colIDFestival.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.Value
        Me.colIDFestival.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.None
        Me.colIDFestival.GroupInterval = DevExpress.XtraGrid.ColumnGroupInterval.[Default]
        Me.colIDFestival.ImageAlignment = System.Drawing.StringAlignment.Near
        Me.colIDFestival.Name = "colIDFestival"
        Me.colIDFestival.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colIDFestival.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colIDFestival.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colIDFestival.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.[Default]
        Me.colIDFestival.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.[Default]
        Me.colIDFestival.OptionsFilter.ImmediateUpdatePopupDateFilterOnCheck = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colIDFestival.OptionsFilter.ImmediateUpdatePopupDateFilterOnDateChange = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colIDFestival.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.[Default]
        Me.colIDFestival.SortMode = DevExpress.XtraGrid.ColumnSortMode.[Default]
        Me.colIDFestival.UnboundType = DevExpress.Data.UnboundColumnType.Bound
        '
        'colIdInstituto
        '
        Me.colIdInstituto.AppearanceCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.colIdInstituto.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.colIdInstituto.AppearanceCell.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.colIdInstituto.AppearanceCell.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.colIdInstituto.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.colIdInstituto.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.colIdInstituto.AppearanceHeader.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.colIdInstituto.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.colIdInstituto.AppearanceHeader.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.colIdInstituto.AppearanceHeader.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.colIdInstituto.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.colIdInstituto.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.colIdInstituto.Caption = "Instituto"
        Me.colIdInstituto.ColumnEdit = Me.RepositoryItemLookUpEdit1
        Me.colIdInstituto.FieldName = "IdInstituto"
        Me.colIdInstituto.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.Value
        Me.colIdInstituto.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.None
        Me.colIdInstituto.GroupInterval = DevExpress.XtraGrid.ColumnGroupInterval.[Default]
        Me.colIdInstituto.ImageAlignment = System.Drawing.StringAlignment.Near
        Me.colIdInstituto.Name = "colIdInstituto"
        Me.colIdInstituto.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colIdInstituto.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colIdInstituto.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colIdInstituto.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.[Default]
        Me.colIdInstituto.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.[Default]
        Me.colIdInstituto.OptionsFilter.ImmediateUpdatePopupDateFilterOnCheck = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colIdInstituto.OptionsFilter.ImmediateUpdatePopupDateFilterOnDateChange = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colIdInstituto.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.[Default]
        Me.colIdInstituto.SortMode = DevExpress.XtraGrid.ColumnSortMode.[Default]
        Me.colIdInstituto.UnboundType = DevExpress.Data.UnboundColumnType.Bound
        Me.colIdInstituto.Visible = True
        Me.colIdInstituto.VisibleIndex = 3
        Me.colIdInstituto.Width = 216
        '
        'RepositoryItemLookUpEdit1
        '
        Me.RepositoryItemLookUpEdit1.AccessibleRole = System.Windows.Forms.AccessibleRole.[Default]
        Me.RepositoryItemLookUpEdit1.AllowNullInput = DevExpress.Utils.DefaultBoolean.[Default]
        Me.RepositoryItemLookUpEdit1.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.RepositoryItemLookUpEdit1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.RepositoryItemLookUpEdit1.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.RepositoryItemLookUpEdit1.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.RepositoryItemLookUpEdit1.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.RepositoryItemLookUpEdit1.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.RepositoryItemLookUpEdit1.AppearanceDisabled.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.RepositoryItemLookUpEdit1.AppearanceDisabled.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.RepositoryItemLookUpEdit1.AppearanceDisabled.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.RepositoryItemLookUpEdit1.AppearanceDisabled.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.RepositoryItemLookUpEdit1.AppearanceDisabled.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.RepositoryItemLookUpEdit1.AppearanceDisabled.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.RepositoryItemLookUpEdit1.AppearanceDropDown.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.RepositoryItemLookUpEdit1.AppearanceDropDown.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.RepositoryItemLookUpEdit1.AppearanceDropDown.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.RepositoryItemLookUpEdit1.AppearanceDropDown.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.RepositoryItemLookUpEdit1.AppearanceDropDown.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.RepositoryItemLookUpEdit1.AppearanceDropDown.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.RepositoryItemLookUpEdit1.AppearanceDropDownHeader.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.RepositoryItemLookUpEdit1.AppearanceDropDownHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.RepositoryItemLookUpEdit1.AppearanceDropDownHeader.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.RepositoryItemLookUpEdit1.AppearanceDropDownHeader.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.RepositoryItemLookUpEdit1.AppearanceDropDownHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.RepositoryItemLookUpEdit1.AppearanceDropDownHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.RepositoryItemLookUpEdit1.AppearanceFocused.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.RepositoryItemLookUpEdit1.AppearanceFocused.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.RepositoryItemLookUpEdit1.AppearanceFocused.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.RepositoryItemLookUpEdit1.AppearanceFocused.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.RepositoryItemLookUpEdit1.AppearanceFocused.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.RepositoryItemLookUpEdit1.AppearanceFocused.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.RepositoryItemLookUpEdit1.AppearanceReadOnly.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.RepositoryItemLookUpEdit1.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.RepositoryItemLookUpEdit1.AppearanceReadOnly.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.RepositoryItemLookUpEdit1.AppearanceReadOnly.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.RepositoryItemLookUpEdit1.AppearanceReadOnly.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.RepositoryItemLookUpEdit1.AppearanceReadOnly.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.RepositoryItemLookUpEdit1.AutoHeight = False
        Me.RepositoryItemLookUpEdit1.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.None
        Me.RepositoryItemLookUpEdit1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.[Default]
        SerializableAppearanceObject1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.RepositoryItemLookUpEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo, "", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Nothing, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject1, "", Nothing, Nothing, True)})
        Me.RepositoryItemLookUpEdit1.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.RepositoryItemLookUpEdit1.DataSource = Me.InstitutoBindingSource
        Me.RepositoryItemLookUpEdit1.DisplayMember = "Nombre"
        Me.RepositoryItemLookUpEdit1.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.[Default]
        Me.RepositoryItemLookUpEdit1.ExportMode = DevExpress.XtraEditors.Repository.ExportMode.[Default]
        Me.RepositoryItemLookUpEdit1.HeaderClickMode = DevExpress.XtraEditors.Controls.HeaderClickMode.Sorting
        Me.RepositoryItemLookUpEdit1.HighlightedItemStyle = DevExpress.XtraEditors.HighlightStyle.[Default]
        Me.RepositoryItemLookUpEdit1.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin
        Me.RepositoryItemLookUpEdit1.Name = "RepositoryItemLookUpEdit1"
        Me.RepositoryItemLookUpEdit1.PopupResizeMode = DevExpress.XtraEditors.Controls.ResizeMode.[Default]
        Me.RepositoryItemLookUpEdit1.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoFilter
        Me.RepositoryItemLookUpEdit1.ShowDropDown = DevExpress.XtraEditors.Controls.ShowDropDown.SingleClick
        Me.RepositoryItemLookUpEdit1.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.RepositoryItemLookUpEdit1.ValueMember = "ID"
        '
        'InstitutoBindingSource
        '
        Me.InstitutoBindingSource.DataMember = "Instituto"
        Me.InstitutoBindingSource.DataSource = Me.DataSetFestival
        '
        'colIdCancion
        '
        Me.colIdCancion.AppearanceCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.colIdCancion.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.colIdCancion.AppearanceCell.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.colIdCancion.AppearanceCell.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.colIdCancion.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.colIdCancion.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.colIdCancion.AppearanceHeader.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.colIdCancion.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.colIdCancion.AppearanceHeader.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.colIdCancion.AppearanceHeader.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.colIdCancion.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.colIdCancion.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.colIdCancion.Caption = "Canción"
        Me.colIdCancion.ColumnEdit = Me.RepositoryItemLookUpEdit2
        Me.colIdCancion.FieldName = "IdCancion"
        Me.colIdCancion.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.Value
        Me.colIdCancion.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.None
        Me.colIdCancion.GroupInterval = DevExpress.XtraGrid.ColumnGroupInterval.[Default]
        Me.colIdCancion.ImageAlignment = System.Drawing.StringAlignment.Near
        Me.colIdCancion.Name = "colIdCancion"
        Me.colIdCancion.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colIdCancion.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colIdCancion.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colIdCancion.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.[Default]
        Me.colIdCancion.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.[Default]
        Me.colIdCancion.OptionsFilter.ImmediateUpdatePopupDateFilterOnCheck = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colIdCancion.OptionsFilter.ImmediateUpdatePopupDateFilterOnDateChange = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colIdCancion.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.[Default]
        Me.colIdCancion.SortMode = DevExpress.XtraGrid.ColumnSortMode.[Default]
        Me.colIdCancion.UnboundType = DevExpress.Data.UnboundColumnType.Bound
        Me.colIdCancion.Visible = True
        Me.colIdCancion.VisibleIndex = 4
        Me.colIdCancion.Width = 220
        '
        'RepositoryItemLookUpEdit2
        '
        Me.RepositoryItemLookUpEdit2.AccessibleRole = System.Windows.Forms.AccessibleRole.[Default]
        Me.RepositoryItemLookUpEdit2.AllowNullInput = DevExpress.Utils.DefaultBoolean.[Default]
        Me.RepositoryItemLookUpEdit2.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.RepositoryItemLookUpEdit2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.RepositoryItemLookUpEdit2.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.RepositoryItemLookUpEdit2.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.RepositoryItemLookUpEdit2.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.RepositoryItemLookUpEdit2.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.RepositoryItemLookUpEdit2.AppearanceDisabled.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.RepositoryItemLookUpEdit2.AppearanceDisabled.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.RepositoryItemLookUpEdit2.AppearanceDisabled.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.RepositoryItemLookUpEdit2.AppearanceDisabled.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.RepositoryItemLookUpEdit2.AppearanceDisabled.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.RepositoryItemLookUpEdit2.AppearanceDisabled.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.RepositoryItemLookUpEdit2.AppearanceDropDown.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.RepositoryItemLookUpEdit2.AppearanceDropDown.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.RepositoryItemLookUpEdit2.AppearanceDropDown.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.RepositoryItemLookUpEdit2.AppearanceDropDown.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.RepositoryItemLookUpEdit2.AppearanceDropDown.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.RepositoryItemLookUpEdit2.AppearanceDropDown.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.RepositoryItemLookUpEdit2.AppearanceDropDownHeader.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.RepositoryItemLookUpEdit2.AppearanceDropDownHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.RepositoryItemLookUpEdit2.AppearanceDropDownHeader.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.RepositoryItemLookUpEdit2.AppearanceDropDownHeader.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.RepositoryItemLookUpEdit2.AppearanceDropDownHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.RepositoryItemLookUpEdit2.AppearanceDropDownHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.RepositoryItemLookUpEdit2.AppearanceFocused.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.RepositoryItemLookUpEdit2.AppearanceFocused.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.RepositoryItemLookUpEdit2.AppearanceFocused.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.RepositoryItemLookUpEdit2.AppearanceFocused.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.RepositoryItemLookUpEdit2.AppearanceFocused.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.RepositoryItemLookUpEdit2.AppearanceFocused.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.RepositoryItemLookUpEdit2.AppearanceReadOnly.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.RepositoryItemLookUpEdit2.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.RepositoryItemLookUpEdit2.AppearanceReadOnly.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.RepositoryItemLookUpEdit2.AppearanceReadOnly.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.RepositoryItemLookUpEdit2.AppearanceReadOnly.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.RepositoryItemLookUpEdit2.AppearanceReadOnly.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.RepositoryItemLookUpEdit2.AutoHeight = False
        Me.RepositoryItemLookUpEdit2.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.None
        Me.RepositoryItemLookUpEdit2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.[Default]
        SerializableAppearanceObject2.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.RepositoryItemLookUpEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo, "", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Nothing, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject2, "", Nothing, Nothing, True)})
        Me.RepositoryItemLookUpEdit2.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.RepositoryItemLookUpEdit2.DataSource = Me.CancionBindingSource
        Me.RepositoryItemLookUpEdit2.DisplayMember = "Nombre"
        Me.RepositoryItemLookUpEdit2.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.[Default]
        Me.RepositoryItemLookUpEdit2.ExportMode = DevExpress.XtraEditors.Repository.ExportMode.[Default]
        Me.RepositoryItemLookUpEdit2.HeaderClickMode = DevExpress.XtraEditors.Controls.HeaderClickMode.Sorting
        Me.RepositoryItemLookUpEdit2.HighlightedItemStyle = DevExpress.XtraEditors.HighlightStyle.[Default]
        Me.RepositoryItemLookUpEdit2.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin
        Me.RepositoryItemLookUpEdit2.Name = "RepositoryItemLookUpEdit2"
        Me.RepositoryItemLookUpEdit2.PopupResizeMode = DevExpress.XtraEditors.Controls.ResizeMode.[Default]
        Me.RepositoryItemLookUpEdit2.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoFilter
        Me.RepositoryItemLookUpEdit2.ShowDropDown = DevExpress.XtraEditors.Controls.ShowDropDown.SingleClick
        Me.RepositoryItemLookUpEdit2.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.RepositoryItemLookUpEdit2.ValueMember = "IDCancion"
        '
        'CancionBindingSource
        '
        Me.CancionBindingSource.DataMember = "Cancion"
        Me.CancionBindingSource.DataSource = Me.DataSetFestival
        '
        'ParticipanteTableAdapter
        '
        Me.ParticipanteTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CancionTableAdapter = Me.CancionTableAdapter
        Me.TableAdapterManager.EvaluacionTableAdapter = Nothing
        Me.TableAdapterManager.FestivalTableAdapter = Nothing
        Me.TableAdapterManager.InstitutoTableAdapter = Me.InstitutoTableAdapter
        Me.TableAdapterManager.JuecesTableAdapter = Nothing
        Me.TableAdapterManager.ParticipanteTableAdapter = Me.ParticipanteTableAdapter
        Me.TableAdapterManager.UpdateOrder = EvaluacionJurado.DataSetFestivalTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'CancionTableAdapter
        '
        Me.CancionTableAdapter.ClearBeforeFill = True
        '
        'InstitutoTableAdapter
        '
        Me.InstitutoTableAdapter.ClearBeforeFill = True
        '
        'XFormResultados
        '
        Me.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(977, 477)
        Me.Controls.Add(Me.PanelControl1)
        Me.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin
        Me.Name = "XFormResultados"
        Me.Text = "Resultados"
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        CType(Me.ParticipanteGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ParticipanteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSetFestival, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InstitutoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CancionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents DataSetFestival As EvaluacionJurado.DataSetFestival
    Friend WithEvents ParticipanteBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ParticipanteTableAdapter As EvaluacionJurado.DataSetFestivalTableAdapters.ParticipanteTableAdapter
    Friend WithEvents TableAdapterManager As EvaluacionJurado.DataSetFestivalTableAdapters.TableAdapterManager
    Friend WithEvents ParticipanteGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colIDParticipante As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOrdenParticipacion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNombre As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colApellido As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIDFestival As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIdInstituto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents colIdCancion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents InstitutoTableAdapter As EvaluacionJurado.DataSetFestivalTableAdapters.InstitutoTableAdapter
    Friend WithEvents InstitutoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents RepositoryItemLookUpEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents CancionTableAdapter As EvaluacionJurado.DataSetFestivalTableAdapters.CancionTableAdapter
    Friend WithEvents CancionBindingSource As System.Windows.Forms.BindingSource
End Class
