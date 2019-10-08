using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace decision_constructs
{
    class Program
    {
        static void Main(string[] args)
        {
            #region if, if/else statements
            if (true)
            {
                // true is a keyword and also a value
                Console.WriteLine(true);
            }
            // by setting it automatically to false "if (false)" then
            // that junk of code will not be reachable
            if (!false)
            {
                Console.WriteLine(false);
            }
            if (false)
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine("if/else {0}", false);
            }
            #endregion
            Console.WriteLine();
            #region switch statements example
            for(int i=0; i<6; i++)
            {
                switch (i)
                {
                    case 0:
                        Console.WriteLine(i);
                        // allows the flow to leave the the switch/case and go back into iteration
                        break;
                    case 1:
                        Console.WriteLine(i);
                        break;
                    case 2:
                    case 3:
                        Console.WriteLine("2 or 3: {0}", i);
                        break;
                    default:
                        Console.WriteLine("Default: {0}", i);
                        break;
                }
            }
            #endregion

            #region

            #endregion
        }
    }
}
