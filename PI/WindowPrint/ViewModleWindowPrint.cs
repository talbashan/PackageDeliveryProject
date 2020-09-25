using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using BE;
using BLL;

namespace PI
{
    public class ViewModleWindowPrint : ObservableCollection<Recipients>
    {
        public ModelWindowPrint currentModle;
        public ObservableCollection<Recipients> listOfRecipients { get; set; }
        public Distributors distributors { get; set; }
        public ViewModleWindowPrint() { }
        public ViewModleWindowPrint(string id, DateTime date, WindowPrint view)
        {
            currentModle = new ModelWindowPrint();
            printUser = new CommandPrintWindow(this);
            listOfRecipients = new ObservableCollection<Recipients>();
            List<Distributors> ezerList = new List<Distributors>(currentModle.getDistributors(d => d.distributors_id == id));
            distributors = new Distributors(ezerList[0]);
            view.FirstName.Text = distributors.distributors_first_name;
            view.LastName.Text = distributors.distributors_last_name;
            view.printButton.Command = printUser;


            try
            {
                listOfRecipients.Clear();
                List<Recipients> modelList = currentModle.findListOfRecipients(id, date);
                for (int i = 0; i < modelList.Count; i++)
                {
                    listOfRecipients.Add(modelList[i]);
                }
            }
            catch (Exception)
            {
            }
            view.listView.ItemsSource = listOfRecipients;
        }

        public ICommand printUser
        {
            get;
            private set;
        }
    }
}
