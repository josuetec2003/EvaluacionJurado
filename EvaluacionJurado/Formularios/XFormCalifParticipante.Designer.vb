<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class XFormCalifParticipante
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
        Dim Eval1Label As System.Windows.Forms.Label
        Dim Eval2Label As System.Windows.Forms.Label
        Dim Eval3Label As System.Windows.Forms.Label
        Dim Eval4Label As System.Windows.Forms.Label
        Dim Eval5Label As System.Windows.Forms.Label
        Dim Eval6Label As System.Windows.Forms.Label
        Dim Eval7Label As System.Windows.Forms.Label
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.Eval1TextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.EvaluacionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSetFestival = New EvaluacionJurado.DataSetFestival()
        Me.Eval7TextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.Eval6TextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.Eval2TextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.Eval5TextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.Eval3TextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.Eval4TextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.TextEditCancion = New DevExpress.XtraEditors.TextEdit()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextEditInstituto = New DevExpress.XtraEditors.TextEdit()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextEditNombre = New DevExpress.XtraEditors.TextEdit()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.EvaluacionTableAdapter = New EvaluacionJurado.DataSetFestivalTableAdapters.EvaluacionTableAdapter()
        Me.TableAdapterManager = New EvaluacionJurado.DataSetFestivalTableAdapters.TableAdapterManager()
        Eval1Label = New System.Windows.Forms.Label()
        Eval2Label = New System.Windows.Forms.Label()
        Eval3Label = New System.Windows.Forms.Label()
        Eval4Label = New System.Windows.Forms.Label()
        Eval5Label = New System.Windows.Forms.Label()
        Eval6Label = New System.Windows.Forms.Label()
        Eval7Label = New System.Windows.Forms.Label()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.Eval1TextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EvaluacionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSetFestival, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Eval7TextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Eval6TextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Eval2TextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Eval5TextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Eval3TextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Eval4TextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.TextEditCancion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEditInstituto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEditNombre.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Eval1Label
        '
        Eval1Label.AutoSize = True
        Eval1Label.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Eval1Label.Location = New System.Drawing.Point(82, 64)
        Eval1Label.Name = "Eval1Label"
        Eval1Label.Size = New System.Drawing.Size(77, 13)
        Eval1Label.TabIndex = 4
        Eval1Label.Text = "Calidad de voz"
        '
        'Eval2Label
        '
        Eval2Label.AutoSize = True
        Eval2Label.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Eval2Label.Location = New System.Drawing.Point(43, 121)
        Eval2Label.Name = "Eval2Label"
        Eval2Label.Size = New System.Drawing.Size(116, 13)
        Eval2Label.TabIndex = 6
        Eval2Label.Text = "Dificultad de la canción"
        '
        'Eval3Label
        '
        Eval3Label.AutoSize = True
        Eval3Label.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Eval3Label.Location = New System.Drawing.Point(108, 185)
        Eval3Label.Name = "Eval3Label"
        Eval3Label.Size = New System.Drawing.Size(51, 13)
        Eval3Label.TabIndex = 8
        Eval3Label.Text = "Afinación"
        '
        'Eval4Label
        '
        Eval4Label.AutoSize = True
        Eval4Label.Location = New System.Drawing.Point(320, 64)
        Eval4Label.Name = "Eval4Label"
        Eval4Label.Size = New System.Drawing.Size(40, 13)
        Eval4Label.TabIndex = 10
        Eval4Label.Text = "Dicción"
        '
        'Eval5Label
        '
        Eval5Label.AutoSize = True
        Eval5Label.Location = New System.Drawing.Point(306, 121)
        Eval5Label.Name = "Eval5Label"
        Eval5Label.Size = New System.Drawing.Size(54, 13)
        Eval5Label.TabIndex = 12
        Eval5Label.Text = "Expresión"
        '
        'Eval6Label
        '
        Eval6Label.AutoSize = True
        Eval6Label.Location = New System.Drawing.Point(318, 185)
        Eval6Label.Name = "Eval6Label"
        Eval6Label.Size = New System.Drawing.Size(42, 13)
        Eval6Label.TabIndex = 14
        Eval6Label.Text = "Métrica"
        '
        'Eval7Label
        '
        Eval7Label.AutoSize = True
        Eval7Label.Location = New System.Drawing.Point(512, 64)
        Eval7Label.Name = "Eval7Label"
        Eval7Label.Size = New System.Drawing.Size(113, 13)
        Eval7Label.TabIndex = 16
        Eval7Label.Text = "Presentación personal"
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
        Me.PanelControl1.Controls.Add(Me.GroupControl2)
        Me.PanelControl1.Controls.Add(Me.GroupControl1)
        Me.PanelControl1.Location = New System.Drawing.Point(12, 12)
        Me.PanelControl1.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(842, 470)
        Me.PanelControl1.TabIndex = 0
        '
        'GroupControl2
        '
        Me.GroupControl2.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.GroupControl2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.GroupControl2.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.GroupControl2.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.GroupControl2.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.GroupControl2.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.GroupControl2.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GroupControl2.AppearanceCaption.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.GroupControl2.AppearanceCaption.Options.UseFont = True
        Me.GroupControl2.AppearanceCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.GroupControl2.AppearanceCaption.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.GroupControl2.AppearanceCaption.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.GroupControl2.AppearanceCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.GroupControl2.AppearanceCaption.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.GroupControl2.CaptionImageLocation = DevExpress.Utils.GroupElementLocation.[Default]
        Me.GroupControl2.CaptionLocation = DevExpress.Utils.Locations.[Default]
        Me.GroupControl2.ContentImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.GroupControl2.Controls.Add(Me.Eval1TextEdit)
        Me.GroupControl2.Controls.Add(Me.Eval7TextEdit)
        Me.GroupControl2.Controls.Add(Eval1Label)
        Me.GroupControl2.Controls.Add(Eval7Label)
        Me.GroupControl2.Controls.Add(Me.Eval6TextEdit)
        Me.GroupControl2.Controls.Add(Eval2Label)
        Me.GroupControl2.Controls.Add(Eval6Label)
        Me.GroupControl2.Controls.Add(Me.Eval2TextEdit)
        Me.GroupControl2.Controls.Add(Me.Eval5TextEdit)
        Me.GroupControl2.Controls.Add(Eval3Label)
        Me.GroupControl2.Controls.Add(Eval5Label)
        Me.GroupControl2.Controls.Add(Me.Eval3TextEdit)
        Me.GroupControl2.Controls.Add(Me.Eval4TextEdit)
        Me.GroupControl2.Controls.Add(Eval4Label)
        Me.GroupControl2.Location = New System.Drawing.Point(17, 192)
        Me.GroupControl2.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(806, 260)
        Me.GroupControl2.TabIndex = 0
        Me.GroupControl2.Text = "Evaluaciones, 5% por cada criterio"
        '
        'Eval1TextEdit
        '
        Me.Eval1TextEdit.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.[Default]
        Me.Eval1TextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.EvaluacionBindingSource, "eval1", True))
        Me.Eval1TextEdit.Location = New System.Drawing.Point(172, 51)
        Me.Eval1TextEdit.Name = "Eval1TextEdit"
        Me.Eval1TextEdit.Properties.AccessibleRole = System.Windows.Forms.AccessibleRole.[Default]
        Me.Eval1TextEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[Default]
        Me.Eval1TextEdit.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 16.0!)
        Me.Eval1TextEdit.Properties.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.Eval1TextEdit.Properties.Appearance.Options.UseFont = True
        Me.Eval1TextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.Eval1TextEdit.Properties.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.Eval1TextEdit.Properties.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.Eval1TextEdit.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.Eval1TextEdit.Properties.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.Eval1TextEdit.Properties.AppearanceDisabled.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.Eval1TextEdit.Properties.AppearanceDisabled.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.Eval1TextEdit.Properties.AppearanceDisabled.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.Eval1TextEdit.Properties.AppearanceDisabled.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.Eval1TextEdit.Properties.AppearanceDisabled.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.Eval1TextEdit.Properties.AppearanceDisabled.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.Eval1TextEdit.Properties.AppearanceFocused.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.Eval1TextEdit.Properties.AppearanceFocused.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.Eval1TextEdit.Properties.AppearanceFocused.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.Eval1TextEdit.Properties.AppearanceFocused.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.Eval1TextEdit.Properties.AppearanceFocused.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.Eval1TextEdit.Properties.AppearanceFocused.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.Eval1TextEdit.Properties.AppearanceReadOnly.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.Eval1TextEdit.Properties.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.Eval1TextEdit.Properties.AppearanceReadOnly.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.Eval1TextEdit.Properties.AppearanceReadOnly.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.Eval1TextEdit.Properties.AppearanceReadOnly.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.Eval1TextEdit.Properties.AppearanceReadOnly.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.Eval1TextEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.[Default]
        Me.Eval1TextEdit.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.Eval1TextEdit.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.[Default]
        Me.Eval1TextEdit.Properties.ExportMode = DevExpress.XtraEditors.Repository.ExportMode.[Default]
        Me.Eval1TextEdit.Properties.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin
        Me.Eval1TextEdit.Properties.Mask.AutoComplete = DevExpress.XtraEditors.Mask.AutoCompleteType.[Default]
        Me.Eval1TextEdit.Properties.Mask.EditMask = "n0"
        Me.Eval1TextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.Eval1TextEdit.Size = New System.Drawing.Size(100, 32)
        Me.Eval1TextEdit.TabIndex = 1
        Me.Eval1TextEdit.ToolTipIconType = DevExpress.Utils.ToolTipIconType.None
        '
        'EvaluacionBindingSource
        '
        Me.EvaluacionBindingSource.DataMember = "Evaluacion"
        Me.EvaluacionBindingSource.DataSource = Me.DataSetFestival
        '
        'DataSetFestival
        '
        Me.DataSetFestival.DataSetName = "DataSetFestival"
        Me.DataSetFestival.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Eval7TextEdit
        '
        Me.Eval7TextEdit.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.[Default]
        Me.Eval7TextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.EvaluacionBindingSource, "eval7", True))
        Me.Eval7TextEdit.Location = New System.Drawing.Point(643, 51)
        Me.Eval7TextEdit.Name = "Eval7TextEdit"
        Me.Eval7TextEdit.Properties.AccessibleRole = System.Windows.Forms.AccessibleRole.[Default]
        Me.Eval7TextEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[Default]
        Me.Eval7TextEdit.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 16.0!)
        Me.Eval7TextEdit.Properties.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.Eval7TextEdit.Properties.Appearance.Options.UseFont = True
        Me.Eval7TextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.Eval7TextEdit.Properties.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.Eval7TextEdit.Properties.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.Eval7TextEdit.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.Eval7TextEdit.Properties.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.Eval7TextEdit.Properties.AppearanceDisabled.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.Eval7TextEdit.Properties.AppearanceDisabled.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.Eval7TextEdit.Properties.AppearanceDisabled.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.Eval7TextEdit.Properties.AppearanceDisabled.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.Eval7TextEdit.Properties.AppearanceDisabled.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.Eval7TextEdit.Properties.AppearanceDisabled.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.Eval7TextEdit.Properties.AppearanceFocused.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.Eval7TextEdit.Properties.AppearanceFocused.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.Eval7TextEdit.Properties.AppearanceFocused.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.Eval7TextEdit.Properties.AppearanceFocused.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.Eval7TextEdit.Properties.AppearanceFocused.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.Eval7TextEdit.Properties.AppearanceFocused.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.Eval7TextEdit.Properties.AppearanceReadOnly.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.Eval7TextEdit.Properties.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.Eval7TextEdit.Properties.AppearanceReadOnly.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.Eval7TextEdit.Properties.AppearanceReadOnly.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.Eval7TextEdit.Properties.AppearanceReadOnly.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.Eval7TextEdit.Properties.AppearanceReadOnly.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.Eval7TextEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.[Default]
        Me.Eval7TextEdit.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.Eval7TextEdit.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.[Default]
        Me.Eval7TextEdit.Properties.ExportMode = DevExpress.XtraEditors.Repository.ExportMode.[Default]
        Me.Eval7TextEdit.Properties.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin
        Me.Eval7TextEdit.Properties.Mask.AutoComplete = DevExpress.XtraEditors.Mask.AutoCompleteType.[Default]
        Me.Eval7TextEdit.Properties.Mask.EditMask = "n0"
        Me.Eval7TextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.Eval7TextEdit.Size = New System.Drawing.Size(100, 32)
        Me.Eval7TextEdit.TabIndex = 7
        Me.Eval7TextEdit.ToolTipIconType = DevExpress.Utils.ToolTipIconType.None
        '
        'Eval6TextEdit
        '
        Me.Eval6TextEdit.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.[Default]
        Me.Eval6TextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.EvaluacionBindingSource, "eval6", True))
        Me.Eval6TextEdit.Location = New System.Drawing.Point(377, 174)
        Me.Eval6TextEdit.Name = "Eval6TextEdit"
        Me.Eval6TextEdit.Properties.AccessibleRole = System.Windows.Forms.AccessibleRole.[Default]
        Me.Eval6TextEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[Default]
        Me.Eval6TextEdit.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 16.0!)
        Me.Eval6TextEdit.Properties.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.Eval6TextEdit.Properties.Appearance.Options.UseFont = True
        Me.Eval6TextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.Eval6TextEdit.Properties.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.Eval6TextEdit.Properties.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.Eval6TextEdit.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.Eval6TextEdit.Properties.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.Eval6TextEdit.Properties.AppearanceDisabled.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.Eval6TextEdit.Properties.AppearanceDisabled.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.Eval6TextEdit.Properties.AppearanceDisabled.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.Eval6TextEdit.Properties.AppearanceDisabled.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.Eval6TextEdit.Properties.AppearanceDisabled.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.Eval6TextEdit.Properties.AppearanceDisabled.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.Eval6TextEdit.Properties.AppearanceFocused.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.Eval6TextEdit.Properties.AppearanceFocused.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.Eval6TextEdit.Properties.AppearanceFocused.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.Eval6TextEdit.Properties.AppearanceFocused.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.Eval6TextEdit.Properties.AppearanceFocused.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.Eval6TextEdit.Properties.AppearanceFocused.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.Eval6TextEdit.Properties.AppearanceReadOnly.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.Eval6TextEdit.Properties.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.Eval6TextEdit.Properties.AppearanceReadOnly.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.Eval6TextEdit.Properties.AppearanceReadOnly.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.Eval6TextEdit.Properties.AppearanceReadOnly.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.Eval6TextEdit.Properties.AppearanceReadOnly.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.Eval6TextEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.[Default]
        Me.Eval6TextEdit.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.Eval6TextEdit.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.[Default]
        Me.Eval6TextEdit.Properties.ExportMode = DevExpress.XtraEditors.Repository.ExportMode.[Default]
        Me.Eval6TextEdit.Properties.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin
        Me.Eval6TextEdit.Properties.Mask.AutoComplete = DevExpress.XtraEditors.Mask.AutoCompleteType.[Default]
        Me.Eval6TextEdit.Properties.Mask.EditMask = "n0"
        Me.Eval6TextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.Eval6TextEdit.Size = New System.Drawing.Size(100, 32)
        Me.Eval6TextEdit.TabIndex = 6
        Me.Eval6TextEdit.ToolTipIconType = DevExpress.Utils.ToolTipIconType.None
        '
        'Eval2TextEdit
        '
        Me.Eval2TextEdit.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.[Default]
        Me.Eval2TextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.EvaluacionBindingSource, "eval2", True))
        Me.Eval2TextEdit.Location = New System.Drawing.Point(172, 108)
        Me.Eval2TextEdit.Name = "Eval2TextEdit"
        Me.Eval2TextEdit.Properties.AccessibleRole = System.Windows.Forms.AccessibleRole.[Default]
        Me.Eval2TextEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[Default]
        Me.Eval2TextEdit.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 16.0!)
        Me.Eval2TextEdit.Properties.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.Eval2TextEdit.Properties.Appearance.Options.UseFont = True
        Me.Eval2TextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.Eval2TextEdit.Properties.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.Eval2TextEdit.Properties.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.Eval2TextEdit.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.Eval2TextEdit.Properties.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.Eval2TextEdit.Properties.AppearanceDisabled.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.Eval2TextEdit.Properties.AppearanceDisabled.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.Eval2TextEdit.Properties.AppearanceDisabled.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.Eval2TextEdit.Properties.AppearanceDisabled.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.Eval2TextEdit.Properties.AppearanceDisabled.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.Eval2TextEdit.Properties.AppearanceDisabled.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.Eval2TextEdit.Properties.AppearanceFocused.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.Eval2TextEdit.Properties.AppearanceFocused.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.Eval2TextEdit.Properties.AppearanceFocused.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.Eval2TextEdit.Properties.AppearanceFocused.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.Eval2TextEdit.Properties.AppearanceFocused.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.Eval2TextEdit.Properties.AppearanceFocused.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.Eval2TextEdit.Properties.AppearanceReadOnly.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.Eval2TextEdit.Properties.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.Eval2TextEdit.Properties.AppearanceReadOnly.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.Eval2TextEdit.Properties.AppearanceReadOnly.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.Eval2TextEdit.Properties.AppearanceReadOnly.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.Eval2TextEdit.Properties.AppearanceReadOnly.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.Eval2TextEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.[Default]
        Me.Eval2TextEdit.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.Eval2TextEdit.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.[Default]
        Me.Eval2TextEdit.Properties.ExportMode = DevExpress.XtraEditors.Repository.ExportMode.[Default]
        Me.Eval2TextEdit.Properties.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin
        Me.Eval2TextEdit.Properties.Mask.AutoComplete = DevExpress.XtraEditors.Mask.AutoCompleteType.[Default]
        Me.Eval2TextEdit.Properties.Mask.EditMask = "n0"
        Me.Eval2TextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.Eval2TextEdit.Size = New System.Drawing.Size(100, 32)
        Me.Eval2TextEdit.TabIndex = 2
        Me.Eval2TextEdit.ToolTipIconType = DevExpress.Utils.ToolTipIconType.None
        '
        'Eval5TextEdit
        '
        Me.Eval5TextEdit.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.[Default]
        Me.Eval5TextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.EvaluacionBindingSource, "eval5", True))
        Me.Eval5TextEdit.Location = New System.Drawing.Point(377, 108)
        Me.Eval5TextEdit.Name = "Eval5TextEdit"
        Me.Eval5TextEdit.Properties.AccessibleRole = System.Windows.Forms.AccessibleRole.[Default]
        Me.Eval5TextEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[Default]
        Me.Eval5TextEdit.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 16.0!)
        Me.Eval5TextEdit.Properties.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.Eval5TextEdit.Properties.Appearance.Options.UseFont = True
        Me.Eval5TextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.Eval5TextEdit.Properties.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.Eval5TextEdit.Properties.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.Eval5TextEdit.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.Eval5TextEdit.Properties.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.Eval5TextEdit.Properties.AppearanceDisabled.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.Eval5TextEdit.Properties.AppearanceDisabled.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.Eval5TextEdit.Properties.AppearanceDisabled.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.Eval5TextEdit.Properties.AppearanceDisabled.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.Eval5TextEdit.Properties.AppearanceDisabled.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.Eval5TextEdit.Properties.AppearanceDisabled.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.Eval5TextEdit.Properties.AppearanceFocused.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.Eval5TextEdit.Properties.AppearanceFocused.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.Eval5TextEdit.Properties.AppearanceFocused.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.Eval5TextEdit.Properties.AppearanceFocused.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.Eval5TextEdit.Properties.AppearanceFocused.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.Eval5TextEdit.Properties.AppearanceFocused.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.Eval5TextEdit.Properties.AppearanceReadOnly.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.Eval5TextEdit.Properties.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.Eval5TextEdit.Properties.AppearanceReadOnly.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.Eval5TextEdit.Properties.AppearanceReadOnly.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.Eval5TextEdit.Properties.AppearanceReadOnly.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.Eval5TextEdit.Properties.AppearanceReadOnly.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.Eval5TextEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.[Default]
        Me.Eval5TextEdit.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.Eval5TextEdit.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.[Default]
        Me.Eval5TextEdit.Properties.ExportMode = DevExpress.XtraEditors.Repository.ExportMode.[Default]
        Me.Eval5TextEdit.Properties.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin
        Me.Eval5TextEdit.Properties.Mask.AutoComplete = DevExpress.XtraEditors.Mask.AutoCompleteType.[Default]
        Me.Eval5TextEdit.Properties.Mask.EditMask = "n0"
        Me.Eval5TextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.Eval5TextEdit.Size = New System.Drawing.Size(100, 32)
        Me.Eval5TextEdit.TabIndex = 5
        Me.Eval5TextEdit.ToolTipIconType = DevExpress.Utils.ToolTipIconType.None
        '
        'Eval3TextEdit
        '
        Me.Eval3TextEdit.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.[Default]
        Me.Eval3TextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.EvaluacionBindingSource, "eval3", True))
        Me.Eval3TextEdit.Location = New System.Drawing.Point(172, 172)
        Me.Eval3TextEdit.Name = "Eval3TextEdit"
        Me.Eval3TextEdit.Properties.AccessibleRole = System.Windows.Forms.AccessibleRole.[Default]
        Me.Eval3TextEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[Default]
        Me.Eval3TextEdit.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 16.0!)
        Me.Eval3TextEdit.Properties.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.Eval3TextEdit.Properties.Appearance.Options.UseFont = True
        Me.Eval3TextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.Eval3TextEdit.Properties.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.Eval3TextEdit.Properties.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.Eval3TextEdit.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.Eval3TextEdit.Properties.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.Eval3TextEdit.Properties.AppearanceDisabled.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.Eval3TextEdit.Properties.AppearanceDisabled.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.Eval3TextEdit.Properties.AppearanceDisabled.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.Eval3TextEdit.Properties.AppearanceDisabled.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.Eval3TextEdit.Properties.AppearanceDisabled.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.Eval3TextEdit.Properties.AppearanceDisabled.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.Eval3TextEdit.Properties.AppearanceFocused.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.Eval3TextEdit.Properties.AppearanceFocused.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.Eval3TextEdit.Properties.AppearanceFocused.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.Eval3TextEdit.Properties.AppearanceFocused.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.Eval3TextEdit.Properties.AppearanceFocused.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.Eval3TextEdit.Properties.AppearanceFocused.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.Eval3TextEdit.Properties.AppearanceReadOnly.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.Eval3TextEdit.Properties.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.Eval3TextEdit.Properties.AppearanceReadOnly.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.Eval3TextEdit.Properties.AppearanceReadOnly.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.Eval3TextEdit.Properties.AppearanceReadOnly.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.Eval3TextEdit.Properties.AppearanceReadOnly.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.Eval3TextEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.[Default]
        Me.Eval3TextEdit.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.Eval3TextEdit.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.[Default]
        Me.Eval3TextEdit.Properties.ExportMode = DevExpress.XtraEditors.Repository.ExportMode.[Default]
        Me.Eval3TextEdit.Properties.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin
        Me.Eval3TextEdit.Properties.Mask.AutoComplete = DevExpress.XtraEditors.Mask.AutoCompleteType.[Default]
        Me.Eval3TextEdit.Properties.Mask.EditMask = "n0"
        Me.Eval3TextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.Eval3TextEdit.Size = New System.Drawing.Size(100, 32)
        Me.Eval3TextEdit.TabIndex = 3
        Me.Eval3TextEdit.ToolTipIconType = DevExpress.Utils.ToolTipIconType.None
        '
        'Eval4TextEdit
        '
        Me.Eval4TextEdit.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.[Default]
        Me.Eval4TextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.EvaluacionBindingSource, "eval4", True))
        Me.Eval4TextEdit.Location = New System.Drawing.Point(377, 51)
        Me.Eval4TextEdit.Name = "Eval4TextEdit"
        Me.Eval4TextEdit.Properties.AccessibleRole = System.Windows.Forms.AccessibleRole.[Default]
        Me.Eval4TextEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[Default]
        Me.Eval4TextEdit.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 16.0!)
        Me.Eval4TextEdit.Properties.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.Eval4TextEdit.Properties.Appearance.Options.UseFont = True
        Me.Eval4TextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.Eval4TextEdit.Properties.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.Eval4TextEdit.Properties.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.Eval4TextEdit.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.Eval4TextEdit.Properties.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.Eval4TextEdit.Properties.AppearanceDisabled.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.Eval4TextEdit.Properties.AppearanceDisabled.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.Eval4TextEdit.Properties.AppearanceDisabled.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.Eval4TextEdit.Properties.AppearanceDisabled.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.Eval4TextEdit.Properties.AppearanceDisabled.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.Eval4TextEdit.Properties.AppearanceDisabled.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.Eval4TextEdit.Properties.AppearanceFocused.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.Eval4TextEdit.Properties.AppearanceFocused.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.Eval4TextEdit.Properties.AppearanceFocused.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.Eval4TextEdit.Properties.AppearanceFocused.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.Eval4TextEdit.Properties.AppearanceFocused.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.Eval4TextEdit.Properties.AppearanceFocused.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.Eval4TextEdit.Properties.AppearanceReadOnly.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.Eval4TextEdit.Properties.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.Eval4TextEdit.Properties.AppearanceReadOnly.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.Eval4TextEdit.Properties.AppearanceReadOnly.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.Eval4TextEdit.Properties.AppearanceReadOnly.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.Eval4TextEdit.Properties.AppearanceReadOnly.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.Eval4TextEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.[Default]
        Me.Eval4TextEdit.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.Eval4TextEdit.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.[Default]
        Me.Eval4TextEdit.Properties.ExportMode = DevExpress.XtraEditors.Repository.ExportMode.[Default]
        Me.Eval4TextEdit.Properties.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin
        Me.Eval4TextEdit.Properties.Mask.AutoComplete = DevExpress.XtraEditors.Mask.AutoCompleteType.[Default]
        Me.Eval4TextEdit.Properties.Mask.EditMask = "n0"
        Me.Eval4TextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.Eval4TextEdit.Size = New System.Drawing.Size(100, 32)
        Me.Eval4TextEdit.TabIndex = 4
        Me.Eval4TextEdit.ToolTipIconType = DevExpress.Utils.ToolTipIconType.None
        '
        'GroupControl1
        '
        Me.GroupControl1.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.GroupControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.GroupControl1.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.GroupControl1.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.GroupControl1.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.GroupControl1.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.GroupControl1.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GroupControl1.AppearanceCaption.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.GroupControl1.AppearanceCaption.Options.UseFont = True
        Me.GroupControl1.AppearanceCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.GroupControl1.AppearanceCaption.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.GroupControl1.AppearanceCaption.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.GroupControl1.AppearanceCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.GroupControl1.AppearanceCaption.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.GroupControl1.CaptionImageLocation = DevExpress.Utils.GroupElementLocation.[Default]
        Me.GroupControl1.CaptionLocation = DevExpress.Utils.Locations.[Default]
        Me.GroupControl1.ContentImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.GroupControl1.Controls.Add(Me.TextEditCancion)
        Me.GroupControl1.Controls.Add(Me.Label3)
        Me.GroupControl1.Controls.Add(Me.TextEditInstituto)
        Me.GroupControl1.Controls.Add(Me.Label2)
        Me.GroupControl1.Controls.Add(Me.TextEditNombre)
        Me.GroupControl1.Controls.Add(Me.Label1)
        Me.GroupControl1.Location = New System.Drawing.Point(17, 16)
        Me.GroupControl1.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(806, 161)
        Me.GroupControl1.TabIndex = 18
        Me.GroupControl1.Text = "Información del participante"
        '
        'TextEditCancion
        '
        Me.TextEditCancion.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.[Default]
        Me.TextEditCancion.Location = New System.Drawing.Point(128, 113)
        Me.TextEditCancion.Name = "TextEditCancion"
        Me.TextEditCancion.Properties.AccessibleRole = System.Windows.Forms.AccessibleRole.[Default]
        Me.TextEditCancion.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[Default]
        Me.TextEditCancion.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.TextEditCancion.Properties.Appearance.ForeColor = System.Drawing.Color.Gray
        Me.TextEditCancion.Properties.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.TextEditCancion.Properties.Appearance.Options.UseFont = True
        Me.TextEditCancion.Properties.Appearance.Options.UseForeColor = True
        Me.TextEditCancion.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.TextEditCancion.Properties.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.TextEditCancion.Properties.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.TextEditCancion.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.TextEditCancion.Properties.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.TextEditCancion.Properties.AppearanceDisabled.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.TextEditCancion.Properties.AppearanceDisabled.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.TextEditCancion.Properties.AppearanceDisabled.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.TextEditCancion.Properties.AppearanceDisabled.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.TextEditCancion.Properties.AppearanceDisabled.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.TextEditCancion.Properties.AppearanceDisabled.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.TextEditCancion.Properties.AppearanceFocused.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.TextEditCancion.Properties.AppearanceFocused.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.TextEditCancion.Properties.AppearanceFocused.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.TextEditCancion.Properties.AppearanceFocused.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.TextEditCancion.Properties.AppearanceFocused.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.TextEditCancion.Properties.AppearanceFocused.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.TextEditCancion.Properties.AppearanceReadOnly.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.TextEditCancion.Properties.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.TextEditCancion.Properties.AppearanceReadOnly.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.TextEditCancion.Properties.AppearanceReadOnly.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.TextEditCancion.Properties.AppearanceReadOnly.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.TextEditCancion.Properties.AppearanceReadOnly.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.TextEditCancion.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.[Default]
        Me.TextEditCancion.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.TextEditCancion.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.[Default]
        Me.TextEditCancion.Properties.ExportMode = DevExpress.XtraEditors.Repository.ExportMode.[Default]
        Me.TextEditCancion.Properties.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin
        Me.TextEditCancion.Properties.Mask.AutoComplete = DevExpress.XtraEditors.Mask.AutoCompleteType.[Default]
        Me.TextEditCancion.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
        Me.TextEditCancion.Size = New System.Drawing.Size(285, 26)
        Me.TextEditCancion.TabIndex = 5
        Me.TextEditCancion.ToolTipIconType = DevExpress.Utils.ToolTipIconType.None
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.Label3.Location = New System.Drawing.Point(34, 116)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 19)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Canción"
        '
        'TextEditInstituto
        '
        Me.TextEditInstituto.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.[Default]
        Me.TextEditInstituto.Location = New System.Drawing.Point(128, 71)
        Me.TextEditInstituto.Name = "TextEditInstituto"
        Me.TextEditInstituto.Properties.AccessibleRole = System.Windows.Forms.AccessibleRole.[Default]
        Me.TextEditInstituto.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[Default]
        Me.TextEditInstituto.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.TextEditInstituto.Properties.Appearance.ForeColor = System.Drawing.Color.Gray
        Me.TextEditInstituto.Properties.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.TextEditInstituto.Properties.Appearance.Options.UseFont = True
        Me.TextEditInstituto.Properties.Appearance.Options.UseForeColor = True
        Me.TextEditInstituto.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.TextEditInstituto.Properties.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.TextEditInstituto.Properties.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.TextEditInstituto.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.TextEditInstituto.Properties.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.TextEditInstituto.Properties.AppearanceDisabled.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.TextEditInstituto.Properties.AppearanceDisabled.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.TextEditInstituto.Properties.AppearanceDisabled.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.TextEditInstituto.Properties.AppearanceDisabled.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.TextEditInstituto.Properties.AppearanceDisabled.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.TextEditInstituto.Properties.AppearanceDisabled.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.TextEditInstituto.Properties.AppearanceFocused.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.TextEditInstituto.Properties.AppearanceFocused.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.TextEditInstituto.Properties.AppearanceFocused.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.TextEditInstituto.Properties.AppearanceFocused.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.TextEditInstituto.Properties.AppearanceFocused.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.TextEditInstituto.Properties.AppearanceFocused.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.TextEditInstituto.Properties.AppearanceReadOnly.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.TextEditInstituto.Properties.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.TextEditInstituto.Properties.AppearanceReadOnly.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.TextEditInstituto.Properties.AppearanceReadOnly.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.TextEditInstituto.Properties.AppearanceReadOnly.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.TextEditInstituto.Properties.AppearanceReadOnly.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.TextEditInstituto.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.[Default]
        Me.TextEditInstituto.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.TextEditInstituto.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.[Default]
        Me.TextEditInstituto.Properties.ExportMode = DevExpress.XtraEditors.Repository.ExportMode.[Default]
        Me.TextEditInstituto.Properties.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin
        Me.TextEditInstituto.Properties.Mask.AutoComplete = DevExpress.XtraEditors.Mask.AutoCompleteType.[Default]
        Me.TextEditInstituto.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
        Me.TextEditInstituto.Size = New System.Drawing.Size(285, 26)
        Me.TextEditInstituto.TabIndex = 3
        Me.TextEditInstituto.ToolTipIconType = DevExpress.Utils.ToolTipIconType.None
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.Label2.Location = New System.Drawing.Point(31, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 19)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Instituto"
        '
        'TextEditNombre
        '
        Me.TextEditNombre.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.[Default]
        Me.TextEditNombre.Location = New System.Drawing.Point(128, 32)
        Me.TextEditNombre.Name = "TextEditNombre"
        Me.TextEditNombre.Properties.AccessibleRole = System.Windows.Forms.AccessibleRole.[Default]
        Me.TextEditNombre.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[Default]
        Me.TextEditNombre.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.TextEditNombre.Properties.Appearance.ForeColor = System.Drawing.Color.Gray
        Me.TextEditNombre.Properties.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.TextEditNombre.Properties.Appearance.Options.UseFont = True
        Me.TextEditNombre.Properties.Appearance.Options.UseForeColor = True
        Me.TextEditNombre.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.TextEditNombre.Properties.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.TextEditNombre.Properties.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.TextEditNombre.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.TextEditNombre.Properties.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.TextEditNombre.Properties.AppearanceDisabled.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.TextEditNombre.Properties.AppearanceDisabled.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.TextEditNombre.Properties.AppearanceDisabled.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.TextEditNombre.Properties.AppearanceDisabled.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.TextEditNombre.Properties.AppearanceDisabled.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.TextEditNombre.Properties.AppearanceDisabled.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.TextEditNombre.Properties.AppearanceFocused.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.TextEditNombre.Properties.AppearanceFocused.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.TextEditNombre.Properties.AppearanceFocused.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.TextEditNombre.Properties.AppearanceFocused.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.TextEditNombre.Properties.AppearanceFocused.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.TextEditNombre.Properties.AppearanceFocused.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.TextEditNombre.Properties.AppearanceReadOnly.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.TextEditNombre.Properties.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.TextEditNombre.Properties.AppearanceReadOnly.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.TextEditNombre.Properties.AppearanceReadOnly.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.TextEditNombre.Properties.AppearanceReadOnly.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.TextEditNombre.Properties.AppearanceReadOnly.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.TextEditNombre.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.[Default]
        Me.TextEditNombre.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.TextEditNombre.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.[Default]
        Me.TextEditNombre.Properties.ExportMode = DevExpress.XtraEditors.Repository.ExportMode.[Default]
        Me.TextEditNombre.Properties.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin
        Me.TextEditNombre.Properties.Mask.AutoComplete = DevExpress.XtraEditors.Mask.AutoCompleteType.[Default]
        Me.TextEditNombre.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
        Me.TextEditNombre.Size = New System.Drawing.Size(363, 26)
        Me.TextEditNombre.TabIndex = 1
        Me.TextEditNombre.ToolTipIconType = DevExpress.Utils.ToolTipIconType.None
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.Label1.Location = New System.Drawing.Point(33, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre"
        '
        'EvaluacionTableAdapter
        '
        Me.EvaluacionTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CancionTableAdapter = Nothing
        Me.TableAdapterManager.EvaluacionTableAdapter = Me.EvaluacionTableAdapter
        Me.TableAdapterManager.FestivalTableAdapter = Nothing
        Me.TableAdapterManager.InstitutoTableAdapter = Nothing
        Me.TableAdapterManager.JuecesTableAdapter = Nothing
        Me.TableAdapterManager.ParticipanteTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = EvaluacionJurado.DataSetFestivalTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'XFormCalifParticipante
        '
        Me.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(866, 482)
        Me.Controls.Add(Me.PanelControl1)
        Me.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin
        Me.Name = "XFormCalifParticipante"
        Me.Text = "Evaluando participante"
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        Me.GroupControl2.PerformLayout()
        CType(Me.Eval1TextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EvaluacionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSetFestival, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Eval7TextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Eval6TextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Eval2TextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Eval5TextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Eval3TextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Eval4TextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.TextEditCancion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEditInstituto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEditNombre.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents DataSetFestival As EvaluacionJurado.DataSetFestival
    Friend WithEvents EvaluacionBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EvaluacionTableAdapter As EvaluacionJurado.DataSetFestivalTableAdapters.EvaluacionTableAdapter
    Friend WithEvents TableAdapterManager As EvaluacionJurado.DataSetFestivalTableAdapters.TableAdapterManager
    Friend WithEvents Eval1TextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Eval2TextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Eval3TextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Eval4TextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Eval5TextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Eval6TextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Eval7TextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents TextEditCancion As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TextEditInstituto As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextEditNombre As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
End Class
