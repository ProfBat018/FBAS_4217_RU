using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
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

namespace EfAsync
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public async Task<List<Car>> Foow(int id)
        {
            using ShowroomContext context = new();

            var cars = await Task.Run(() => context.Cars.Where(x => x.Id == id).ToList());

            return cars;
        }

        private async void GetAll_Click(object sender, RoutedEventArgs e)
        {
            var cars = await Foow(1);

            foreach (var car in cars)
            {
                ShowroomBox.Items.Add(car);
            }
        }

        private void Foo_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Foo");
        }
    }
}
