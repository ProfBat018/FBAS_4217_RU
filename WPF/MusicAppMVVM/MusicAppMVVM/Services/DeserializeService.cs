using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using MusicAppMVVM.Model;

namespace MusicAppMVVM.Services
{
    public class DeserializeService
    {
        public static async Task<T?> DeserializeAsync<T>(string json)
        {
            return JsonSerializer.Deserialize<T>(json);
        }
    }
}
