using System.Net.Sockets;
using System.Net;
using System.Text;

Dictionary<int, TcpClient>
    listClients = new(); // Список клиентов (ключ - порядковый номер клиента, значение - объект TcpClient)
TcpListener
    ServerSocket = new(IPAddress.Any, 5000); // Создаем "серверный" сокет и привязываем его к локальному адресу и порту
ServerSocket.Start(); // Запускаем прослушивание входящих соединений

int count = 1;

while (true)
{
    TcpClient
        client = ServerSocket.AcceptTcpClient(); // Принимаем входящее соединение и создаем для него "клиентский" сокет
    listClients.Add(count, client); // Добавляем клиента в список
    Console.WriteLine($"{client.Client.RemoteEndPoint} connected!!");

    await HandleClients(count);

    count++;
}

async Task HandleClients(int id)
{
    TcpClient client = listClients[id]; // Получаем клиента из списка по ключу

    while (true)
    {
        NetworkStream stream = client.GetStream(); // Получаем поток для чтения и записи
        byte[] buffer = new byte[1024]; // Создаем буфер для приема данных
        int byteCount = stream.Read(buffer, 0, buffer.Length); // Читаем данные из потока

        if (byteCount != 0)
        {
            string data = Encoding.ASCII.GetString(buffer, 0, byteCount); // Декодируем данные из буфера в строку
            Broadcast(data).GetAwaiter().GetResult(); // Отправляем данные всем клиентам
            Console.WriteLine(data); // Выводим данные в консоль
        }
        else
            break;
    }

    listClients.Remove(id); // Удаляем клиента из списка
    client.Client.Shutdown(SocketShutdown.Both); // Отключаем сокет от удаленного хоста и закрываем сокет
    client.Close(); // Закрываем соединение
}

async Task Broadcast(string data)
{
    byte[] buffer = Encoding.ASCII.GetBytes(data + Environment.NewLine); // Кодируем данные в байты и добавляем символ перевода строки

    foreach (TcpClient client in listClients.Values)
    {
        NetworkStream stream = client.GetStream(); // Получаем поток для чтения и записи

        stream.Write(buffer, 0, buffer.Length); // Записываем данные в поток клиента 
    }
}