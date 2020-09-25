using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using BLL;

namespace PI
{
    

    public class ModelRecipientsA
    {
        BLLImp bll;

        public ModelRecipientsA() 
        {
            bll = new BLLImp();
        }
        public bool checkInfo(Recipients recipients)
        {
            List<Recipients> list = new List<Recipients>();
            list = bll.selectRecipients();
            list = bll.selectRecipients(r => r.recipients_id == recipients.recipients_id);
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
                bll.AddRecipients(recipients);
            }
            catch (Exception exp)
            {
                throw exp;
            }
            return true;
        }

    }
}
