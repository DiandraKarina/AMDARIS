using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    internal class VeganStrategy : IRBoxMembershipStrategy
    {
        public string SelectMembership(IList<string> dietname)
        {
            return dietname[0];
        }
    }
}
