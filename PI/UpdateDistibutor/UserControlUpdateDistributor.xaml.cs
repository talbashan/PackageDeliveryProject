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
    /// Interaction logic for UserControlUpdateDistributor.xaml
    /// </summary>
    public partial class UserControlUpdateDistributor : UserControl
    {
        public ViewModelDistibutorU viewModel { get; set; }
        public UserControlUpdateDistributor()
        {
            InitializeComponent();
            this.genderComboBox.ItemsSource = Enum.GetValues(typeof(BE.gender));

            viewModel = new ViewModelDistibutorU();
            this.DataContext = viewModel;
        }
        private void TextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = new Regex("[^0-9]+").IsMatch(e.Text);
        }

        private void workDays_Expanded(object sender, RoutedEventArgs e)
        {
            this.label.Visibility = Visibility.Hidden;
            this.label.Height = 0;
            this.label.Width = 0;
            this.personalData.IsExpanded = false;
            this.update.IsExpanded = false;
            this.search.IsExpanded = false;
        }

        private void personalData_Expanded(object sender, RoutedEventArgs e)
        {
            this.label.Visibility = Visibility.Hidden;
            this.label.Height = 0;
            this.label.Width = 0;
            this.workDays.IsExpanded = false;
            this.update.IsExpanded = false;
            this.search.IsExpanded = false;
        }

        private void update_Expanded(object sender, RoutedEventArgs e)
        {
            this.label.Visibility = Visibility.Hidden;
            this.label.Height = 0;
            this.label.Width = 0;
            this.personalData.IsExpanded = false;
            this.workDays.IsExpanded = false;
            this.search.IsExpanded = false;

        }

        private void search_Expanded(object sender, RoutedEventArgs e)
        {
            this.label.Visibility = Visibility.Hidden;
            this.label.Height = 0;
            this.label.Width = 0;
            this.personalData.IsExpanded = false;
            this.workDays.IsExpanded = false;
            this.update.IsExpanded = false;

        }
    }
}
