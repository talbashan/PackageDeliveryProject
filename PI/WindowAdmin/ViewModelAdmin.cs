using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using BE;

namespace PI
{
    public class ViewModelAdmin
    {
        private ModelAdmin currentModle;

         public ViewModelAdmin()
        {
            currentModle = new ModelAdmin();
            AddCommend = new CommandCheckAdmin(this);
        }

        public ICommand AddCommend
        {
            get;
            private set;
        }
        public void checkInfo(Admin admin)
        {
            try
            {
                currentModle.checkInfo(admin);
                foreach (Window window in Application.Current.Windows)
                {
                    if (window.GetType() == typeof(WindowAdmin))
                    {
                        (window as WindowAdmin).Close();
                    }
                    if (window.GetType() == typeof(WindowMain))
                    {
                        (window as WindowMain).menuBotton.IsEnabled = true;
                    }
                }
                new WindowMessageBox("ההתחברות עברה בהצלחה", "הנתונים הנכונים הוזנו", false).Show();
                    
            }
            catch (Exception error)
            {
                new WindowMessageBox(error.Message, "שגיאה בהתחברות", true).Show();
            }
        }   
    }
}
