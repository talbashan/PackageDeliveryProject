using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using BLL;

namespace PI
{
    public class ModelRecipientsU
    {
        BLLImp bll;

        public ModelRecipientsU()
        {
            bll = new BLLImp();
        }
        public Recipients searchRecipients(string id)
        {
            List<Recipients> list = new List<Recipients>();
            list = bll.selectRecipients(r => r.recipients_id == id);
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
        public bool updateRecipients(Recipients recipients)
        {
            List<Recipients> list = new List<Recipients>();
            list = bll.selectRecipients();
            list = bll.selectRecipients(r => r.recipients_id == recipients.recipients_id);
            string error = "";
            if (list.Count != 1)
            {
                error += "תעודת זהות לא קיימת במערכת";
                error += "\n";
            }

            if (error != "")
            {
                throw new Exception(error);
            }
            try
            {
                bll.UpdateRecipients(recipients);
            }
            catch (Exception exp)
            {
                throw exp;
            }
            return true;
        }

    }
}
