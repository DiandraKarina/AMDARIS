using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3_2
{
    internal class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public readonly Gender gender; // can't change gender

        public enum Gender
        {
            Female,
            Male
        };

        private readonly DateTime DOB; // can't change date of birth

        public Person(Gender gen, string firstname, string lastname, DateTime? dob=null)
        {
            this.gender = gen;
            this.FirstName = firstname;
            this.LastName = lastname;
            this.DOB = (DateTime)dob;
            
        }

        public string DateofBirth
        {
            get
            {
                return this.DOB.ToShortDateString();
            } 
        }

        public void ViewBlog()
        {
            Console.WriteLine("{0} {1} just viewed the post",FirstName,LastName);
        }

    }
}
