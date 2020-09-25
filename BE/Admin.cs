using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BE
{
    public class Admin
    {
        [Key]
        public string admin_id { get; set; }
        public string admin_user_name { get; set; }
        public string admin_password { get; set; }


        public Admin()
        {
           
        }

        public Admin(string admin_id, string admin_user_name, string admin_password)
        {
            this.admin_id = admin_id;
            this.admin_user_name = admin_user_name;
            this.admin_password = admin_password;
        }

        public Admin(Admin admin )
        {
            this.admin_id = admin.admin_id;
            this.admin_user_name = admin.admin_user_name;
            this.admin_password = admin.admin_password;
        }
    }
}
