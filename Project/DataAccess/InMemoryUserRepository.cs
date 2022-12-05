using Domain.Models;
using Domain.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DataAccess
{
    public class InMemoryUserRepository
    {
        private readonly List<User> _users = new();

        public InMemoryUserRepository()
        {
            _users = new List<User>
            {
                new("Diandra","Gherman",1,Gender.Female,"ghermandiandra@yahoo.com",new DateTime(2000,01,07)),
                new("Loredana","Gherman",2,Gender.Female,"loredanagherman@yahoo.com",new DateTime(1976,06,20)),
                new("Maria","Popescu",3,Gender.Female,"mariapopescu3@yahoo.com",new DateTime(1999,07,04)),
                new("Patrick","Vezentan",4,Gender.Male,"patrickvezentan@yahoo.com",new DateTime(1998,01,15))
            };
        }

        public void CreateUser(User user)
        {
            user.Id = _users.Count + 1;
            _users.Add(user);
        }

        public User GetUser(int id)
        {
            return _users.FirstOrDefault(u => u.Id == id);
        }

        public IEnumerable<User> GetUsers()
        {
            return _users;
        }
    }
}
