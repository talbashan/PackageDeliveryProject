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
    public class ViewModleChartTwo
    {
        public ModleChartTwo currentModle { get; set; }

        public SeriesCollection SeriesCollection { get; set; }

        public List<string> FinalCityList { get; set; }

        public ViewModleChartTwo()
        {
            currentModle = new ModleChartTwo();
            SeriesCollection = new SeriesCollection();
            drewChart = new CommandDrewChartTwo(this);

            FinalCityList = new List<string>();
            List<string> citysList = new List<string>();
            List<Recipients> ezerlist = currentModle.getRecipients();
            foreach (Recipients item in ezerlist)
            {
                citysList.Add(item.recipients_address.address_city);
            }
            IEnumerable<string> temp = citysList.Distinct();
            foreach (string item in temp)
            {
                FinalCityList.Add(item);
            }
            foreach (string city in FinalCityList)
            {
                SeriesCollection.Add(new PieSeries
                {
                    Title = city,
                    DataLabels = true,
                    Values = new ChartValues<int> { 0 }
                });
            }
        }
        public ICommand drewChart
        {
            get;
            private set;
        }
        public void clearList()
        {
            SeriesCollection.Clear();
            foreach (string city in FinalCityList)
            {
                SeriesCollection.Add(new PieSeries
                {
                    Title = city,
                    DataLabels = true,
                    Values = new ChartValues<int> { 0 }
                });
            }
        }

        public void drewChartfunc(string divide, DateTime date)
        {
            clearList();
            if (divide == "יומי")
            {
                List<Recipients> numPackage = new List<Recipients>();
                int i = 0;
                foreach (string city in FinalCityList)
                {
                    try
                    {
                        numPackage = currentModle.recipientsPackageByDayAndCity(date, city);
                        SeriesCollection[i].Values = new ChartValues<int> { numPackage.Count };
                        i++;
                    }
                    catch (Exception exp)
                    {
                        new WindowMessageBox(exp.Message, "שגיאה ", true).Show();

                        //System.Windows.MessageBox.Show(exp.Message, "שגיאה ", MessageBoxButton.OK, MessageBoxImage.Error);
                    }

                }
            }
            if (divide == "שבועי")
            {
                int count = 0;
                int i = 0;
                DateTime mydate = date;
                DayOfWeek day = date.DayOfWeek;
                switch (day)
                {
                    case DayOfWeek.Sunday:
                        break;
                    case DayOfWeek.Monday:
                        mydate = date.AddDays(-1);
                        break;
                    case DayOfWeek.Tuesday:
                        mydate = date.AddDays(-2);
                        break;
                    case DayOfWeek.Wednesday:
                        mydate = date.AddDays(-3);
                        break;
                    case DayOfWeek.Thursday:
                        mydate = date.AddDays(-4);
                        break;
                    case DayOfWeek.Friday:
                        mydate = date.AddDays(-5);
                        break;
                    default:
                        break;
                }
                foreach (string city in FinalCityList)
                {
                    count = 0;
                    DateTime date1 = mydate;
                   //string city1 = "אשדוד";
                    try
                    {
                        for (int j = 0; j < 7; j++)
                        {
                            List<Recipients> numPackage = currentModle.recipientsPackageByDayAndCity(date1, city);
                            count += numPackage.Count;
                            date1 = date1.AddDays(1);
                        }
                        SeriesCollection[i].Values = new ChartValues<int> { count };
                        i++;
                    }
                    catch (Exception exp)
                    {
                        new WindowMessageBox(exp.Message, "שגיאה ", true).Show();

                        //System.Windows.MessageBox.Show(exp.Message, "שגיאה ", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                }
            }
            if (divide == "חודשי")
            {
                int count = 0;
                int i = 0;
                foreach (string city in FinalCityList)
                {
                    count = 0;
                    DateTime mydate = new DateTime(date.Year, date.Month, 1);

                    try
                    {
                        for (int j = 1; j <= DateTime.DaysInMonth(mydate.Year, mydate.Month) && (mydate.Month == date.Month); j++)
                        {
                            List<Recipients> numPackage = currentModle.recipientsPackageByDayAndCity(mydate, city);
                            count += numPackage.Count;
                            mydate = mydate.AddDays(1);
                        }
                        SeriesCollection[i].Values = new ChartValues<int> { count };
                        i++;
                    }
                    catch (Exception exp)
                    {
                        new WindowMessageBox(exp.Message, "שגיאה ", true).Show();

                        //System.Windows.MessageBox.Show(exp.Message, "שגיאה ", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                }
            }
        }
    }
}

            
        
