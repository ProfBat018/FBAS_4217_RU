using System.Net;
using System.Net.Sockets;

var server = new Socket(
    AddressFamily.InterNetwork,
    SocketType.Stream,
    ProtocolType.Tcp
);

var ep = new IPEndPoint(
    IPAddress.Any,
    55000
);
server.Bind(ep);
server.Listen(100);

while (true)
{
    var a = new SocketAsyncEventArgs();
    a.Completed += SocketArgs_Completed;
    server.AcceptAsync(a);

    void SocketArgs_Completed(object sender, SocketAsyncEventArgs e)
    {
        var c = e.AcceptSocket;
        Console.WriteLine($"[{c.RemoteEndPoint} connected]");
        while (true)
        {
            var a = new SocketAsyncEventArgs();
            a.Completed += A_Completed;
            c.ReceiveAsync(a);
        }
    }
}

void A_Completed(object sender, SocketAsyncEventArgs e)
{

}
public enum MessageType
{
    Exit,
    Start,
    Kill,
    Tasklist,
    TextMessage
}
public class Message
{
    public Guid Id { get; set; }
    public string Sender { get; set; }
    public object Data { get; set; }
    public MessageType Type { get; set; }
}

