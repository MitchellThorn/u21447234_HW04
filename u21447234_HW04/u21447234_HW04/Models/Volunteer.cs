using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace u21447234_HW04.Models
{
    public abstract class Volunteer
    {
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }

        public Volunteer()
        {

        }

        public Volunteer(string fullName, string email, string address)
        {
            FullName = fullName;
            Email = email;
            Address = address;
        }

        public abstract string getFullName();

        public abstract string getChoice();

        public virtual string getType() 
        {
            return "";
        }
    }
}