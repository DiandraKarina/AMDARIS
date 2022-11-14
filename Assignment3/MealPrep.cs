using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3_2
{
    internal class MealPrep : IEnumerable<Recipe>
    {

        public List<Recipe> recipe;
        public MealPrep()
        {
            recipe = new List<Recipe>(){
            new Recipe("Oil","normal flour"),
            new Recipe("Milk","oat flour"),
            new Recipe("Sparkling Water","normal flour"),
            new Recipe("Melted Butter", "almond flour"),
    };
        }

        IEnumerator<Recipe> IEnumerable<Recipe>.GetEnumerator()
        {
            return recipe.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
