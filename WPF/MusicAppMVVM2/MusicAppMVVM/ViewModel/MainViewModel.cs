using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Messaging;
using MusicAppMVVM.Message;

namespace MusicAppMVVM.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        public ViewModelBase? CurrentViewModel { get; set; }

        private readonly IMessenger _messenger;

        public MainViewModel(IMessenger messenger)
        {
            CurrentViewModel = App.Container?.GetInstance<SearchViewModel>();

            _messenger = messenger;

            _messenger.Register<NavigationMessage?>(this, message =>
            {
                var viewModel = App.Container?.GetInstance(message?.ViewModelType) as ViewModelBase;
                CurrentViewModel = viewModel;
            });
        }
    }
}
