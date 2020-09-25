using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using BE;
using BLL;

namespace PI
{
    /// <summary>
    /// Interaction logic for WindowPrint.xaml
    /// </summary>
    public partial class WindowPrint : Window
    {
        public ViewModleWindowPrint viewModel { get; set; }
        public WindowPrint(string id, DateTime date1)
        {
            InitializeComponent();
            this.date.Text = date1.Date.ToShortDateString();
            callVM(id,date1);
          
        }
        public void callVM(string id, DateTime date1)
        {
            viewModel = new ViewModleWindowPrint(id, date1, this);
            this.DataContext = viewModel;
        }
    }
}
