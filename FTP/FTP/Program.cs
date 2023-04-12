using System.Net;
using System.Drawing.Drawing2D;

using System.Drawing;
using System.Drawing.Imaging;

#region Upload

// Create ftp request 

// FtpWebRequest request = WebRequest.Create(new Uri("ftp://win8013.site4now.net")) as FtpWebRequest;
//
// request.Method = WebRequestMethods.Ftp.ListDirectory;
//
// request.Credentials = new NetworkCredential("nightcallftp", "Elvin_123");
//
// var response = request.GetResponse();
//
// if(response != null)
// {
//     using (var reader = new StreamReader(response.GetResponseStream()))
//     {
//         var result = reader.ReadToEnd();
//         Console.WriteLine(result);
//     }
// }

#endregion

#region Download

FtpWebRequest request = WebRequest.Create(new Uri("ftp://win8013.site4now.net//1648304408_2-kartinkof-club-p-muzhik-na-plyazhe-mem-2.jpg")) as FtpWebRequest;

        request.Method = WebRequestMethods.Ftp.DownloadFile;

        request.Credentials = new NetworkCredential("nightcallftp", "Elvin_123");

var response = request.GetResponse();

        if (response != null)
        {
            using var stream = response.GetResponseStream();
            using var img = new Bitmap(stream);
            img.Save("foo.png", ImageFormat.Jpeg);
            
        }

#endregion


