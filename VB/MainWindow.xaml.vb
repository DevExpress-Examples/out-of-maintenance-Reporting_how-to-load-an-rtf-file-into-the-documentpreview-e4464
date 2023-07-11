Imports System.IO
Imports System.Windows
Imports DevExpress.Xpf.Core
Imports DevExpress.Xpf.Printing
Imports Microsoft.Win32
' ...

Namespace MinimalisticReportPreviewDemo
	''' <summary>
	''' Interaction logic for MainWindow.xaml
	''' </summary>
	Partial Public Class MainWindow
		Inherits Window

		Public Sub New()
			ApplicationThemeHelper.ApplicationThemeName = "Office2007Silver"
			InitializeComponent()
		End Sub

		Private Sub ShowPreview(ByVal sender As Object, ByVal e As RoutedEventArgs)
			Dim ofd As New OpenFileDialog()
			If ofd.ShowDialog().Equals(True) Then
				Dim report As New Report()
				report.xrRichText1.Rtf = File.ReadAllText(ofd.FileName)

				Dim window As New DocumentPreviewWindow()
				window.PreviewControl.DocumentSource = report
				report.CreateDocument(True)
				window.ShowDialog()
			End If
		End Sub

	End Class
End Namespace
