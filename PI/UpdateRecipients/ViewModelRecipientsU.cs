using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using BE;

namespace PI
{
    public class ViewModelRecipientsU: INotifyPropertyChanged
    {
        private ModelRecipientsU currentModle;

        public event PropertyChangedEventHandler PropertyChanged;

        public Recipients recipients { get; set; }

        public ViewModelRecipientsU()
        {
            recipients = new Recipients();
            currentModle = new ModelRecipientsU();
            searchReci = new CommandSearchRecipients(this);
            updateReci = new CommandUpdateRecipients(this);
        }
        public ICommand searchReci
        {
            get;
            private set;
        }
        public ICommand updateReci
        {
            get;
            private set;
        }

        public string FirstName
        {
            get { return recipients.recipients_first_name; }
            set
            {
                recipients.recipients_first_name = value;
                if (PropertyChanged != null) PropertyChanged(this, new PropertyChangedEventArgs("FirstName"));
            }
        }
        public string LastName
        {
            get { return recipients.recipients_last_name; }
            set
            {
                recipients.recipients_last_name = value;
                if (PropertyChanged != null) PropertyChanged(this, new PropertyChangedEventArgs("LastName"));
            }
        }
        public string EmailAddress
        {
            get { return recipients.recipients_email_address; }
            set
            {
                recipients.recipients_email_address = value;
                if (PropertyChanged != null) PropertyChanged(this, new PropertyChangedEventArgs("EmailAddress"));
            }
        }
        public string PhoneNumber
        {
            get { return recipients.recipients_phone_number; }
            set
            {
                recipients.recipients_phone_number = value;
                if (PropertyChanged != null) PropertyChanged(this, new PropertyChangedEventArgs("PhoneNumber"));
            }
        }
        public DateTime DateOfBirth
        {
            get { return recipients.recipients_date_of_birth; }
            set
            {
                recipients.recipients_date_of_birth = value;
                if (PropertyChanged != null) PropertyChanged(this, new PropertyChangedEventArgs("DateOfBirth"));
            }
        }
        public gender GenderR
        {
            get { return recipients.recipients_gender; }
            set
            {
                recipients.recipients_gender = value;
                if (PropertyChanged != null) PropertyChanged(this, new PropertyChangedEventArgs("GenderR"));
            }
        }
        public string AddressCity
        {
            get { return recipients.recipients_address.address_city; }
            set
            {
                recipients.recipients_address.address_city = value;
                if (PropertyChanged != null) PropertyChanged(this, new PropertyChangedEventArgs("AddressCity"));
            }
        }
        public string AddressStreet
        {
            get { return recipients.recipients_address.address_street; }
            set
            {
                recipients.recipients_address.address_street = value;
                if (PropertyChanged != null) PropertyChanged(this, new PropertyChangedEventArgs("AddressStreet"));
            }
        }
        public string AddressNum
        {
            get { return recipients.recipients_address.address_number; }
            set
            {
                recipients.recipients_address.address_number = value;
                if (PropertyChanged != null) PropertyChanged(this, new PropertyChangedEventArgs("AddressNum"));
            }
        }
        public status StatusR
        {
            get { return recipients.recipients_status; }
            set
            {
                recipients.recipients_status = value;
                if (PropertyChanged != null) PropertyChanged(this, new PropertyChangedEventArgs("StatusR"));
            }
        }
        public frequency package_frequency
        {
            get { return recipients.recipients_package.package_frequency; }
            set
            {
                recipients.recipients_package.package_frequency = value;
                if (PropertyChanged != null) PropertyChanged(this, new PropertyChangedEventArgs("package_frequency"));
            }
        }
        public DateTime packageStartDate
        {
            get { return recipients.recipients_package.package_start_date; }
            set
            {
                recipients.recipients_package.package_start_date = value;
                if (PropertyChanged != null) PropertyChanged(this, new PropertyChangedEventArgs("packageStartDate"));
            }
        }
        public DateTime packageFinishDate
        {
            get { return recipients.recipients_package.package_finish_date; }
            set
            {
                recipients.recipients_package.package_finish_date = value;
                if (PropertyChanged != null) PropertyChanged(this, new PropertyChangedEventArgs("packageFinishDate"));
            }
        }
        public bool food_eggs
        {
            get { return recipients.recipients_package.food_eggs; }
            set
            {
                recipients.recipients_package.food_eggs = value;
                if (PropertyChanged != null) PropertyChanged(this, new PropertyChangedEventArgs("food_eggs"));
            }
        }
        public bool food_bread
        {
            get { return recipients.recipients_package.food_bread; }
            set
            {
                recipients.recipients_package.food_bread = value;
                if (PropertyChanged != null) PropertyChanged(this, new PropertyChangedEventArgs("food_bread"));
            }
        }
        public bool food_oil
        {
            get { return recipients.recipients_package.food_oil; }
            set
            {
                recipients.recipients_package.food_oil = value;
                if (PropertyChanged != null) PropertyChanged(this, new PropertyChangedEventArgs("food_oil"));
            }
        }
        public bool food_milk
        {
            get { return recipients.recipients_package.food_milk; }
            set
            {
                recipients.recipients_package.food_milk = value;
                if (PropertyChanged != null) PropertyChanged(this, new PropertyChangedEventArgs("food_milk"));
            }
        }
        public bool food_sugar
        {
            get { return recipients.recipients_package.food_sugar; }
            set
            {
                recipients.recipients_package.food_sugar = value;
                if (PropertyChanged != null) PropertyChanged(this, new PropertyChangedEventArgs("food_sugar"));
            }
        }
        public bool food_salt
        {
            get { return recipients.recipients_package.food_salt; }
            set
            {
                recipients.recipients_package.food_salt = value;
                if (PropertyChanged != null) PropertyChanged(this, new PropertyChangedEventArgs("food_salt"));
            }
        }
        public bool food_butter
        {
            get { return recipients.recipients_package.food_butter; }
            set
            {
                recipients.recipients_package.food_butter = value;
                if (PropertyChanged != null) PropertyChanged(this, new PropertyChangedEventArgs("food_butter"));
            }
        }
        public bool food_cream_cheese
        {
            get { return recipients.recipients_package.food_cream_cheese; }
            set
            {
                recipients.recipients_package.food_cream_cheese = value;
                if (PropertyChanged != null) PropertyChanged(this, new PropertyChangedEventArgs("food_cream_cheese"));
            }
        }
        public bool food_water
        {
            get { return recipients.recipients_package.food_water; }
            set
            {
                recipients.recipients_package.food_water = value;
                if (PropertyChanged != null) PropertyChanged(this, new PropertyChangedEventArgs("food_water"));
            }
        }
        public bool food_ice_cream
        {
            get { return recipients.recipients_package.food_ice_cream; }
            set
            {
                recipients.recipients_package.food_ice_cream = value;
                if (PropertyChanged != null) PropertyChanged(this, new PropertyChangedEventArgs("food_ice_cream"));
            }
        }
        public bool food_chocolate
        {
            get { return recipients.recipients_package.food_chocolate; }
            set
            {
                recipients.recipients_package.food_chocolate = value;
                if (PropertyChanged != null) PropertyChanged(this, new PropertyChangedEventArgs("food_chocolate"));
            }
        }
        public bool food_vegetables
        {
            get { return recipients.recipients_package.food_vegetables; }
            set
            {
                recipients.recipients_package.food_vegetables = value;
                if (PropertyChanged != null) PropertyChanged(this, new PropertyChangedEventArgs("food_vegetables"));
            }
        }
        public bool food_fruit
        {
            get { return recipients.recipients_package.food_fruit; }
            set
            {
                recipients.recipients_package.food_fruit = value;
                if (PropertyChanged != null) PropertyChanged(this, new PropertyChangedEventArgs("food_fruit"));
            }
        }
        public bool medicine_acamol {
            get { return recipients.recipients_package.medicine_acamol; }
            set
            {
                recipients.recipients_package.medicine_acamol = value;
                if (PropertyChanged != null) PropertyChanged(this, new PropertyChangedEventArgs("medicine_acamol"));
            }
        }
        public bool medicine_optalgin {
            get { return recipients.recipients_package.medicine_optalgin; }
            set
            {
                recipients.recipients_package.medicine_optalgin = value;
                if (PropertyChanged != null) PropertyChanged(this, new PropertyChangedEventArgs("medicine_optalgin"));
            }
        }
        public bool medicine_adex {
            get { return recipients.recipients_package.medicine_adex; }
            set
            {
                recipients.recipients_package.medicine_adex = value;
                if (PropertyChanged != null) PropertyChanged(this, new PropertyChangedEventArgs("medicine_adex"));
            }
        }
        public bool medicine_nurofen {
            get { return recipients.recipients_package.medicine_nurofen; }
            set
            {
                recipients.recipients_package.medicine_nurofen = value;
                if (PropertyChanged != null) PropertyChanged(this, new PropertyChangedEventArgs("medicine_nurofen"));
            }
        }
        public bool medicine_advil {
            get { return recipients.recipients_package.medicine_advil; }
            set
            {
                recipients.recipients_package.medicine_advil = value;
                if (PropertyChanged != null) PropertyChanged(this, new PropertyChangedEventArgs("medicine_advil"));
            }
        }
        public bool medicine_ibuprofen {
            get { return recipients.recipients_package.medicine_ibuprofen; }
            set
            {
                recipients.recipients_package.medicine_ibuprofen = value;
                if (PropertyChanged != null) PropertyChanged(this, new PropertyChangedEventArgs("medicine_ibuprofen"));
            }
        }
        public bool medicine_vitamin_C {
            get { return recipients.recipients_package.medicine_vitamin_C; }
            set
            {
                recipients.recipients_package.medicine_vitamin_C = value;
                if (PropertyChanged != null) PropertyChanged(this, new PropertyChangedEventArgs("medicine_vitamin_C"));
            }
        }
        public bool medicine_vitamin_D {
            get { return recipients.recipients_package.medicine_vitamin_D; }
            set
            {
                recipients.recipients_package.medicine_vitamin_D = value;
                if (PropertyChanged != null) PropertyChanged(this, new PropertyChangedEventArgs("medicine_vitamin_D"));
            }
        }

        public Recipients searchRecipients(string id)
        {
            try
            {
                recipients = currentModle.searchRecipients(id);
                packageFinishDate = recipients.recipients_package.package_finish_date;
                packageStartDate = recipients.recipients_package.package_start_date;
                FirstName = recipients.recipients_first_name;
                LastName = recipients.recipients_last_name;
                PhoneNumber = recipients.recipients_phone_number;
                EmailAddress = recipients.recipients_email_address;
                GenderR = recipients.recipients_gender;
                StatusR = recipients.recipients_status;
                DateOfBirth = recipients.recipients_date_of_birth;
                AddressCity = recipients.recipients_address.address_city;
                AddressStreet = recipients.recipients_address.address_street;
                AddressNum = recipients.recipients_address.address_number;
                package_frequency = recipients.recipients_package.package_frequency;

                
                food_bread = recipients.recipients_package.food_bread;
                food_butter = recipients.recipients_package.food_butter;
                food_chocolate = recipients.recipients_package.food_chocolate;
                food_cream_cheese = recipients.recipients_package.food_cream_cheese;
                food_eggs = recipients.recipients_package.food_eggs;
                food_fruit = recipients.recipients_package.food_fruit;
                food_ice_cream = recipients.recipients_package.food_ice_cream;
                food_milk = recipients.recipients_package.food_milk;
                food_oil = recipients.recipients_package.food_oil;
                food_salt = recipients.recipients_package.food_salt;
                food_sugar = recipients.recipients_package.food_sugar;
                food_vegetables = recipients.recipients_package.food_vegetables;
                food_water = recipients.recipients_package.food_water;
                medicine_acamol = recipients.recipients_package.medicine_acamol;
                medicine_adex = recipients.recipients_package.medicine_adex;
                medicine_advil = recipients.recipients_package.medicine_advil;
                medicine_ibuprofen = recipients.recipients_package.medicine_ibuprofen;
                medicine_nurofen = recipients.recipients_package.medicine_nurofen;
                medicine_optalgin = recipients.recipients_package.medicine_optalgin;
                medicine_vitamin_C = recipients.recipients_package.medicine_vitamin_C;
                medicine_vitamin_D = recipients.recipients_package.medicine_vitamin_D;
                new WindowMessageBox("החיפוש הושלם", "החיפוש הושלם", false).Show();

                //System.Windows.MessageBox.Show("החיפוש הושלם", "החיפוש הושלם", MessageBoxButton.OK, MessageBoxImage.Information);
                return recipients;
            }
            catch (Exception exp)
            {
                new WindowMessageBox(exp.Message, "שגיאה בחיפוש", true).Show();
                //System.Windows.MessageBox.Show(exp.Message, "שגיאה בחיפוש", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            return null;
        }

        public bool updateRecipients(Recipients recipients)
        {
            string error = "";
            if (recipients.recipients_id.Length < 9)
            {
                error += "תעודת זהות קצרה מידי";
                error += "\n";

            }
            if (recipients.recipients_id.Length > 9)
            {
                error += "תעודת זהות ארוכה מידי";
                error += "\n";
            }
            if (recipients.recipients_phone_number.Length < 10)
            {
                error += "מספר הטלפון שהוזן קצר מידי";
                error += "\n";
            }
            if (recipients.recipients_email_address.Length == 0)
            {
                error += "כתובת המייל שהוזנה אינה תקינה";
                error += "\n";

            }
            else if (recipients.recipients_email_address.IndexOf('@') != recipients.recipients_email_address.IndexOf('@') || recipients.recipients_email_address.IndexOf('@') == -1)
            {
                error += "כתובת המייל שהוזנה אינה תקינה";
                error += "\n";

            }
            else if (recipients.recipients_email_address.IndexOf(".") == -1)
            {

                error += "כתובת המייל שהוזנה אינה תקינה";
                error += "\n";
            }
            if (error != "")
            {
                new WindowMessageBox(error.ToString(), "שגיאה בהזנת הנתונים", true).Show();
                //MessageBox.Show(error.ToString(), "שגיאה בהזנת הנתונים", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }
            else
            {
                try
                {
                    currentModle.updateRecipients(recipients);
                    new WindowMessageBox("הנתונים הוזנו בהצלחה", "הנתונים הוזנו בהצלחה", false).Show();
                    //System.Windows.MessageBox.Show("הנתונים הוזנו בהצלחה", "הנתונים הוזנו בהצלחה", MessageBoxButton.OK, MessageBoxImage.None);
                    return true;
                }
                catch (Exception exp)
                {
                    new WindowMessageBox(exp.Message, "שגיאה בהזנת הנתונים", true).Show();
                    //System.Windows.MessageBox.Show(exp.Message, "שגיאה בהזנת הנתונים", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            return true;
        }
        }
}
