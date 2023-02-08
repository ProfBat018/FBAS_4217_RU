using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Weather.Services
{
    public class DeserializeService
    {
        public static T Deserialize<T>(string? json)
        {
            if (json != null)
            {
                T? res = JsonSerializer.Deserialize<T>(json);

                if (res != null)
                {
                    return res;
                }
            }
            throw new NullReferenceException();
        }
    }
}
