using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace HeavenlyVisions
{
    internal class Customer
    {
        private int id;
        private string name;
        private string phone;
        private string email;
        private string notes;

        public string Name { get => name; set => name = value; }
        public string Phone { get => phone; set => phone = value; }
        public string Email { get => email; set => email = value; }
        public string Notes { get => notes; set => notes = value; }
        public int Id { get => id; set => id = value; }

        public Customer(string name, string phone, string email) 
        {
            this.name = name;
            this.phone = phone;
            this.email = email;
        }
        public Customer(string name, string phone, string email, string notes)
        {
            this.name = name;
            this.phone = phone;
            this.email = email;
            this.notes = notes;
        }

        public void SetName(String name)
        {
            this.name = name;
        }
        public void SetPhone(String phone)
        {
            this.phone = phone;
        }
        public void SetEmail(String email)
        {
            this.email = email;
        }
        public void SetNotes(String notes)
        {
            this.notes = notes;
        }
        public void setId(int id)
        {
            this.id = id;
        }
        public string Display()
        {
            if (notes != null)
            {
                return $"{name} {phone} {email} {notes}";
            }
            else
            {
                return $"{name} {phone} {email}";
            }
        }
        public string getName()
        {
            return name;
        }
        public string getPhone()
        {
            return phone;
        }
        public string getEmail()
        {
            return email;
        }
        public string getNotes()
        {
            return notes;
        }
    }
}
