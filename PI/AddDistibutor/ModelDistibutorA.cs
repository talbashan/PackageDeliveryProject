using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using BLL;

namespace PI
{
    

    public class ModelDistibutorA
    {
        BLLImp bll;

        public ModelDistibutorA() 
        {
            bll = new BLLImp();
        }
        public bool checkInfo(Distributors distributor)
        {
            List<Distributors> list = new List<Distributors>();
            list = bll.selectDistributors(d => d.distributors_id == distributor.distributors_id);
            string error = "";
            if (list.Count == 1)
            {
                error += "תעודת זהות קיימת במערכת";
                error += "\n";
            }
            if (error != "")
            {
                throw new Exception(error);
            }
            try
            {
                bll.AddDistrubutor(distributor);
            }
            catch (Exception exp)
            {
                throw exp;
            }
            return true;
        }

    }
}
