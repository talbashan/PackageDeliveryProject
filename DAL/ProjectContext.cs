using System;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using BE;

namespace DAL
{
    public class ProjectContext : DbContext
    {
        public ProjectContext():base()
        { }
        public ProjectContext(string c):base(c)
        { }


        //public DbSet<Address> addresses { get; set; }


        

        public DbSet<Admin> Admins { get; set; }
        public DbSet<Distributors> Distributors { get; set;}
        public DbSet<WorkSchedule> WorkSchedules { get; set; }
        public DbSet<Recipients> Recipients { get; set; }
    }
}
