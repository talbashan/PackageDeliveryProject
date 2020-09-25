using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using BE;
using BLL;

namespace PI
{
    public class ViewModelPackageByDay: ObservableCollection<Recipients>, INotifyPropertyChanged
    {
        private ModelPackageByDay currentModle;
        public ObservableCollection<Recipients> listOfRecipients { get; set; }

        public ViewModelPackageByDay()
        {
            currentModle = new ModelPackageByDay();
            viewComand = new CommandPackageByDay(this);
            backComand = new CommandBack(this);
            listOfRecipients = new ObservableCollection<Recipients>();
        }
        public ICommand viewComand
        {
            get;
            private set;
        }

        public ICommand backComand
        {
            get;
            private set;
        }

        public ObservableCollection<Recipients> searchRecipients(DateTime date)
        {
            try
            {
                listOfRecipients.Clear();
                ObservableCollection<Recipients> temp = new ObservableCollection<Recipients>(currentModle.searchRecipients(date));
                for(int i=0; i<temp.Count; i++)
                {
                    listOfRecipients.Add(temp[i]);  
                }
            }
            catch (Exception exp)
            {
                new WindowMessageBox(exp.Message, "שגיאה בהזנת הנתונים", true).Show();
                //MessageBox.Show(exp.Message, "שגיאה בהזנת הנתונים", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            return listOfRecipients;
        }
    }
}
