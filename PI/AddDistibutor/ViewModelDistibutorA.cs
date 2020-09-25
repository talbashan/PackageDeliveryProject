using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using System.Windows.Input;
using BE;
using MessageBox = System.Windows.MessageBox;

namespace PI
{
    public class ViewModelDistibutorA
    {
        private ModelDistibutorA currentModle;
        public Distributors distributor1 { get; set; }

        public ViewModelDistibutorA()
        {
            distributor1 = new Distributors();
            currentModle = new ModelDistibutorA();
            AddCommend = new CommandAddDistibutor(this);
        }
        public ICommand AddCommend
        {
            get;
            private set;
        }

        public bool checkInfo(Distributors distributor)
        {
            string error = "";
            if (distributor.distributors_id.Length < 9)
            {
                error += "תעודת זהות קצרה מידי";
                error += "\n";

            }
            if (distributor.distributors_id.Length > 9)
            {
                error += "תעודת זהות ארוכה מידי";
                error += "\n";
            }
            if (distributor.distributors_phone_number.Length < 10)
            {
                error += "מספר הטלפון שהוזן קצר מידי";
                error += "\n";
            }
            if (distributor.distributors_email_address.Length == 0)
            {
                error += "כתובת המייל שהוזנה אינה תקינה";
                error += "\n";

            }
           else  if (distributor.distributors_email_address.IndexOf('@') != distributor.distributors_email_address.IndexOf('@') || distributor.distributors_email_address.IndexOf('@') == -1)
            {
                error += "כתובת המייל שהוזנה אינה תקינה";
                error += "\n";

            }
            else if (distributor.distributors_email_address.IndexOf(".") == -1)
            {

                error += "כתובת המייל שהוזנה אינה תקינה";
                error += "\n";
            }
            if (error != "")
            {
                new WindowMessageBox(error.ToString(), "שגיאה בהזנת הנתונים",true).Show();
                //MessageBox.Show(error.ToString(), "שגיאה בהזנת הנתונים", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }
            else
            {
                try
                {
                    currentModle.checkInfo(distributor);
                    new WindowMessageBox("הנתונים הוזנו בהצלחה", "הנתונים הוזנו בהצלחה", false).Show();

                    //System.Windows.MessageBox.Show("הנתונים הוזנו בהצלחה", "הנתונים הוזנו בהצלחה", MessageBoxButton.OK, MessageBoxImage.None);
                   
                    return true;

                }
                catch (Exception exp)
                {
                    new WindowMessageBox(exp.ToString(), "שגיאה בהזנת הנתונים", true).Show();

                    //System.Windows.MessageBox.Show(exp.Message, "שגיאה בהזנת הנתונים", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            return false;
        }
    }
}
