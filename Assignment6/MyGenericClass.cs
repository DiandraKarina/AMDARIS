using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6
{
    internal class MyGenericClass
    {
        public class MyGenericCollection<T>
        {
            private T[] array;
            private int next = 0;

            // get item at given index
            public T Get(int i)
            {
                return array[i];
            }

            // set item at given index method
            public void Set(int i, T item)
            {
                array[i] = item;
            }

            public MyGenericCollection(int length)
            {
                array = new T[length];
            }
            
            //add method
            public void Add(T item)
            {
                array[next] = item;
                next++;
            }

            // Swap
            public void SwapItems(int indexA, int indexB)
            {
                T tmp = array[indexA];
                array[indexA] = array[indexB];
                array[indexB] = tmp;
                
            }

        }
    }
}
