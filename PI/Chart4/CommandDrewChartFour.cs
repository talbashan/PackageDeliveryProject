using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace PI
{
   public class CommandDrewChartFour: ICommand
    {
        public ViewModleChartFour Cvm;
        public CommandDrewChartFour(ViewModleChartFour vm)
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
            var values = (Object[])parameter;

            DateTime date = DateTime.Parse(values[0].ToString());
            string id = values[1].ToString();
            string divide = values[2].ToString();

            Cvm.drewChartfunc(id,divide,date);

        }
    }
}
