using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace PI
{
   public class ViewModelCharts
    {
        public ViewModelCharts(ViewModelMainWindow mvm)
        {
            openBarChart = new ComBarChart(this, mvm);
            openPieChart = new ComPieChart(this, mvm);
            openDountChart = new ComDountChart(this, mvm);
            openSticksChart = new ComSticksChart(this, mvm);
        }
        public ICommand openBarChart
        {
            get;
            private set;
        }
        public ICommand openSticksChart
        {
            get;
            private set;
        }
        public ICommand openDountChart
        {
            get;
            private set;
        }
        public ICommand openPieChart
        {
            get;
            private set;
        }
    }
}
