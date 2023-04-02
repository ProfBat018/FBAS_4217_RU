using System.Diagnostics;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

#pragma warning disable SYSLIB0011

var server = new Socket(
    AddressFamily.InterNetwork, // ipv4 address
    SocketType.Stream,
    ProtocolType.Tcp
);

var ep = new IPEndPoint( // endpoint состоит из ip и порта
    IPAddress.Any,
    55000
);

server.Bind(ep); // привязываю сокет к конкретному порту и ip
server.Listen(100); // начинаю слушать порт на предмет входящих подключений (100 - максимальное количество подключений в очереди)


while (true)
{
    var client = server.Accept(); // принимаю подключение
    await Task.Run(() =>
    {
        var acceptedClient = client; // это мой клиент
        Console.WriteLine($"[{acceptedClient.RemoteEndPoint} connected]");
        while (true)
        {
            try
            {
                var msg = acceptedClient.Receive<Message>();
                switch (msg.Type)
                {
                    case MessageType.Exit:
                        break;
                    case MessageType.Start:
                        Process.Start(msg.Data as string);
                        break;
                    case MessageType.Kill:
                        break;
                    case MessageType.Tasklist:
                        break;
                    default:    
                        break;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine($"{acceptedClient.RemoteEndPoint} disconnected");
                break;
            }
        }
    });
}


public static class SocketExtensions
{
    public static T Receive<T>(
       this Socket socket)
    {
        var bytes = new byte[1000000];
        int len = socket.Receive(bytes);
        using var ms = new MemoryStream(bytes, 0, len);
        var bf = new BinaryFormatter(); // класс для сериализации и десериализации в бинарный формат
        var obj = (T)bf.Deserialize(ms);
        return obj;
    }

    public static void Send(this Socket socket, string text)
    {
        var bytes = Encoding.ASCII.GetBytes(text);
        socket.Send(bytes);
    }

    public static string ReceiveString(Socket socket)
    {
        var bytes = new byte[1024];
        int len = socket.Receive(bytes);
        var str = Encoding.ASCII.GetString(bytes, 0, len);
        return str;
    }
}

public enum MessageType
{
    Exit,
    Start,
    Kill,
    Tasklist
}

public class Message
{
    public Guid Id { get; set; } // Guid - уникальный идентификатор, который генерируется автоматически. Напрмиер: 3b9d0b5a-1b5a-4b9d-9b5a-1b5a4b9d0b5a
    public string Sender { get; set; } // имя отправителя
    public object Data { get; set; } // данные
    public MessageType Type { get; set; } // тип сообщения
}







