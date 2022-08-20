using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace u21447234_HW04.Models
{
    public abstract class User
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Adress { get; set; }

        public User()
        {

        }

        public User(string name, string email, string adress)
        {
            Name = name;
            Email = email;
            Adress = adress;
        }

    /*    public abstract string getName();


        public virtual string getsomthing();
*/
    }
}