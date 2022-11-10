using Assignment3;
using System;
using System.Collections;
using System.Collections.Generic;

//IEnumerable- interface that enables iterating over collections
//ICloneable-interface that allows objects to provide cloning support
class Program:Car
{
    static void Main(string[] args)
    {
        Car car = new Car();
        car.gas = 40;
        car.Drive(100);
        car.Go();

        SportsCar sportscar = new SportsCar();
        sportscar.gas = 40;
        sportscar.speed = 70;
        sportscar.Drive(100);
        sportscar.Go();

        SportsCar sportscar2 = sportscar.Clone() as SportsCar;
        sportscar2.Drive(100);
        sportscar2.Go();


        Truck truck = new Truck();
        truck.gas = 40;
        truck.speed = 50;
        truck.Drive(100,10);
        truck.Go();


        CarService service= new CarService();

        foreach(BrokenCars brokencar in service)
        {
            if(!brokencar.IsRepaired)
            {
                brokencar.RepairCar("yes");
            }
            else
            {
                brokencar.RepairCar("no");
            }
        }

    }
}



