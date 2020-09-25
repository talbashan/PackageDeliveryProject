using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
    /// Interaction logic for UserControlAddDistibutor.xaml
    /// </summary>
    public partial class UserControlAddDistibutor : UserControl
    {
        private ViewModelDistibutorA viewModel { get; set; }

        public UserControlAddDistibutor()
        {
            InitializeComponent();
            this.genderComboBox.ItemsSource = Enum.GetValues(typeof(BE.gender));

            viewModel = new ViewModelDistibutorA();
            this.DataContext = viewModel;
        }
        private void workDays_Expanded(object sender, RoutedEventArgs e)
        {
            this.label.Visibility = Visibility.Hidden;
            this.label.Height = 0;
            this.label.Width = 0;
            this.personalData.IsExpanded = false;
            this.save.IsExpanded = false;
        }

        private void personalData_Expanded(object sender, RoutedEventArgs e)
        {
            this.label.Visibility = Visibility.Hidden;
            this.label.Height = 0;
            this.label.Width = 0;
            this.workDays.IsExpanded = false;
            this.save.IsExpanded = false;
        }

        private void save_Expanded(object sender, RoutedEventArgs e)
        {
            this.label.Visibility = Visibility.Hidden;
            this.label.Height = 0;
            this.label.Width = 0;
            this.personalData.IsExpanded = false;
            this.workDays.IsExpanded = false;

        }

        private void TextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = new Regex("[^0-9]+").IsMatch(e.Text);
        }
    }
}
