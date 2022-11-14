using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3_2
{
    internal class Admin : Person
    {
        public Admin(Enums.Gender gen, string firstname, string lastname, DateTime? dob = null) : base(gen, firstname, lastname, dob)
        {
        }

        public void DeletePost(int id)
        {
            Console.WriteLine("Admin deleted post of user {0}", id);
        }
  
    }
}
