namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class migration1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Admins",
                c => new
                {
                    admin_id = c.String(nullable: false, maxLength: 128),
                    admin_user_name = c.String(),
                    admin_password = c.String(),
                })
                .PrimaryKey(t => t.admin_id);

            CreateTable(
                "dbo.Distributors",
                c => new
                {
                    distributors_id = c.String(nullable: false, maxLength: 128),
                    distributors_work_days_sunday = c.Boolean(nullable: false),
                    distributors_work_days_monday = c.Boolean(nullable: false),
                    distributors_work_days_tuesday = c.Boolean(nullable: false),
                    distributors_work_days_wednesday = c.Boolean(nullable: false),
                    distributors_work_days_thursday = c.Boolean(nullable: false),
                    distributors_work_days_friday = c.Boolean(nullable: false),
                    distributors_phone_number = c.String(),
                    distributors_address_address_street = c.String(),
                    distributors_address_address_city = c.String(),
                    distributors_address_address_number = c.String(),
                    distributors_first_name = c.String(),
                    distributors_last_name = c.String(),
                    distributors_email_address = c.String(),
                    distributors_date_of_birth = c.DateTime(nullable: false),
                    distributors_gender = c.Int(nullable: false),
                })
                .PrimaryKey(t => t.distributors_id);

            CreateTable(
                "dbo.Recipients",
                c => new
                {
                    recipients_id = c.String(nullable: false, maxLength: 128),
                    recipients_phone_number = c.String(),
                    recipients_address_address_street = c.String(),
                    recipients_address_address_city = c.String(),
                    recipients_address_address_number = c.String(),
                    recipients_first_name = c.String(),
                    recipients_last_name = c.String(),
                    recipients_email_address = c.String(),
                    recipients_date_of_birth = c.DateTime(nullable: false),
                    recipients_gender = c.Int(nullable: false),
                    recipients_package_package_frequency = c.Int(nullable: false),
                    recipients_package_package_start_date = c.DateTime(nullable: false),
                    recipients_package_package_finish_date = c.DateTime(nullable: false),
                    recipients_package_food_eggs = c.Boolean(nullable: false),
                    recipients_package_food_bread = c.Boolean(nullable: false),
                    recipients_package_food_oil = c.Boolean(nullable: false),
                    recipients_package_food_milk = c.Boolean(nullable: false),
                    recipients_package_food_sugar = c.Boolean(nullable: false),
                    recipients_package_food_salt = c.Boolean(nullable: false),
                    recipients_package_food_butter = c.Boolean(nullable: false),
                    recipients_package_food_cream_cheese = c.Boolean(nullable: false),
                    recipients_package_food_water = c.Boolean(nullable: false),
                    recipients_package_food_ice_cream = c.Boolean(nullable: false),
                    recipients_package_food_chocolate = c.Boolean(nullable: false),
                    recipients_package_food_vegetables = c.Boolean(nullable: false),
                    recipients_package_food_fruit = c.Boolean(nullable: false),
                    recipients_package_medicine_acamol = c.Boolean(nullable: false),
                    recipients_package_medicine_optalgin = c.Boolean(nullable: false),
                    recipients_package_medicine_adex = c.Boolean(nullable: false),
                    recipients_package_medicine_nurofen = c.Boolean(nullable: false),
                    recipients_package_medicine_advil = c.Boolean(nullable: false),
                    recipients_package_medicine_ibuprofen = c.Boolean(nullable: false),
                    recipients_package_medicine_vitamin_C = c.Boolean(nullable: false),
                    recipients_package_medicine_vitamin_D = c.Boolean(nullable: false),
                    recipients_status = c.Int(nullable: false),
                })
                .PrimaryKey(t => t.recipients_id);

            CreateTable(
                "dbo.WorkSchedules",
                c => new
                {
                    distributor_id = c.String(nullable: false, maxLength: 128),
                    workSchedule_date = c.DateTime(nullable: false),
                    all_recipients_id = c.String(),
                })
                .PrimaryKey(t => new { t.distributor_id, t.workSchedule_date });

        }

        public override void Down()
        {
            DropTable("dbo.WorkSchedules");
            DropTable("dbo.Recipients");
            DropTable("dbo.Distributors");
            DropTable("dbo.Admins");
        }
    }
}
