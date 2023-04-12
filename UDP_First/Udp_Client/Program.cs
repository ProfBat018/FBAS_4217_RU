using System.Net.Sockets;
using System.Net;

IPEndPoint ipEndpoint = new IPEndPoint(IPAddress.Any, 50001);
using UdpClient client = new(ipEndpoint);


while (true)
{
    var receivedData =  client.Receive(ref ipEndpoint);

	if (receivedData.Length > 0)
	{
		Console.WriteLine(receivedData.Length);
	}
}

