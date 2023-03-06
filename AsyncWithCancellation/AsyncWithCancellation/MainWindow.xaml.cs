using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
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

namespace AsyncWithCancellation
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;
        private CancellationTokenSource tokenSource;

        public int Counter { get; set; } = 0;


        public MainWindow()
        {
            InitializeComponent();
        }


        private void ThreadWithCounter(int count, CancellationToken token)
        {
            tokenSource = new();

            for (int i = 0; i < count; i++)
            {
                Thread.Sleep(100);
                Counter++;

                if (tokenSource.IsCancellationRequested)
                {
                    token.ThrowIfCancellationRequested();
                }
            }
        }

        private async void Start_Click(object sender, RoutedEventArgs e)
        {
            CancellationToken token = new();

            try
            {
                await Task.Run(() => ThreadWithCounter(100, token));
                counterLabel.Content = "Completed!!";
            }
            catch (OperationCanceledException ex)
            {
                return;
            }
            finally
            {
                tokenSource.Dispose();
            }
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            tokenSource.Cancel();
        }
    }
}
