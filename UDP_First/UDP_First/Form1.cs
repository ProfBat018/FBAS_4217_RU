using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;

namespace UDP_First;

public partial class Form1 : Form
{
        byte[] ImgData = new byte[400000];

    public Form1()
    {
        InitializeComponent();

        Thread thread = new(Receive);

        thread.Start();
    }

    void Receive()
    {

        var receiverPort = 12001;
        var address = IPAddress.Parse("224.0.0.1");

        var receiver = new UdpClient(receiverPort);

        try
        {
            receiver.JoinMulticastGroup(address);

            IPEndPoint receiverEP = null;

            while (true)
            {
                var result = receiver.Receive(ref receiverEP);

                MessageBox.Show($"received: {result.Length.ToString()}");
                foreach (var item in result)
                {
                    ImgData = ImgData.Prepend(item).ToArray();
                }
            }

         
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
        finally
        {
            receiver.Close();
        }
    }

    private async void captureButton_Click(object sender, EventArgs e)
    {
        var bytes = ScreenCapturer.CaptureScreen();

        //
        var senderPort = 12001;
        var address = IPAddress.Parse("224.0.0.1");

        var senderClient = new UdpClient();

        try
        {
            var endpoint = new IPEndPoint(address, senderPort);

            var count = bytes.Length / 64000;

            MessageBox.Show($"Sended {bytes.Length}");
            for (int i = 0, j = 0; j <= bytes.Length; i++, j += 64000)
            {
                var length = 64000;

                if (count - 1 < i)
                {
                    length = bytes.Length - length * i;
                }
                var dataToSend = new byte[64000];

                Array.Copy(bytes, j, dataToSend, 0, length);
                await senderClient.SendAsync(dataToSend, dataToSend.Length, endpoint);
            }

            using MemoryStream buf = new MemoryStream(ImgData);
            Image image = Image.FromStream(buf, true);
            image.Save("C:\\Users\\elvin\\Desktop\\a.jpg");

        }
        catch (Exception ex)
        {
            Console.WriteLine(ex);
        }
        finally
        {
            senderClient.Close();
        }
        //




    }
}