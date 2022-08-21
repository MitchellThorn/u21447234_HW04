using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace u21447234_HW04.Models
{
    public class Missionary : Volunteer
    {
        public string Option { get; set; }

        public Missionary()
        {

        }

        public Missionary(string fullName, string email, string address, string option) : base(fullName, email, address)
        {
            Option = option;
        }

        public override string getFullName()
        {
            return "" + FullName;
        }

        public override string getChoice()
        {
            return "" + Option;
        }

        public override string getType()
        {
            string type1 = "Missionary";
            return type1;
        }
    }
}