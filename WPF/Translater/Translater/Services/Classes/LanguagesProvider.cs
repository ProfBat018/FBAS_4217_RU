using Google.Cloud.Translate.V3;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Translater.Services.Interfaces;
using static System.Net.Mime.MediaTypeNames;

namespace Translater.Services.Classes
{
    public class LanguagesProvider : ILanguagesProvider
    {
        private TranslationServiceClient? _client = TranslationServiceClient.Create();
        private Dictionary<string, string>? _result = new();

        public Dictionary<string, string>? GetLanguages()
        {
            var request = new GetSupportedLanguagesRequest()
            {
                Parent = "projects/asp1-234911/locations/global"
            };

            var langs =  _client?.GetSupportedLanguages(request);

            foreach (var item in langs.Languages)
            {
                var code = item.LanguageCode;
                var info = new CultureInfo(code);

                _result?.Add(code, info.DisplayName);
            }
            return _result;
        }
    }
}
