using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using BE;

namespace PI
{
    public class CommandSearchRecipients : ICommand
    {
        private ViewModelRecipientsU _viewModel;

        public CommandSearchRecipients(ViewModelRecipientsU vm)
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
            _viewModel.searchRecipients(parameter.ToString());
        }
    }
}
