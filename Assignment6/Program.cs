using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Assignment6;

class Program : MyGenericClass {

    static void Main(string[] args)
    {
        MyGenericCollection<string> myColl = new MyGenericCollection<string>(5);
        myColl.Add("sugar");
        myColl.Add("pumpkin");
        myColl.Add("cacao");
        myColl.Add("coconut");
        myColl.Add("spices");


        for (int i = 0; i < 5; i++)
       
            {
            Console.WriteLine("Item {0}: {1}",i,myColl.Get(i));
        }

        // Swap two items
        Console.WriteLine("Unswapped items: {0},{1} ",myColl.Get(3), myColl.Get(4));
        
        myColl.SwapItems(3, 4);

        Console.WriteLine("Swapped items: {0},{1} ", myColl.Get(3), myColl.Get(4));

    }
}