using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.Json;
using System.Threading;
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

namespace MovieTaskExample
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private async Task<WeatherForecast> GetData(string cityName)
        {
            WebClient client = new();

            var json = client.DownloadString($"https://api.openweathermap.org/data/2.5/weather?q={cityName}&appid=5191fee1957155f779bfd029a4a97e18&units=metric");

            var result = JsonSerializer.Deserialize<WeatherForecast>(json);

            return result;
        }

        private void searchButton_Click(object sender, RoutedEventArgs e)
        {
            var res = GetData(searchBox.Text);

            tempLabel.Content = res.Result.main.temp;
        }
    }
}
