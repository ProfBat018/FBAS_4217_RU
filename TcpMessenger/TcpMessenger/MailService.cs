using System.Net;
using System.Net.Mail;

namespace TcpMessenger;


class MailService
{

    public static void Send()
    {
        SmtpClient client = new SmtpClient("smtp.gmail.com", 587)
        {
            Credentials = new NetworkCredential("elvin.azim01@gmail.com", "ldhsmaybvnvvldmm")
        };

        client.EnableSsl = true;

        MailMessage message = new MailMessage
        {
            From = new MailAddress("elvin.azim01@gmail.com"),
            Subject = "Sended",
            Body = "Hello, world!"
        };

        message.To.Add("elvin.azim01@gmail.com");

        client.Send(message);

    }
}