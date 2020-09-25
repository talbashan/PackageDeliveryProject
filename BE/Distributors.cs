using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BE
{
    public class Distributors 
    {
        
        
        [Key]

        public string distributors_id { get; set; }
        public WeekDays distributors_work_days { get; set; }
        public string distributors_phone_number { get; set; }
        public Address distributors_address { get; set; }
        public string distributors_first_name { get; set; }
        public string distributors_last_name { get; set; }
        public string distributors_email_address { get; set; }
        public DateTime distributors_date_of_birth { get; set; }
        public gender distributors_gender { get; set; }




        public Distributors(Distributors distributors) //copy c-tor
        {
            distributors_id = distributors.distributors_id;
            distributors_work_days = distributors.distributors_work_days;
            distributors_phone_number = distributors.distributors_phone_number;
            distributors_address = distributors.distributors_address;
            distributors_first_name = distributors.distributors_first_name;
            distributors_last_name = distributors.distributors_last_name;
            distributors_email_address = distributors.distributors_email_address;
            distributors_date_of_birth = distributors.distributors_date_of_birth;
            distributors_gender = distributors.distributors_gender;
        }

        public Distributors(string id, WeekDays distributors_work_days, string distributors_phone_number, Address distributors_address, string distributors_first_name,
            string distributors_last_name, string distributors_email_address, DateTime distributors_date_of_birth, gender distributors_gender)
        {
            this.distributors_id = distributors_id;
            this.distributors_work_days = distributors_work_days;
            this.distributors_phone_number = distributors_phone_number;
            this.distributors_address = distributors_address;
            this.distributors_first_name = distributors_first_name;
            this.distributors_last_name = distributors_last_name;
            this.distributors_email_address = distributors_email_address;
            this.distributors_date_of_birth = distributors_date_of_birth;
            this.distributors_gender = distributors_gender;
        }

        public Distributors()
        {
            distributors_address = new Address();
            distributors_date_of_birth = new DateTime();
            distributors_work_days = new WeekDays();
         
        }
    }
}
