using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Microsoft.WindowsAPICodePack.Dialogs;

namespace PictureArranger
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        bool isSourceOk = false;
        bool isTargetOk = false;
        public MainWindow()
        {
            
        }

        private void SourceButton_Click(object sender, RoutedEventArgs e)
        {
            InitializeComponent();
            var dialog = new CommonOpenFileDialog();
            dialog.IsFolderPicker = true;
            CommonFileDialogResult result = dialog.ShowDialog();
            if (result == CommonFileDialogResult.Ok)
            {
                pathSourceTextBox.Text = dialog.FileName;
                isSourceOk = true;
            }
        }

        private void TargetButton_Click(object sender, RoutedEventArgs e)
        {
            InitializeComponent();
            var dialog = new CommonOpenFileDialog();
            dialog.IsFolderPicker = true;
            CommonFileDialogResult result = dialog.ShowDialog();
            if (result == CommonFileDialogResult.Ok)
            {
                pathSourceTextBox.Text = dialog.FileName;
                isTargetOk = true;
            }
        }

        private void copyButton_Click(object sender, RoutedEventArgs e)
        {
            DirectoryInfo dr = new DirectoryInfo(pathSourceTextBox.Text);
            foreach (var file in dr.GetFiles())
            {
                
            }

        }
    }
}
