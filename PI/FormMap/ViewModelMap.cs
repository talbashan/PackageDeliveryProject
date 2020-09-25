using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Device.Location;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using static PI.ViewModelMap;

namespace PI
{
    public class ViewModelMap
    {
        public ModelMap currentModle { get; set; }

        public UserControlMap map { get; set; }

        public ViewModelMap(UserControlMap _map)
        {
            //map = new UserControlMap();
            map = _map;
            //Locations1 = new ObservableCollection<MapLocation>();
            currentModle = new ModelMap();
            viewMapCommand = new CommandMap(this);
        }
        public ICommand viewMapCommand
        {
            get;
            private set;
        }

        public double[][,] Getalllatlon(DateTime date)
        {
            System.Windows.Media.SolidColorBrush[] color =
                {
                    System.Windows.Media.Brushes.Yellow,
                    System.Windows.Media.Brushes.Blue,
                    System.Windows.Media.Brushes.Red,

                };
            try
            {
                double[][,] latlon = currentModle.GetalllatlonRec(date);
                if (latlon.Length == 0)
                    throw new Exception("לא קיים חילוק עבודה");
                GeoCoordinate geo = new GeoCoordinate(latlon[0][0, 0], latlon[0][0, 1]);
                map.removeLayer();
                for (int i = 0; i < latlon.Length; i++)
                {
                    for (int j = 0; j < latlon[i].Length / 2; j++)
                    {
                        if (j == 0)
                            map.addLatlonToMap(new GeoCoordinate(latlon[i][j, 0], latlon[i][j, 1]), color[i], 0);
                        else
                            map.addLatlonToMap(new GeoCoordinate(latlon[i][j, 0], latlon[i][j, 1]), color[i], 1);
                    }
                }

            }
            catch (Exception e)
            {
                new WindowMessageBox(e.Message, "שגיאה ", true).Show();

                //System.Windows.MessageBox.Show(e.Message, "שגיאה בהזנת הנתונים", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            return null;
        }
    }
}
