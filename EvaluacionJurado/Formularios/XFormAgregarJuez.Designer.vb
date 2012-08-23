<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class XFormAgregarJuez
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
        Dim UsuarioLabel As System.Windows.Forms.Label
        Dim ContrasenaLabel As System.Windows.Forms.Label
        Dim NombreLabel As System.Windows.Forms.Label
        Dim ApellidoLabel As System.Windows.Forms.Label
        Dim AnioParticipacionLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.JuecesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSetFestival = New EvaluacionJurado.DataSetFestival()
        Me.RepContrasenaTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.btnAgregarJuez = New DevExpress.XtraEditors.SimpleButton()
        Me.UsuarioTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.ContrasenaTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.NombreTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.ApellidoTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.AnioParticipacionTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.JuecesTableAdapter = New EvaluacionJurado.DataSetFestivalTableAdapters.JuecesTableAdapter()
        Me.TableAdapterManager = New EvaluacionJurado.DataSetFestivalTableAdapters.TableAdapterManager()
        UsuarioLabel = New System.Windows.Forms.Label()
        ContrasenaLabel = New System.Windows.Forms.Label()
        NombreLabel = New System.Windows.Forms.Label()
        ApellidoLabel = New System.Windows.Forms.Label()
        AnioParticipacionLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.JuecesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSetFestival, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepContrasenaTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UsuarioTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ContrasenaTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NombreTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ApellidoTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AnioParticipacionTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UsuarioLabel
        '
        UsuarioLabel.AutoSize = True
        UsuarioLabel.Location = New System.Drawing.Point(171, 171)
        UsuarioLabel.Name = "UsuarioLabel"
        UsuarioLabel.Size = New System.Drawing.Size(43, 13)
        UsuarioLabel.TabIndex = 2
        UsuarioLabel.Text = "Usuario"
        '
        'ContrasenaLabel
        '
        ContrasenaLabel.AutoSize = True
        ContrasenaLabel.Location = New System.Drawing.Point(151, 197)
        ContrasenaLabel.Name = "ContrasenaLabel"
        ContrasenaLabel.Size = New System.Drawing.Size(63, 13)
        ContrasenaLabel.TabIndex = 4
        ContrasenaLabel.Text = "Contraseña"
        '
        'NombreLabel
        '
        NombreLabel.AutoSize = True
        NombreLabel.Location = New System.Drawing.Point(166, 45)
        NombreLabel.Name = "NombreLabel"
        NombreLabel.Size = New System.Drawing.Size(44, 13)
        NombreLabel.TabIndex = 6
        NombreLabel.Text = "Nombre"
        '
        'ApellidoLabel
        '
        ApellidoLabel.AutoSize = True
        ApellidoLabel.Location = New System.Drawing.Point(166, 71)
        ApellidoLabel.Name = "ApellidoLabel"
        ApellidoLabel.Size = New System.Drawing.Size(44, 13)
        ApellidoLabel.TabIndex = 8
        ApellidoLabel.Text = "Apellido"
        '
        'AnioParticipacionLabel
        '
        AnioParticipacionLabel.AutoSize = True
        AnioParticipacionLabel.Location = New System.Drawing.Point(103, 96)
        AnioParticipacionLabel.Name = "AnioParticipacionLabel"
        AnioParticipacionLabel.Size = New System.Drawing.Size(107, 13)
        AnioParticipacionLabel.TabIndex = 10
        AnioParticipacionLabel.Text = "Año  de participación"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(115, 227)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(99, 13)
        Label1.TabIndex = 13
        Label1.Text = "Repetir contraseña"
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
        Me.PanelControl1.Controls.Add(Me.Label2)
        Me.PanelControl1.Controls.Add(Label1)
        Me.PanelControl1.Controls.Add(Me.RepContrasenaTextEdit)
        Me.PanelControl1.Controls.Add(Me.btnAgregarJuez)
        Me.PanelControl1.Controls.Add(UsuarioLabel)
        Me.PanelControl1.Controls.Add(Me.UsuarioTextEdit)
        Me.PanelControl1.Controls.Add(ContrasenaLabel)
        Me.PanelControl1.Controls.Add(Me.ContrasenaTextEdit)
        Me.PanelControl1.Controls.Add(NombreLabel)
        Me.PanelControl1.Controls.Add(Me.NombreTextEdit)
        Me.PanelControl1.Controls.Add(ApellidoLabel)
        Me.PanelControl1.Controls.Add(Me.ApellidoTextEdit)
        Me.PanelControl1.Controls.Add(AnioParticipacionLabel)
        Me.PanelControl1.Controls.Add(Me.AnioParticipacionTextEdit)
        Me.PanelControl1.Controls.Add(Me.ShapeContainer1)
        Me.PanelControl1.Location = New System.Drawing.Point(12, 12)
        Me.PanelControl1.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(635, 300)
        Me.PanelControl1.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.JuecesBindingSource, "AnioParticipacion", True))
        Me.Label2.Location = New System.Drawing.Point(342, 132)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 13)
        Me.Label2.TabIndex = 14
        '
        'JuecesBindingSource
        '
        Me.JuecesBindingSource.DataMember = "Jueces"
        Me.JuecesBindingSource.DataSource = Me.DataSetFestival
        '
        'DataSetFestival
        '
        Me.DataSetFestival.DataSetName = "DataSetFestival"
        Me.DataSetFestival.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'RepContrasenaTextEdit
        '
        Me.RepContrasenaTextEdit.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.[Default]
        Me.RepContrasenaTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.JuecesBindingSource, "Contrasena", True))
        Me.RepContrasenaTextEdit.Location = New System.Drawing.Point(251, 223)
        Me.RepContrasenaTextEdit.Name = "RepContrasenaTextEdit"
        Me.RepContrasenaTextEdit.Properties.AccessibleRole = System.Windows.Forms.AccessibleRole.[Default]
        Me.RepContrasenaTextEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[Default]
        Me.RepContrasenaTextEdit.Properties.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.RepContrasenaTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.RepContrasenaTextEdit.Properties.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.RepContrasenaTextEdit.Properties.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.RepContrasenaTextEdit.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.RepContrasenaTextEdit.Properties.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.RepContrasenaTextEdit.Properties.AppearanceDisabled.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.RepContrasenaTextEdit.Properties.AppearanceDisabled.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.RepContrasenaTextEdit.Properties.AppearanceDisabled.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.RepContrasenaTextEdit.Properties.AppearanceDisabled.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.RepContrasenaTextEdit.Properties.AppearanceDisabled.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.RepContrasenaTextEdit.Properties.AppearanceDisabled.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.RepContrasenaTextEdit.Properties.AppearanceFocused.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.RepContrasenaTextEdit.Properties.AppearanceFocused.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.RepContrasenaTextEdit.Properties.AppearanceFocused.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.RepContrasenaTextEdit.Properties.AppearanceFocused.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.RepContrasenaTextEdit.Properties.AppearanceFocused.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.RepContrasenaTextEdit.Properties.AppearanceFocused.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.RepContrasenaTextEdit.Properties.AppearanceReadOnly.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.RepContrasenaTextEdit.Properties.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.RepContrasenaTextEdit.Properties.AppearanceReadOnly.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.RepContrasenaTextEdit.Properties.AppearanceReadOnly.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.RepContrasenaTextEdit.Properties.AppearanceReadOnly.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.RepContrasenaTextEdit.Properties.AppearanceReadOnly.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.RepContrasenaTextEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.[Default]
        Me.RepContrasenaTextEdit.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.RepContrasenaTextEdit.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.[Default]
        Me.RepContrasenaTextEdit.Properties.ExportMode = DevExpress.XtraEditors.Repository.ExportMode.[Default]
        Me.RepContrasenaTextEdit.Properties.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin
        Me.RepContrasenaTextEdit.Properties.Mask.AutoComplete = DevExpress.XtraEditors.Mask.AutoCompleteType.[Default]
        Me.RepContrasenaTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
        Me.RepContrasenaTextEdit.Properties.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.RepContrasenaTextEdit.Size = New System.Drawing.Size(144, 20)
        Me.RepContrasenaTextEdit.TabIndex = 5
        Me.RepContrasenaTextEdit.ToolTipIconType = DevExpress.Utils.ToolTipIconType.None
        '
        'btnAgregarJuez
        '
        Me.btnAgregarJuez.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.[Default]
        Me.btnAgregarJuez.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.btnAgregarJuez.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.btnAgregarJuez.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.btnAgregarJuez.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.btnAgregarJuez.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.btnAgregarJuez.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.btnAgregarJuez.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.[Default]
        Me.btnAgregarJuez.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnAgregarJuez.ImageLocation = DevExpress.XtraEditors.ImageLocation.[Default]
        Me.btnAgregarJuez.Location = New System.Drawing.Point(486, 228)
        Me.btnAgregarJuez.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin
        Me.btnAgregarJuez.Name = "btnAgregarJuez"
        Me.btnAgregarJuez.Size = New System.Drawing.Size(130, 54)
        Me.btnAgregarJuez.TabIndex = 6
        Me.btnAgregarJuez.Text = "Agregar juez"
        Me.btnAgregarJuez.ToolTipIconType = DevExpress.Utils.ToolTipIconType.None
        '
        'UsuarioTextEdit
        '
        Me.UsuarioTextEdit.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.[Default]
        Me.UsuarioTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.JuecesBindingSource, "Usuario", True))
        Me.UsuarioTextEdit.Location = New System.Drawing.Point(251, 167)
        Me.UsuarioTextEdit.Name = "UsuarioTextEdit"
        Me.UsuarioTextEdit.Properties.AccessibleRole = System.Windows.Forms.AccessibleRole.[Default]
        Me.UsuarioTextEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[Default]
        Me.UsuarioTextEdit.Properties.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.UsuarioTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.UsuarioTextEdit.Properties.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.UsuarioTextEdit.Properties.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.UsuarioTextEdit.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.UsuarioTextEdit.Properties.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.UsuarioTextEdit.Properties.AppearanceDisabled.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.UsuarioTextEdit.Properties.AppearanceDisabled.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.UsuarioTextEdit.Properties.AppearanceDisabled.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.UsuarioTextEdit.Properties.AppearanceDisabled.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.UsuarioTextEdit.Properties.AppearanceDisabled.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.UsuarioTextEdit.Properties.AppearanceDisabled.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.UsuarioTextEdit.Properties.AppearanceFocused.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.UsuarioTextEdit.Properties.AppearanceFocused.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.UsuarioTextEdit.Properties.AppearanceFocused.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.UsuarioTextEdit.Properties.AppearanceFocused.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.UsuarioTextEdit.Properties.AppearanceFocused.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.UsuarioTextEdit.Properties.AppearanceFocused.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.UsuarioTextEdit.Properties.AppearanceReadOnly.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.UsuarioTextEdit.Properties.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.UsuarioTextEdit.Properties.AppearanceReadOnly.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.UsuarioTextEdit.Properties.AppearanceReadOnly.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.UsuarioTextEdit.Properties.AppearanceReadOnly.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.UsuarioTextEdit.Properties.AppearanceReadOnly.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.UsuarioTextEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.[Default]
        Me.UsuarioTextEdit.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.UsuarioTextEdit.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.[Default]
        Me.UsuarioTextEdit.Properties.ExportMode = DevExpress.XtraEditors.Repository.ExportMode.[Default]
        Me.UsuarioTextEdit.Properties.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin
        Me.UsuarioTextEdit.Properties.Mask.AutoComplete = DevExpress.XtraEditors.Mask.AutoCompleteType.[Default]
        Me.UsuarioTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
        Me.UsuarioTextEdit.Size = New System.Drawing.Size(144, 20)
        Me.UsuarioTextEdit.TabIndex = 3
        Me.UsuarioTextEdit.ToolTipIconType = DevExpress.Utils.ToolTipIconType.None
        '
        'ContrasenaTextEdit
        '
        Me.ContrasenaTextEdit.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.[Default]
        Me.ContrasenaTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.JuecesBindingSource, "Contrasena", True))
        Me.ContrasenaTextEdit.Location = New System.Drawing.Point(251, 193)
        Me.ContrasenaTextEdit.Name = "ContrasenaTextEdit"
        Me.ContrasenaTextEdit.Properties.AccessibleRole = System.Windows.Forms.AccessibleRole.[Default]
        Me.ContrasenaTextEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[Default]
        Me.ContrasenaTextEdit.Properties.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.ContrasenaTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.ContrasenaTextEdit.Properties.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.ContrasenaTextEdit.Properties.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.ContrasenaTextEdit.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.ContrasenaTextEdit.Properties.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.ContrasenaTextEdit.Properties.AppearanceDisabled.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.ContrasenaTextEdit.Properties.AppearanceDisabled.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.ContrasenaTextEdit.Properties.AppearanceDisabled.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.ContrasenaTextEdit.Properties.AppearanceDisabled.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.ContrasenaTextEdit.Properties.AppearanceDisabled.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.ContrasenaTextEdit.Properties.AppearanceDisabled.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.ContrasenaTextEdit.Properties.AppearanceFocused.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.ContrasenaTextEdit.Properties.AppearanceFocused.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.ContrasenaTextEdit.Properties.AppearanceFocused.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.ContrasenaTextEdit.Properties.AppearanceFocused.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.ContrasenaTextEdit.Properties.AppearanceFocused.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.ContrasenaTextEdit.Properties.AppearanceFocused.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.ContrasenaTextEdit.Properties.AppearanceReadOnly.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.ContrasenaTextEdit.Properties.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.ContrasenaTextEdit.Properties.AppearanceReadOnly.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.ContrasenaTextEdit.Properties.AppearanceReadOnly.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.ContrasenaTextEdit.Properties.AppearanceReadOnly.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.ContrasenaTextEdit.Properties.AppearanceReadOnly.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.ContrasenaTextEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.[Default]
        Me.ContrasenaTextEdit.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.ContrasenaTextEdit.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.[Default]
        Me.ContrasenaTextEdit.Properties.ExportMode = DevExpress.XtraEditors.Repository.ExportMode.[Default]
        Me.ContrasenaTextEdit.Properties.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin
        Me.ContrasenaTextEdit.Properties.Mask.AutoComplete = DevExpress.XtraEditors.Mask.AutoCompleteType.[Default]
        Me.ContrasenaTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
        Me.ContrasenaTextEdit.Properties.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.ContrasenaTextEdit.Size = New System.Drawing.Size(144, 20)
        Me.ContrasenaTextEdit.TabIndex = 4
        Me.ContrasenaTextEdit.ToolTipIconType = DevExpress.Utils.ToolTipIconType.None
        '
        'NombreTextEdit
        '
        Me.NombreTextEdit.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.[Default]
        Me.NombreTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.JuecesBindingSource, "Nombre", True))
        Me.NombreTextEdit.Location = New System.Drawing.Point(251, 41)
        Me.NombreTextEdit.Name = "NombreTextEdit"
        Me.NombreTextEdit.Properties.AccessibleRole = System.Windows.Forms.AccessibleRole.[Default]
        Me.NombreTextEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[Default]
        Me.NombreTextEdit.Properties.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.NombreTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.NombreTextEdit.Properties.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.NombreTextEdit.Properties.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.NombreTextEdit.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.NombreTextEdit.Properties.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.NombreTextEdit.Properties.AppearanceDisabled.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.NombreTextEdit.Properties.AppearanceDisabled.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.NombreTextEdit.Properties.AppearanceDisabled.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.NombreTextEdit.Properties.AppearanceDisabled.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.NombreTextEdit.Properties.AppearanceDisabled.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.NombreTextEdit.Properties.AppearanceDisabled.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.NombreTextEdit.Properties.AppearanceFocused.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.NombreTextEdit.Properties.AppearanceFocused.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.NombreTextEdit.Properties.AppearanceFocused.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.NombreTextEdit.Properties.AppearanceFocused.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.NombreTextEdit.Properties.AppearanceFocused.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.NombreTextEdit.Properties.AppearanceFocused.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.NombreTextEdit.Properties.AppearanceReadOnly.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.NombreTextEdit.Properties.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.NombreTextEdit.Properties.AppearanceReadOnly.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.NombreTextEdit.Properties.AppearanceReadOnly.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.NombreTextEdit.Properties.AppearanceReadOnly.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.NombreTextEdit.Properties.AppearanceReadOnly.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.NombreTextEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.[Default]
        Me.NombreTextEdit.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.NombreTextEdit.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.[Default]
        Me.NombreTextEdit.Properties.ExportMode = DevExpress.XtraEditors.Repository.ExportMode.[Default]
        Me.NombreTextEdit.Properties.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin
        Me.NombreTextEdit.Properties.Mask.AutoComplete = DevExpress.XtraEditors.Mask.AutoCompleteType.[Default]
        Me.NombreTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
        Me.NombreTextEdit.Size = New System.Drawing.Size(219, 20)
        Me.NombreTextEdit.TabIndex = 0
        Me.NombreTextEdit.ToolTipIconType = DevExpress.Utils.ToolTipIconType.None
        '
        'ApellidoTextEdit
        '
        Me.ApellidoTextEdit.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.[Default]
        Me.ApellidoTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.JuecesBindingSource, "Apellido", True))
        Me.ApellidoTextEdit.Location = New System.Drawing.Point(251, 67)
        Me.ApellidoTextEdit.Name = "ApellidoTextEdit"
        Me.ApellidoTextEdit.Properties.AccessibleRole = System.Windows.Forms.AccessibleRole.[Default]
        Me.ApellidoTextEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[Default]
        Me.ApellidoTextEdit.Properties.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.ApellidoTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.ApellidoTextEdit.Properties.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.ApellidoTextEdit.Properties.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.ApellidoTextEdit.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.ApellidoTextEdit.Properties.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.ApellidoTextEdit.Properties.AppearanceDisabled.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.ApellidoTextEdit.Properties.AppearanceDisabled.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.ApellidoTextEdit.Properties.AppearanceDisabled.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.ApellidoTextEdit.Properties.AppearanceDisabled.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.ApellidoTextEdit.Properties.AppearanceDisabled.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.ApellidoTextEdit.Properties.AppearanceDisabled.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.ApellidoTextEdit.Properties.AppearanceFocused.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.ApellidoTextEdit.Properties.AppearanceFocused.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.ApellidoTextEdit.Properties.AppearanceFocused.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.ApellidoTextEdit.Properties.AppearanceFocused.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.ApellidoTextEdit.Properties.AppearanceFocused.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.ApellidoTextEdit.Properties.AppearanceFocused.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.ApellidoTextEdit.Properties.AppearanceReadOnly.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.ApellidoTextEdit.Properties.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.ApellidoTextEdit.Properties.AppearanceReadOnly.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.ApellidoTextEdit.Properties.AppearanceReadOnly.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.ApellidoTextEdit.Properties.AppearanceReadOnly.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.ApellidoTextEdit.Properties.AppearanceReadOnly.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.ApellidoTextEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.[Default]
        Me.ApellidoTextEdit.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.ApellidoTextEdit.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.[Default]
        Me.ApellidoTextEdit.Properties.ExportMode = DevExpress.XtraEditors.Repository.ExportMode.[Default]
        Me.ApellidoTextEdit.Properties.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin
        Me.ApellidoTextEdit.Properties.Mask.AutoComplete = DevExpress.XtraEditors.Mask.AutoCompleteType.[Default]
        Me.ApellidoTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
        Me.ApellidoTextEdit.Size = New System.Drawing.Size(219, 20)
        Me.ApellidoTextEdit.TabIndex = 1
        Me.ApellidoTextEdit.ToolTipIconType = DevExpress.Utils.ToolTipIconType.None
        '
        'AnioParticipacionTextEdit
        '
        Me.AnioParticipacionTextEdit.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.[Default]
        Me.AnioParticipacionTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.JuecesBindingSource, "AnioParticipacion", True))
        Me.AnioParticipacionTextEdit.Location = New System.Drawing.Point(251, 93)
        Me.AnioParticipacionTextEdit.Name = "AnioParticipacionTextEdit"
        Me.AnioParticipacionTextEdit.Properties.AccessibleRole = System.Windows.Forms.AccessibleRole.[Default]
        Me.AnioParticipacionTextEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[Default]
        Me.AnioParticipacionTextEdit.Properties.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.AnioParticipacionTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.AnioParticipacionTextEdit.Properties.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.AnioParticipacionTextEdit.Properties.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.AnioParticipacionTextEdit.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.AnioParticipacionTextEdit.Properties.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.AnioParticipacionTextEdit.Properties.AppearanceDisabled.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.AnioParticipacionTextEdit.Properties.AppearanceDisabled.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.AnioParticipacionTextEdit.Properties.AppearanceDisabled.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.AnioParticipacionTextEdit.Properties.AppearanceDisabled.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.AnioParticipacionTextEdit.Properties.AppearanceDisabled.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.AnioParticipacionTextEdit.Properties.AppearanceDisabled.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.AnioParticipacionTextEdit.Properties.AppearanceFocused.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.AnioParticipacionTextEdit.Properties.AppearanceFocused.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.AnioParticipacionTextEdit.Properties.AppearanceFocused.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.AnioParticipacionTextEdit.Properties.AppearanceFocused.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.AnioParticipacionTextEdit.Properties.AppearanceFocused.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.AnioParticipacionTextEdit.Properties.AppearanceFocused.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.AnioParticipacionTextEdit.Properties.AppearanceReadOnly.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.AnioParticipacionTextEdit.Properties.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.AnioParticipacionTextEdit.Properties.AppearanceReadOnly.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.AnioParticipacionTextEdit.Properties.AppearanceReadOnly.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.AnioParticipacionTextEdit.Properties.AppearanceReadOnly.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.AnioParticipacionTextEdit.Properties.AppearanceReadOnly.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.AnioParticipacionTextEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.[Default]
        Me.AnioParticipacionTextEdit.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.AnioParticipacionTextEdit.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.[Default]
        Me.AnioParticipacionTextEdit.Properties.ExportMode = DevExpress.XtraEditors.Repository.ExportMode.[Default]
        Me.AnioParticipacionTextEdit.Properties.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin
        Me.AnioParticipacionTextEdit.Properties.Mask.AutoComplete = DevExpress.XtraEditors.Mask.AutoCompleteType.[Default]
        Me.AnioParticipacionTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
        Me.AnioParticipacionTextEdit.Size = New System.Drawing.Size(73, 20)
        Me.AnioParticipacionTextEdit.TabIndex = 2
        Me.AnioParticipacionTextEdit.ToolTipIconType = DevExpress.Utils.ToolTipIconType.None
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(3, 3)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(629, 294)
        Me.ShapeContainer1.TabIndex = 15
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape1
        '
        Me.LineShape1.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 16
        Me.LineShape1.X2 = 608
        Me.LineShape1.Y1 = 137
        Me.LineShape1.Y2 = 137
        '
        'JuecesTableAdapter
        '
        Me.JuecesTableAdapter.ClearBeforeFill = True
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
        'XFormAgregarJuez
        '
        Me.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(662, 324)
        Me.Controls.Add(Me.PanelControl1)
        Me.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin
        Me.Name = "XFormAgregarJuez"
        Me.Text = "Agregar juez"
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.JuecesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSetFestival, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepContrasenaTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UsuarioTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ContrasenaTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NombreTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ApellidoTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AnioParticipacionTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents DataSetFestival As EvaluacionJurado.DataSetFestival
    Friend WithEvents JuecesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents JuecesTableAdapter As EvaluacionJurado.DataSetFestivalTableAdapters.JuecesTableAdapter
    Friend WithEvents TableAdapterManager As EvaluacionJurado.DataSetFestivalTableAdapters.TableAdapterManager
    Friend WithEvents UsuarioTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ContrasenaTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents NombreTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ApellidoTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btnAgregarJuez As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents RepContrasenaTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents AnioParticipacionTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
End Class
