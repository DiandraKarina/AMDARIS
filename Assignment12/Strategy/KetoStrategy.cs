using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    class KetoStrategy : IRBoxMembershipStrategy
    {
        public string SelectMembership(IList<string> dietname)
        {
            return dietname[1];
        }
    }
}
