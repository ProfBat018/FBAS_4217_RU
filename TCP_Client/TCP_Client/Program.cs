using System.Net.Sockets;
using System.Text;

// Client 

TcpClient client = new();

Console.Write("Enter your username: ");
var username = Console.ReadLine();

if (username != null)
{
    var buffer = Encoding.Unicode.GetBytes(username);

    await client.ConnectAsync("127.0.0.1", 12001);

    var clientStream = client.GetStream();

    await clientStream.WriteAsync(buffer, 0, buffer.Length);


    Console.WriteLine($"Client connected: {client.Connected}");

    StringBuilder sb = new();
    while (true)
    {
        if (clientStream.DataAvailable)
        {
            buffer = new byte[client.ReceiveBufferSize];

            await clientStream.ReadAsync(buffer, 0, client.ReceiveBufferSize);
            var clientData = Encoding.Unicode.GetString(buffer);
            Console.WriteLine(clientData);
        }
    }
}