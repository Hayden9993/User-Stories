using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace HeavenlyVisions
{
    
    internal class Tour
    {
        public List<Tour> tours1 = new List<Tour>();
        private string name;
        private string time;
        private string date;
        private string location;
        private Customer[] customers;
        private string description = " ";

        public Tour(string name, string date, string time, string location)
        {
            this.name = name;
            this.date = date;
            this.location = location;
            this.time = time;
        }

        public Tour(string name, string date, string time, string location, string description)
        {
            this.name = name;
            this.date = date;
            this.location = location;
            this.time = time;
            this.description = description;
        }

        public string Name { get => name; set => name = value; }
        public string Time { get => time; set => time = value; }
        public string Date { get => date; set => date = value; }
        public string Location { get => location; set => location = value; }

        public static void addCustomer(Customer customer)
        {
            customers.Append(customer);
        }
        public static void removeCustomer()
        {
            
            
            //figure out how to remove from an array
        }
        public static void setDescription(string description)
        {
            this.description = description;
        }
        public static void setDate(string date)
        {
            this.date = date;
        }
        public static void setTime(string time)
        {
            this.time = time;
        }
        public static void setLocation(string location)
        {
            this.location = location;
        }
        public static void setName(string name)
        {
            this.name = name;
        }

        public string getName()
        {
            return name;
        }
        public string getLocation()
        {
            return location;
        }
        public string getDate() { return date; }
        public string getTime() { return time; }
        public string getDescription() { return description; }
        public string getCustomers() {return customers}


    }
}

