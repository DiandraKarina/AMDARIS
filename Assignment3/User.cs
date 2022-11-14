using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3_2
{
    internal class User : Person, ICloneable
    {
        public User(Enums.Gender gen, string firstname, string lastname, DateTime? dob = null) : base(gen, firstname, lastname, dob)
        {
        }

        public int Id { get; set; }
        
        public void DeletePost()
        {
            Console.WriteLine("User {0} deleted his post",FirstName);
        }

        public void ViewBlog()
        {
            Console.WriteLine("The user {0} {1} just viewed the post", FirstName, LastName);
        }

        public object Clone()
        {
            return this;
        }

    }
}
