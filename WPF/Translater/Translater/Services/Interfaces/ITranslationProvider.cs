using Google.Cloud.Translate.V3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Translater.Services.Interfaces
{
    public interface ITranslationProvider
    {
        public Task<Translation>? TranslateAsync(string? text, string? translateTo);
    }
}
