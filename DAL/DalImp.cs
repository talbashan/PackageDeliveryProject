using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Text;
using BE;
using System.Linq;
using System.Web.UI;

namespace DAL
{
    public class DalImp
    {
        public const string connectionString = @"name=ProjectContext";

        public AddressCalculations addressCalculations;
        public DalImp()
        {
            addressCalculations = new AddressCalculations();
        }

        public void AddDistrubutor(Distributors distributor)
        {
            using (var ctx = new ProjectContext(connectionString))
            {
                try
                {
                    ctx.Distributors.Add(distributor);
                    ctx.SaveChanges();
                }
                catch (Exception)
                {
                    throw new Exception("הערך כבר קיים במאגר");
                }
            }
        }

        public void AddRecipients(Recipients recipients)
        {
            using (var ctx = new ProjectContext(connectionString))
            {
                try
                {
                    ctx.Recipients.Add(recipients);
                    ctx.SaveChanges();
                }
                catch (Exception)
                {
                    throw new Exception("הערך כבר קיים במאגר");
                }
            }
        }

        public void AddWorkSchedule(WorkSchedule workSchedule)
        {
            using (var ctx = new ProjectContext(connectionString))
            {
                try
                {
                    ctx.WorkSchedules.Add(workSchedule);
                    ctx.SaveChanges();
                }
                catch (Exception)
                {
                    throw new Exception("הערך כבר קיים במאגר");
                }
            }
        }

        public void AddAdmin(Admin admin)
        {
            using (var ctx = new ProjectContext(connectionString))
            {
                try
                {
                    ctx.Admins.Add(admin);
                    ctx.SaveChanges();
                }
                catch (Exception)
                {
                    throw new Exception("הערך כבר קיים במאגר");
                }
            }
        }

        public void UpdateDistributors(Distributors distributors) 
        {
            using (var ctx = new ProjectContext(connectionString))
            {
                var itemToUpdate = ctx.Distributors.Find(distributors.distributors_id); //returns a single item.

                if (itemToUpdate != null)
                {
                    ctx.Distributors.AddOrUpdate(distributors);
                    ctx.SaveChanges();
                }
                else
                    throw new Exception("  הערך לא קיים במאגר" );
            }
        }

        public void UpdateRecipients(Recipients recipients)
        {
            using (var ctx = new ProjectContext(connectionString))
            {
                var itemToUpdate = ctx.Recipients.Find(recipients.recipients_id); //returns a single item.

                if (itemToUpdate != null)
                {
                    ctx.Recipients.AddOrUpdate(recipients);
                    ctx.SaveChanges();
                }
                else
                    throw new Exception("  הערך לא קיים במאגר");

            }
        }

        public void UpdateWorkSchedule(WorkSchedule workSchedule)
        {
            using (var ctx = new ProjectContext(connectionString))
            {
                var itemToUpdate = ctx.WorkSchedules.Find(workSchedule.distributor_id , workSchedule.workSchedule_date); //returns a single item.

                if (itemToUpdate != null)
                {
                    ctx.WorkSchedules.AddOrUpdate(workSchedule);
                    ctx.SaveChanges();
                }
                else
                    throw new Exception("  הערך לא קיים במאגר");
            }
        }

        public void UpdateAdmin(Admin admin)
        {

            using (var ctx = new ProjectContext(connectionString))
            {
                var itemToUpdate = ctx.Admins.Find(admin.admin_id); //returns a single item.

                if (itemToUpdate != null)
                {
                    ctx.Admins.AddOrUpdate(admin);
                    ctx.SaveChanges();
                }
                else
                    throw new Exception("  הערך לא קיים במאגר");
            }
        }


        public void DeleteDistributors(Distributors distributors)
        {
            using (var ctx = new ProjectContext(connectionString))
            {
                var itemToRemove = ctx.Distributors.Find(distributors.distributors_id); //returns a single item.

                if (itemToRemove != null)
                {
                    ctx.Distributors.Remove(itemToRemove);
                    ctx.SaveChanges();
                }
                else
                    throw new Exception("הערך לא קיים");
            }
        }

        public void DeleteRecipients(Recipients recipients)
        {
            using (var ctx = new ProjectContext(connectionString))
            {
                var itemToRemove = ctx.Recipients.Find(recipients.recipients_id); //returns a single item.

                if (itemToRemove != null)
                {
                    ctx.Recipients.Remove(itemToRemove);
                    ctx.SaveChanges();
                }
                else
                    throw new Exception("הערך לא קיים");
            }
        }

        public void DeleteAdmin(Admin admin)
        {

            using (var ctx = new ProjectContext(connectionString))
            {
                var itemToRemove = ctx.Admins.Find(admin.admin_id); //returns a single item.

                if (itemToRemove != null)
                {
                    ctx.Admins.Remove(itemToRemove);
                    ctx.SaveChanges();
                }
                else
                    throw new Exception("הערך לא קיים");
            }
        }
        public List<Distributors> selectDistributors(Func<Distributors, bool> predicat)
        {
            using (var ctx = new ProjectContext(connectionString))
            {
                if (predicat == null)
                {
                    return ctx.Distributors.ToList<Distributors>();
                }
                else
                    return ctx.Distributors.Where(predicat).ToList<Distributors>();
            }
        }

        public List<Recipients> selectRecipients(Func<Recipients, bool> predicat)
        {
            using (var ctx = new ProjectContext(connectionString))
            {
                if (predicat == null)
                {
                    return ctx.Recipients.ToList<Recipients>();
                }
                else
                    return ctx.Recipients.Where(predicat).ToList<Recipients>();
            }
        }

        public List<Admin> selectAdmins(Func<Admin, bool> predicat)
        {
            using (var ctx = new ProjectContext(connectionString))
            {
                if (predicat == null)
                {
                    return ctx.Admins.ToList<Admin>();
                }
                else
                    return ctx.Admins.Where(predicat).ToList<Admin>();
            }
        }
        public List<WorkSchedule> selectWorkSchedule(Func<WorkSchedule, bool> predicat)
        {
            using (var ctx = new ProjectContext(connectionString))
            {
                if (predicat == null)
                {
                    return ctx.WorkSchedules.ToList<WorkSchedule>();
                }
                else
                    return ctx.WorkSchedules.Where(predicat).ToList<WorkSchedule>();
            }
        }


    }
}
