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

namespace PI
{
    public class ViewModleChartOne: ObservableCollection<string>, INotifyPropertyChanged
    {
        public ModleChartOne currentModle { get; set; }
        public SeriesCollection SeriesCollection { get; set; }

        private string[] Labels;
        public string[] Labels1 
        { 
            get { return Labels; }
            set { 
                Labels = value;
                PropertyChanged(this, new PropertyChangedEventArgs(null));
            }
        }
        private ObservableCollection<string> recipientsList;

        public ObservableCollection<string> RecipientsList1
        {
            get
            {
                return recipientsList;
            }
            set
            {
                recipientsList = value;
            }
        }

        public Func<double, string> Formatter { get; set; }
         
        public ViewModleChartOne()
        {
            currentModle = new ModleChartOne();
            drewChart = new CommandDrewChartOne(this);
            SeriesCollection = new SeriesCollection();
            SeriesCollection.Add(new ColumnSeries
            {
                Title = "תכנון",
                Values = new ChartValues<int>()
            });
            SeriesCollection.Add(new ColumnSeries
            {
                Title = "ביצוע",
                Values = new ChartValues<int>()
            });
            Formatter = value => value.ToString("N");
            RecipientsList1 = new ObservableCollection<string>();
            List<string> RecipientsList2 = new List<string>();
            List<Recipients> ezerlist = currentModle.getRecipients();
            foreach (Recipients item in ezerlist)
            {
                RecipientsList2.Add(item.recipients_address.address_city);
            }
            foreach (var item in RecipientsList2.Distinct())
            {
                RecipientsList1.Add(item);
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void clearList()
        {
            SeriesCollection.Clear();
            SeriesCollection.Add(new ColumnSeries
            {
                Title = "תכנון",
                Values = new ChartValues<int>()
            });
            SeriesCollection.Add(new ColumnSeries
            {
                Title = "ביצוע",
                Values = new ChartValues<int>()
            });
        }
        public ICommand drewChart
        {
            get;
            private set;
        }
        public void drewChartfunc(string city, string divide, DateTime date)
        {
            clearList();
            if(divide == "יומי")
            {
                Labels1 = new[] { "ראשון","שני","שלישי","רביעי","חמישי","שישי" };
                DateTime mydate = date;
                DayOfWeek day = date.DayOfWeek;
                switch (day)
                {
                    case DayOfWeek.Sunday:
                        break;
                    case DayOfWeek.Monday:mydate = date.AddDays(-1);
                        break;
                    case DayOfWeek.Tuesday:mydate = date.AddDays(-2);
                        break;
                    case DayOfWeek.Wednesday:mydate = date.AddDays(-3);
                        break;
                    case DayOfWeek.Thursday:mydate = date.AddDays(-4);
                        break;
                    case DayOfWeek.Friday:mydate = date.AddDays(-5);
                        break;
                    default:
                        break;
                }
                for (int i = 0; i < 6; i++)
                {
                    try
                    {
                        List<Recipients> recipients = currentModle.recipientsPackageByDayAndCity(mydate,city);
                        SeriesCollection[0].Values.Add(recipients.Count);
                        if ((DateTime.Compare(mydate,date) <= 0  && DateTime.Compare(mydate, DateTime.Today) <= 0) || DateTime.Compare(date, DateTime.Today)<0)
                        {
                            SeriesCollection[1].Values.Add(recipients.Count);
                        }
                        mydate = mydate.AddDays(1);
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
                Labels1 = new[] { "שבוע ראשון","שבוע שני","שבוע שלישי","שבוע רביעי" };
                DateTime mydate = new DateTime(date.Year, date.Month, 1);
                int count = 0;
                for (int i = 0; i < 4; i++)
                {
                    count = 0;
                    try
                    {
                        for (int j = 0; j < 7; j++)
                        {
                            List<Recipients> recipients = currentModle.recipientsPackageByDayAndCity(mydate, city);
                            count += recipients.Count;
                            mydate = mydate.AddDays(1);
                        }
                        SeriesCollection[0].Values.Add(count);
                        if (DateTime.Compare(mydate,DateTime.Today)<=0)
                        {
                            SeriesCollection[1].Values.Add(count);
                        }
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
                Labels1 = new[] { "1","2","3","4","5","6","7","8","9","10","11","12" };
                DateTime mydate = new DateTime(date.Year, 1, 1);
                int count = 0;
                for (int i = 0; i < 12; i++)
                {
                    count = 0;
                    try
                    {
                        for (int j = 0; j < DateTime.DaysInMonth(mydate.Year, mydate.Month); j++)
                        {
                            List<Recipients> recipients = currentModle.recipientsPackageByDayAndCity(mydate, city);
                            count += recipients.Count;
                            mydate = mydate.AddDays(1);
                        }
                        SeriesCollection[0].Values.Add(count);
                        if (DateTime.Compare(mydate, DateTime.Today) <= 0)
                        {
                            SeriesCollection[1].Values.Add(count);
                        }
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
