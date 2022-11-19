using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
     class RecipeBoxContext
    {
        private IRBoxMembershipStrategy _strategy;

        public RecipeBoxContext() { }
        public void SetStrategy(IRBoxMembershipStrategy strategy)
        {
            _strategy = strategy;
        }


        public void MemberDietType()
        {
            Console.WriteLine("Context: Member is selecting " +
                "Their Membership Type");

            var customerMembership = _strategy
                .SelectMembership(new List<string>
                {
                "Vegan diet",
                "Keto Diet",
                "Vegetarian Diet"
                });

            Console.WriteLine("With this membership you will " +
                "get weekly a recipe box for the " + customerMembership);
        }
    }
}

