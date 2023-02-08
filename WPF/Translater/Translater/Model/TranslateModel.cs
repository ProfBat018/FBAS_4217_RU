using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Translater.Model
{
    public class TranslateModel : ViewModelBase
    {
        public Dictionary<string, string> Languages { get; set; }
        public string? SelectedFrom { get; set; }
        
        private string? _selectedTo;
        public string? SelectedTo { get => _selectedTo; set => Set(ref _selectedTo, value); }
        public string? FromText { get; set; }

        private string? _toText;

        public string? ToText { get => _toText; set => Set(ref _toText, value); }
    }
}
