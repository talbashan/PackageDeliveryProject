using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL;
using BE;

namespace PI
{
    public class ModelMap
    {

        BLLImp bll;

        public ModelMap()
        {
            bll = new BLLImp();
        }

        public double[][,] GetalllatlonRec(DateTime date)
        {
            List<WorkSchedule> workSchedules = bll.selectWorkSchedule(w => w.workSchedule_date == date);
            int count = workSchedules.Count();
            if (count == 0)
            {
                throw new Exception("לא קיים חילוק עבודה ביום זה");
            }
            if (count != 3)
            {
                throw new Exception("שגיאה במספר המחלקים");
            }

            double[][,] latlon = new double[count][,];
            int i = 0;
            int j = 0;
            foreach (WorkSchedule workSchedule in workSchedules)
            {

                try
                {
                    Distributors dists = bll.selectDistributors(d => d.distributors_id == workSchedule.distributor_id)[0];
                    Address a1 = dists.distributors_address;
                    double[] latlon1 = bll.getLatLongFromAddress(a1);
                    List<Recipients> recipients = bll.selectRecipientsById(workSchedule.all_recipients_id);
                    latlon[i] = new double[recipients.Count + 1, 2];
                    latlon[i][j, 0] = latlon1[0];
                    latlon[i][j, 1] = latlon1[1];
                    j++;
                    foreach (Recipients recipients1 in recipients)
                    {
                        Address a2 = recipients1.recipients_address;
                        double[] latlon2 = bll.getLatLongFromAddress(a2);
                        latlon[i][j, 0] = latlon2[0];
                        latlon[i][j, 1] = latlon2[1];
                        j++;
                    }
                    j = 0;
                    i++;


                }
                catch (Exception e)
                {
                    throw e;
                }

            }
            return latlon;

        }
    }
}
