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
    /// Interaction logic for UserControlUpdateRecipients.xaml
    /// </summary>
    public partial class UserControlUpdateRecipients : UserControl
    {
        public ViewModelRecipientsU viewModel { get; set; }

        public UserControlUpdateRecipients()
        {
            InitializeComponent();
            this.genderComboBox.ItemsSource = Enum.GetValues(typeof(BE.gender));
            this.statusComboBox.ItemsSource = Enum.GetValues(typeof(BE.status));
            this.frequencyComboBox.ItemsSource = Enum.GetValues(typeof(BE.frequency));

            viewModel = new ViewModelRecipientsU();
            this.DataContext = viewModel;
        }
        private void personalData_Expanded(object sender, RoutedEventArgs e)
        {
            this.label.Visibility = Visibility.Hidden;
            this.label.Height = 0;
            this.label.Width = 0;
            this.save.IsExpanded = false;
            this.package.IsExpanded = false;
            this.dataPackage.IsExpanded = false;
            this.search.IsExpanded = false;
        }

        private void package_Expanded(object sender, RoutedEventArgs e)
        {
            this.label.Visibility = Visibility.Hidden;
            this.label.Height = 0;
            this.label.Width = 0;
            this.save.IsExpanded = false;
            this.personalData.IsExpanded = false;
            this.dataPackage.IsExpanded = false;
            this.search.IsExpanded = false;
        }

        private void save_Expanded(object sender, RoutedEventArgs e)
        {
            this.label.Visibility = Visibility.Hidden;
            this.label.Height = 0;
            this.label.Width = 0;
            this.personalData.IsExpanded = false;
            this.package.IsExpanded = false;
            this.dataPackage.IsExpanded = false;
            this.search.IsExpanded = false;
        }

        private void dataPackage_Expanded(object sender, RoutedEventArgs e)
        {
            this.label.Visibility = Visibility.Hidden;
            this.label.Height = 0;
            this.label.Width = 0;
            this.save.IsExpanded = false;
            this.package.IsExpanded = false;
            this.personalData.IsExpanded = false;
            this.search.IsExpanded = false;

        }
        private void TextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = new Regex("[^0-9]+").IsMatch(e.Text);
        }

        private void search_Expanded(object sender, RoutedEventArgs e)
        {
            this.label.Visibility = Visibility.Hidden;
            this.label.Height = 0;
            this.label.Width = 0;
            this.save.IsExpanded = false;
            this.package.IsExpanded = false;
            this.dataPackage.IsExpanded = false;
            this.personalData.IsExpanded = false;
        }
    }
}
