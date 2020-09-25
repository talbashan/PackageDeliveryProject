using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using BLL;

namespace PI
{
  public class ModleChartOne
    {
       BLLImp bll;
        public ModleChartOne()
        {
            bll = new BLLImp();
        }
        public List<Recipients> getRecipients()
        {
            return bll.selectRecipients();
        }
        public List<Recipients> recipientsPackageByDayAndCity(DateTime date, string city)
        {
            return bll.recipientsPackageByDayAndCity(date, city);
        }
        
    }
}
