using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSHARP_Chapter_5_Exercise_5._22
{
    class TabularOutputTest
    {
        static void Main(string[] args)
        {
            int n = 1; //declares n variable
            int i = 10; //declares i variable

            Console.WriteLine("N     " + i + "*N   " + Math.Pow(i, 2) + "*N   " + Math.Pow(i, 3) + "*N");
            Console.WriteLine();
            while (n <= 5) //checks for lines written, once lines for 5 numbers have been written, exits loop
            {
                Console.WriteLine(n + "     " + n * i + "     " + n * Math.Pow(i, 2) + "     " + n * Math.Pow(i, 3));
                n = n + 1; //increases variable value by 1 for each loop
            }

        }
    }
}
