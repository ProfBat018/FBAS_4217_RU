using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;



namespace MusicInfo
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public SearchRes? Data { get; set; }

        private async void search_btn_Click(object sender, RoutedEventArgs e)
        {
            string? json = await DownloadService.FindMusic(search_box.Text);

            Data = await DeserializeService.Deserialize(json);


            foreach (var item in Data.result.songs)
            {
                result_listbox.Items.Add(item);
            }
        }

        private async void result_listbox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var index = result_listbox.SelectedIndex;

            var selecteditem = Data.result.songs[index];

            try
            {

                name_lbl.Content = selecteditem.name;
                artist_lbl.Content = selecteditem.artists[0].name;
                albumName_lbl.Content = selecteditem.album.name;
                duration_lbl.Content = selecteditem.duration / 60f;

                image_box.Source = new BitmapImage(new Uri(selecteditem.thumbnail));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
