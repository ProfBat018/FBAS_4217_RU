using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace MyCommand.ViewModel
{
    public class HomeViewModel
    {
        public string Text { get; set; } = "Hello";

        public MyCommand TestCommand
        {
            get => new(() => { MessageBox.Show("Omar");});
        }
    }

    public class MyCommand : ICommand
    {
        private readonly Action? _execute;

        public MyCommand(Action? execute)
        {
            _execute = execute;
        }

        public bool CanExecute(object? parameter)
        {
            return true;
        }

        public void Execute(object? parameter) // Main Logic
        {
            _execute?.Invoke();
        }

        public event EventHandler? CanExecuteChanged;
    }
}
