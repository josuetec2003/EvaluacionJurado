<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class XFormAgregarParticipante
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
        Dim OrdenParticipacionLabel As System.Windows.Forms.Label
        Dim NombreLabel As System.Windows.Forms.Label
        Dim ApellidoLabel As System.Windows.Forms.Label
        Dim IdInstitutoLabel As System.Windows.Forms.Label
        Dim IdCancionLabel As System.Windows.Forms.Label
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.OrdenParticipacionTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.lblInstituto = New System.Windows.Forms.Label()
        Me.lblCancion = New System.Windows.Forms.Label()
        Me.btnAgregarParticipante = New DevExpress.XtraEditors.SimpleButton()
        Me.btnCancion = New DevExpress.XtraEditors.SimpleButton()
        Me.btnIntituto = New DevExpress.XtraEditors.SimpleButton()
        Me.IdCancionTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.IdInstitutoTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.NombreTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.ApellidoTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.ParticipanteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSetFestival = New EvaluacionJurado.DataSetFestival()
        Me.ParticipanteTableAdapter = New EvaluacionJurado.DataSetFestivalTableAdapters.ParticipanteTableAdapter()
        Me.TableAdapterManager = New EvaluacionJurado.DataSetFestivalTableAdapters.TableAdapterManager()
        OrdenParticipacionLabel = New System.Windows.Forms.Label()
        NombreLabel = New System.Windows.Forms.Label()
        ApellidoLabel = New System.Windows.Forms.Label()
        IdInstitutoLabel = New System.Windows.Forms.Label()
        IdCancionLabel = New System.Windows.Forms.Label()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.OrdenParticipacionTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IdCancionTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IdInstitutoTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NombreTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ApellidoTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ParticipanteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSetFestival, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'OrdenParticipacionLabel
        '
        OrdenParticipacionLabel.AutoSize = True
        OrdenParticipacionLabel.Font = New System.Drawing.Font("Tahoma", 12.0!)
        OrdenParticipacionLabel.Location = New System.Drawing.Point(53, 115)
        OrdenParticipacionLabel.Name = "OrdenParticipacionLabel"
        OrdenParticipacionLabel.Size = New System.Drawing.Size(169, 19)
        OrdenParticipacionLabel.TabIndex = 2
        OrdenParticipacionLabel.Text = "Orden de participación"
        '
        'NombreLabel
        '
        NombreLabel.AutoSize = True
        NombreLabel.Font = New System.Drawing.Font("Tahoma", 12.0!)
        NombreLabel.Location = New System.Drawing.Point(156, 42)
        NombreLabel.Name = "NombreLabel"
        NombreLabel.Size = New System.Drawing.Size(66, 19)
        NombreLabel.TabIndex = 4
        NombreLabel.Text = "Nombre"
        '
        'ApellidoLabel
        '
        ApellidoLabel.AutoSize = True
        ApellidoLabel.Font = New System.Drawing.Font("Tahoma", 12.0!)
        ApellidoLabel.Location = New System.Drawing.Point(155, 77)
        ApellidoLabel.Name = "ApellidoLabel"
        ApellidoLabel.Size = New System.Drawing.Size(67, 19)
        ApellidoLabel.TabIndex = 6
        ApellidoLabel.Text = "Apellido"
        '
        'IdInstitutoLabel
        '
        IdInstitutoLabel.AutoSize = True
        IdInstitutoLabel.Font = New System.Drawing.Font("Tahoma", 12.0!)
        IdInstitutoLabel.Location = New System.Drawing.Point(152, 150)
        IdInstitutoLabel.Name = "IdInstitutoLabel"
        IdInstitutoLabel.Size = New System.Drawing.Size(68, 19)
        IdInstitutoLabel.TabIndex = 10
        IdInstitutoLabel.Text = "Instituto"
        '
        'IdCancionLabel
        '
        IdCancionLabel.AutoSize = True
        IdCancionLabel.Font = New System.Drawing.Font("Tahoma", 12.0!)
        IdCancionLabel.Location = New System.Drawing.Point(155, 189)
        IdCancionLabel.Name = "IdCancionLabel"
        IdCancionLabel.Size = New System.Drawing.Size(65, 19)
        IdCancionLabel.TabIndex = 12
        IdCancionLabel.Text = "Canción"
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
        Me.PanelControl1.Controls.Add(Me.OrdenParticipacionTextEdit)
        Me.PanelControl1.Controls.Add(Me.lblInstituto)
        Me.PanelControl1.Controls.Add(Me.lblCancion)
        Me.PanelControl1.Controls.Add(Me.btnAgregarParticipante)
        Me.PanelControl1.Controls.Add(Me.btnCancion)
        Me.PanelControl1.Controls.Add(Me.btnIntituto)
        Me.PanelControl1.Controls.Add(Me.IdCancionTextEdit)
        Me.PanelControl1.Controls.Add(Me.IdInstitutoTextEdit)
        Me.PanelControl1.Controls.Add(OrdenParticipacionLabel)
        Me.PanelControl1.Controls.Add(NombreLabel)
        Me.PanelControl1.Controls.Add(Me.NombreTextEdit)
        Me.PanelControl1.Controls.Add(ApellidoLabel)
        Me.PanelControl1.Controls.Add(Me.ApellidoTextEdit)
        Me.PanelControl1.Controls.Add(IdInstitutoLabel)
        Me.PanelControl1.Controls.Add(IdCancionLabel)
        Me.PanelControl1.Location = New System.Drawing.Point(49, 47)
        Me.PanelControl1.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(560, 326)
        Me.PanelControl1.TabIndex = 0
        '
        'OrdenParticipacionTextEdit
        '
        Me.OrdenParticipacionTextEdit.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.[Default]
        Me.OrdenParticipacionTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ParticipanteBindingSource, "OrdenParticipacion", True))
        Me.OrdenParticipacionTextEdit.Location = New System.Drawing.Point(257, 112)
        Me.OrdenParticipacionTextEdit.Name = "OrdenParticipacionTextEdit"
        Me.OrdenParticipacionTextEdit.Properties.AccessibleRole = System.Windows.Forms.AccessibleRole.[Default]
        Me.OrdenParticipacionTextEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[Default]
        Me.OrdenParticipacionTextEdit.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.OrdenParticipacionTextEdit.Properties.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.OrdenParticipacionTextEdit.Properties.Appearance.Options.UseFont = True
        Me.OrdenParticipacionTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.OrdenParticipacionTextEdit.Properties.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.OrdenParticipacionTextEdit.Properties.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.OrdenParticipacionTextEdit.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.OrdenParticipacionTextEdit.Properties.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.OrdenParticipacionTextEdit.Properties.AppearanceDisabled.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.OrdenParticipacionTextEdit.Properties.AppearanceDisabled.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.OrdenParticipacionTextEdit.Properties.AppearanceDisabled.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.OrdenParticipacionTextEdit.Properties.AppearanceDisabled.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.OrdenParticipacionTextEdit.Properties.AppearanceDisabled.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.OrdenParticipacionTextEdit.Properties.AppearanceDisabled.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.OrdenParticipacionTextEdit.Properties.AppearanceFocused.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.OrdenParticipacionTextEdit.Properties.AppearanceFocused.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.OrdenParticipacionTextEdit.Properties.AppearanceFocused.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.OrdenParticipacionTextEdit.Properties.AppearanceFocused.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.OrdenParticipacionTextEdit.Properties.AppearanceFocused.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.OrdenParticipacionTextEdit.Properties.AppearanceFocused.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.OrdenParticipacionTextEdit.Properties.AppearanceReadOnly.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.OrdenParticipacionTextEdit.Properties.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.OrdenParticipacionTextEdit.Properties.AppearanceReadOnly.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.OrdenParticipacionTextEdit.Properties.AppearanceReadOnly.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.OrdenParticipacionTextEdit.Properties.AppearanceReadOnly.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.OrdenParticipacionTextEdit.Properties.AppearanceReadOnly.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.OrdenParticipacionTextEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.[Default]
        Me.OrdenParticipacionTextEdit.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.OrdenParticipacionTextEdit.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.[Default]
        Me.OrdenParticipacionTextEdit.Properties.ExportMode = DevExpress.XtraEditors.Repository.ExportMode.[Default]
        Me.OrdenParticipacionTextEdit.Properties.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin
        Me.OrdenParticipacionTextEdit.Properties.Mask.AutoComplete = DevExpress.XtraEditors.Mask.AutoCompleteType.[Default]
        Me.OrdenParticipacionTextEdit.Properties.Mask.BeepOnError = True
        Me.OrdenParticipacionTextEdit.Properties.Mask.EditMask = "n0"
        Me.OrdenParticipacionTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.OrdenParticipacionTextEdit.Size = New System.Drawing.Size(66, 26)
        Me.OrdenParticipacionTextEdit.TabIndex = 2
        Me.OrdenParticipacionTextEdit.ToolTipIconType = DevExpress.Utils.ToolTipIconType.None
        '
        'lblInstituto
        '
        Me.lblInstituto.AutoSize = True
        Me.lblInstituto.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.lblInstituto.Location = New System.Drawing.Point(329, 153)
        Me.lblInstituto.Name = "lblInstituto"
        Me.lblInstituto.Size = New System.Drawing.Size(0, 19)
        Me.lblInstituto.TabIndex = 21
        '
        'lblCancion
        '
        Me.lblCancion.AutoSize = True
        Me.lblCancion.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.lblCancion.Location = New System.Drawing.Point(330, 192)
        Me.lblCancion.Name = "lblCancion"
        Me.lblCancion.Size = New System.Drawing.Size(0, 19)
        Me.lblCancion.TabIndex = 20
        '
        'btnAgregarParticipante
        '
        Me.btnAgregarParticipante.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.[Default]
        Me.btnAgregarParticipante.Appearance.ForeColor = System.Drawing.Color.Black
        Me.btnAgregarParticipante.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.btnAgregarParticipante.Appearance.Options.UseForeColor = True
        Me.btnAgregarParticipante.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.btnAgregarParticipante.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.btnAgregarParticipante.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.btnAgregarParticipante.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.btnAgregarParticipante.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.btnAgregarParticipante.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.[Default]
        Me.btnAgregarParticipante.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnAgregarParticipante.ImageLocation = DevExpress.XtraEditors.ImageLocation.[Default]
        Me.btnAgregarParticipante.Location = New System.Drawing.Point(330, 250)
        Me.btnAgregarParticipante.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin
        Me.btnAgregarParticipante.Name = "btnAgregarParticipante"
        Me.btnAgregarParticipante.Size = New System.Drawing.Size(142, 46)
        Me.btnAgregarParticipante.TabIndex = 7
        Me.btnAgregarParticipante.ToolTipIconType = DevExpress.Utils.ToolTipIconType.None
        '
        'btnCancion
        '
        Me.btnCancion.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.[Default]
        Me.btnCancion.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.btnCancion.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.btnCancion.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.btnCancion.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.btnCancion.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.btnCancion.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.btnCancion.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.[Default]
        Me.btnCancion.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnCancion.ImageLocation = DevExpress.XtraEditors.ImageLocation.[Default]
        Me.btnCancion.Location = New System.Drawing.Point(301, 187)
        Me.btnCancion.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin
        Me.btnCancion.Name = "btnCancion"
        Me.btnCancion.Size = New System.Drawing.Size(22, 23)
        Me.btnCancion.TabIndex = 6
        Me.btnCancion.Text = "..."
        Me.btnCancion.ToolTipIconType = DevExpress.Utils.ToolTipIconType.None
        '
        'btnIntituto
        '
        Me.btnIntituto.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.[Default]
        Me.btnIntituto.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.btnIntituto.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.btnIntituto.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.btnIntituto.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.btnIntituto.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.btnIntituto.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.btnIntituto.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.[Default]
        Me.btnIntituto.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnIntituto.ImageLocation = DevExpress.XtraEditors.ImageLocation.[Default]
        Me.btnIntituto.Location = New System.Drawing.Point(301, 148)
        Me.btnIntituto.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin
        Me.btnIntituto.Name = "btnIntituto"
        Me.btnIntituto.Size = New System.Drawing.Size(22, 23)
        Me.btnIntituto.TabIndex = 4
        Me.btnIntituto.Text = "..."
        Me.btnIntituto.ToolTipIconType = DevExpress.Utils.ToolTipIconType.None
        '
        'IdCancionTextEdit
        '
        Me.IdCancionTextEdit.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.[Default]
        Me.IdCancionTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ParticipanteBindingSource, "IdCancion", True))
        Me.IdCancionTextEdit.Location = New System.Drawing.Point(257, 186)
        Me.IdCancionTextEdit.Name = "IdCancionTextEdit"
        Me.IdCancionTextEdit.Properties.AccessibleRole = System.Windows.Forms.AccessibleRole.[Default]
        Me.IdCancionTextEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[Default]
        Me.IdCancionTextEdit.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.IdCancionTextEdit.Properties.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.IdCancionTextEdit.Properties.Appearance.Options.UseFont = True
        Me.IdCancionTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.IdCancionTextEdit.Properties.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.IdCancionTextEdit.Properties.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.IdCancionTextEdit.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.IdCancionTextEdit.Properties.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.IdCancionTextEdit.Properties.AppearanceDisabled.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.IdCancionTextEdit.Properties.AppearanceDisabled.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.IdCancionTextEdit.Properties.AppearanceDisabled.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.IdCancionTextEdit.Properties.AppearanceDisabled.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.IdCancionTextEdit.Properties.AppearanceDisabled.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.IdCancionTextEdit.Properties.AppearanceDisabled.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.IdCancionTextEdit.Properties.AppearanceFocused.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.IdCancionTextEdit.Properties.AppearanceFocused.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.IdCancionTextEdit.Properties.AppearanceFocused.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.IdCancionTextEdit.Properties.AppearanceFocused.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.IdCancionTextEdit.Properties.AppearanceFocused.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.IdCancionTextEdit.Properties.AppearanceFocused.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.IdCancionTextEdit.Properties.AppearanceReadOnly.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.IdCancionTextEdit.Properties.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.IdCancionTextEdit.Properties.AppearanceReadOnly.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.IdCancionTextEdit.Properties.AppearanceReadOnly.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.IdCancionTextEdit.Properties.AppearanceReadOnly.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.IdCancionTextEdit.Properties.AppearanceReadOnly.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.IdCancionTextEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.[Default]
        Me.IdCancionTextEdit.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.IdCancionTextEdit.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.[Default]
        Me.IdCancionTextEdit.Properties.ExportMode = DevExpress.XtraEditors.Repository.ExportMode.[Default]
        Me.IdCancionTextEdit.Properties.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin
        Me.IdCancionTextEdit.Properties.Mask.AutoComplete = DevExpress.XtraEditors.Mask.AutoCompleteType.[Default]
        Me.IdCancionTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
        Me.IdCancionTextEdit.Properties.ReadOnly = True
        Me.IdCancionTextEdit.Size = New System.Drawing.Size(38, 26)
        Me.IdCancionTextEdit.TabIndex = 5
        Me.IdCancionTextEdit.ToolTipIconType = DevExpress.Utils.ToolTipIconType.None
        '
        'IdInstitutoTextEdit
        '
        Me.IdInstitutoTextEdit.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.[Default]
        Me.IdInstitutoTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ParticipanteBindingSource, "IdInstituto", True))
        Me.IdInstitutoTextEdit.Location = New System.Drawing.Point(257, 147)
        Me.IdInstitutoTextEdit.Name = "IdInstitutoTextEdit"
        Me.IdInstitutoTextEdit.Properties.AccessibleRole = System.Windows.Forms.AccessibleRole.[Default]
        Me.IdInstitutoTextEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[Default]
        Me.IdInstitutoTextEdit.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.IdInstitutoTextEdit.Properties.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.IdInstitutoTextEdit.Properties.Appearance.Options.UseFont = True
        Me.IdInstitutoTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.IdInstitutoTextEdit.Properties.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.IdInstitutoTextEdit.Properties.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.IdInstitutoTextEdit.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.IdInstitutoTextEdit.Properties.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.IdInstitutoTextEdit.Properties.AppearanceDisabled.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.IdInstitutoTextEdit.Properties.AppearanceDisabled.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.IdInstitutoTextEdit.Properties.AppearanceDisabled.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.IdInstitutoTextEdit.Properties.AppearanceDisabled.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.IdInstitutoTextEdit.Properties.AppearanceDisabled.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.IdInstitutoTextEdit.Properties.AppearanceDisabled.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.IdInstitutoTextEdit.Properties.AppearanceFocused.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.IdInstitutoTextEdit.Properties.AppearanceFocused.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.IdInstitutoTextEdit.Properties.AppearanceFocused.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.IdInstitutoTextEdit.Properties.AppearanceFocused.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.IdInstitutoTextEdit.Properties.AppearanceFocused.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.IdInstitutoTextEdit.Properties.AppearanceFocused.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.IdInstitutoTextEdit.Properties.AppearanceReadOnly.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.IdInstitutoTextEdit.Properties.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.IdInstitutoTextEdit.Properties.AppearanceReadOnly.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.IdInstitutoTextEdit.Properties.AppearanceReadOnly.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.IdInstitutoTextEdit.Properties.AppearanceReadOnly.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.IdInstitutoTextEdit.Properties.AppearanceReadOnly.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.IdInstitutoTextEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.[Default]
        Me.IdInstitutoTextEdit.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.IdInstitutoTextEdit.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.[Default]
        Me.IdInstitutoTextEdit.Properties.ExportMode = DevExpress.XtraEditors.Repository.ExportMode.[Default]
        Me.IdInstitutoTextEdit.Properties.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin
        Me.IdInstitutoTextEdit.Properties.Mask.AutoComplete = DevExpress.XtraEditors.Mask.AutoCompleteType.[Default]
        Me.IdInstitutoTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
        Me.IdInstitutoTextEdit.Properties.ReadOnly = True
        Me.IdInstitutoTextEdit.Size = New System.Drawing.Size(38, 26)
        Me.IdInstitutoTextEdit.TabIndex = 3
        Me.IdInstitutoTextEdit.ToolTipIconType = DevExpress.Utils.ToolTipIconType.None
        '
        'NombreTextEdit
        '
        Me.NombreTextEdit.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.[Default]
        Me.NombreTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ParticipanteBindingSource, "Nombre", True))
        Me.NombreTextEdit.Location = New System.Drawing.Point(257, 39)
        Me.NombreTextEdit.Name = "NombreTextEdit"
        Me.NombreTextEdit.Properties.AccessibleRole = System.Windows.Forms.AccessibleRole.[Default]
        Me.NombreTextEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[Default]
        Me.NombreTextEdit.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.NombreTextEdit.Properties.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.NombreTextEdit.Properties.Appearance.Options.UseFont = True
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
        Me.NombreTextEdit.Size = New System.Drawing.Size(215, 26)
        Me.NombreTextEdit.TabIndex = 0
        Me.NombreTextEdit.ToolTipIconType = DevExpress.Utils.ToolTipIconType.None
        '
        'ApellidoTextEdit
        '
        Me.ApellidoTextEdit.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.[Default]
        Me.ApellidoTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ParticipanteBindingSource, "Apellido", True))
        Me.ApellidoTextEdit.Location = New System.Drawing.Point(257, 74)
        Me.ApellidoTextEdit.Name = "ApellidoTextEdit"
        Me.ApellidoTextEdit.Properties.AccessibleRole = System.Windows.Forms.AccessibleRole.[Default]
        Me.ApellidoTextEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[Default]
        Me.ApellidoTextEdit.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.ApellidoTextEdit.Properties.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.ApellidoTextEdit.Properties.Appearance.Options.UseFont = True
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
        Me.ApellidoTextEdit.Size = New System.Drawing.Size(215, 26)
        Me.ApellidoTextEdit.TabIndex = 1
        Me.ApellidoTextEdit.ToolTipIconType = DevExpress.Utils.ToolTipIconType.None
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
        'ParticipanteTableAdapter
        '
        Me.ParticipanteTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CancionTableAdapter = Nothing
        Me.TableAdapterManager.EvaluacionTableAdapter = Nothing
        Me.TableAdapterManager.FestivalTableAdapter = Nothing
        Me.TableAdapterManager.InstitutoTableAdapter = Nothing
        Me.TableAdapterManager.JuecesTableAdapter = Nothing
        Me.TableAdapterManager.ParticipanteTableAdapter = Me.ParticipanteTableAdapter
        Me.TableAdapterManager.UpdateOrder = EvaluacionJurado.DataSetFestivalTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'XFormAgregarParticipante
        '
        Me.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(684, 428)
        Me.Controls.Add(Me.PanelControl1)
        Me.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin
        Me.Name = "XFormAgregarParticipante"
        Me.Text = "Agregar Participante"
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.OrdenParticipacionTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IdCancionTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IdInstitutoTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NombreTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ApellidoTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ParticipanteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSetFestival, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents DataSetFestival As EvaluacionJurado.DataSetFestival
    Friend WithEvents ParticipanteBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ParticipanteTableAdapter As EvaluacionJurado.DataSetFestivalTableAdapters.ParticipanteTableAdapter
    Friend WithEvents TableAdapterManager As EvaluacionJurado.DataSetFestivalTableAdapters.TableAdapterManager
    Friend WithEvents NombreTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ApellidoTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents IdCancionTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents IdInstitutoTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btnCancion As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnIntituto As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lblCancion As System.Windows.Forms.Label
    Friend WithEvents btnAgregarParticipante As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lblInstituto As System.Windows.Forms.Label
    Friend WithEvents OrdenParticipacionTextEdit As DevExpress.XtraEditors.TextEdit
End Class
