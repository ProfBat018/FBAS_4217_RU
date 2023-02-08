using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Media3D;
using System.Xml.Linq;
using MusicAppMVVM.Model;

namespace MusicAppMVVM.Services
{
   public class ApiService
    {
        public static async Task<string> FindMusic(string? name)
        {
            WebClient client = new();

            string uri = $@"https://youtube-music1.p.rapidapi.com/v2/search?query={name}";



            client.Headers.Add("X-RapidAPI-Key", "afce3bc89fmsh1ca02613744b32ap11d006jsnda1143ee3262");
            client.Headers.Add("X-RapidAPI-Host", "youtube-music1.p.rapidapi.com");

            return await client.DownloadStringTaskAsync(new Uri(uri));
        }

        public static async Task GetDownloadUrl(string? id, string? path)
        {
            string uri = $@"https://youtube-music1.p.rapidapi.com/get_download_url?id={id}&ext=mp3";

            var url = new Uri(uri);
            using var httpClient = new HttpClient();

            httpClient.DefaultRequestHeaders.Add("X-RapidAPI-Key", "afce3bc89fmsh1ca02613744b32ap11d006jsnda1143ee3262");
            httpClient.DefaultRequestHeaders.Add("X-RapidAPI-Host", "youtube-music1.p.rapidapi.com");

            var data = await DeserializeService.DeserializeAsync<DownloadModel>(await httpClient.GetStringAsync(uri));

            var res = await httpClient.GetByteArrayAsync(data?.result.download_url);

            await File.WriteAllBytesAsync(path, res);

        }
    }
}
