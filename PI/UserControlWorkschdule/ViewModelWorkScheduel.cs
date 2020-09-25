using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using BE;
using BLL;

namespace PI
{
   public class ViewModelWorkScheduel: ObservableCollection<Distributors>
    {
        public ModelWorkScheduel currentModle;
        public ObservableCollection<Distributors> listOfDistributors { get; set; }

        public ViewModelWorkScheduel() 
        {
            currentModle = new ModelWorkScheduel();
            DateTime date = DateTime.Today;
            Func<Distributors, bool> predicat = (d => d.distributors_work_days.myDayIs(date.DayOfWeek));
            listOfDistributors = new ObservableCollection<Distributors>(currentModle.getDistributors(predicat));
            viewCommand = new CommandWorkScheduel(this);
        }
        public ICommand viewCommand
        {
            get;
            private set;
        }

        public void saveWorkSchedual(List<Distributors> myList)
        {
            WindowMessageBox w;
            if (myList.Count != 3)
            {
                string error = "שגיאה - יש לבחור 3 מחלקים לכל יום";
                new WindowMessageBox(error.ToString(), "שגיאה בהזנת הנתונים", true).Show();
                //MessageBox.Show(error.ToString(), "שגיאה בהזנת הנתונים", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            try
            {
                currentModle.saveWorkSchedual(myList);
                string str = "סידור העבודה עבר בהצלחה";
                str += "\n";
                str += "המתן כעת לחילוק כתובות למשלוח עבור כל מחלק";
                w = new WindowMessageBox(str, "הנתונים הוזנו בהצלחה", false);
                w.Show();
                //System.Windows.MessageBox.Show(str, "הנתונים הוזנו בהצלחה", MessageBoxButton.OK, MessageBoxImage.None);
                try
                {
                    currentModle.k_Mean();
                    w.Close();
                    new WindowMessageBox("החילוק עבר בהצלחה", "החילוק עבר בהצלחה", false).Show();
                    //System.Windows.MessageBox.Show("החילוק עבר בהצלחה", "החילוק עבר בהצלחה", MessageBoxButton.OK, MessageBoxImage.None);
                }
                catch (Exception e)
                {
                    new WindowMessageBox(e.Message, "שגיאה בביצוע חלוקת הכתובות", true).Show();
                    //MessageBox.Show(e.Message, "שגיאה בביצוע חלוקת הכתובות", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            catch (Exception exp)
            {
                new WindowMessageBox(exp.Message, "שגיאה בהזנת הנתונים", true).Show();
                //MessageBox.Show(exp.Message, "שגיאה בהזנת הנתונים", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
