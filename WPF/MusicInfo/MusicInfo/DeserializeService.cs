using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace MusicInfo
{
    public static class DeserializeService
    {
        public static async Task<SearchRes?> Deserialize(string json)
        {
            return JsonSerializer.Deserialize<SearchRes>(json);
        }
    }
}
