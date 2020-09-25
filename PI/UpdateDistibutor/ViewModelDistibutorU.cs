using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using BE;

namespace PI
{
    public class ViewModelDistibutorU: INotifyPropertyChanged
    {
        private ModelDistibutorU currentModle;

        public event PropertyChangedEventHandler PropertyChanged;

        public Distributors distributors { get; set; }

        public ViewModelDistibutorU()
        {
            currentModle = new ModelDistibutorU();
            searchDis = new CommandSearchDistibutor(this);
            UpdateCommend = new CommandUpdateDistibutor(this);
            distributors = new Distributors();
        }
        public ICommand searchDis
        {
            get;
            private set;
        }
        public ICommand UpdateCommend
        {
            get;
            private set;
        }


        public string FirstName
        {
            get { return distributors.distributors_first_name; }
            set { distributors.distributors_first_name = value;
                if (PropertyChanged != null) PropertyChanged(this, new PropertyChangedEventArgs("FirstName"));
            }
        }
        public string LastName
        {
            get { return distributors.distributors_last_name; }
            set
            {
                distributors.distributors_last_name = value;
                if (PropertyChanged != null) PropertyChanged(this, new PropertyChangedEventArgs("LastName"));
            }
        }
        public string EmailAddress
        {
            get { return distributors.distributors_email_address; }
            set
            {
                distributors.distributors_email_address = value;
                if (PropertyChanged != null) PropertyChanged(this, new PropertyChangedEventArgs("EmailAddress"));
            }
        }
        public string PhoneNumber
        {
            get { return distributors.distributors_phone_number; }
            set
            {
                distributors.distributors_phone_number = value;
                if (PropertyChanged != null) PropertyChanged(this, new PropertyChangedEventArgs("PhoneNumber"));
            }
        }
        public DateTime DateOfBirth
        {
            get { return distributors.distributors_date_of_birth; }
            set
            {
                distributors.distributors_date_of_birth = value;
                if (PropertyChanged != null) PropertyChanged(this, new PropertyChangedEventArgs("DateOfBirth"));
            }
        }
        public gender Gender
        {
            get { return distributors.distributors_gender; }
            set
            {
                distributors.distributors_gender = value;
                if (PropertyChanged != null) PropertyChanged(this, new PropertyChangedEventArgs("Gender"));
            }
        }
        public string AddressCity
        {
            get { return distributors.distributors_address.address_city; }
            set
            {
                distributors.distributors_address.address_city = value;
                if (PropertyChanged != null) PropertyChanged(this, new PropertyChangedEventArgs("AddressCity"));
            }
        }
        public string AddressStreet
        {
            get { return distributors.distributors_address.address_street; }
            set
            {
                distributors.distributors_address.address_street = value;
                if (PropertyChanged != null) PropertyChanged(this, new PropertyChangedEventArgs("AddressStreet"));
            }
        }
        public string AddressNum
        {
            get { return distributors.distributors_address.address_number; }
            set
            {
                distributors.distributors_address.address_number = value;
                if (PropertyChanged != null) PropertyChanged(this, new PropertyChangedEventArgs("AddressNum"));
            }
        }
        public bool sunday
        {
            get { return distributors.distributors_work_days.sunday; }
            set
            {
                distributors.distributors_work_days.sunday = value;
                if (PropertyChanged != null) PropertyChanged(this, new PropertyChangedEventArgs("sunday"));
            }
        }
        public bool monday
        {
            get { return distributors.distributors_work_days.monday; }
            set
            {
                distributors.distributors_work_days.monday = value;
                if (PropertyChanged != null) PropertyChanged(this, new PropertyChangedEventArgs("monday"));
            }
        }
        public bool tuesday
        {
            get { return distributors.distributors_work_days.tuesday; }
            set
            {
                distributors.distributors_work_days.tuesday = value;
                if (PropertyChanged != null) PropertyChanged(this, new PropertyChangedEventArgs("tuesday"));
            }
        }
        public bool wednesday
        {
            get { return distributors.distributors_work_days.wednesday; }
            set
            {
                distributors.distributors_work_days.wednesday = value;
                if (PropertyChanged != null) PropertyChanged(this, new PropertyChangedEventArgs("wednesday"));
            }
        }
        public bool thursday
        {
            get { return distributors.distributors_work_days.thursday; }
            set
            {
                distributors.distributors_work_days.thursday = value;
                if (PropertyChanged != null) PropertyChanged(this, new PropertyChangedEventArgs("thursday"));
            }
        }
        public bool friday
        {
            get { return distributors.distributors_work_days.friday; }
            set
            {
                distributors.distributors_work_days.friday = value;
                if (PropertyChanged != null) PropertyChanged(this, new PropertyChangedEventArgs("friday"));
            }
        }

        public Distributors searchDistributor(string id)
        {
            try
            {
                distributors = currentModle.searchDistributor(id);
                FirstName = distributors.distributors_first_name;
                LastName = distributors.distributors_last_name;
                EmailAddress = distributors.distributors_email_address;
                PhoneNumber = distributors.distributors_phone_number;
                DateOfBirth = distributors.distributors_date_of_birth;
                Gender = distributors.distributors_gender;
                AddressCity = distributors.distributors_address.address_city;
                AddressStreet = distributors.distributors_address.address_street;
                AddressNum = distributors.distributors_address.address_number;
                sunday = distributors.distributors_work_days.sunday;
                monday = distributors.distributors_work_days.monday;
                tuesday = distributors.distributors_work_days.tuesday;
                wednesday = distributors.distributors_work_days.wednesday;
                thursday = distributors.distributors_work_days.thursday;
                friday = distributors.distributors_work_days.friday;
                //System.Windows.MessageBox.Show("החיפוש הושלם", "החיפוש הושלם", MessageBoxButton.OK, MessageBoxImage.Information);
                new WindowMessageBox("החיפוש הושלם", "החיפוש הושלם",false).Show();
                return distributors;
            }
            catch (Exception exp)
            {
                new WindowMessageBox(exp.Message, "שגיאה בחיפוש", true).Show();
                //System.Windows.MessageBox.Show(exp.Message, "שגיאה בחיפוש", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            return null;
        }

        public bool updateDistributor(Distributors dis)
        {
            string error = "";
            if (dis.distributors_id.Length < 9)
            {
                error += "תעודת זהות קצרה מידי";
                error += "\n";

            }
            if (dis.distributors_id.Length > 9)
            {
                error += "תעודת זהות ארוכה מידי";
                error += "\n";
            }
            if (dis.distributors_phone_number.Length < 10)
            {
                error += "מספר הטלפון שהוזן קצר מידי";
                error += "\n";
            }
            if (dis.distributors_email_address.Length == 0)
            {
                error += "כתובת המייל שהוזנה אינה תקינה";
                error += "\n";

            }
            else if (dis.distributors_email_address.IndexOf('@') != dis.distributors_email_address.IndexOf('@') || dis.distributors_email_address.IndexOf('@') == -1)
            {
                error += "כתובת המייל שהוזנה אינה תקינה";
                error += "\n";

            }
            else if (dis.distributors_email_address.IndexOf(".") == -1)
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
                    currentModle.updateDistributor(dis);
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
            return false;
        }
    }
}
