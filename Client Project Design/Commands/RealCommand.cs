using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Client_Project_Design.Commands
{
    public class RealCommand:ICommand
    {

        public event EventHandler? CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        Predicate<object>? _canExecute;
        Action<object>? _Execute;

        public RealCommand(Action<object?>? excecute, Predicate<object?>? canExcecute = null)
        {
            _canExecute = canExcecute;
            _Execute = excecute;
        }

        public bool CanExecute(object? parameter)
        {
            if (_canExecute == null) return true;
            return _canExecute(parameter);
        }

        public void Execute(object? parameter)
        {
            _Execute?.Invoke(parameter);
        }

    }
}
