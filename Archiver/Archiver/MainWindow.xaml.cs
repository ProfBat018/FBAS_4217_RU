using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows;
using System.Windows.Forms;

namespace Archiver
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {



        private string fromPath;
        private string toPath;
        private Compressor compressor = new();

        public MainWindow()
        {
            InitializeComponent();
        }


        private void From_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Forms.OpenFileDialog dialog = new();

            dialog.Filter = "All files (*.*)|*.*";

            dialog.ShowDialog();

            fromPath = dialog.FileName;
            FromName.Text = dialog.FileName;
        }

        private void To_Click(object sender, RoutedEventArgs e)
        {
            var dialog = new FolderBrowserDialog();

            dialog.ShowDialog();

            toPath = dialog.SelectedPath;
            ToName.Text = dialog.SelectedPath;
        }


        private void Archive_Click(object sender, RoutedEventArgs e)
        {
            compressor.ComressFile(fromPath, toPath);
        }
    }
}
