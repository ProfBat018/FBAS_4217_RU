using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Media.Imaging;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using MusicAppMVVM.Message;
using MusicAppMVVM.Model;
using MusicAppMVVM.Services.Classes;
using MusicAppMVVM.Services.Interfaces;



namespace MusicAppMVVM.ViewModel
{
    public class SearchViewModel : ViewModelBase
    {
        private INavigationService? _navigationService;
        public string? Search { get; set; }
        public ObservableCollection<Song>? Songs { get; set; } = new();
        public Song? Selected { get; set; }
        public int SelectedIndex { get; set; }

        public SearchViewModel(INavigationService? navigationService)
        {
            _navigationService = navigationService;
        }
        public RelayCommand SearchCommand
        {
            get => new(async () =>
            {
                Songs?.Clear();

                try
                {
                    var data = await DeserializeService.DeserializeAsync<MusicModel>(await ApiService.FindMusic(Search));
                    
                    IEnumerable<Song?> tmp = data.result.songs;

                    foreach (var song in tmp)
                    {
                        song.Img = new BitmapImage(new Uri(song?.thumbnail));
                        Songs.Add(song);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Something went wrong", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            });
        }

        public RelayCommand<object> InfoCommand
        {
            get => new(async param =>
            {
                _navigationService?.NavigateTo<InfoViewModel>(new ParameterMessage() { Message = Selected }); ;
                
            });
        }


        public RelayCommand DownloadCommand
        {
            get => new(async () =>
            {
                await FileService.WriteToFileAsync(Songs[SelectedIndex].id, Songs[SelectedIndex].name);
            });
        }
    }
}
