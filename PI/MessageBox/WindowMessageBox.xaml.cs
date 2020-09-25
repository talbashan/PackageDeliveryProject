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
using System.Windows.Shapes;

namespace PI
{
    /// <summary>
    /// Interaction logic for WindowMessageBox.xaml
    /// </summary>
    public partial class WindowMessageBox : Window
    {
        public ViewModleMessageBox viewModle { get; set; }
        public WindowMessageBox(string one, string two, bool isError)
        {
            InitializeComponent();
            this.header.Content = two;
            this.content.Content = one;
            if (isError == true)
            {
                this.error.Visibility = Visibility.Visible;
                this.alert.Visibility = Visibility.Hidden;
            }
            else
            {
                this.error.Visibility = Visibility.Hidden;
                this.alert.Visibility = Visibility.Visible;
            }

            buildViewModle();
        }
        public void buildViewModle()
        {
            viewModle = new ViewModleMessageBox(this);
            this.DataContext = viewModle;
        }

    }
}

