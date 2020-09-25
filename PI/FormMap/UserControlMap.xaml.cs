using Microsoft.Maps.MapControl.WPF;
using System;
using System.Collections.Generic;
using System.Drawing;
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

using Color = System.Drawing.Color;
using BE;
using BLL;
using System.Device.Location;

namespace PI
{
    /// <summary>
    /// Interaction logic for UserControlMap.xaml
    /// </summary>
    public partial class UserControlMap : UserControl
    {
        private ViewModelMap viewModel { get; set; }
        private MapLayer dataLayer { get; set; }
        public UserControlMap()
        {
            InitializeComponent();
            callVM();
        }
        public void callVM()
        {
            viewModel = new ViewModelMap(this);
            this.DataContext = viewModel;
            dataLayer = new MapLayer();
            mymap.Children.Add(dataLayer);
        }
        public void addLatlonToMap(GeoCoordinate geoCoordinate, System.Windows.Media.Brush color, int num)
        {
            Pushpin pin1 = new Pushpin();
            pin1.Background = color;
            pin1.Location = new Microsoft.Maps.MapControl.Location(geoCoordinate.Latitude, geoCoordinate.Longitude);
            pin1.Tag = "מחלק";
            pin1.AllowDrop = true;
            pin1.ToolTip= "מחלק";
            if (num == 1)
            {
                pin1.Opacity = 0.5;
                pin1.ToolTip = "מחולק";
            }
            dataLayer.Children.Add(pin1);
        }

        public void removeLayer()
        {
            dataLayer.Children.Clear();
            //mymap.Children.Remove(dataLayer);
        }
    }
}
