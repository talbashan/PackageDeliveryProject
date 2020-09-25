using System;
using System.Collections.Generic;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PI
{
    /// <summary>
    /// Interaction logic for UserControlChartTwo.xaml
    /// </summary>
    public partial class UserControlChartTwo : UserControl
    {
        public ViewModleChartTwo viewModle { get; set; }
        public UserControlChartTwo()
        {
            InitializeComponent();
            this.divide.ItemsSource = Enum.GetValues(typeof(BE.frequency));
            viewModle = new ViewModleChartTwo();
            this.DataContext = viewModle;
        }
    }
}
