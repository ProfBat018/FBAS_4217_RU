using MusicAppMVVM.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicAppMVVM.Message
{
    public class NavigationMessage
    {
        public Type? ViewModelType { get; set; }
    }
}
