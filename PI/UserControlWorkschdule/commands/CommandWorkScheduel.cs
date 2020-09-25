using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media.Imaging;
using BE;

namespace PI
{
   public class CommandWorkScheduel :ICommand
    {
        public ViewModelWorkScheduel _viewModel;
        public List<Distributors> temp = new List<Distributors>();
        public CommandWorkScheduel(ViewModelWorkScheduel vm)
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
            //  throw new NotImplementedException();
        }

        public void Execute(object parameter)
        {

            Frame frame = (Frame)Application.Current.MainWindow.FindName("myFrame");
            UserControl userControl1 = frame.Content as UserControl;
            ListView list1 = (userControl1.Content as Grid).Children[1] as ListView;
            temp.Clear();
            foreach (Distributors dist in list1.SelectedItems)
            {
                temp.Add(dist);
            }
            _viewModel.saveWorkSchedual(temp);
        }
    }
}
