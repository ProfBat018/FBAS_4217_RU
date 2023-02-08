using GalaSoft.MvvmLight;
using MusicAppMVVM.Message;


namespace MusicAppMVVM.Services.Interfaces
{
    public interface INavigationService
    {
        public void NavigateTo<T>(ParameterMessage message=null) where T : ViewModelBase;
    }
}
