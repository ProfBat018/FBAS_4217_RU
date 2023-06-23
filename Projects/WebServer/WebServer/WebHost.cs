using System.Net;
using System.Text;
using System.Text.RegularExpressions;

class WebHost
{
    private string url;
    private HttpListener listener;

    public WebHost(string prefix, UInt16 port)
    {
        Regex re = new(@"^https?:");

        if (re.IsMatch(prefix))
        {
            this.url = $"{prefix}:{port}/";
        }

        this.listener = new();
        listener.Prefixes.Add(this.url);
    }

    public void Start()
    {
        listener.Start();

        while (true)
        {
            Console.WriteLine("Waiting for request...");
            HttpListenerContext context = listener.GetContext();

            Console.WriteLine("Request received!");
            HttpListenerRequest request = context.Request;

            Console.WriteLine($"Path: {request.Url.AbsolutePath}");

            string requestPath = request.Url.AbsolutePath;
            
            if (requestPath.ToString() != "/")
            {
                StringBuilder sb = new("Views");
                sb.Append(requestPath);
                sb.Append(".html");
                requestPath = sb.ToString();
            }

            var files = Directory.GetFiles("Views");

            foreach (var fileName in files)
            {
                if (requestPath == fileName)
                {
                    var bytes = File.ReadAllBytes(fileName);

                    context.Response.ContentType = "text/html";
                    context.Response.OutputStream.Write(bytes, 0, bytes.Length);
                }
            }
        }
    }
}