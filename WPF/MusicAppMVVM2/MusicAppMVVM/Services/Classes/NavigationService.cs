using GalaSoft.MvvmLight.Messaging;
using GalaSoft.MvvmLight;
using MusicAppMVVM.Message;
using MusicAppMVVM.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace MusicAppMVVM.Services.Classes
{
    internal class NavigationService : INavigationService
    {
        private readonly IMessenger _messenger;
        public NavigationService(IMessenger messenger)
        {
            _messenger = messenger;
        }

        public void NavigateTo<T>(ParameterMessage? message) where T : ViewModelBase
        {
            _messenger.Send(message);
            _messenger.Send(new NavigationMessage() { ViewModelType = typeof(T) });
        }
    }
}
