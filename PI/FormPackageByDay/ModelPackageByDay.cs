using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL;
using BE;

namespace PI
{
    public class ModelPackageByDay
    {
        BLLImp bll;

        public ModelPackageByDay()
        {
            bll = new BLLImp();
        }
        public List<Recipients> searchRecipients(DateTime date)
        {
            List<Recipients> list = new List<Recipients>();
            list = bll.recipientsPackageByDay(date);
            return list;
        }
    }
}
