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
using System.Resources;
using System.ComponentModel;
using System.Collections.ObjectModel;
using System.Drawing;
using MaterialDesignColors;
using System.Windows.Media;

namespace PI
{
    public class ViewModleChartFour: INotifyPropertyChanged
    {
        public ModleChartFour currentModle { get; set; }
        public SeriesCollection SeriesCollection { get; set; }
        public List<string> myDistributors { get; set; }

        private string[] Labels;
        public string[] Labels1
        {
            get { return Labels; }
            set
            {
                Labels = value;
                PropertyChanged(this, new PropertyChangedEventArgs(null));
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;

        public ViewModleChartFour()
        {
            currentModle = new ModleChartFour();
            drewChart = new CommandDrewChartFour(this);
            List<Distributors> ezerList = new List<Distributors>(currentModle.getDistributors());
            myDistributors = new List<string>();
            for (int i = 0; i < ezerList.Count; i++)
            {
                myDistributors.Add(ezerList[i].distributors_id);
            }
            SeriesCollection = new SeriesCollection();
            System.Windows.Media.Color c = System.Windows.Media.Color.FromRgb(0, 0, 139);
            SeriesCollection.Add(new StepLineSeries
            {
                Title="",
                PointGeometrySize = 15,
                PointForeground = new SolidColorBrush(c),
                Values = new ChartValues<int> { 0 }
            });

        }
        public ICommand drewChart
        {
            get;
            private set;
        }

        public void clearList()
        {
            SeriesCollection.Clear();
            System.Windows.Media.Color c = System.Windows.Media.Color.FromRgb(0, 0, 139);

            SeriesCollection.Add(new StepLineSeries
            {
                Title = "",
                PointGeometrySize = 15,
                PointForeground = new SolidColorBrush(c),
                
                Values = new ChartValues<int> { 0 }
            });
        }
       
        public void drewChartfunc(string id, string divide, DateTime date)
        {
            clearList();
            if (divide == "יומי")
            {
                Labels1 = new[] { "ראשון", "שני", "שלישי", "רביעי", "חמישי", "שישי" };

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
                SeriesCollection[0].Values.Clear();
                for (int i = 0; i < 6; i++)
                {
                    try
                    {
                        List<WorkSchedule> workSchedules = currentModle.getWorkSchedules(id, mydate);
                        SeriesCollection[0].Values.Add(workSchedules.Count);
                        mydate = mydate.AddDays(1);
                    }
                    catch (Exception exp)
                    {
                        new WindowMessageBox(exp.Message, "שגיאה ", true).Show();
                    }
                }

            }

            if (divide == "שבועי")
            {
                Labels1 = new[] { "שבוע ראשון", "שבוע שני", "שבוע שלישי", "שבוע רביעי" };
                DateTime mydate = new DateTime(date.Year, date.Month, 1);
                int count = 0;
                SeriesCollection[0].Values.Clear();
                for (int i = 0; i < 4; i++)
                {
                    count = 0;
                    try
                    {
                        for (int j = 0; j < 7; j++)
                        {
                            List<WorkSchedule> workSchedules = currentModle.getWorkSchedules(id, mydate);
                            count += workSchedules.Count;
                            mydate = mydate.AddDays(1);
                        }
                        SeriesCollection[0].Values.Add(count);
                    }
                    catch (Exception exp)
                    {
                        new WindowMessageBox(exp.Message, "שגיאה ", true).Show();
                    }
                }
            }
            if (divide == "חודשי")
            {
                Labels1 = new[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12" };
                DateTime mydate = new DateTime(date.Year, 1, 1);
                int count = 0;
                SeriesCollection[0].Values.Clear();
                for (int i = 0; i < 12; i++)
                {
                    count = 0;
                    try
                    {
                        for (int j = 0; j < DateTime.DaysInMonth(mydate.Year, mydate.Month); j++)
                        {
                            List<WorkSchedule> workSchedules = currentModle.getWorkSchedules(id, mydate);
                            count += workSchedules.Count;
                            mydate = mydate.AddDays(1);
                        }
                        SeriesCollection[0].Values.Add(count);
                      
                    }
                    catch (Exception exp)
                    {
                        new WindowMessageBox(exp.Message, "שגיאה ", true).Show();
                    }
                }

            }
        }
    }
}
