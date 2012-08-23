<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class XFormAgregarCancion
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
        Dim InterpreteLabel As System.Windows.Forms.Label
        Dim GeneroLabel As System.Windows.Forms.Label
        Me.DataSetFestival = New EvaluacionJurado.DataSetFestival()
        Me.CancionTableAdapter = New EvaluacionJurado.DataSetFestivalTableAdapters.CancionTableAdapter()
        Me.NombreTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.CancionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.InterpreteTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.btnAgregarCancion = New DevExpress.XtraEditors.SimpleButton()
        Me.GeneroTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.TableAdapterManager = New EvaluacionJurado.DataSetFestivalTableAdapters.TableAdapterManager()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        NombreLabel = New System.Windows.Forms.Label()
        InterpreteLabel = New System.Windows.Forms.Label()
        GeneroLabel = New System.Windows.Forms.Label()
        CType(Me.DataSetFestival, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NombreTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CancionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InterpreteTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GeneroTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'NombreLabel
        '
        NombreLabel.AutoSize = True
        NombreLabel.Font = New System.Drawing.Font("Tahoma", 10.0!)
        NombreLabel.Location = New System.Drawing.Point(54, 73)
        NombreLabel.Name = "NombreLabel"
        NombreLabel.Size = New System.Drawing.Size(57, 17)
        NombreLabel.TabIndex = 3
        NombreLabel.Text = "Nombre"
        '
        'InterpreteLabel
        '
        InterpreteLabel.AutoSize = True
        InterpreteLabel.Font = New System.Drawing.Font("Tahoma", 10.0!)
        InterpreteLabel.Location = New System.Drawing.Point(42, 109)
        InterpreteLabel.Name = "InterpreteLabel"
        InterpreteLabel.Size = New System.Drawing.Size(69, 17)
        InterpreteLabel.TabIndex = 5
        InterpreteLabel.Text = "Interprete"
        '
        'GeneroLabel
        '
        GeneroLabel.AutoSize = True
        GeneroLabel.Font = New System.Drawing.Font("Tahoma", 10.0!)
        GeneroLabel.Location = New System.Drawing.Point(59, 145)
        GeneroLabel.Name = "GeneroLabel"
        GeneroLabel.Size = New System.Drawing.Size(52, 17)
        GeneroLabel.TabIndex = 7
        GeneroLabel.Text = "Genero"
        '
        'DataSetFestival
        '
        Me.DataSetFestival.DataSetName = "DataSetFestival"
        Me.DataSetFestival.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CancionTableAdapter
        '
        Me.CancionTableAdapter.ClearBeforeFill = True
        '
        'NombreTextEdit
        '
        Me.NombreTextEdit.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.[Default]
        Me.NombreTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.CancionBindingSource, "Nombre", True))
        Me.NombreTextEdit.Location = New System.Drawing.Point(142, 70)
        Me.NombreTextEdit.Name = "NombreTextEdit"
        Me.NombreTextEdit.Properties.AccessibleRole = System.Windows.Forms.AccessibleRole.[Default]
        Me.NombreTextEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[Default]
        Me.NombreTextEdit.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
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
        Me.NombreTextEdit.Size = New System.Drawing.Size(221, 23)
        Me.NombreTextEdit.TabIndex = 0
        Me.NombreTextEdit.ToolTipIconType = DevExpress.Utils.ToolTipIconType.None
        '
        'CancionBindingSource
        '
        Me.CancionBindingSource.DataMember = "Cancion"
        Me.CancionBindingSource.DataSource = Me.DataSetFestival
        '
        'InterpreteTextEdit
        '
        Me.InterpreteTextEdit.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.[Default]
        Me.InterpreteTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.CancionBindingSource, "Interprete", True))
        Me.InterpreteTextEdit.Location = New System.Drawing.Point(142, 106)
        Me.InterpreteTextEdit.Name = "InterpreteTextEdit"
        Me.InterpreteTextEdit.Properties.AccessibleRole = System.Windows.Forms.AccessibleRole.[Default]
        Me.InterpreteTextEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[Default]
        Me.InterpreteTextEdit.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.InterpreteTextEdit.Properties.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.InterpreteTextEdit.Properties.Appearance.Options.UseFont = True
        Me.InterpreteTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.InterpreteTextEdit.Properties.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.InterpreteTextEdit.Properties.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.InterpreteTextEdit.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.InterpreteTextEdit.Properties.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.InterpreteTextEdit.Properties.AppearanceDisabled.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.InterpreteTextEdit.Properties.AppearanceDisabled.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.InterpreteTextEdit.Properties.AppearanceDisabled.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.InterpreteTextEdit.Properties.AppearanceDisabled.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.InterpreteTextEdit.Properties.AppearanceDisabled.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.InterpreteTextEdit.Properties.AppearanceDisabled.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.InterpreteTextEdit.Properties.AppearanceFocused.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.InterpreteTextEdit.Properties.AppearanceFocused.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.InterpreteTextEdit.Properties.AppearanceFocused.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.InterpreteTextEdit.Properties.AppearanceFocused.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.InterpreteTextEdit.Properties.AppearanceFocused.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.InterpreteTextEdit.Properties.AppearanceFocused.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.InterpreteTextEdit.Properties.AppearanceReadOnly.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.InterpreteTextEdit.Properties.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.InterpreteTextEdit.Properties.AppearanceReadOnly.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.InterpreteTextEdit.Properties.AppearanceReadOnly.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.InterpreteTextEdit.Properties.AppearanceReadOnly.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.InterpreteTextEdit.Properties.AppearanceReadOnly.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.InterpreteTextEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.[Default]
        Me.InterpreteTextEdit.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.InterpreteTextEdit.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.[Default]
        Me.InterpreteTextEdit.Properties.ExportMode = DevExpress.XtraEditors.Repository.ExportMode.[Default]
        Me.InterpreteTextEdit.Properties.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin
        Me.InterpreteTextEdit.Properties.Mask.AutoComplete = DevExpress.XtraEditors.Mask.AutoCompleteType.[Default]
        Me.InterpreteTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
        Me.InterpreteTextEdit.Size = New System.Drawing.Size(221, 23)
        Me.InterpreteTextEdit.TabIndex = 1
        Me.InterpreteTextEdit.ToolTipIconType = DevExpress.Utils.ToolTipIconType.None
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
        Me.btnAgregarCancion.Location = New System.Drawing.Point(218, 190)
        Me.btnAgregarCancion.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin
        Me.btnAgregarCancion.Name = "btnAgregarCancion"
        Me.btnAgregarCancion.Size = New System.Drawing.Size(145, 50)
        Me.btnAgregarCancion.TabIndex = 3
        Me.btnAgregarCancion.Text = "Agregar canción"
        Me.btnAgregarCancion.ToolTipIconType = DevExpress.Utils.ToolTipIconType.None
        '
        'GeneroTextEdit
        '
        Me.GeneroTextEdit.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.[Default]
        Me.GeneroTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.CancionBindingSource, "Genero", True))
        Me.GeneroTextEdit.Location = New System.Drawing.Point(142, 142)
        Me.GeneroTextEdit.Name = "GeneroTextEdit"
        Me.GeneroTextEdit.Properties.AccessibleRole = System.Windows.Forms.AccessibleRole.[Default]
        Me.GeneroTextEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[Default]
        Me.GeneroTextEdit.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.GeneroTextEdit.Properties.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.GeneroTextEdit.Properties.Appearance.Options.UseFont = True
        Me.GeneroTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.GeneroTextEdit.Properties.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.GeneroTextEdit.Properties.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.GeneroTextEdit.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.GeneroTextEdit.Properties.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.GeneroTextEdit.Properties.AppearanceDisabled.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.GeneroTextEdit.Properties.AppearanceDisabled.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.GeneroTextEdit.Properties.AppearanceDisabled.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.GeneroTextEdit.Properties.AppearanceDisabled.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.GeneroTextEdit.Properties.AppearanceDisabled.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.GeneroTextEdit.Properties.AppearanceDisabled.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.GeneroTextEdit.Properties.AppearanceFocused.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.GeneroTextEdit.Properties.AppearanceFocused.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.GeneroTextEdit.Properties.AppearanceFocused.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.GeneroTextEdit.Properties.AppearanceFocused.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.GeneroTextEdit.Properties.AppearanceFocused.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.GeneroTextEdit.Properties.AppearanceFocused.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.GeneroTextEdit.Properties.AppearanceReadOnly.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.GeneroTextEdit.Properties.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.GeneroTextEdit.Properties.AppearanceReadOnly.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.GeneroTextEdit.Properties.AppearanceReadOnly.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.GeneroTextEdit.Properties.AppearanceReadOnly.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.GeneroTextEdit.Properties.AppearanceReadOnly.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.GeneroTextEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.[Default]
        Me.GeneroTextEdit.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.GeneroTextEdit.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.[Default]
        Me.GeneroTextEdit.Properties.ExportMode = DevExpress.XtraEditors.Repository.ExportMode.[Default]
        Me.GeneroTextEdit.Properties.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin
        Me.GeneroTextEdit.Properties.Mask.AutoComplete = DevExpress.XtraEditors.Mask.AutoCompleteType.[Default]
        Me.GeneroTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
        Me.GeneroTextEdit.Size = New System.Drawing.Size(221, 23)
        Me.GeneroTextEdit.TabIndex = 2
        Me.GeneroTextEdit.ToolTipIconType = DevExpress.Utils.ToolTipIconType.None
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
        'PanelControl1
        '
        Me.PanelControl1.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.PanelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.PanelControl1.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.PanelControl1.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.PanelControl1.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.PanelControl1.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.PanelControl1.ContentImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.PanelControl1.Controls.Add(Me.InterpreteTextEdit)
        Me.PanelControl1.Controls.Add(Me.GeneroTextEdit)
        Me.PanelControl1.Controls.Add(GeneroLabel)
        Me.PanelControl1.Controls.Add(Me.btnAgregarCancion)
        Me.PanelControl1.Controls.Add(InterpreteLabel)
        Me.PanelControl1.Controls.Add(NombreLabel)
        Me.PanelControl1.Controls.Add(Me.NombreTextEdit)
        Me.PanelControl1.Location = New System.Drawing.Point(12, 12)
        Me.PanelControl1.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(430, 286)
        Me.PanelControl1.TabIndex = 8
        '
        'XFormAgregarCancion
        '
        Me.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(455, 311)
        Me.Controls.Add(Me.PanelControl1)
        Me.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "XFormAgregarCancion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Agregar canción"
        CType(Me.DataSetFestival, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NombreTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CancionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InterpreteTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GeneroTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataSetFestival As EvaluacionJurado.DataSetFestival
    Friend WithEvents CancionBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CancionTableAdapter As EvaluacionJurado.DataSetFestivalTableAdapters.CancionTableAdapter
    Friend WithEvents TableAdapterManager As EvaluacionJurado.DataSetFestivalTableAdapters.TableAdapterManager
    Friend WithEvents NombreTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents InterpreteTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btnAgregarCancion As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GeneroTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
End Class
