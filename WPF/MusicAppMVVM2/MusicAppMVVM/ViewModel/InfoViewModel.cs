using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Messaging;
using MaterialDesignThemes.Wpf;
using MusicAppMVVM.Message;
using MusicAppMVVM.Model;
using MusicAppMVVM.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicAppMVVM.ViewModel
{
    internal class InfoViewModel : ViewModelBase
    {
        public Song SongInfo { get; set; }
        private readonly INavigationService? _service;
        private readonly IMessenger _messenger;

        public InfoViewModel(INavigationService? service, IMessenger messenger)
        {
            _service = service;
            _messenger = messenger;

            _messenger.Register<ParameterMessage>(this, param =>
            {
                SongInfo = param?.Message as Song;
            });
        }

        public RelayCommand<Song> BackCommand
        {
            get => new(async param =>
            {
                _service?.NavigateTo<SearchViewModel>();
            });
        }
    }
}
