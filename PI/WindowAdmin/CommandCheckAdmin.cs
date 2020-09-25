using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using BE;

namespace PI
{
    internal class CommandCheckAdmin : ICommand
    {
        private ViewModelAdmin _viewModel;

        public CommandCheckAdmin(ViewModelAdmin vm)
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
           // throw new NotImplementedException();
        }

        public void Execute(object parameter)
        {
            var values = (Object[])parameter;

            Admin admin = new Admin()
            {
                admin_id= values[0].ToString(),
                admin_user_name = values[1].ToString(),
                admin_password = values[2].ToString(),
            };
            _viewModel.checkInfo(admin);
         }
    }  
}
