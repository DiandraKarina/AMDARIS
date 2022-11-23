using Domain.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class User
    {
        public User(string firstname, string lastname, int id, Gender gen, DateTime? dob = null)
        {

            this.FirstName = firstname;
            this.LastName = lastname;
            this.Id = Id;
            this.Gender = gen;
            this.DOB = (DateTime)dob;

        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Id { get; set; }
        public Gender Gender { get; set; }// can't change gender
        public DateTime DOB { get; private set; } // can't change date of birth

        
    }
}
