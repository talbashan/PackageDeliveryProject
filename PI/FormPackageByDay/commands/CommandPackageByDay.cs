using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace PI
{
    public class CommandPackageByDay: ICommand
    {
        private ViewModelPackageByDay _viewModel;

        public CommandPackageByDay(ViewModelPackageByDay vm) 
        {
            _viewModel = vm;
        }
        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public bool CanExecute(object parameter)
        {
            return true;
            //  throw new NotImplementedException();
        }

        public void Execute(object parameter)
        {
            DateTime date = DateTime.Parse(parameter.ToString());
            _viewModel.searchRecipients(date);
        }
    }
}
