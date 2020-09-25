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
    /// Interaction logic for UserControlCharts.xaml
    /// </summary>
    public partial class UserControlCharts : UserControl
    { 
        public ViewModelCharts viewModel { get; set; }

        public UserControlCharts(ViewModelMainWindow mvm)
        {
            InitializeComponent();
            viewModel = new ViewModelCharts(mvm);
            this.DataContext = viewModel;
        }
      
    }
}
