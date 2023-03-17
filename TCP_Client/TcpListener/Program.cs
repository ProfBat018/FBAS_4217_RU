using System.Data;
using System.Net;
using System.Net.Sockets;
using System.Text;

// Server
// 127.0.0.1 - localhost 


TcpListener listener = new(IPAddress.Parse("127.0.0.1"), 12001);


listener.Start(); // Start server 

while (true)
{
    var client = await listener.AcceptTcpClientAsync(); // Accept all clients 

    var clientStream = client.GetStream();

    if (client.ReceiveBufferSize > 0)
    {

        var buffer = new byte[client.ReceiveBufferSize];

        await clientStream.ReadAsync(buffer, 0, client.ReceiveBufferSize);

        var clientName = Encoding.Unicode.GetString(buffer, 0, 10); // превращает из массива байтов в строук


        Console.WriteLine($"Client Name: {clientName}\t{client.Connected}");

        for (int i = 0; i < clientName.Length; i++)
        {
            Console.Write((int)clientName[i]);
        }

        while (true)
        {
            Console.WriteLine("Enter message: ");
            string message = Console.ReadLine();

            Console.WriteLine(clientName.Length);

            string data = clientName + ": " + message;
            var bytes = Encoding.Unicode.GetBytes(data);

            await clientStream.WriteAsync(bytes, 0, bytes.Length);
        }
    }
}