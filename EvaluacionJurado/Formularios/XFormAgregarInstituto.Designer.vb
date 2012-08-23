<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class XFormAgregarInstituto
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
        Dim NombreLabel As System.Windows.Forms.Label
        Dim DireccionLabel As System.Windows.Forms.Label
        Dim TelLabel As System.Windows.Forms.Label
        Dim NombreContactoLabel As System.Windows.Forms.Label
        Me.DataSetFestival = New EvaluacionJurado.DataSetFestival()
        Me.InstitutoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.InstitutoTableAdapter = New EvaluacionJurado.DataSetFestivalTableAdapters.InstitutoTableAdapter()
        Me.TableAdapterManager = New EvaluacionJurado.DataSetFestivalTableAdapters.TableAdapterManager()
        Me.NombreTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.DireccionMemoEdit = New DevExpress.XtraEditors.MemoEdit()
        Me.TelTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.NombreContactoTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.btnOK = New DevExpress.XtraEditors.SimpleButton()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        NombreLabel = New System.Windows.Forms.Label()
        DireccionLabel = New System.Windows.Forms.Label()
        TelLabel = New System.Windows.Forms.Label()
        NombreContactoLabel = New System.Windows.Forms.Label()
        CType(Me.DataSetFestival, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InstitutoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NombreTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DireccionMemoEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TelTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NombreContactoTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'NombreLabel
        '
        NombreLabel.AutoSize = True
        NombreLabel.Font = New System.Drawing.Font("Tahoma", 9.0!)
        NombreLabel.Location = New System.Drawing.Point(118, 34)
        NombreLabel.Name = "NombreLabel"
        NombreLabel.Size = New System.Drawing.Size(50, 14)
        NombreLabel.TabIndex = 3
        NombreLabel.Text = "Nombre"
        '
        'DireccionLabel
        '
        DireccionLabel.AutoSize = True
        DireccionLabel.Font = New System.Drawing.Font("Tahoma", 9.0!)
        DireccionLabel.Location = New System.Drawing.Point(112, 64)
        DireccionLabel.Name = "DireccionLabel"
        DireccionLabel.Size = New System.Drawing.Size(56, 14)
        DireccionLabel.TabIndex = 5
        DireccionLabel.Text = "Dirección"
        '
        'TelLabel
        '
        TelLabel.AutoSize = True
        TelLabel.Font = New System.Drawing.Font("Tahoma", 9.0!)
        TelLabel.Location = New System.Drawing.Point(112, 170)
        TelLabel.Name = "TelLabel"
        TelLabel.Size = New System.Drawing.Size(56, 14)
        TelLabel.TabIndex = 7
        TelLabel.Text = "Teléfono"
        '
        'NombreContactoLabel
        '
        NombreContactoLabel.AutoSize = True
        NombreContactoLabel.Font = New System.Drawing.Font("Tahoma", 9.0!)
        NombreContactoLabel.Location = New System.Drawing.Point(45, 200)
        NombreContactoLabel.Name = "NombreContactoLabel"
        NombreContactoLabel.Size = New System.Drawing.Size(123, 14)
        NombreContactoLabel.TabIndex = 9
        NombreContactoLabel.Text = "Nombre del contacto"
        '
        'DataSetFestival
        '
        Me.DataSetFestival.DataSetName = "DataSetFestival"
        Me.DataSetFestival.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'InstitutoBindingSource
        '
        Me.InstitutoBindingSource.DataMember = "Instituto"
        Me.InstitutoBindingSource.DataSource = Me.DataSetFestival
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
        'NombreTextEdit
        '
        Me.NombreTextEdit.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.[Default]
        Me.NombreTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.InstitutoBindingSource, "Nombre", True))
        Me.NombreTextEdit.Location = New System.Drawing.Point(205, 31)
        Me.NombreTextEdit.Name = "NombreTextEdit"
        Me.NombreTextEdit.Properties.AccessibleRole = System.Windows.Forms.AccessibleRole.[Default]
        Me.NombreTextEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[Default]
        Me.NombreTextEdit.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
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
        Me.NombreTextEdit.Size = New System.Drawing.Size(251, 21)
        Me.NombreTextEdit.TabIndex = 4
        Me.NombreTextEdit.ToolTipIconType = DevExpress.Utils.ToolTipIconType.None
        '
        'DireccionMemoEdit
        '
        Me.DireccionMemoEdit.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.[Default]
        Me.DireccionMemoEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.InstitutoBindingSource, "Direccion", True))
        Me.DireccionMemoEdit.Location = New System.Drawing.Point(205, 61)
        Me.DireccionMemoEdit.Name = "DireccionMemoEdit"
        Me.DireccionMemoEdit.Properties.AccessibleRole = System.Windows.Forms.AccessibleRole.[Default]
        Me.DireccionMemoEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[Default]
        Me.DireccionMemoEdit.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.DireccionMemoEdit.Properties.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.DireccionMemoEdit.Properties.Appearance.Options.UseFont = True
        Me.DireccionMemoEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.DireccionMemoEdit.Properties.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.DireccionMemoEdit.Properties.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.DireccionMemoEdit.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.DireccionMemoEdit.Properties.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.DireccionMemoEdit.Properties.AppearanceDisabled.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.DireccionMemoEdit.Properties.AppearanceDisabled.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.DireccionMemoEdit.Properties.AppearanceDisabled.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.DireccionMemoEdit.Properties.AppearanceDisabled.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.DireccionMemoEdit.Properties.AppearanceDisabled.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.DireccionMemoEdit.Properties.AppearanceDisabled.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.DireccionMemoEdit.Properties.AppearanceFocused.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.DireccionMemoEdit.Properties.AppearanceFocused.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.DireccionMemoEdit.Properties.AppearanceFocused.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.DireccionMemoEdit.Properties.AppearanceFocused.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.DireccionMemoEdit.Properties.AppearanceFocused.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.DireccionMemoEdit.Properties.AppearanceFocused.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.DireccionMemoEdit.Properties.AppearanceReadOnly.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.DireccionMemoEdit.Properties.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.DireccionMemoEdit.Properties.AppearanceReadOnly.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.DireccionMemoEdit.Properties.AppearanceReadOnly.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.DireccionMemoEdit.Properties.AppearanceReadOnly.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.DireccionMemoEdit.Properties.AppearanceReadOnly.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.DireccionMemoEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.[Default]
        Me.DireccionMemoEdit.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.DireccionMemoEdit.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.[Default]
        Me.DireccionMemoEdit.Properties.ExportMode = DevExpress.XtraEditors.Repository.ExportMode.[Default]
        Me.DireccionMemoEdit.Properties.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin
        Me.DireccionMemoEdit.Properties.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DireccionMemoEdit.Size = New System.Drawing.Size(251, 96)
        Me.DireccionMemoEdit.TabIndex = 6
        Me.DireccionMemoEdit.ToolTipIconType = DevExpress.Utils.ToolTipIconType.None
        '
        'TelTextEdit
        '
        Me.TelTextEdit.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.[Default]
        Me.TelTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.InstitutoBindingSource, "Tel", True))
        Me.TelTextEdit.Location = New System.Drawing.Point(205, 167)
        Me.TelTextEdit.Name = "TelTextEdit"
        Me.TelTextEdit.Properties.AccessibleRole = System.Windows.Forms.AccessibleRole.[Default]
        Me.TelTextEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[Default]
        Me.TelTextEdit.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.TelTextEdit.Properties.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.TelTextEdit.Properties.Appearance.Options.UseFont = True
        Me.TelTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.TelTextEdit.Properties.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.TelTextEdit.Properties.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.TelTextEdit.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.TelTextEdit.Properties.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.TelTextEdit.Properties.AppearanceDisabled.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.TelTextEdit.Properties.AppearanceDisabled.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.TelTextEdit.Properties.AppearanceDisabled.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.TelTextEdit.Properties.AppearanceDisabled.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.TelTextEdit.Properties.AppearanceDisabled.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.TelTextEdit.Properties.AppearanceDisabled.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.TelTextEdit.Properties.AppearanceFocused.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.TelTextEdit.Properties.AppearanceFocused.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.TelTextEdit.Properties.AppearanceFocused.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.TelTextEdit.Properties.AppearanceFocused.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.TelTextEdit.Properties.AppearanceFocused.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.TelTextEdit.Properties.AppearanceFocused.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.TelTextEdit.Properties.AppearanceReadOnly.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.TelTextEdit.Properties.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.TelTextEdit.Properties.AppearanceReadOnly.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.TelTextEdit.Properties.AppearanceReadOnly.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.TelTextEdit.Properties.AppearanceReadOnly.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.TelTextEdit.Properties.AppearanceReadOnly.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.TelTextEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.[Default]
        Me.TelTextEdit.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.TelTextEdit.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.[Default]
        Me.TelTextEdit.Properties.ExportMode = DevExpress.XtraEditors.Repository.ExportMode.[Default]
        Me.TelTextEdit.Properties.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin
        Me.TelTextEdit.Properties.Mask.AutoComplete = DevExpress.XtraEditors.Mask.AutoCompleteType.[Default]
        Me.TelTextEdit.Properties.Mask.BeepOnError = True
        Me.TelTextEdit.Properties.Mask.EditMask = "\d\d\d\d-\d\d\d\d"
        Me.TelTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Regular
        Me.TelTextEdit.Size = New System.Drawing.Size(251, 21)
        Me.TelTextEdit.TabIndex = 8
        Me.TelTextEdit.ToolTipIconType = DevExpress.Utils.ToolTipIconType.None
        '
        'NombreContactoTextEdit
        '
        Me.NombreContactoTextEdit.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.[Default]
        Me.NombreContactoTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.InstitutoBindingSource, "NombreContacto", True))
        Me.NombreContactoTextEdit.Location = New System.Drawing.Point(205, 197)
        Me.NombreContactoTextEdit.Name = "NombreContactoTextEdit"
        Me.NombreContactoTextEdit.Properties.AccessibleRole = System.Windows.Forms.AccessibleRole.[Default]
        Me.NombreContactoTextEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[Default]
        Me.NombreContactoTextEdit.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.NombreContactoTextEdit.Properties.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.NombreContactoTextEdit.Properties.Appearance.Options.UseFont = True
        Me.NombreContactoTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.NombreContactoTextEdit.Properties.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.NombreContactoTextEdit.Properties.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.NombreContactoTextEdit.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.NombreContactoTextEdit.Properties.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.NombreContactoTextEdit.Properties.AppearanceDisabled.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.NombreContactoTextEdit.Properties.AppearanceDisabled.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.NombreContactoTextEdit.Properties.AppearanceDisabled.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.NombreContactoTextEdit.Properties.AppearanceDisabled.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.NombreContactoTextEdit.Properties.AppearanceDisabled.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.NombreContactoTextEdit.Properties.AppearanceDisabled.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.NombreContactoTextEdit.Properties.AppearanceFocused.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.NombreContactoTextEdit.Properties.AppearanceFocused.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.NombreContactoTextEdit.Properties.AppearanceFocused.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.NombreContactoTextEdit.Properties.AppearanceFocused.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.NombreContactoTextEdit.Properties.AppearanceFocused.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.NombreContactoTextEdit.Properties.AppearanceFocused.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.NombreContactoTextEdit.Properties.AppearanceReadOnly.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.NombreContactoTextEdit.Properties.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.NombreContactoTextEdit.Properties.AppearanceReadOnly.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.NombreContactoTextEdit.Properties.AppearanceReadOnly.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.NombreContactoTextEdit.Properties.AppearanceReadOnly.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.NombreContactoTextEdit.Properties.AppearanceReadOnly.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.NombreContactoTextEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.[Default]
        Me.NombreContactoTextEdit.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.NombreContactoTextEdit.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.[Default]
        Me.NombreContactoTextEdit.Properties.ExportMode = DevExpress.XtraEditors.Repository.ExportMode.[Default]
        Me.NombreContactoTextEdit.Properties.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin
        Me.NombreContactoTextEdit.Properties.Mask.AutoComplete = DevExpress.XtraEditors.Mask.AutoCompleteType.[Default]
        Me.NombreContactoTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
        Me.NombreContactoTextEdit.Size = New System.Drawing.Size(251, 21)
        Me.NombreContactoTextEdit.TabIndex = 10
        Me.NombreContactoTextEdit.ToolTipIconType = DevExpress.Utils.ToolTipIconType.None
        '
        'btnOK
        '
        Me.btnOK.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.[Default]
        Me.btnOK.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.btnOK.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.btnOK.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.btnOK.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.btnOK.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.btnOK.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.btnOK.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.[Default]
        Me.btnOK.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnOK.ImageLocation = DevExpress.XtraEditors.ImageLocation.[Default]
        Me.btnOK.Location = New System.Drawing.Point(300, 238)
        Me.btnOK.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(156, 50)
        Me.btnOK.TabIndex = 11
        Me.btnOK.Text = "Agregar instituto"
        Me.btnOK.ToolTipIconType = DevExpress.Utils.ToolTipIconType.None
        '
        'PanelControl1
        '
        Me.PanelControl1.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.PanelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.PanelControl1.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.PanelControl1.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.PanelControl1.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.PanelControl1.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.PanelControl1.ContentImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.PanelControl1.Controls.Add(Me.DireccionMemoEdit)
        Me.PanelControl1.Controls.Add(Me.btnOK)
        Me.PanelControl1.Controls.Add(Me.NombreContactoTextEdit)
        Me.PanelControl1.Controls.Add(NombreLabel)
        Me.PanelControl1.Controls.Add(NombreContactoLabel)
        Me.PanelControl1.Controls.Add(Me.NombreTextEdit)
        Me.PanelControl1.Controls.Add(Me.TelTextEdit)
        Me.PanelControl1.Controls.Add(DireccionLabel)
        Me.PanelControl1.Controls.Add(TelLabel)
        Me.PanelControl1.Location = New System.Drawing.Point(12, 12)
        Me.PanelControl1.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(534, 328)
        Me.PanelControl1.TabIndex = 12
        '
        'XFormAgregarInstituto
        '
        Me.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(558, 353)
        Me.Controls.Add(Me.PanelControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "XFormAgregarInstituto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Agregar instituto"
        CType(Me.DataSetFestival, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InstitutoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NombreTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DireccionMemoEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TelTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NombreContactoTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataSetFestival As EvaluacionJurado.DataSetFestival
    Friend WithEvents InstitutoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents InstitutoTableAdapter As EvaluacionJurado.DataSetFestivalTableAdapters.InstitutoTableAdapter
    Friend WithEvents TableAdapterManager As EvaluacionJurado.DataSetFestivalTableAdapters.TableAdapterManager
    Friend WithEvents NombreTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents DireccionMemoEdit As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents TelTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents NombreContactoTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btnOK As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
End Class
