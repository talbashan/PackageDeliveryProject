using LiveCharts;
using LiveCharts.Wpf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using BE;
using BLL;
using System.Windows;

namespace PI
{
    public class ViewModleChartThree
    {
        public ModleChartThree currentModle { get; set; }

        public SeriesCollection SeriesCollection { get; set; }

        public List<status> statusList { get; set; }

        public ViewModleChartThree()
        {
            currentModle = new ModleChartThree();
            SeriesCollection = new SeriesCollection();

            statusList = new List<status>();
            statusList.Add(status.בידוד);
            statusList.Add(status.בעל_מוגבלות);
            statusList.Add(status.חולה_קרונה);
            statusList.Add(status.קשיש);
            foreach (var item in statusList)
            {
                SeriesCollection.Add(new PieSeries
                {
                    Title = item.ToString(),
                    DataLabels = true,
                    Values = new ChartValues<int> { 0 }
                });
            }
            drewChartfunc();
        }
        
        public void drewChartfunc()
        {
            List<Recipients> allRecipients;
            int i = 0;
            foreach (var item in statusList)
            {
                allRecipients = currentModle.getRecipientsbyStatus(item);
                SeriesCollection[i].Values = new ChartValues<int> { allRecipients.Count };
                i++;
            }
        }
    }
}

            
        
