using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    internal class Car
    {
        public int speed = 30;
        public double gas { get; set; }
        public void Go()
        {
            Console.WriteLine("This car is moving with " + speed + " miles/h");
        }

        public void Drive(double miles)
        {
            gas -= 0.02 * miles;
            Console.WriteLine("Gas after 100 miles is " + gas + " l");
        }
    }
}
