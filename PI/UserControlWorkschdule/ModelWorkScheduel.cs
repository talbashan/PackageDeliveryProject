using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using BLL;

namespace PI
{
   public class ModelWorkScheduel
    {
        BLLImp bll;

        public ModelWorkScheduel()
        {
            bll = new BLLImp();
        }

        public void saveWorkSchedual(List<Distributors> myList)
        {
            WorkSchedule work;
            List<WorkSchedule> temp = bll.selectWorkSchedule(w => w.workSchedule_date == DateTime.Today);
            if(temp.Count == 3)
            {
                string error = "שגיאה - כבר קיים סידור עבודה ליום זה";
                throw new Exception(error);
            }
            foreach (Distributors item in myList)
            {
                work = new WorkSchedule(item.distributors_id, DateTime.Today);
                try
                {
                    bll.AddWorkSchedule(work);
                }
                catch (Exception exp)
                {

                    throw exp;
                }
            }
        }
        public void k_Mean()
        {
            DateTime date = DateTime.Today;
            try
            {
                bll.dayWorkSchedule(date);
            }
            catch (Exception exp)
            {

                throw exp;
            }
        }
        public List<Distributors> getDistributors(Func<Distributors, bool> predicat = null)
        {
            return bll.selectDistributors(predicat);
        }

    }
}
