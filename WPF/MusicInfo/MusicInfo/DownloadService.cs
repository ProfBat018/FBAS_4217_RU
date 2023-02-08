using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;


namespace MusicInfo
{
    public static class DownloadService
    {
        public static async Task<string> FindMusic(string? name)
        {
            WebClient client = new();

            string uri = $@"https://youtube-music1.p.rapidapi.com/v2/search?query={name}";

            client.Headers.Add("X-RapidAPI-Key", "afce3bc89fmsh1ca02613744b32ap11d006jsnda1143ee3262");
            client.Headers.Add("X-RapidAPI-Host", "youtube-music1.p.rapidapi.com");

            return await client.DownloadStringTaskAsync(new Uri(uri));
            //return client.DownloadString(uri);
        }

    }
}
