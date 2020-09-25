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
    /// Interaction logic for UserControlChartOne.xaml
    /// </summary>
    public partial class UserControlChartOne : UserControl
    {
        public ViewModleChartOne ViewModle { get; set; }
        public UserControlChartOne()
        {
            InitializeComponent();
            this.divide.ItemsSource = Enum.GetValues(typeof(BE.frequency));
            ViewModle = new ViewModleChartOne();
            this.DataContext = ViewModle;

        }
    }
}
