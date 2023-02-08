using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using Translater.Services.Interfaces;
using Translater.Model;
using System.Threading.Tasks;

namespace Translater.ViewModel
{
    public class TranslateViewModel : ViewModelBase
    {
        public TranslateModel? Model { get; set; } = new();

        private ITranslationProvider? _translationProvider;
        private ILanguagesProvider? _langProvider;

        public TranslateViewModel(ITranslationProvider? provider, ILanguagesProvider? langProvider)
        {
            _translationProvider = provider;
            _langProvider = langProvider;
            Model.Languages = _langProvider?.GetLanguages();
        }

        public RelayCommand TranslateCommand
        {
            get => new(async () =>
            {
                var res = await _translationProvider?.TranslateAsync(Model?.FromText, Model?.SelectedTo);
                

                Model.SelectedFrom = res.DetectedLanguageCode.ToLower();
                
                Model.ToText = res.TranslatedText;
            });
        }
    }
}
