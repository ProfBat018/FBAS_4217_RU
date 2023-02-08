﻿using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Translater.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        public ViewModelBase? CurrentViewModel { get; set; }

        public MainViewModel()
        {
            CurrentViewModel = App.IOC?.GetInstance<TranslateViewModel>();
        }
    }
}
