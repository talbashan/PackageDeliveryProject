using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Documents;
using System.Windows.Input;
using BE;
using BLL;

namespace PI
{
   public class ViewModelMyRecipients: ObservableCollection<Recipients>
    {
        public ModelMyRecipients currentModle;
        public ObservableCollection<Recipients> listOfRecipients { get; set; }

        public List<string> myDistributors { get; set; }

        public ViewModelMyRecipients()
        {
            currentModle = new ModelMyRecipients();
            List<Distributors> ezerList = new List<Distributors>(currentModle.getDistributors());
            myDistributors = new List<string>();
            searchList = new CommandsearchList(this);
            printUser = new CommandPrint(this);
            for (int i=0; i<ezerList.Count; i++)
            {
                myDistributors.Add(ezerList[i].distributors_id);
            }
            listOfRecipients = new ObservableCollection<Recipients>();
            //listOfRecipients = new ObservableCollection<Recipients>(currentModle.bll.selectRecipients());
        }
        public ICommand searchList
        {
            get;
            private set;
        }

        public ICommand printUser
        {
            get;
            private set;
        }

        public ObservableCollection<Recipients> findListOfRecipients(string id, DateTime date)
        {
            try
            {
                listOfRecipients.Clear();
                List<Recipients> modelList = currentModle.findListOfRecipients(id, date);
                for (int i = 0; i < modelList.Count; i++)
                {
                    listOfRecipients.Add(modelList[i]);
                }
                return listOfRecipients;
            }
            catch (Exception exp)
            {
                new WindowMessageBox(exp.Message, "שגיאה בהזנת הנתונים", true).Show();
                //MessageBox.Show(exp.Message, "שגיאה בהזנת הנתונים", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            return null;

        }
    }
}
