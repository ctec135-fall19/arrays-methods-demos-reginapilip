using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            // declaring
            // new creates an object (reference type.. hint hint)
            int[] myArray = new int[5];

            // initializing
            for(int i=0; i<myArray.Length; i++)
            {
                myArray[i] = i + 10;
            }

            // traversing
            Console.WriteLine("Print Array Elements");
            foreach(int element in myArray)
            {
                Console.WriteLine(element);
            }
            Console.WriteLine();
        }

    }
}
