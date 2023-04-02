using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Net.Sockets;
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

namespace TcpMessenger
{
    public partial class MainWindow : Window
    {
        TcpClient client = new();
        IPEndPoint endPoint = new(IPAddress.Parse("127.0.0.1"), 5000);
        NetworkStream ns;
        
        MailService mailService = new();

        public MainWindow()
        {
            InitializeComponent();
            MailService.Send();
        }

        async Task ReceiveData(TcpClient client)
        {
            NetworkStream ns = client.GetStream();
            byte[] receivedBytes = new byte[1024];
            int byteCount;
        
            while ((byteCount = await ns.ReadAsync(receivedBytes, 0, receivedBytes.Length)) > 0)
            {
              MessageListBox.Items.Add(Encoding.ASCII.GetString(receivedBytes, 0, byteCount));
            }
        }
        

        private async void ConnectButton_OnClick(object sender, RoutedEventArgs e)
        {
            await client.ConnectAsync(endPoint);

            if (client.Connected)
            {
                ConnectButton.Foreground = new SolidColorBrush(Colors.Green);
                ns = client.GetStream();
                await ReceiveData(client);
            }
        }

        private void DisconnectButton_OnClick(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private async void SendButton_OnClick(object sender, RoutedEventArgs e)
        {
            while (!string.IsNullOrEmpty(MessageTextBox.Text))
            {
                byte[] buffer = Encoding.ASCII.GetBytes(MessageTextBox.Text);
                await ns.WriteAsync(buffer, 0, buffer.Length);
            }
        }
    }
}
