using Google.Cloud.Translate.V3;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Translater.Services.Interfaces
{
    public interface ILanguagesProvider
    {
        public Dictionary<string, string>? GetLanguages();
    }
}
