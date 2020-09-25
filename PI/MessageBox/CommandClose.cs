using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace PI
{
    public class CommandClose : ICommand
    {
        public ViewModleMessageBox _viewModle { get; set; }
        public CommandClose(ViewModleMessageBox vm)
        {
            _viewModle = vm;
        }

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }
        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            _viewModle.view.Close();
            //throw new NotImplementedException();
        }
    }
}
