using MusicAppMVVM.Model;
using MusicAppMVVM.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace MusicAppMVVM.Message
{
    public class ParameterMessage
    {
        public ISendable? Message { get; set; }
    }
}
