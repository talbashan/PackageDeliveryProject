using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;
using BE;

namespace PI
{
    public class CommandUpdateDistibutor: ICommand
    {
        private ViewModelDistibutorU _viewModel;

        public CommandUpdateDistibutor(ViewModelDistibutorU vm)
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
            var values = (Object[])parameter;

            Distributors distributor = new Distributors()
            {
                distributors_id = values[0].ToString(),
                distributors_first_name = values[1].ToString(),
                distributors_last_name = values[2].ToString(),
                distributors_date_of_birth = DateTime.Parse(values[3].ToString()),
                distributors_phone_number = values[4].ToString(),
                distributors_email_address = values[5].ToString(),
                distributors_gender = (gender)Enum.Parse(typeof(gender), values[6].ToString()),
                distributors_address = new Address(values[7].ToString(), values[8].ToString(), values[9].ToString()),
                distributors_work_days= new WeekDays((bool)values[10], (bool)values[11], (bool)values[12], (bool)values[13], (bool)values[14], (bool)values[15])
            };
           _viewModel.updateDistributor(distributor);
            //throw new NotImplementedException();
        }
    }
}
