using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    internal class SportsCar:Car, ICloneable
    {
        public void Drive(double miles)
        {
            gas -= 0.06 * miles;
            Console.WriteLine("Gas after 100 miles is " + gas + " l");
        }

        public object Clone()
        {
            return this;
        }
    }
}
