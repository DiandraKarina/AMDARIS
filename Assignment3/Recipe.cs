﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3_2
{
    internal class Recipe
    {
        public string WetIngredient { get; set; }

        public string DryIngredient { get; set; }

        public Recipe(string wetingredient, string dryingredient)
        {
            this.DryIngredient = dryingredient;
            this.WetIngredient = wetingredient;
        }
        public void IsGlutenfree(string x)
        {
            Console.WriteLine("This recipe containing {0} as the dry ingredient {1} in the gluten free category",DryIngredient,x);
        }

    }
}
