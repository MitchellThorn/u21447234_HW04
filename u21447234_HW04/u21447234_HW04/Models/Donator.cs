using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace u21447234_HW04.Models
{
    public class Donator:User
    {
        public string DisplayName { get; set; }

        public Donator()
        {

        }

        public Donator(string displayName):base()
        {
            DisplayName = displayName;
        }

/*        public override string getName()
        {
            string area = 0;
            return area;
        }*/
    }
}