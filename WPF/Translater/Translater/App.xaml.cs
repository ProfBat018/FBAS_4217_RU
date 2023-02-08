using SimpleInjector;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using Translater.Services.Classes;
using Translater.Services.Interfaces;
using Translater.View;
using Translater.ViewModel;

namespace Translater
{
    public partial class App : Application
    {
        public static Container? IOC { get; set; } = new();

        protected override void OnStartup(StartupEventArgs e)
        {
            IOC?.RegisterSingleton<INavService, NavService>();
            IOC?.RegisterSingleton<IMessenger, Messenger>();
            IOC?.RegisterSingleton<ITranslationProvider, TranslationProvider>();
            IOC?.RegisterSingleton<ILanguagesProvider, LanguagesProvider>();

            IOC?.RegisterSingleton<MainViewModel>();
            IOC?.RegisterSingleton<TranslateViewModel>();
            IOC?.Verify();

            Window mainView = new MainView();
            mainView.DataContext = IOC?.GetInstance<MainViewModel>();
            mainView.ShowDialog();


            base.OnStartup(e);
        }

    }
}
