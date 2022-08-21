using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace u21447234_HW04.Models
{
    public class OceanCleaner : Volunteer
    {
        public string Area { get; set; }

        public OceanCleaner()
        {

        }

        public OceanCleaner(string fullName, string email, string address, string area) : base(fullName, email, address)
        {
            Area = area;
        }

        public override string getFullName()
        {
            return "" + FullName;
        }

        public override string getChoice()
        {
            return "" + Area;
        }

        public override string getType()
        {
            string type1 = "OceanCleaner";
            return type1;
        }
    }
}