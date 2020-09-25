using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using BLL;

namespace PI
{
   public class ModelMyRecipients
    {
       BLLImp bll;

        public ModelMyRecipients()
        {
            bll = new BLLImp();
        }

        public List<Recipients> findListOfRecipients(string id, DateTime date)
        {
            List<WorkSchedule> workSchedule = bll.selectWorkSchedule(b => b.distributor_id == id && b.workSchedule_date == date);
            if (workSchedule.Count == 0)
            {
                throw new Exception("לא קיימת רשומת לוז עבודה לעובד זה בתאריך זה");
            }
            if (workSchedule.Count > 1)
            {
                throw new Exception("שגיאה - שגיאה בחיפוש רשומת לוז");
            }
            List<Recipients> ans = bll.selectRecipientsById(workSchedule[0].all_recipients_id);
            return ans;
        }
        public List<Distributors> getDistributors() 
        {
            return bll.selectDistributors();
        }
    }
}
