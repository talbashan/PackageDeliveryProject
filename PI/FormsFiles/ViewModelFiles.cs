using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;

namespace PI
{
   public class ViewModelFiles : INotifyPropertyChanged
    {
        public ViewModelFiles(ViewModelMainWindow mvm)
        {
            openPackByDay = new ComOpenPackByDay(this,mvm);
            openMap = new ComOpenMap(this, mvm);
            openWorkSchdule =new ComOpenWorkSchdule(this, mvm);
            myRecipients = new CommyRecipients(this, mvm);
        }

        public ICommand openPackByDay
        {
            get;
            private set;
        }

        public ICommand openMap
        {
            get;
            private set;
        }
        public ICommand openWorkSchdule
        {
            get;
            private set;
        }
        public ICommand myRecipients
        {
            get;
            private set;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private UserControl _UserControl;
        public UserControl UserControl
        {
            get { return _UserControl; }
            set
            {
                _UserControl = value;
                PropertyChanged(this, new PropertyChangedEventArgs(null));
            }
        }
    }
}
