<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RFormPrincipal
    Inherits DevExpress.XtraBars.Ribbon.RibbonForm

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
        Me.RibbonControl = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.BarButtonParticipantes = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonInstitutos = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonCanciones = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonJueces = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonCalificar = New DevExpress.XtraBars.BarButtonItem()
        Me.BarStaticItem1 = New DevExpress.XtraBars.BarStaticItem()
        Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem2 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonResultados = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonResultadosTotales = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonFestival = New DevExpress.XtraBars.BarButtonItem()
        Me.RibbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup5 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RPGJuez = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RPGAdmin = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RPGConfig = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonStatusBar = New DevExpress.XtraBars.Ribbon.RibbonStatusBar()
        Me.ClientPanel = New DevExpress.XtraEditors.PanelControl()
        Me.DefaultLookAndFeel1 = New DevExpress.LookAndFeel.DefaultLookAndFeel(Me.components)
        Me.XtraTabbedMdiManager1 = New DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(Me.components)
        CType(Me.RibbonControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XtraTabbedMdiManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RibbonControl
        '
        Me.RibbonControl.ApplicationButtonText = Nothing
        Me.RibbonControl.ButtonGroupsVertAlign = DevExpress.Utils.VertAlignment.[Default]
        Me.RibbonControl.Dock = System.Windows.Forms.DockStyle.Top
        Me.RibbonControl.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.BarButtonParticipantes, Me.BarButtonInstitutos, Me.BarButtonCanciones, Me.BarButtonJueces, Me.BarButtonCalificar, Me.BarStaticItem1, Me.BarButtonItem1, Me.BarButtonItem2, Me.BarButtonResultados, Me.BarButtonResultadosTotales, Me.BarButtonFestival})
        Me.RibbonControl.ItemsVertAlign = DevExpress.Utils.VertAlignment.[Default]
        Me.RibbonControl.Location = New System.Drawing.Point(0, 0)
        Me.RibbonControl.MaxItemId = 12
        Me.RibbonControl.MdiMergeStyle = DevExpress.XtraBars.Ribbon.RibbonMdiMergeStyle.[Default]
        Me.RibbonControl.Name = "RibbonControl"
        Me.RibbonControl.PageCategoryAlignment = DevExpress.XtraBars.Ribbon.RibbonPageCategoryAlignment.[Default]
        Me.RibbonControl.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.RibbonPage1})
        Me.RibbonControl.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.[Default]
        Me.RibbonControl.SelectedPage = Me.RibbonPage1
        Me.RibbonControl.ShowExpandCollapseButton = DevExpress.Utils.DefaultBoolean.[Default]
        Me.RibbonControl.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.[Default]
        Me.RibbonControl.Size = New System.Drawing.Size(927, 147)
        Me.RibbonControl.StatusBar = Me.RibbonStatusBar
        Me.RibbonControl.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.[Default]
        '
        'BarButtonParticipantes
        '
        Me.BarButtonParticipantes.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.[Default]
        Me.BarButtonParticipantes.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.BarButtonParticipantes.AppearanceDisabled.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.BarButtonParticipantes.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.[Default]
        Me.BarButtonParticipantes.Caption = "Listado de participantes"
        Me.BarButtonParticipantes.Id = 1
        Me.BarButtonParticipantes.ItemClickFireMode = DevExpress.XtraBars.BarItemEventFireMode.[Default]
        Me.BarButtonParticipantes.LargeGlyph = Global.EvaluacionJurado.My.Resources.Resources.user_gray
        Me.BarButtonParticipantes.MergeType = DevExpress.XtraBars.BarMenuMerge.Add
        Me.BarButtonParticipantes.Name = "BarButtonParticipantes"
        Me.BarButtonParticipantes.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
        '
        'BarButtonInstitutos
        '
        Me.BarButtonInstitutos.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.[Default]
        Me.BarButtonInstitutos.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.BarButtonInstitutos.AppearanceDisabled.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.BarButtonInstitutos.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.[Default]
        Me.BarButtonInstitutos.Caption = "Institutos"
        Me.BarButtonInstitutos.Id = 2
        Me.BarButtonInstitutos.ItemClickFireMode = DevExpress.XtraBars.BarItemEventFireMode.[Default]
        Me.BarButtonInstitutos.LargeGlyph = Global.EvaluacionJurado.My.Resources.Resources.entity
        Me.BarButtonInstitutos.MergeType = DevExpress.XtraBars.BarMenuMerge.Add
        Me.BarButtonInstitutos.Name = "BarButtonInstitutos"
        Me.BarButtonInstitutos.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
        '
        'BarButtonCanciones
        '
        Me.BarButtonCanciones.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.[Default]
        Me.BarButtonCanciones.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.BarButtonCanciones.AppearanceDisabled.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.BarButtonCanciones.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.[Default]
        Me.BarButtonCanciones.Caption = "Canciones"
        Me.BarButtonCanciones.Id = 3
        Me.BarButtonCanciones.ItemClickFireMode = DevExpress.XtraBars.BarItemEventFireMode.[Default]
        Me.BarButtonCanciones.LargeGlyph = Global.EvaluacionJurado.My.Resources.Resources.music
        Me.BarButtonCanciones.MergeType = DevExpress.XtraBars.BarMenuMerge.Add
        Me.BarButtonCanciones.Name = "BarButtonCanciones"
        Me.BarButtonCanciones.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
        '
        'BarButtonJueces
        '
        Me.BarButtonJueces.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.[Default]
        Me.BarButtonJueces.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.BarButtonJueces.AppearanceDisabled.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.BarButtonJueces.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.[Default]
        Me.BarButtonJueces.Caption = "Jueces"
        Me.BarButtonJueces.Id = 4
        Me.BarButtonJueces.ItemClickFireMode = DevExpress.XtraBars.BarItemEventFireMode.[Default]
        Me.BarButtonJueces.LargeGlyph = Global.EvaluacionJurado.My.Resources.Resources.user_policeman
        Me.BarButtonJueces.MergeType = DevExpress.XtraBars.BarMenuMerge.Add
        Me.BarButtonJueces.Name = "BarButtonJueces"
        Me.BarButtonJueces.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
        '
        'BarButtonCalificar
        '
        Me.BarButtonCalificar.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.[Default]
        Me.BarButtonCalificar.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.BarButtonCalificar.AppearanceDisabled.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.BarButtonCalificar.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.[Default]
        Me.BarButtonCalificar.Caption = "Calificaciones"
        Me.BarButtonCalificar.Id = 5
        Me.BarButtonCalificar.ItemClickFireMode = DevExpress.XtraBars.BarItemEventFireMode.[Default]
        Me.BarButtonCalificar.LargeGlyph = Global.EvaluacionJurado.My.Resources.Resources.page_white_edit
        Me.BarButtonCalificar.MergeType = DevExpress.XtraBars.BarMenuMerge.Add
        Me.BarButtonCalificar.Name = "BarButtonCalificar"
        Me.BarButtonCalificar.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
        '
        'BarStaticItem1
        '
        Me.BarStaticItem1.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.[Default]
        Me.BarStaticItem1.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.BarStaticItem1.Appearance.Options.UseFont = True
        Me.BarStaticItem1.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.BarStaticItem1.AppearanceDisabled.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.BarStaticItem1.AutoSize = DevExpress.XtraBars.BarStaticItemSize.Content
        Me.BarStaticItem1.Caption = "BarStaticItem1"
        Me.BarStaticItem1.Id = 6
        Me.BarStaticItem1.ItemClickFireMode = DevExpress.XtraBars.BarItemEventFireMode.[Default]
        Me.BarStaticItem1.MergeType = DevExpress.XtraBars.BarMenuMerge.Add
        Me.BarStaticItem1.Name = "BarStaticItem1"
        Me.BarStaticItem1.TextAlignment = System.Drawing.StringAlignment.Near
        Me.BarStaticItem1.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
        '
        'BarButtonItem1
        '
        Me.BarButtonItem1.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.[Default]
        Me.BarButtonItem1.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.BarButtonItem1.AppearanceDisabled.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.BarButtonItem1.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.[Default]
        Me.BarButtonItem1.Caption = "Cambiar sesión"
        Me.BarButtonItem1.Id = 7
        Me.BarButtonItem1.ItemClickFireMode = DevExpress.XtraBars.BarItemEventFireMode.[Default]
        Me.BarButtonItem1.LargeGlyph = Global.EvaluacionJurado.My.Resources.Resources.switch
        Me.BarButtonItem1.MergeType = DevExpress.XtraBars.BarMenuMerge.Add
        Me.BarButtonItem1.Name = "BarButtonItem1"
        Me.BarButtonItem1.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
        '
        'BarButtonItem2
        '
        Me.BarButtonItem2.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.[Default]
        Me.BarButtonItem2.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.BarButtonItem2.AppearanceDisabled.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.BarButtonItem2.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.[Default]
        Me.BarButtonItem2.Caption = "Salir"
        Me.BarButtonItem2.Id = 8
        Me.BarButtonItem2.ItemClickFireMode = DevExpress.XtraBars.BarItemEventFireMode.[Default]
        Me.BarButtonItem2.LargeGlyph = Global.EvaluacionJurado.My.Resources.Resources.door_out
        Me.BarButtonItem2.MergeType = DevExpress.XtraBars.BarMenuMerge.Add
        Me.BarButtonItem2.Name = "BarButtonItem2"
        Me.BarButtonItem2.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
        '
        'BarButtonResultados
        '
        Me.BarButtonResultados.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.[Default]
        Me.BarButtonResultados.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.BarButtonResultados.AppearanceDisabled.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.BarButtonResultados.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.[Default]
        Me.BarButtonResultados.Caption = "Resultados Detallados"
        Me.BarButtonResultados.Id = 9
        Me.BarButtonResultados.ItemClickFireMode = DevExpress.XtraBars.BarItemEventFireMode.[Default]
        Me.BarButtonResultados.LargeGlyph = Global.EvaluacionJurado.My.Resources.Resources.application_form_edit
        Me.BarButtonResultados.MergeType = DevExpress.XtraBars.BarMenuMerge.Add
        Me.BarButtonResultados.Name = "BarButtonResultados"
        Me.BarButtonResultados.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
        '
        'BarButtonResultadosTotales
        '
        Me.BarButtonResultadosTotales.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.[Default]
        Me.BarButtonResultadosTotales.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.BarButtonResultadosTotales.AppearanceDisabled.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.BarButtonResultadosTotales.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.[Default]
        Me.BarButtonResultadosTotales.Caption = "Resultados totales"
        Me.BarButtonResultadosTotales.Id = 10
        Me.BarButtonResultadosTotales.ItemClickFireMode = DevExpress.XtraBars.BarItemEventFireMode.[Default]
        Me.BarButtonResultadosTotales.LargeGlyph = Global.EvaluacionJurado.My.Resources.Resources.application_edit
        Me.BarButtonResultadosTotales.MergeType = DevExpress.XtraBars.BarMenuMerge.Add
        Me.BarButtonResultadosTotales.Name = "BarButtonResultadosTotales"
        Me.BarButtonResultadosTotales.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
        '
        'BarButtonFestival
        '
        Me.BarButtonFestival.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.[Default]
        Me.BarButtonFestival.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.BarButtonFestival.AppearanceDisabled.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.BarButtonFestival.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.[Default]
        Me.BarButtonFestival.Caption = "Festival"
        Me.BarButtonFestival.Id = 11
        Me.BarButtonFestival.ItemClickFireMode = DevExpress.XtraBars.BarItemEventFireMode.[Default]
        Me.BarButtonFestival.LargeGlyph = Global.EvaluacionJurado.My.Resources.Resources.star
        Me.BarButtonFestival.MergeType = DevExpress.XtraBars.BarMenuMerge.Add
        Me.BarButtonFestival.Name = "BarButtonFestival"
        Me.BarButtonFestival.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
        '
        'RibbonPage1
        '
        Me.RibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup5, Me.RPGJuez, Me.RPGAdmin, Me.RPGConfig})
        Me.RibbonPage1.ImageAlign = DevExpress.Utils.HorzAlignment.[Default]
        Me.RibbonPage1.Name = "RibbonPage1"
        Me.RibbonPage1.Text = "Menú"
        '
        'RibbonPageGroup5
        '
        Me.RibbonPageGroup5.ItemLinks.Add(Me.BarButtonItem1)
        Me.RibbonPageGroup5.ItemLinks.Add(Me.BarButtonItem2)
        Me.RibbonPageGroup5.Name = "RibbonPageGroup5"
        Me.RibbonPageGroup5.ShowCaptionButton = False
        Me.RibbonPageGroup5.Text = "Inicio"
        '
        'RPGJuez
        '
        Me.RPGJuez.ItemLinks.Add(Me.BarButtonCalificar)
        Me.RPGJuez.Name = "RPGJuez"
        Me.RPGJuez.ShowCaptionButton = False
        Me.RPGJuez.Text = "Juez"
        '
        'RPGAdmin
        '
        Me.RPGAdmin.ItemLinks.Add(Me.BarButtonResultados)
        Me.RPGAdmin.ItemLinks.Add(Me.BarButtonResultadosTotales)
        Me.RPGAdmin.Name = "RPGAdmin"
        Me.RPGAdmin.ShowCaptionButton = False
        Me.RPGAdmin.Text = "Admin"
        '
        'RPGConfig
        '
        Me.RPGConfig.ItemLinks.Add(Me.BarButtonParticipantes)
        Me.RPGConfig.ItemLinks.Add(Me.BarButtonInstitutos)
        Me.RPGConfig.ItemLinks.Add(Me.BarButtonCanciones)
        Me.RPGConfig.ItemLinks.Add(Me.BarButtonJueces)
        Me.RPGConfig.ItemLinks.Add(Me.BarButtonFestival)
        Me.RPGConfig.Name = "RPGConfig"
        Me.RPGConfig.ShowCaptionButton = False
        Me.RPGConfig.Text = "Configuraciones"
        '
        'RibbonStatusBar
        '
        Me.RibbonStatusBar.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.RibbonStatusBar.ItemLinks.Add(Me.BarStaticItem1)
        Me.RibbonStatusBar.Location = New System.Drawing.Point(0, 467)
        Me.RibbonStatusBar.Name = "RibbonStatusBar"
        Me.RibbonStatusBar.Ribbon = Me.RibbonControl
        Me.RibbonStatusBar.Size = New System.Drawing.Size(927, 23)
        '
        'ClientPanel
        '
        Me.ClientPanel.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.ClientPanel.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.ClientPanel.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.ClientPanel.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.ClientPanel.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.ClientPanel.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.ClientPanel.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.ClientPanel.ContentImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.ClientPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ClientPanel.Location = New System.Drawing.Point(0, 147)
        Me.ClientPanel.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin
        Me.ClientPanel.Name = "ClientPanel"
        Me.ClientPanel.Size = New System.Drawing.Size(927, 320)
        Me.ClientPanel.TabIndex = 2
        '
        'DefaultLookAndFeel1
        '
        Me.DefaultLookAndFeel1.LookAndFeel.SkinName = "Money Twins"
        Me.DefaultLookAndFeel1.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin
        '
        'XtraTabbedMdiManager1
        '
        Me.XtraTabbedMdiManager1.AllowDragDrop = DevExpress.Utils.DefaultBoolean.[Default]
        Me.XtraTabbedMdiManager1.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.XtraTabbedMdiManager1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.XtraTabbedMdiManager1.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.XtraTabbedMdiManager1.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.XtraTabbedMdiManager1.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.XtraTabbedMdiManager1.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.XtraTabbedMdiManager1.AppearancePage.Header.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.XtraTabbedMdiManager1.AppearancePage.Header.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.XtraTabbedMdiManager1.AppearancePage.Header.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.XtraTabbedMdiManager1.AppearancePage.Header.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.XtraTabbedMdiManager1.AppearancePage.Header.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.XtraTabbedMdiManager1.AppearancePage.Header.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.XtraTabbedMdiManager1.AppearancePage.HeaderActive.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.XtraTabbedMdiManager1.AppearancePage.HeaderActive.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.XtraTabbedMdiManager1.AppearancePage.HeaderActive.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.XtraTabbedMdiManager1.AppearancePage.HeaderActive.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.XtraTabbedMdiManager1.AppearancePage.HeaderActive.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.XtraTabbedMdiManager1.AppearancePage.HeaderActive.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.XtraTabbedMdiManager1.AppearancePage.HeaderDisabled.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.XtraTabbedMdiManager1.AppearancePage.HeaderDisabled.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.XtraTabbedMdiManager1.AppearancePage.HeaderDisabled.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.XtraTabbedMdiManager1.AppearancePage.HeaderDisabled.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.XtraTabbedMdiManager1.AppearancePage.HeaderDisabled.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.XtraTabbedMdiManager1.AppearancePage.HeaderDisabled.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.XtraTabbedMdiManager1.AppearancePage.HeaderHotTracked.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.XtraTabbedMdiManager1.AppearancePage.HeaderHotTracked.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.XtraTabbedMdiManager1.AppearancePage.HeaderHotTracked.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.XtraTabbedMdiManager1.AppearancePage.HeaderHotTracked.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.XtraTabbedMdiManager1.AppearancePage.HeaderHotTracked.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.XtraTabbedMdiManager1.AppearancePage.HeaderHotTracked.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.XtraTabbedMdiManager1.AppearancePage.PageClient.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.XtraTabbedMdiManager1.AppearancePage.PageClient.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.XtraTabbedMdiManager1.AppearancePage.PageClient.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.XtraTabbedMdiManager1.AppearancePage.PageClient.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.XtraTabbedMdiManager1.AppearancePage.PageClient.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.XtraTabbedMdiManager1.AppearancePage.PageClient.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.XtraTabbedMdiManager1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.[Default]
        Me.XtraTabbedMdiManager1.BorderStylePage = DevExpress.XtraEditors.Controls.BorderStyles.[Default]
        Me.XtraTabbedMdiManager1.ClosePageButtonShowMode = DevExpress.XtraTab.ClosePageButtonShowMode.InAllTabPagesAndTabControlHeader
        Me.XtraTabbedMdiManager1.FloatOnDoubleClick = DevExpress.Utils.DefaultBoolean.[Default]
        Me.XtraTabbedMdiManager1.FloatOnDrag = DevExpress.Utils.DefaultBoolean.[Default]
        Me.XtraTabbedMdiManager1.HeaderAutoFill = DevExpress.Utils.DefaultBoolean.[Default]
        Me.XtraTabbedMdiManager1.HeaderButtons = DevExpress.XtraTab.TabButtons.[Default]
        Me.XtraTabbedMdiManager1.HeaderButtonsShowMode = DevExpress.XtraTab.TabButtonShowMode.[Default]
        Me.XtraTabbedMdiManager1.HeaderLocation = DevExpress.XtraTab.TabHeaderLocation.Top
        Me.XtraTabbedMdiManager1.HeaderOrientation = DevExpress.XtraTab.TabOrientation.[Default]
        Me.XtraTabbedMdiManager1.MdiParent = Me
        Me.XtraTabbedMdiManager1.MultiLine = DevExpress.Utils.DefaultBoolean.[Default]
        Me.XtraTabbedMdiManager1.PageImagePosition = DevExpress.XtraTab.TabPageImagePosition.Near
        Me.XtraTabbedMdiManager1.SetNextMdiChildMode = DevExpress.XtraTabbedMdi.SetNextMdiChildMode.[Default]
        Me.XtraTabbedMdiManager1.ShowHeaderFocus = DevExpress.Utils.DefaultBoolean.[Default]
        Me.XtraTabbedMdiManager1.ShowToolTips = DevExpress.Utils.DefaultBoolean.[Default]
        '
        'RFormPrincipal
        '
        Me.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(927, 490)
        Me.Controls.Add(Me.ClientPanel)
        Me.Controls.Add(Me.RibbonStatusBar)
        Me.Controls.Add(Me.RibbonControl)
        Me.IsMdiContainer = True
        Me.Name = "RFormPrincipal"
        Me.Ribbon = Me.RibbonControl
        Me.StatusBar = Me.RibbonStatusBar
        Me.Text = "RFormPrincipal"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.RibbonControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientPanel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XtraTabbedMdiManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents RibbonControl As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents RibbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RPGConfig As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonStatusBar As DevExpress.XtraBars.Ribbon.RibbonStatusBar
    Friend WithEvents ClientPanel As DevExpress.XtraEditors.PanelControl
    Friend WithEvents DefaultLookAndFeel1 As DevExpress.LookAndFeel.DefaultLookAndFeel
    Friend WithEvents BarButtonParticipantes As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents XtraTabbedMdiManager1 As DevExpress.XtraTabbedMdi.XtraTabbedMdiManager
    Friend WithEvents BarButtonInstitutos As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonCanciones As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonJueces As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonCalificar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarStaticItem1 As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem2 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonResultados As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RPGAdmin As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents BarButtonResultadosTotales As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonFestival As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPageGroup5 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RPGJuez As DevExpress.XtraBars.Ribbon.RibbonPageGroup


End Class
