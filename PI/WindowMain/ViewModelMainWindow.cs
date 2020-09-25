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
    public class ViewModelMainWindow : INotifyPropertyChanged
    {
        //private ModelMainWindow currentModle;

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

        public ViewModelMainWindow()
        {
            openAddDistributor = new ComAddDistributor(this);
            openAddRecipient = new ComAddRecipients(this);
            openAdminWin = new ComAddAdminWin(this);
            openUpdateDistributor = new ComUpdateDistributor(this);
            openUpdateRecipients = new ComUpdateRecipients(this);
            openFiles = new ComOpenFiles(this);
            openChart = new ComOpenChart(this);
        }

        public ICommand openAddDistributor
        {
            get;
            private set;
        }

        public ICommand openAddRecipient
        {
            get;
            private set;
        }

        public ICommand openAdminWin
        {
            get;
            private set;
        }

        public ICommand openUpdateDistributor
        {
            get;
            private set;
        }
        public ICommand openUpdateRecipients
        {
            get;
            private set;
        }
        public ICommand openFiles
        {
            get;
            private set;
        }
        public ICommand openChart
        {
            get;
            private set;
        }

    }
}
