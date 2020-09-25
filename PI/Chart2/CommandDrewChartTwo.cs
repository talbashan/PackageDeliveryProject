using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace PI
{
   public class CommandDrewChartTwo: ICommand
    {
        public ViewModleChartTwo Cvm;
        public CommandDrewChartTwo(ViewModleChartTwo vm)
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
            string divide = values[1].ToString();
            Cvm.drewChartfunc(divide,date);

        }
    }
}
