using System.Windows;
using GalaSoft.MvvmLight.Messaging;
using MusicAppMVVM.Services.Classes;
using MusicAppMVVM.Services.Interfaces;
using MusicAppMVVM.View;
using MusicAppMVVM.ViewModel;
using SimpleInjector;

namespace MusicAppMVVM
{
    public partial class App : Application
    {
        public static Container? Container { get; set; } // SimpleInjector

        protected override void OnStartup(StartupEventArgs e)
        {
            Register();
          
            MainStartup();

            base.OnStartup(e);
        }

        private void Register()
        {
            Container = new();

<<<<<<< HEAD
            Container.RegisterSingleton<IMessenger, Messenger>();
            Container.RegisterSingleton<INavigationService, NavigationService>();

            Container.RegisterSingleton<MainViewModel>();

=======
            Container.RegisterSingleton<MainViewModel>(); // Container.Instances.Add(new MainViewModel());
>>>>>>> 79d5a3ad3b02a70c3ffb97d7c945bbd5ebb3e3e1
            Container.RegisterSingleton<SearchViewModel>();
            Container.RegisterSingleton<InfoViewModel>();
            

            Container.Verify();
        }
        private void MainStartup()
        {
            Window mainView = new MainView();

            mainView.DataContext = Container?.GetInstance<MainViewModel>();

            mainView.ShowDialog();
        }

    }
}
