using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSHARP_Chapter_6_Exercise_6._15
{
    class TrianglePrintingProgram
    {
        static void Main(string[] args)
        {
            for (int counter = 1; counter <= 10; ++counter)
            {
                for (int columncounter = 1; columncounter <= counter; ++columncounter)
                    Console.Write("*");
                Console.WriteLine();
            }
            for (int counter = 10; counter >= 1; --counter)
            {
                for (int columncounter = 1; columncounter <= counter; ++columncounter)
                    Console.Write("*");
                Console.WriteLine();
            }
            for (int counter = 10; counter >= 1; --counter)
            {
                if (counter <= 9)
                {
                   for (int spacecount = 1; spacecount <= 10 - counter; ++spacecount)
                   Console.Write(" ");
                }
                for (int columncounter = 1; columncounter <= counter; ++columncounter)
                    Console.Write("*");
                Console.WriteLine();
            }
            for (int counter = 1; counter <= 10; ++counter)
            {
                if (counter <= 9)
                {
                    for (int spacecount = 1; spacecount <= 10 - counter; ++spacecount)
                        Console.Write(" ");
                }
                for (int columncounter = 1; columncounter <= counter; ++columncounter)
                    Console.Write("*");
                Console.WriteLine();
            }
      }
                
   }
}
    

