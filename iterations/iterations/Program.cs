// for loops = definite loops
// while loops = indefinite loops



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iterations
{
    class Program
    {   
        static void Main(string[] args)
        {
            #region simple for loop
            Console.WriteLine("Simple for Loop Example\n");
            // i can be any variable, but i,j, or k are typically what is used
            for (int i = 0; i <5; i++)
            {
                Console.WriteLine("Iteration {0} |\t{1}",i,i);
            }
            Console.WriteLine();
            #endregion

            #region nested for loops
            Console.WriteLine("Nested for Loop Example\n");
            Console.WriteLine("i, j\n----");
            for(int i = 0; i <3; i++)
            {
                for(int j = 0; j <3; j++)
                {
                    Console.WriteLine("{0}, {1}", i,j);
                }
            }
            Console.WriteLine();
            #endregion

            #region foreach loop 
            Console.WriteLine("Foreach Loop Example\n");
            int[] myInts = { 1, 2, 3, 4, 5 };
            // count allows for a change in value
            for(int i = 0; i < myInts.Length; i++)
            {
                myInts[i] = i + 10;
            }
            // can't change value because no count variable
            // don't need a count variable bc is sequences through a list 
            // (list provides the count)
            foreach(int element in myInts)
            {
                Console.WriteLine(element);
            }
            Console.WriteLine();
            #endregion

            #region while loop
            // defining variable
            Console.WriteLine("While loop example\n");
            int count = 0;
            while(count < myInts.Length)
            {
                Console.WriteLine("{0}", myInts[count]);
                count++;
            }
            Console.WriteLine();
            #endregion

            #region do/while example
            Console.WriteLine("Do/While Example\n");
            count = 0;
            do
            {
                // this allows the loop to iterate at least once
                // the while loop, if the condition isn't met at first 
                // iteration, loop will not run at all
                Console.WriteLine(myInts[count]);
                count++;
            }
            while (count < myInts.Length);
            Console.WriteLine();
            #endregion
        }
    }
}
