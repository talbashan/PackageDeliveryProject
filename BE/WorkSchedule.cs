using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BE
{
    public class WorkSchedule
    {
        [Key]
        [Column(Order = 1)]
        public string distributor_id { get; set; }

        [Key]
        [Column(Order = 2)]
        public DateTime workSchedule_date { get; set; }
        public string all_recipients_id { get; set; }

        public WorkSchedule()
        {
            this.distributor_id = "";
            this.workSchedule_date = DateTime.Today;
            this.all_recipients_id = "";
        }
        public WorkSchedule(string id, DateTime date)
        {
            this.distributor_id = id;
            this.workSchedule_date = date;
            this.all_recipients_id = "";
        }
        public WorkSchedule(string id, DateTime date, List<Recipients> recipients)
        {
            this.distributor_id = id;
            this.workSchedule_date = date;
            this.all_recipients_id = getString(recipients);
        }

        public string getString(List<Recipients> recipients)
        {
            string listString="";
            foreach(Recipients recipients1 in recipients)
            {
                listString = listString + recipients1.recipients_id.ToString() + ",";
            }
            return listString;
        }
    }
}
