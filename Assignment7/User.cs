using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment7
{
    internal class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    internal class UserNameComparer : IEqualityComparer<User>
    {
        public bool Equals(User x, User y)
        {
            if (string.Equals(x.Name, y.Name, StringComparison.OrdinalIgnoreCase))
            {
                return true;
            }
            return false;
        }
        public int GetHashCode(User obj)
        {
            return obj.Name.GetHashCode();
        }
    }
}
