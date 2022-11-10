using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    internal class BrokenCars
    {
        public string Name;
        public bool IsRepaired { get; set; }

        public BrokenCars(string name, bool isRepaired)
        {
            this.Name = name;
            this.IsRepaired = isRepaired;
        }

        public void RepairCar(string x)
        {
            Console.WriteLine("{0} to be repaired: {1} ", Name, x);
        }
    }
}
