<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLogin
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtUser = New DevExpress.XtraEditors.TextEdit()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtPass = New DevExpress.XtraEditors.TextEdit()
        Me.btnOK = New DevExpress.XtraEditors.SimpleButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cboTipoAcceso = New System.Windows.Forms.ComboBox()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        CType(Me.txtUser.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPass.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtUser
        '
        Me.txtUser.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.[Default]
        Me.txtUser.Location = New System.Drawing.Point(181, 42)
        Me.txtUser.Name = "txtUser"
        Me.txtUser.Properties.AccessibleRole = System.Windows.Forms.AccessibleRole.[Default]
        Me.txtUser.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[Default]
        Me.txtUser.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.txtUser.Properties.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.txtUser.Properties.Appearance.Options.UseFont = True
        Me.txtUser.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.txtUser.Properties.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.txtUser.Properties.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.txtUser.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.txtUser.Properties.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.txtUser.Properties.AppearanceDisabled.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.txtUser.Properties.AppearanceDisabled.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.txtUser.Properties.AppearanceDisabled.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.txtUser.Properties.AppearanceDisabled.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.txtUser.Properties.AppearanceDisabled.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.txtUser.Properties.AppearanceDisabled.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.txtUser.Properties.AppearanceFocused.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.txtUser.Properties.AppearanceFocused.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.txtUser.Properties.AppearanceFocused.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.txtUser.Properties.AppearanceFocused.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.txtUser.Properties.AppearanceFocused.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.txtUser.Properties.AppearanceFocused.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.txtUser.Properties.AppearanceReadOnly.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.txtUser.Properties.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.txtUser.Properties.AppearanceReadOnly.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.txtUser.Properties.AppearanceReadOnly.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.txtUser.Properties.AppearanceReadOnly.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.txtUser.Properties.AppearanceReadOnly.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.txtUser.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.[Default]
        Me.txtUser.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtUser.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.[Default]
        Me.txtUser.Properties.ExportMode = DevExpress.XtraEditors.Repository.ExportMode.[Default]
        Me.txtUser.Properties.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin
        Me.txtUser.Properties.Mask.AutoComplete = DevExpress.XtraEditors.Mask.AutoCompleteType.[Default]
        Me.txtUser.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
        Me.txtUser.Size = New System.Drawing.Size(208, 26)
        Me.txtUser.TabIndex = 0
        Me.txtUser.ToolTipIconType = DevExpress.Utils.ToolTipIconType.None
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label1.Location = New System.Drawing.Point(85, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Usuario"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label2.Location = New System.Drawing.Point(57, 84)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 20)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Contraseña"
        '
        'txtPass
        '
        Me.txtPass.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.[Default]
        Me.txtPass.Location = New System.Drawing.Point(181, 81)
        Me.txtPass.Name = "txtPass"
        Me.txtPass.Properties.AccessibleRole = System.Windows.Forms.AccessibleRole.[Default]
        Me.txtPass.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[Default]
        Me.txtPass.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.txtPass.Properties.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.txtPass.Properties.Appearance.Options.UseFont = True
        Me.txtPass.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.txtPass.Properties.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.txtPass.Properties.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.txtPass.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.txtPass.Properties.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.txtPass.Properties.AppearanceDisabled.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.txtPass.Properties.AppearanceDisabled.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.txtPass.Properties.AppearanceDisabled.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.txtPass.Properties.AppearanceDisabled.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.txtPass.Properties.AppearanceDisabled.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.txtPass.Properties.AppearanceDisabled.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.txtPass.Properties.AppearanceFocused.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.txtPass.Properties.AppearanceFocused.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.txtPass.Properties.AppearanceFocused.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.txtPass.Properties.AppearanceFocused.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.txtPass.Properties.AppearanceFocused.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.txtPass.Properties.AppearanceFocused.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.txtPass.Properties.AppearanceReadOnly.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.txtPass.Properties.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.txtPass.Properties.AppearanceReadOnly.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.txtPass.Properties.AppearanceReadOnly.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.txtPass.Properties.AppearanceReadOnly.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.txtPass.Properties.AppearanceReadOnly.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.txtPass.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.[Default]
        Me.txtPass.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtPass.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.[Default]
        Me.txtPass.Properties.ExportMode = DevExpress.XtraEditors.Repository.ExportMode.[Default]
        Me.txtPass.Properties.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin
        Me.txtPass.Properties.Mask.AutoComplete = DevExpress.XtraEditors.Mask.AutoCompleteType.[Default]
        Me.txtPass.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
        Me.txtPass.Properties.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPass.Size = New System.Drawing.Size(208, 26)
        Me.txtPass.TabIndex = 1
        Me.txtPass.ToolTipIconType = DevExpress.Utils.ToolTipIconType.None
        '
        'btnOK
        '
        Me.btnOK.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.[Default]
        Me.btnOK.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.btnOK.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.btnOK.Appearance.Options.UseFont = True
        Me.btnOK.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.btnOK.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.btnOK.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.btnOK.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.btnOK.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.btnOK.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.[Default]
        Me.btnOK.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnOK.ImageLocation = DevExpress.XtraEditors.ImageLocation.[Default]
        Me.btnOK.Location = New System.Drawing.Point(280, 163)
        Me.btnOK.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(109, 38)
        Me.btnOK.TabIndex = 3
        Me.btnOK.Text = "&Iniciar sesión"
        Me.btnOK.ToolTipIconType = DevExpress.Utils.ToolTipIconType.None
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label3.Location = New System.Drawing.Point(33, 123)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(116, 20)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Tipo de acceso"
        '
        'cboTipoAcceso
        '
        Me.cboTipoAcceso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTipoAcceso.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.cboTipoAcceso.FormattingEnabled = True
        Me.cboTipoAcceso.Items.AddRange(New Object() {"Juez", "Administrador"})
        Me.cboTipoAcceso.Location = New System.Drawing.Point(181, 120)
        Me.cboTipoAcceso.Name = "cboTipoAcceso"
        Me.cboTipoAcceso.Size = New System.Drawing.Size(208, 28)
        Me.cboTipoAcceso.TabIndex = 2
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
        Me.PanelControl1.Controls.Add(Me.cboTipoAcceso)
        Me.PanelControl1.Controls.Add(Me.txtUser)
        Me.PanelControl1.Controls.Add(Me.Label3)
        Me.PanelControl1.Controls.Add(Me.Label1)
        Me.PanelControl1.Controls.Add(Me.btnOK)
        Me.PanelControl1.Controls.Add(Me.txtPass)
        Me.PanelControl1.Controls.Add(Me.Label2)
        Me.PanelControl1.Location = New System.Drawing.Point(12, 12)
        Me.PanelControl1.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(436, 235)
        Me.PanelControl1.TabIndex = 7
        '
        'frmLogin
        '
        Me.AcceptButton = Me.btnOK
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(458, 259)
        Me.Controls.Add(Me.PanelControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Inicio de sesión"
        CType(Me.txtUser.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPass.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtUser As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtPass As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btnOK As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cboTipoAcceso As System.Windows.Forms.ComboBox
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl

End Class
