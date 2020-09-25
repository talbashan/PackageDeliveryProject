using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using BLL;

namespace PI
{
    class ModelAdmin
    {
        BLLImp bll;
        public ModelAdmin()
        {
             bll = new BLLImp();
        }

        public bool checkInfo(Admin admin)
        {
            List<Admin> list = new List<Admin>();
            list = bll.selectAdmins(a => a.admin_id == admin.admin_id);
            string error = "";
            if(list.Count == 0)
            {
                error+="תעודת זהות שגויה";
                error += "\n";
            }
            else
            {
                if (list[0].admin_user_name != admin.admin_user_name)
                {
                    error += "שם משתמש שגוי";
                    error += "\n";
                }
                if (list[0].admin_password != admin.admin_password)
                {
                    error += "סיסמה שגויה";
                    error += "\n";
                }
            }
            if(error != "")
            {
                throw new Exception(error);
            }
            return true;
        }
    }
}
