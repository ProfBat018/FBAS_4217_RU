using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using MusicAppMVVM.Model;

namespace MusicAppMVVM.Services.Classes
{
    public static class DeserializeService
    {
        public static async Task<T?> DeserializeAsync<T>(string json)
        {
            var res = JsonSerializer.Deserialize<T>(json);

            if (res != null)
            {
                return res;
            }
            throw new SerializationException();
        }
    }
}
