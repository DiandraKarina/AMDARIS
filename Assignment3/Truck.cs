using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    internal class Truck:Car
    {
        public void Drive(double miles, int dwell)
        {
            gas -= 0.04 * miles + 0.01 * dwell;
            Console.WriteLine("Gas after 100 miles and 10 minutes break is " + gas + " l");
        }
    }
}
