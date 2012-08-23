<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class XFormFestival
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
        Dim DescripcionLabel As System.Windows.Forms.Label
        Dim HomenajeadoLabel As System.Windows.Forms.Label
        Dim AñoLabel As System.Windows.Forms.Label
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.btnOK = New DevExpress.XtraEditors.SimpleButton()
        Me.DescripcionTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.FestivalBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSetFestival = New EvaluacionJurado.DataSetFestival()
        Me.HomenajeadoTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.AñoTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.FestivalTableAdapter = New EvaluacionJurado.DataSetFestivalTableAdapters.FestivalTableAdapter()
        Me.TableAdapterManager = New EvaluacionJurado.DataSetFestivalTableAdapters.TableAdapterManager()
        DescripcionLabel = New System.Windows.Forms.Label()
        HomenajeadoLabel = New System.Windows.Forms.Label()
        AñoLabel = New System.Windows.Forms.Label()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.DescripcionTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FestivalBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSetFestival, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HomenajeadoTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AñoTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DescripcionLabel
        '
        DescripcionLabel.AutoSize = True
        DescripcionLabel.Font = New System.Drawing.Font("Tahoma", 12.0!)
        DescripcionLabel.Location = New System.Drawing.Point(94, 62)
        DescripcionLabel.Name = "DescripcionLabel"
        DescripcionLabel.Size = New System.Drawing.Size(90, 19)
        DescripcionLabel.TabIndex = 2
        DescripcionLabel.Text = "Descripción"
        '
        'HomenajeadoLabel
        '
        HomenajeadoLabel.AutoSize = True
        HomenajeadoLabel.Font = New System.Drawing.Font("Tahoma", 12.0!)
        HomenajeadoLabel.Location = New System.Drawing.Point(77, 104)
        HomenajeadoLabel.Name = "HomenajeadoLabel"
        HomenajeadoLabel.Size = New System.Drawing.Size(107, 19)
        HomenajeadoLabel.TabIndex = 4
        HomenajeadoLabel.Text = "Homenajeado"
        '
        'AñoLabel
        '
        AñoLabel.AutoSize = True
        AñoLabel.Font = New System.Drawing.Font("Tahoma", 12.0!)
        AñoLabel.Location = New System.Drawing.Point(146, 147)
        AñoLabel.Name = "AñoLabel"
        AñoLabel.Size = New System.Drawing.Size(38, 19)
        AñoLabel.TabIndex = 6
        AñoLabel.Text = "Año"
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
        Me.PanelControl1.Controls.Add(Me.btnOK)
        Me.PanelControl1.Controls.Add(DescripcionLabel)
        Me.PanelControl1.Controls.Add(Me.DescripcionTextEdit)
        Me.PanelControl1.Controls.Add(HomenajeadoLabel)
        Me.PanelControl1.Controls.Add(Me.HomenajeadoTextEdit)
        Me.PanelControl1.Controls.Add(AñoLabel)
        Me.PanelControl1.Controls.Add(Me.AñoTextEdit)
        Me.PanelControl1.Location = New System.Drawing.Point(76, 34)
        Me.PanelControl1.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(564, 291)
        Me.PanelControl1.TabIndex = 0
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
        Me.btnOK.Location = New System.Drawing.Point(338, 213)
        Me.btnOK.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(167, 41)
        Me.btnOK.TabIndex = 8
        Me.btnOK.ToolTipIconType = DevExpress.Utils.ToolTipIconType.None
        '
        'DescripcionTextEdit
        '
        Me.DescripcionTextEdit.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.[Default]
        Me.DescripcionTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.FestivalBindingSource, "Descripcion", True))
        Me.DescripcionTextEdit.Location = New System.Drawing.Point(235, 59)
        Me.DescripcionTextEdit.Name = "DescripcionTextEdit"
        Me.DescripcionTextEdit.Properties.AccessibleRole = System.Windows.Forms.AccessibleRole.[Default]
        Me.DescripcionTextEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[Default]
        Me.DescripcionTextEdit.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.DescripcionTextEdit.Properties.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.DescripcionTextEdit.Properties.Appearance.Options.UseFont = True
        Me.DescripcionTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.DescripcionTextEdit.Properties.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.DescripcionTextEdit.Properties.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.DescripcionTextEdit.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.DescripcionTextEdit.Properties.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.DescripcionTextEdit.Properties.AppearanceDisabled.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.DescripcionTextEdit.Properties.AppearanceDisabled.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.DescripcionTextEdit.Properties.AppearanceDisabled.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.DescripcionTextEdit.Properties.AppearanceDisabled.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.DescripcionTextEdit.Properties.AppearanceDisabled.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.DescripcionTextEdit.Properties.AppearanceDisabled.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.DescripcionTextEdit.Properties.AppearanceFocused.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.DescripcionTextEdit.Properties.AppearanceFocused.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.DescripcionTextEdit.Properties.AppearanceFocused.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.DescripcionTextEdit.Properties.AppearanceFocused.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.DescripcionTextEdit.Properties.AppearanceFocused.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.DescripcionTextEdit.Properties.AppearanceFocused.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.DescripcionTextEdit.Properties.AppearanceReadOnly.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.DescripcionTextEdit.Properties.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.DescripcionTextEdit.Properties.AppearanceReadOnly.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.DescripcionTextEdit.Properties.AppearanceReadOnly.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.DescripcionTextEdit.Properties.AppearanceReadOnly.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.DescripcionTextEdit.Properties.AppearanceReadOnly.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.DescripcionTextEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.[Default]
        Me.DescripcionTextEdit.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.DescripcionTextEdit.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.[Default]
        Me.DescripcionTextEdit.Properties.ExportMode = DevExpress.XtraEditors.Repository.ExportMode.[Default]
        Me.DescripcionTextEdit.Properties.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin
        Me.DescripcionTextEdit.Properties.Mask.AutoComplete = DevExpress.XtraEditors.Mask.AutoCompleteType.[Default]
        Me.DescripcionTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
        Me.DescripcionTextEdit.Size = New System.Drawing.Size(270, 26)
        Me.DescripcionTextEdit.TabIndex = 3
        Me.DescripcionTextEdit.ToolTipIconType = DevExpress.Utils.ToolTipIconType.None
        '
        'FestivalBindingSource
        '
        Me.FestivalBindingSource.DataMember = "Festival"
        Me.FestivalBindingSource.DataSource = Me.DataSetFestival
        '
        'DataSetFestival
        '
        Me.DataSetFestival.DataSetName = "DataSetFestival"
        Me.DataSetFestival.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'HomenajeadoTextEdit
        '
        Me.HomenajeadoTextEdit.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.[Default]
        Me.HomenajeadoTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.FestivalBindingSource, "Homenajeado", True))
        Me.HomenajeadoTextEdit.Location = New System.Drawing.Point(235, 101)
        Me.HomenajeadoTextEdit.Name = "HomenajeadoTextEdit"
        Me.HomenajeadoTextEdit.Properties.AccessibleRole = System.Windows.Forms.AccessibleRole.[Default]
        Me.HomenajeadoTextEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[Default]
        Me.HomenajeadoTextEdit.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.HomenajeadoTextEdit.Properties.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.HomenajeadoTextEdit.Properties.Appearance.Options.UseFont = True
        Me.HomenajeadoTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.HomenajeadoTextEdit.Properties.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.HomenajeadoTextEdit.Properties.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.HomenajeadoTextEdit.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.HomenajeadoTextEdit.Properties.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.HomenajeadoTextEdit.Properties.AppearanceDisabled.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.HomenajeadoTextEdit.Properties.AppearanceDisabled.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.HomenajeadoTextEdit.Properties.AppearanceDisabled.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.HomenajeadoTextEdit.Properties.AppearanceDisabled.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.HomenajeadoTextEdit.Properties.AppearanceDisabled.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.HomenajeadoTextEdit.Properties.AppearanceDisabled.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.HomenajeadoTextEdit.Properties.AppearanceFocused.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.HomenajeadoTextEdit.Properties.AppearanceFocused.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.HomenajeadoTextEdit.Properties.AppearanceFocused.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.HomenajeadoTextEdit.Properties.AppearanceFocused.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.HomenajeadoTextEdit.Properties.AppearanceFocused.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.HomenajeadoTextEdit.Properties.AppearanceFocused.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.HomenajeadoTextEdit.Properties.AppearanceReadOnly.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.HomenajeadoTextEdit.Properties.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.HomenajeadoTextEdit.Properties.AppearanceReadOnly.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.HomenajeadoTextEdit.Properties.AppearanceReadOnly.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.HomenajeadoTextEdit.Properties.AppearanceReadOnly.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.HomenajeadoTextEdit.Properties.AppearanceReadOnly.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.HomenajeadoTextEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.[Default]
        Me.HomenajeadoTextEdit.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.HomenajeadoTextEdit.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.[Default]
        Me.HomenajeadoTextEdit.Properties.ExportMode = DevExpress.XtraEditors.Repository.ExportMode.[Default]
        Me.HomenajeadoTextEdit.Properties.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin
        Me.HomenajeadoTextEdit.Properties.Mask.AutoComplete = DevExpress.XtraEditors.Mask.AutoCompleteType.[Default]
        Me.HomenajeadoTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
        Me.HomenajeadoTextEdit.Size = New System.Drawing.Size(270, 26)
        Me.HomenajeadoTextEdit.TabIndex = 5
        Me.HomenajeadoTextEdit.ToolTipIconType = DevExpress.Utils.ToolTipIconType.None
        '
        'AñoTextEdit
        '
        Me.AñoTextEdit.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.[Default]
        Me.AñoTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.FestivalBindingSource, "Año", True))
        Me.AñoTextEdit.Location = New System.Drawing.Point(235, 144)
        Me.AñoTextEdit.Name = "AñoTextEdit"
        Me.AñoTextEdit.Properties.AccessibleRole = System.Windows.Forms.AccessibleRole.[Default]
        Me.AñoTextEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[Default]
        Me.AñoTextEdit.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.AñoTextEdit.Properties.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.AñoTextEdit.Properties.Appearance.Options.UseFont = True
        Me.AñoTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.AñoTextEdit.Properties.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.AñoTextEdit.Properties.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.AñoTextEdit.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.AñoTextEdit.Properties.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.AñoTextEdit.Properties.AppearanceDisabled.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.AñoTextEdit.Properties.AppearanceDisabled.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.AñoTextEdit.Properties.AppearanceDisabled.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.AñoTextEdit.Properties.AppearanceDisabled.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.AñoTextEdit.Properties.AppearanceDisabled.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.AñoTextEdit.Properties.AppearanceDisabled.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.AñoTextEdit.Properties.AppearanceFocused.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.AñoTextEdit.Properties.AppearanceFocused.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.AñoTextEdit.Properties.AppearanceFocused.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.AñoTextEdit.Properties.AppearanceFocused.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.AñoTextEdit.Properties.AppearanceFocused.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.AñoTextEdit.Properties.AppearanceFocused.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.AñoTextEdit.Properties.AppearanceReadOnly.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.AñoTextEdit.Properties.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.AñoTextEdit.Properties.AppearanceReadOnly.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.AñoTextEdit.Properties.AppearanceReadOnly.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.AñoTextEdit.Properties.AppearanceReadOnly.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.AñoTextEdit.Properties.AppearanceReadOnly.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.AñoTextEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.[Default]
        Me.AñoTextEdit.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.AñoTextEdit.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.[Default]
        Me.AñoTextEdit.Properties.ExportMode = DevExpress.XtraEditors.Repository.ExportMode.[Default]
        Me.AñoTextEdit.Properties.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin
        Me.AñoTextEdit.Properties.Mask.AutoComplete = DevExpress.XtraEditors.Mask.AutoCompleteType.[Default]
        Me.AñoTextEdit.Properties.Mask.EditMask = "n0"
        Me.AñoTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.AñoTextEdit.Size = New System.Drawing.Size(100, 26)
        Me.AñoTextEdit.TabIndex = 7
        Me.AñoTextEdit.ToolTipIconType = DevExpress.Utils.ToolTipIconType.None
        '
        'FestivalTableAdapter
        '
        Me.FestivalTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CancionTableAdapter = Nothing
        Me.TableAdapterManager.EvaluacionTableAdapter = Nothing
        Me.TableAdapterManager.FestivalTableAdapter = Me.FestivalTableAdapter
        Me.TableAdapterManager.InstitutoTableAdapter = Nothing
        Me.TableAdapterManager.JuecesTableAdapter = Nothing
        Me.TableAdapterManager.ParticipanteTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = EvaluacionJurado.DataSetFestivalTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'XFormFestival
        '
        Me.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(710, 363)
        Me.Controls.Add(Me.PanelControl1)
        Me.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin
        Me.Name = "XFormFestival"
        Me.Text = "Administrar festival"
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.DescripcionTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FestivalBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSetFestival, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HomenajeadoTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AñoTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents DataSetFestival As EvaluacionJurado.DataSetFestival
    Friend WithEvents FestivalBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents FestivalTableAdapter As EvaluacionJurado.DataSetFestivalTableAdapters.FestivalTableAdapter
    Friend WithEvents TableAdapterManager As EvaluacionJurado.DataSetFestivalTableAdapters.TableAdapterManager
    Friend WithEvents DescripcionTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents HomenajeadoTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents AñoTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btnOK As DevExpress.XtraEditors.SimpleButton
End Class
