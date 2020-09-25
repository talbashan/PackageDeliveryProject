using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace PI
{
    public class CommandsearchList: ICommand
    {
        public ViewModelMyRecipients _viewModel;
        public CommandsearchList(ViewModelMyRecipients vm)
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
            var values = (Object[])parameter;
            string id = values[0].ToString();
            DateTime date = DateTime.Parse(values[1].ToString());

            _viewModel.findListOfRecipients(id, date);
        }
    }
}
