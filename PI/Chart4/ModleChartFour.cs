using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using BLL;

namespace PI
{
  public class ModleChartFour
    {
       BLLImp bll;
        public ModleChartFour()
        {
            bll = new BLLImp();
        }
        public List<Distributors> getDistributors()
        {
            return bll.selectDistributors();
        } 
        public List<WorkSchedule> getWorkSchedules(string id, DateTime date)
        {
            return bll.selectWorkSchedule(w => w.distributor_id == id && w.workSchedule_date==date);
        }
    }
}
