using System.IO;
using System.Windows;
using DevExpress.Xpf.Core;
using DevExpress.Xpf.Printing;
using Microsoft.Win32;
// ...

namespace MinimalisticReportPreviewDemo {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            ApplicationThemeHelper.ApplicationThemeName = "Office2007Silver";
            InitializeComponent();
        }

        private void ShowPreview(object sender, RoutedEventArgs e) {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == true) {
                Report report = new Report();
                report.xrRichText1.Rtf = File.ReadAllText(ofd.FileName);

                DocumentPreviewWindow window = new DocumentPreviewWindow();
                window.PreviewControl.DocumentSource = report;
                report.CreateDocument(true);
                window.ShowDialog();
            }
        }

    }
}
