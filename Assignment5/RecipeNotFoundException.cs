using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    public class RecipeNotFoundException : Exception
    {

        public string ErrorCode { get; }

        public RecipeNotFoundException()
        {
        }

        public RecipeNotFoundException(string message) : base(message)
        {
        }
    }
}
