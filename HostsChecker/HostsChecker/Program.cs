using System.Net;
using System.Net.NetworkInformation;

IPAddress start = IPAddress.Parse("10.1.10.3"); // Мой IpV4 адрес

var bytes = start.GetAddressBytes(); // Получаем массив байтов
var leastSigByte = start.GetAddressBytes().Last(); // Получаем последний байт
var range = 255 - leastSigByte; // 10.1.10.0-255

var p = new Ping();

var pingReplyTasks = Enumerable.Range(leastSigByte, range)
    .Select(x =>
    {
        bytes[3] = (byte)x;
        var destIp = new IPAddress(bytes);
        var pingResultTask = p.SendPingAsync(destIp);
        return new { pingResultTask, addr = destIp };
    })
    .ToList();


await Task.WhenAll(pingReplyTasks.Select(x => x.pingResultTask));

foreach (var pr in pingReplyTasks)
{
    var tsk = pr.pingResultTask;
    var pingResult = tsk.Result; //we know these are completed tasks
    var ip = pr.addr;
    if (pingResult.Status == IPStatus.Success)
    {
        Console.WriteLine("{0} : {1}", ip, pingResult.Status);
    }
}