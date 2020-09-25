using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace PI
{
    public class ViewModleMessageBox
    {
        public WindowMessageBox view { get; set; }
        public ViewModleMessageBox(WindowMessageBox v)
        {
            view = v;
            close = new CommandClose(this);
        }
        public ICommand close
        {
            get;
            private set;
        }
    }
}
