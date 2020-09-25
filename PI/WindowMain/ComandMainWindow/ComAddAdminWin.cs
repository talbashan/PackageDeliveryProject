using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace PI
{
    public class ComAddAdminWin : ICommand
    {
        public ViewModelMainWindow Cvm;
        public ComAddAdminWin(ViewModelMainWindow vm)
        {
            Cvm = vm;
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
             
            new WindowAdmin().Show();
            //Cvm.Admin_identify.IsEnabled = false;
            // throw new NotImplementedException();
        }
    }
}
