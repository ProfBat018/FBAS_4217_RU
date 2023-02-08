﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Weather.Data.DbContexts;
using Weather.Data.Models;
using Weather.Services;

namespace Weather.Views
{
    /// <summary>
    /// Interaction logic for Home.xaml
    /// </summary>
    public partial class Home : Window
    {
        public Forecast ForecastResult { get; set; } 
        public DeserializeService DeserializeService { get; set; } = new();
        public GetJsonService GetJsonService { get; set; } = new();

        public string? Search { get; set; }


        public Home()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string? json = null;

            if (Search != null)
            {
                try
                {
                    json = GetJsonService.GetWeatherJson(Search);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            
            try
            {
                ForecastResult = DeserializeService.Deserialize<Forecast>(json);

               
                SaveService.Save(ForecastResult);
                    
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
