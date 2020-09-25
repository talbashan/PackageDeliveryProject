using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using BLL;

namespace PI
{
    public class ModelDistibutorU
    {
        BLLImp bll;

        public ModelDistibutorU()
        {
            bll = new BLLImp();
        }
        public Distributors searchDistributor(string id)
        {
            List<Distributors> list = new List<Distributors>();
            list = bll.selectDistributors(d => d.distributors_id == id);
            string error = "";
            if (list.Count == 0)
            {
                error += "תעודת זהות לא קיימת במערכת";
                error += "\n";
            }
            if (error != "")
            {
                throw new Exception(error);
            }
            return list[0];
        }
        public bool updateDistributor(Distributors distributor)
        {
            List<Distributors> list = new List<Distributors>();
            list = bll.selectDistributors(d => d.distributors_id == distributor.distributors_id);
            string error = "";
            if (list.Count != 1)
            {
                error += "תעודת הזהות לא קיימת במערכת";
                error += "\n";
            }
            if (error != "")
            {
                throw new Exception(error);
            }
            try
            {
                bll.UpdateDistributors(distributor);
            }
            catch (Exception exp)
            {
                throw exp;
            }
            return true;
        }
    }    
}
