using System;
using System.Collections.Generic;
using System.Text;

namespace BE
{
    public class Address
    {
        public string address_street { get; set; }
        public string address_city { get; set; }
        public string address_number { get; set; }

        public Address() 
        {
            address_city = "";
            address_number = "";
            address_street = "";
        }
        public Address(string city, string street, string number)
        {
            address_city = city;
            address_street = street;
            address_number = number;
        }
        public Address(Address address)
        {
            address_city = address.address_city;
            address_street = address.address_street;
            address_number = address.address_number;
        }

        public Address(string address)
        {
            char sepurator = ' ';
            var values = (Object[])address.Split(sepurator);
            address_city = values[0].ToString();
            address_street = values[1].ToString();
            address_number = values[2].ToString();
        }

        public override string ToString()
        {
            string str = "";
            str += address_city + " " + address_street + " " + address_number;
            return str;
        }
        public string varification()
        {
            string str = "";
            str += address_street +" "+address_city+" "+address_number;
            return str;
        }
    }
    public class Place
    {
        public string place_id { get; set; }
        public string licence { get; set; }
        public string osm_type { get; set; }
        public string osm_id { get; set; }
        public List<string> boundingbox { get; set; }
        public string lat { get; set; }
        public string lon { get; set; }
        public string display_name { get; set; }
        public string place_class { get; set; }
        public string place_type { get; set; }
        public double importance { get; set; }
    }
}
