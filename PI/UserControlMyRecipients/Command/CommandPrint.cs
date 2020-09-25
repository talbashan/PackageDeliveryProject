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
   public class CommandPrint: ICommand
    {
        public ViewModelMyRecipients _viewModel;
        public CommandPrint(ViewModelMyRecipients vm)
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
            var values = (Object[])parameter;
            string id = values[0].ToString();
            DateTime date = DateTime.Parse(values[1].ToString());
            new WindowPrint(id, date).Show();

            //Frame frame = (Frame)Application.Current.MainWindow.FindName("myFrame");
            //UserControl userControl1 = frame.Content as UserControl;

            //PrintDialog printDialog = new PrintDialog();
            //if (printDialog.ShowDialog() == true)
            //{
            //    printDialog.PrintVisual(userControl1, "printMyList");
            //}
        }
    }
}
