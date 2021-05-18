using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace eportfolioWorkingSample
{
    public class MyCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;
        private Action _execute;

        private Action<object> _executeWithParameter;

        public MyCommand(Action execute)
        {
            _execute = execute;
        }

        public MyCommand(Action<object> execute)
        {
            _executeWithParameter = execute;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            if (_execute != null) _execute.Invoke();
            else _executeWithParameter.Invoke(parameter);
        }
    }
}
