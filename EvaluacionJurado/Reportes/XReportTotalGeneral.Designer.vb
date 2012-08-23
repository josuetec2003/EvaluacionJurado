<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class XReportTotalGeneral
    Inherits DevExpress.XtraReports.UI.XtraReport

    'XtraReport overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Designer
    'It can be modified using the Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim XrSummary3 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim XrSummary1 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim XrSummary4 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim XrSummary2 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim XrSummary5 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(XReportTotalGeneral))
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
        Me.DataSetFestival1 = New EvaluacionJurado.DataSetFestival()
        Me.TotalGeneralTableAdapter = New EvaluacionJurado.DataSetFestivalTableAdapters.TotalGeneralTableAdapter()
        Me.Title = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.FieldCaption = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.PageInfo = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.DataField = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.PageHeaderBand1 = New DevExpress.XtraReports.UI.PageHeaderBand()
        Me.XrTable1 = New DevExpress.XtraReports.UI.XRTable()
        Me.XrTable2 = New DevExpress.XtraReports.UI.XRTable()
        Me.XrTableRow1 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableRow2 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell1 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell2 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell3 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell4 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.PageFooterBand1 = New DevExpress.XtraReports.UI.PageFooterBand()
        Me.XrPageInfo1 = New DevExpress.XtraReports.UI.XRPageInfo()
        Me.XrPageInfo2 = New DevExpress.XtraReports.UI.XRPageInfo()
        Me.ReportHeaderBand1 = New DevExpress.XtraReports.UI.ReportHeaderBand()
        Me.XrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.TopMarginBand1 = New DevExpress.XtraReports.UI.TopMarginBand()
        Me.BottomMarginBand1 = New DevExpress.XtraReports.UI.BottomMarginBand()
        Me.XrPictureBox1 = New DevExpress.XtraReports.UI.XRPictureBox()
        CType(Me.DataSetFestival1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrTable2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrTable2})
        Me.Detail.HeightF = 38.0!
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Detail.PageBreak = DevExpress.XtraReports.UI.PageBreak.None
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'DataSetFestival1
        '
        Me.DataSetFestival1.DataSetName = "DataSetFestival"
        Me.DataSetFestival1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TotalGeneralTableAdapter
        '
        Me.TotalGeneralTableAdapter.ClearBeforeFill = True
        '
        'Title
        '
        Me.Title.BackColor = System.Drawing.Color.White
        Me.Title.BorderColor = System.Drawing.SystemColors.ControlText
        Me.Title.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.Title.BorderWidth = 1
        Me.Title.Font = New System.Drawing.Font("Tahoma", 24.0!, System.Drawing.FontStyle.Bold)
        Me.Title.ForeColor = System.Drawing.Color.Teal
        Me.Title.Name = "Title"
        '
        'FieldCaption
        '
        Me.FieldCaption.BackColor = System.Drawing.Color.White
        Me.FieldCaption.BorderColor = System.Drawing.SystemColors.ControlText
        Me.FieldCaption.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.FieldCaption.BorderWidth = 1
        Me.FieldCaption.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
        Me.FieldCaption.ForeColor = System.Drawing.Color.Black
        Me.FieldCaption.Name = "FieldCaption"
        '
        'PageInfo
        '
        Me.PageInfo.BackColor = System.Drawing.Color.White
        Me.PageInfo.BorderColor = System.Drawing.SystemColors.ControlText
        Me.PageInfo.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.PageInfo.BorderWidth = 1
        Me.PageInfo.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.PageInfo.ForeColor = System.Drawing.SystemColors.ControlText
        Me.PageInfo.Name = "PageInfo"
        '
        'DataField
        '
        Me.DataField.BackColor = System.Drawing.Color.White
        Me.DataField.BorderColor = System.Drawing.SystemColors.ControlText
        Me.DataField.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.DataField.BorderWidth = 1
        Me.DataField.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.DataField.ForeColor = System.Drawing.SystemColors.ControlText
        Me.DataField.Name = "DataField"
        Me.DataField.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        '
        'PageHeaderBand1
        '
        Me.PageHeaderBand1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrTable1})
        Me.PageHeaderBand1.HeightF = 36.0!
        Me.PageHeaderBand1.Name = "PageHeaderBand1"
        Me.PageHeaderBand1.PageBreak = DevExpress.XtraReports.UI.PageBreak.None
        Me.PageHeaderBand1.PrintOn = DevExpress.XtraReports.UI.PrintOnPages.AllPages
        '
        'XrTable1
        '
        Me.XrTable1.AnchorVertical = DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom
        Me.XrTable1.LocationFloat = New DevExpress.Utils.PointFloat(6.0!, 0.0!)
        Me.XrTable1.Name = "XrTable1"
        Me.XrTable1.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow1})
        Me.XrTable1.SizeF = New System.Drawing.SizeF(638.0!, 36.0!)
        Me.XrTable1.StylePriority.UseTextAlignment = False
        Me.XrTable1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrTable2
        '
        Me.XrTable2.AnchorVertical = CType((DevExpress.XtraReports.UI.VerticalAnchorStyles.Top Or DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom), DevExpress.XtraReports.UI.VerticalAnchorStyles)
        Me.XrTable2.LocationFloat = New DevExpress.Utils.PointFloat(6.0!, 0.0!)
        Me.XrTable2.Name = "XrTable2"
        Me.XrTable2.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow2})
        Me.XrTable2.SizeF = New System.Drawing.SizeF(638.0!, 38.0!)
        '
        'XrTableRow1
        '
        Me.XrTableRow1.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell1, Me.XrTableCell3})
        Me.XrTableRow1.Name = "XrTableRow1"
        Me.XrTableRow1.Weight = 1.0R
        '
        'XrTableRow2
        '
        Me.XrTableRow2.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell2, Me.XrTableCell4})
        Me.XrTableRow2.Name = "XrTableRow2"
        Me.XrTableRow2.Weight = 1.0R
        '
        'XrTableCell1
        '
        Me.XrTableCell1.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell1.CanGrow = False
        Me.XrTableCell1.Name = "XrTableCell1"
        Me.XrTableCell1.Padding = New DevExpress.XtraPrinting.PaddingInfo(10, 10, 10, 10, 100.0!)
        Me.XrTableCell1.StyleName = "FieldCaption"
        Me.XrTableCell1.StylePriority.UseBorders = False
        Me.XrTableCell1.StylePriority.UsePadding = False
        XrSummary3.Func = DevExpress.XtraReports.UI.SummaryFunc.Sum
        XrSummary3.Running = DevExpress.XtraReports.UI.SummaryRunning.None
        Me.XrTableCell1.Summary = XrSummary3
        Me.XrTableCell1.Text = "Nombre del participante"
        Me.XrTableCell1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.XrTableCell1.Weight = 290.236817889079R
        '
        'XrTableCell2
        '
        Me.XrTableCell2.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell2.CanGrow = False
        Me.XrTableCell2.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "TotalGeneral.Nombre")})
        Me.XrTableCell2.Name = "XrTableCell2"
        Me.XrTableCell2.Padding = New DevExpress.XtraPrinting.PaddingInfo(10, 10, 10, 10, 100.0!)
        Me.XrTableCell2.StyleName = "DataField"
        Me.XrTableCell2.StylePriority.UseBorders = False
        Me.XrTableCell2.StylePriority.UsePadding = False
        XrSummary1.Func = DevExpress.XtraReports.UI.SummaryFunc.Sum
        XrSummary1.Running = DevExpress.XtraReports.UI.SummaryRunning.None
        Me.XrTableCell2.Summary = XrSummary1
        Me.XrTableCell2.Weight = 290.236817889079R
        '
        'XrTableCell3
        '
        Me.XrTableCell3.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell3.CanGrow = False
        Me.XrTableCell3.Name = "XrTableCell3"
        Me.XrTableCell3.Padding = New DevExpress.XtraPrinting.PaddingInfo(10, 10, 10, 10, 100.0!)
        Me.XrTableCell3.StyleName = "FieldCaption"
        Me.XrTableCell3.StylePriority.UseBorders = False
        Me.XrTableCell3.StylePriority.UsePadding = False
        Me.XrTableCell3.StylePriority.UseTextAlignment = False
        XrSummary4.Func = DevExpress.XtraReports.UI.SummaryFunc.Sum
        XrSummary4.Running = DevExpress.XtraReports.UI.SummaryRunning.None
        Me.XrTableCell3.Summary = XrSummary4
        Me.XrTableCell3.Text = "Evaluación final"
        Me.XrTableCell3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.XrTableCell3.Weight = 346.763182110921R
        '
        'XrTableCell4
        '
        Me.XrTableCell4.Borders = CType((DevExpress.XtraPrinting.BorderSide.Right Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell4.CanGrow = False
        Me.XrTableCell4.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "TotalGeneral.Total")})
        Me.XrTableCell4.Name = "XrTableCell4"
        Me.XrTableCell4.Padding = New DevExpress.XtraPrinting.PaddingInfo(10, 10, 10, 10, 100.0!)
        Me.XrTableCell4.StyleName = "DataField"
        Me.XrTableCell4.StylePriority.UseBorders = False
        Me.XrTableCell4.StylePriority.UsePadding = False
        Me.XrTableCell4.StylePriority.UseTextAlignment = False
        XrSummary2.Func = DevExpress.XtraReports.UI.SummaryFunc.Sum
        XrSummary2.Running = DevExpress.XtraReports.UI.SummaryRunning.None
        Me.XrTableCell4.Summary = XrSummary2
        Me.XrTableCell4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.XrTableCell4.Weight = 346.763182110921R
        '
        'PageFooterBand1
        '
        Me.PageFooterBand1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrPageInfo1, Me.XrPageInfo2})
        Me.PageFooterBand1.HeightF = 29.0!
        Me.PageFooterBand1.Name = "PageFooterBand1"
        Me.PageFooterBand1.PageBreak = DevExpress.XtraReports.UI.PageBreak.None
        Me.PageFooterBand1.PrintOn = DevExpress.XtraReports.UI.PrintOnPages.AllPages
        '
        'XrPageInfo1
        '
        Me.XrPageInfo1.LocationFloat = New DevExpress.Utils.PointFloat(6.0!, 6.0!)
        Me.XrPageInfo1.Name = "XrPageInfo1"
        Me.XrPageInfo1.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime
        Me.XrPageInfo1.SizeF = New System.Drawing.SizeF(313.0!, 23.0!)
        Me.XrPageInfo1.StyleName = "PageInfo"
        '
        'XrPageInfo2
        '
        Me.XrPageInfo2.Format = "Page {0} of {1}"
        Me.XrPageInfo2.LocationFloat = New DevExpress.Utils.PointFloat(331.0!, 6.0!)
        Me.XrPageInfo2.Name = "XrPageInfo2"
        Me.XrPageInfo2.PageInfo = DevExpress.XtraPrinting.PageInfo.NumberOfTotal
        Me.XrPageInfo2.SizeF = New System.Drawing.SizeF(313.0!, 23.0!)
        Me.XrPageInfo2.StyleName = "PageInfo"
        Me.XrPageInfo2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'ReportHeaderBand1
        '
        Me.ReportHeaderBand1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrPictureBox1, Me.XrLabel1})
        Me.ReportHeaderBand1.HeightF = 166.0!
        Me.ReportHeaderBand1.Name = "ReportHeaderBand1"
        Me.ReportHeaderBand1.PageBreak = DevExpress.XtraReports.UI.PageBreak.None
        '
        'XrLabel1
        '
        Me.XrLabel1.Font = New System.Drawing.Font("Tahoma", 16.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(5.999994!, 113.0!)
        Me.XrLabel1.Name = "XrLabel1"
        Me.XrLabel1.SizeF = New System.Drawing.SizeF(638.0!, 43.0!)
        Me.XrLabel1.StyleName = "Title"
        Me.XrLabel1.StylePriority.UseFont = False
        Me.XrLabel1.StylePriority.UseTextAlignment = False
        XrSummary5.Func = DevExpress.XtraReports.UI.SummaryFunc.Sum
        XrSummary5.Running = DevExpress.XtraReports.UI.SummaryRunning.None
        Me.XrLabel1.Summary = XrSummary5
        Me.XrLabel1.Text = "Reporte de evaluación final"
        Me.XrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'TopMarginBand1
        '
        Me.TopMarginBand1.Name = "TopMarginBand1"
        Me.TopMarginBand1.PageBreak = DevExpress.XtraReports.UI.PageBreak.None
        '
        'BottomMarginBand1
        '
        Me.BottomMarginBand1.Name = "BottomMarginBand1"
        Me.BottomMarginBand1.PageBreak = DevExpress.XtraReports.UI.PageBreak.None
        '
        'XrPictureBox1
        '
        Me.XrPictureBox1.Image = CType(resources.GetObject("XrPictureBox1.Image"), System.Drawing.Image)
        Me.XrPictureBox1.LocationFloat = New DevExpress.Utils.PointFloat(5.999994!, 10.00001!)
        Me.XrPictureBox1.Name = "XrPictureBox1"
        Me.XrPictureBox1.SizeF = New System.Drawing.SizeF(638.0!, 103.0!)
        Me.XrPictureBox1.Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage
        '
        'XReportTotalGeneral
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.PageHeaderBand1, Me.PageFooterBand1, Me.ReportHeaderBand1, Me.TopMarginBand1, Me.BottomMarginBand1})
        Me.DataAdapter = Me.TotalGeneralTableAdapter
        Me.DataMember = "TotalGeneral"
        Me.DataSource = Me.DataSetFestival1
        Me.StyleSheet.AddRange(New DevExpress.XtraReports.UI.XRControlStyle() {Me.Title, Me.FieldCaption, Me.PageInfo, Me.DataField})
        Me.Version = "10.1"
        CType(Me.DataSetFestival1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrTable1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrTable2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents DataSetFestival1 As EvaluacionJurado.DataSetFestival
    Friend WithEvents TotalGeneralTableAdapter As EvaluacionJurado.DataSetFestivalTableAdapters.TotalGeneralTableAdapter
    Friend WithEvents XrTable2 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow2 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell2 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell4 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents Title As DevExpress.XtraReports.UI.XRControlStyle
    Friend WithEvents FieldCaption As DevExpress.XtraReports.UI.XRControlStyle
    Friend WithEvents PageInfo As DevExpress.XtraReports.UI.XRControlStyle
    Friend WithEvents DataField As DevExpress.XtraReports.UI.XRControlStyle
    Friend WithEvents PageHeaderBand1 As DevExpress.XtraReports.UI.PageHeaderBand
    Friend WithEvents XrTable1 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow1 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell1 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell3 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents PageFooterBand1 As DevExpress.XtraReports.UI.PageFooterBand
    Friend WithEvents XrPageInfo1 As DevExpress.XtraReports.UI.XRPageInfo
    Friend WithEvents XrPageInfo2 As DevExpress.XtraReports.UI.XRPageInfo
    Friend WithEvents ReportHeaderBand1 As DevExpress.XtraReports.UI.ReportHeaderBand
    Friend WithEvents XrLabel1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents TopMarginBand1 As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents BottomMarginBand1 As DevExpress.XtraReports.UI.BottomMarginBand
    Friend WithEvents XrPictureBox1 As DevExpress.XtraReports.UI.XRPictureBox
End Class
