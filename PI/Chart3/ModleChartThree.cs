using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using BLL;

namespace PI
{
  public class ModleChartThree
    {
       BLLImp bll;
        public ModleChartThree()
        {
            bll = new BLLImp();
        }
        public List<Recipients> getRecipients()
        {
            return bll.selectRecipients();
        }
        public List<Recipients> getRecipientsbyStatus(status status)
        {
            return bll.selectRecipients(r=> r.recipients_status==status);
        }
    }
}
