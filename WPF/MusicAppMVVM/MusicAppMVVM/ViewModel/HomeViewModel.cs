using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Printing;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media.Imaging;
using GalaSoft.MvvmLight.Command;
using Microsoft.Win32;
using MusicAppMVVM.Model;
using MusicAppMVVM.Services;

namespace MusicAppMVVM.ViewModel
{
    public class HomeViewModel
    {
        public string Search { get; set; }
        public ObservableCollection<Song> Songs { get; set; } = new();
        public int SelectedIndex { get; set; }
        public BitmapImage Thumbnail { get; set; }
        public string Name { get; set; }


        public RelayCommand SearchCommand
        {
            get => new(async () =>
            {
                Songs.Clear();

                var data = await DeserializeService.DeserializeAsync<MusicModel>(await ApiService.FindMusic(Search));

                IEnumerable<Song> tmp = data.result.songs;

                foreach (var song in tmp)
                {
                    song.Img = new BitmapImage(new Uri(song.thumbnail));
                    Songs.Add(song);
                }
            });
        }

        public RelayCommand DownloadCommand
        {
            get => new(async () =>
            {
                var saveDialog = new SaveFileDialog();

                saveDialog.InitialDirectory = @"C:\Users\Wayne\Desktop";
                saveDialog.Filter = "Music Files | .mp3";
                saveDialog.DefaultExt = "mp3";

                saveDialog.FileName = Songs[SelectedIndex].name;

                var res = saveDialog.ShowDialog();

                if (res.Value)
                {
                    await ApiService.GetDownloadUrl(Songs[SelectedIndex].id, Path.GetFullPath(saveDialog.FileName));
                }
            });
        }
    }
}
