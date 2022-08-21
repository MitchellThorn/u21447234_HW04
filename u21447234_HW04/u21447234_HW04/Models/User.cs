using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace u21447234_HW04.Models
{
    public abstract class User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Adress { get; set; }
        
        public User()
        {

        }

        public User(string firstName, string lastName, string email, string adress)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Adress = adress;
        }

    /*    public abstract string getName();


        public virtual string getsomthing();
*/
    }
}