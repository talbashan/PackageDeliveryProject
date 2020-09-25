using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace PI
{
    public class CommandMap : ICommand
    {
        private ViewModelMap _viewModel;

        public CommandMap(ViewModelMap vm)
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
            //throw new NotImplementedException();
        }

        public void Execute(object parameter)
        {
            DateTime date = DateTime.Parse(parameter.ToString());
            double[][,] latlon = _viewModel.Getalllatlon(date);

            //_viewModel.checkInfo(distributor);
            //throw new NotImplementedException();
        }
    }
}

