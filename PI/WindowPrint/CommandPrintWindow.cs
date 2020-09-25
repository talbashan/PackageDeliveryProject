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
   public class CommandPrintWindow : ICommand
    {
        public ViewModleWindowPrint _viewModel;
        public CommandPrintWindow(ViewModleWindowPrint vm)
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
            foreach (Window window in Application.Current.Windows)
            {
                if (window.GetType() == typeof(WindowPrint))
                {
                    PrintDialog printDialog = new PrintDialog();
                    if (printDialog.ShowDialog() == true)
                    {
                        printDialog.PrintVisual((window as WindowPrint).print, "WindowPrint");
                    }
                }
            }
            
        }
    }
}
