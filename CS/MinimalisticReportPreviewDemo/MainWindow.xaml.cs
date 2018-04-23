using System;
using System.Windows;
using DevExpress.Xpf.Core;
using DevExpress.Xpf.Themes;
using DevExpress.Xpf.Printing;
using Microsoft.Win32;
using System.IO;
// ...

namespace MinimalisticReportPreviewDemo {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            ThemeManager.ApplicationThemeName = "Office2007Silver";
            InitializeComponent();
        }

        private void ShowPreview(object sender, RoutedEventArgs e) {
            OpenFileDialog ofd = new OpenFileDialog();
            if(ofd.ShowDialog() == true) {
                Report report = new Report();
                report.xrRichText1.Rtf = File.ReadAllText(ofd.FileName);
                XtraReportPreviewModel model = new XtraReportPreviewModel(report);
                DocumentPreviewWindow window = new DocumentPreviewWindow() { Model = model };
                report.CreateDocument(true);
                window.ShowDialog();
            }
        }

    }
}
