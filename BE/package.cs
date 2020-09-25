using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Text;

namespace BE
{
    public class Package
    {
        public frequency package_frequency { get; set; }
        public DateTime package_start_date { get; set; }
        public DateTime package_finish_date { get; set; }

        public bool food_eggs { get; set; }
        public bool food_bread { get; set; }
        public bool food_oil { get; set; }
        public bool food_milk { get; set; }
        public bool food_sugar { get; set; }
        public bool food_salt { get; set; }
        public bool food_butter { get; set; }
        public bool food_cream_cheese {get; set;}
        public bool food_water { get; set; }
        public bool food_ice_cream { get; set; }
        public bool food_chocolate { get; set; }
        public bool food_vegetables { get; set; }
        public bool food_fruit { get; set; }

        public bool medicine_acamol { get; set; }
        public bool medicine_optalgin{ get; set; }
        public bool medicine_adex { get; set; }
        public bool medicine_nurofen{ get; set; }
        public bool medicine_advil { get; set; }
        public bool medicine_ibuprofen  { get; set; }
        public bool medicine_vitamin_C { get; set; }
        public bool medicine_vitamin_D { get; set; }

        public Package(Package package)
        {
            package_frequency = package.package_frequency;
            package_start_date = package.package_start_date;
            package_finish_date = package.package_finish_date;
            food_eggs = package.food_eggs;
            food_bread = package.food_bread;
            food_oil = package.food_oil;
            food_milk = package.food_milk;
            food_sugar = package.food_sugar;
            food_salt = package.food_salt;
            food_butter = package.food_butter;
            food_cream_cheese = package.food_cream_cheese;
            food_water = package.food_water;
            food_ice_cream = package.food_ice_cream;
            food_chocolate = package.food_chocolate;
            food_vegetables = package.food_vegetables;
            food_fruit = package.food_fruit;

            medicine_acamol = package.medicine_acamol;
            medicine_optalgin = package.medicine_optalgin;
            medicine_adex = package.medicine_adex;
            medicine_nurofen = package.medicine_nurofen;
            medicine_advil = package.medicine_advil;
            medicine_ibuprofen = package.medicine_ibuprofen;
            medicine_vitamin_C = package.medicine_vitamin_C;
            medicine_vitamin_D = package.medicine_vitamin_D;
        }

        public Package()
        {
            package_frequency = frequency.יומי;
            package_start_date = DateTime.Today;
            package_finish_date = DateTime.Today.AddYears(1);
            food_eggs = false;
            food_bread = false;
            food_oil = false;
            food_milk = false;
            food_sugar = false;
            food_salt = false;
            food_butter = false;
            food_cream_cheese = false;
            food_water = false;
            food_ice_cream = false;
            food_chocolate = false;
            food_vegetables = false;
            food_fruit = false;

            medicine_acamol = false;
            medicine_optalgin = false;
            medicine_adex = false;
            medicine_nurofen = false;
            medicine_advil = false;
            medicine_ibuprofen = false;
            medicine_vitamin_C = false;
            medicine_vitamin_D = false;
        }

        public Package(frequency package_frequency, DateTime package_start_date, DateTime package_finish_date, bool food_eggs, bool food_bread, bool food_oil, bool food_milk,
            bool food_sugar, bool food_salt, bool food_butter, bool food_cream_cheese, bool food_water, bool food_ice_cream, bool food_chocolate,
            bool food_vegetables, bool food_fruit, bool medicine_acamol, bool medicine_optalgin, bool medicine_adex, bool medicine_nurofen, 
            bool medicine_advil, bool medicine_ibuprofen, bool medicine_vitamin_C, bool medicine_vitamin_D)
        {
            this.package_frequency = package_frequency;
            this.package_start_date = package_start_date;
            this.package_finish_date = package_finish_date;
            this.food_eggs = food_eggs;
            this.food_bread = food_bread;
            this.food_oil = food_oil;
            this.food_milk = food_milk;
            this.food_sugar = food_sugar;
            this.food_salt = food_salt;
            this.food_butter = food_butter;
            this.food_cream_cheese = food_cream_cheese;
            this.food_water = food_water;
            this.food_ice_cream = food_ice_cream;
            this.food_chocolate = food_chocolate;
            this.food_vegetables = food_vegetables;
            this.food_fruit = food_fruit;
            this.medicine_acamol = medicine_acamol;
            this.medicine_optalgin = medicine_optalgin;
            this.medicine_adex = medicine_adex;
            this.medicine_nurofen = medicine_nurofen;
            this.medicine_advil = medicine_advil;
            this.medicine_ibuprofen = medicine_ibuprofen;
            this.medicine_vitamin_C = medicine_vitamin_C;
            this.medicine_vitamin_D = medicine_vitamin_D;
        }

        public int numOfProducts()
        {
            int count = 0;
            if (food_eggs) count++;
            if (food_bread) count++;
            if (food_oil) count++;
            if (food_milk) count++;
            if (food_sugar) count++;
            if (food_salt) count++;
            if (food_butter) count++;
            if (food_cream_cheese) count++;
            if (food_water) count++;
            if (food_ice_cream) count++;
            if (food_chocolate) count++;
            if (food_vegetables) count++;
            if (food_fruit) count++;
            if (medicine_acamol) count++;
            if (medicine_optalgin) count++;
            if (medicine_adex) count++;
            if (medicine_nurofen) count++;
            if (medicine_advil) count++;
            if (medicine_ibuprofen) count++;
            if (medicine_vitamin_C) count++;
            if (medicine_vitamin_D) count++;
            return count;

        }
        //public override string ToString()
        //{
        //    string str = "";
        //    return str;
        //}
    }

}
