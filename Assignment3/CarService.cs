using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    internal class CarService : IEnumerable<BrokenCars>
    {
        public List<BrokenCars> brokencar;
        public CarService()
        {
            brokencar = new List<BrokenCars>(){
            new BrokenCars("Audi",false),
            new BrokenCars("Bmw", true),
            new BrokenCars("Mazda", true),
            new BrokenCars("Opel", false),
    };
        }

        IEnumerator<BrokenCars> IEnumerable<BrokenCars>.GetEnumerator()
        {
            return brokencar.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
