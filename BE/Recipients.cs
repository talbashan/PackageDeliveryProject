using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BE
{
    public class Recipients
    {

        [Key]
        public string recipients_id { get; set; }
        public string recipients_phone_number { get; set; }
        public Address recipients_address { get; set; }
        public string recipients_first_name { get; set; }
        public string recipients_last_name { get; set; }
        public string recipients_email_address { get; set; }
        public DateTime recipients_date_of_birth { get; set; }
        public gender recipients_gender { get; set; }
        public Package recipients_package { get; set; }
        public status recipients_status { get; set; }



        public Recipients()
        {
            recipients_package = new Package();
            recipients_address = new Address();
            recipients_date_of_birth = new DateTime();
            recipients_status = status.קשיש;
        }

        public Recipients(Recipients recipients)
        {
            recipients_id = recipients.recipients_id;
            recipients_phone_number = recipients.recipients_phone_number;
            recipients_address = recipients.recipients_address;
            recipients_first_name = recipients.recipients_first_name;
            recipients_last_name = recipients.recipients_last_name;
            recipients_email_address = recipients.recipients_email_address;
            recipients_date_of_birth = recipients.recipients_date_of_birth;
            recipients_gender = recipients.recipients_gender;
            recipients_package = recipients.recipients_package;
            recipients_status = recipients.recipients_status;
        }

        public Recipients(string recipients_id, string recipients_phone_number, Address recipients_address, string recipients_first_name,
            string recipients_last_name, string recipients_email_address, 
            DateTime recipients_date_of_birth, gender recipients_gender, Package recipients_package, status recipients_status)
        {
            this.recipients_id = recipients_id;
            this.recipients_phone_number = recipients_phone_number;
            this.recipients_address = recipients_address;
            this.recipients_first_name = recipients_first_name;
            this.recipients_last_name = recipients_last_name;
            this.recipients_email_address = recipients_email_address;
            this.recipients_date_of_birth = recipients_date_of_birth;
            this.recipients_gender = recipients_gender;
            this.recipients_package = recipients_package;
            this.recipients_status = recipients_status;
        }

    }
}
