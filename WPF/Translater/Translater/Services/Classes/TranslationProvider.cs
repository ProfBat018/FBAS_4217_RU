using Google.Cloud.Translate.V3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows;
using Translater.Services.Interfaces;


namespace Translater.Services.Classes
{
    public class TranslationProvider : ITranslationProvider
    {
        private TranslationServiceClient? _client =  TranslationServiceClient.Create();

        public async Task<Translation>? TranslateAsync(string? text, string? translateTo)
        {
            var request = new TranslateTextRequest
            {
                Contents = { text },
                TargetLanguageCode = translateTo,
                Parent = "projects/asp1-234911/locations/global"
            };

            var response = await _client!.TranslateTextAsync(request);

            return response.Translations[0];
        }
    }
}
