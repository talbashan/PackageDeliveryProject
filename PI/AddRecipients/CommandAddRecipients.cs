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
    public class CommandAddRecipients : ICommand
    {
        private ViewModelRecipientsA _viewModel;

        public CommandAddRecipients(ViewModelRecipientsA vm)
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

            Package pack = new Package()
            {
                food_eggs = (bool)values[11],
            food_bread = (bool)values[12],
                food_oil = (bool)values[13],
                food_milk = (bool)values[14],
                food_sugar = (bool)values[15],
                food_salt = (bool)values[16],
                food_butter = (bool)values[17],
                food_cream_cheese = (bool)values[18],
                food_water = (bool)values[19],
                food_ice_cream = (bool)values[20],
                food_chocolate = (bool)values[21],
                food_vegetables = (bool)values[22],
                food_fruit = (bool)values[23],

                medicine_acamol = (bool)values[24],
                medicine_optalgin = (bool)values[25],
                medicine_adex = (bool)values[26],
                medicine_nurofen = (bool)values[27],
                medicine_advil = (bool)values[28],
                medicine_ibuprofen = (bool)values[29],
                medicine_vitamin_C = (bool)values[30],
                medicine_vitamin_D = (bool)values[31],

                package_start_date = DateTime.Parse(values[32].ToString()),
                package_finish_date = DateTime.Parse(values[33].ToString()),
                package_frequency = (frequency)Enum.Parse(typeof(frequency), values[34].ToString())
            };

            Recipients recipients= new Recipients()
            {
                recipients_id = values[0].ToString(),
                recipients_first_name = values[1].ToString(),
                recipients_last_name = values[2].ToString(),
                recipients_date_of_birth = DateTime.Parse(values[3].ToString()),
                recipients_phone_number = values[4].ToString(),
                recipients_email_address = values[5].ToString(),
                recipients_gender = (gender)Enum.Parse(typeof(gender), values[6].ToString()),
                recipients_status = (status)Enum.Parse(typeof(status),values[7].ToString()),
                recipients_address = new Address(values[8].ToString(), values[9].ToString(), values[10].ToString()),
                recipients_package = new Package(pack)
            };
            _viewModel.checkInfo(recipients);
        }
    }
}
