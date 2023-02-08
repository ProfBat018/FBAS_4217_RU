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

namespace MusicAppMVVM.Services.Classes
{
    public static class ApiService
    {
        private static HttpClient _httpClient;

        static ApiService()
        {
            _httpClient = new();
            _httpClient.DefaultRequestHeaders.Add("X-RapidAPI-Key", "afce3bc89fmsh1ca02613744b32ap11d006jsnda1143ee3262");
            _httpClient.DefaultRequestHeaders.Add("X-RapidAPI-Host", "youtube-music1.p.rapidapi.com");
        }

        public static async Task<string> FindMusic(string? name)
        {
            try
            {
                string uri = $@"https://youtube-music1.p.rapidapi.com/v2/search?query={name}";

                return await _httpClient.GetStringAsync(new Uri(uri));
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public static async Task<byte[]> GetDownloadDataAsync(string? id)
        {
            string uri = $@"https://youtube-music1.p.rapidapi.com/get_download_url?id={id}&ext=mp3";

            var data = await DeserializeService.DeserializeAsync<DownloadModel>(await _httpClient.GetStringAsync(uri));

            var res = await _httpClient.GetByteArrayAsync(data?.result.download_url);

            return res;
        }
    }
}
