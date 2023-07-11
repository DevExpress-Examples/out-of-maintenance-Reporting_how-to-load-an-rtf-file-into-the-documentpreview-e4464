Imports System
Imports DevExpress.XtraReports.UI

Namespace MinimalisticReportPreviewDemo
	Public Class Report
		Inherits DevExpress.XtraReports.UI.XtraReport

		Private Detail As DevExpress.XtraReports.UI.DetailBand
		Private topMarginBand1 As DevExpress.XtraReports.UI.TopMarginBand
		Private ReportHeader As DevExpress.XtraReports.UI.ReportHeaderBand
		Public xrRichText1 As XRRichText
		Private bottomMarginBand1 As DevExpress.XtraReports.UI.BottomMarginBand

		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub InitializeComponent()
'INSTANT VB NOTE: The variable resources was renamed since it may cause conflicts with calls to static members of the user-defined type with this name:
			Dim resources_Conflict As New System.ComponentModel.ComponentResourceManager(GetType(Report))
			Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
			Me.topMarginBand1 = New DevExpress.XtraReports.UI.TopMarginBand()
			Me.bottomMarginBand1 = New DevExpress.XtraReports.UI.BottomMarginBand()
			Me.ReportHeader = New DevExpress.XtraReports.UI.ReportHeaderBand()
			Me.xrRichText1 = New DevExpress.XtraReports.UI.XRRichText()
			DirectCast(Me.xrRichText1, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me, System.ComponentModel.ISupportInitialize).BeginInit()
			' 
			' Detail
			' 
			Me.Detail.HeightF = 0F
			Me.Detail.Name = "Detail"
			Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
			Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
			' 
			' topMarginBand1
			' 
			Me.topMarginBand1.HeightF = 48F
			Me.topMarginBand1.Name = "topMarginBand1"
			' 
			' bottomMarginBand1
			' 
			Me.bottomMarginBand1.HeightF = 48F
			Me.bottomMarginBand1.Name = "bottomMarginBand1"
			' 
			' ReportHeader
			' 
			Me.ReportHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrRichText1})
			Me.ReportHeader.HeightF = 203.2083F
			Me.ReportHeader.Name = "ReportHeader"
			' 
			' xrRichText1
			' 
			Me.xrRichText1.Font = New DevExpress.Drawing.DXFont("Times New Roman", 9.75F)
			Me.xrRichText1.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
			Me.xrRichText1.Name = "xrRichText1"
			Me.xrRichText1.SerializableRtfString = resources_Conflict.GetString("xrRichText1.SerializableRtfString")
			Me.xrRichText1.SizeF = New System.Drawing.SizeF(750F, 203.2083F)
			' 
			' Report
			' 
			Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() { Me.Detail, Me.topMarginBand1, Me.bottomMarginBand1, Me.ReportHeader})
			Me.Bookmark = "Table of Contents"
			Me.Margins = New DevExpress.Drawing.DXMargins(49, 51, 48, 48)
			Me.Version = "12.2"
			DirectCast(Me.xrRichText1, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me, System.ComponentModel.ISupportInitialize).EndInit()

		End Sub

	End Class
End Namespace
