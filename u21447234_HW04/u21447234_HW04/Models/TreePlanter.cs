using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace u21447234_HW04.Models
{
    public class TreePlanter : Volunteer
    {
        public string Ttype { get; set; }

        public TreePlanter()
        {

        }

        public TreePlanter(string fullName, string email, string address, string ttype) : base(fullName, email, address)
        {
            Ttype = ttype;
        }

        public override string getFullName()
        {
            return "" + FullName;
        }

        public override string getChoice()
        {
            return "" + Ttype;
        }

        public override string getType()
        {
            string type1 = "TreePlanter";
            return type1;
        }
    }
}