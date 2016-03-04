using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSHARP_Chapter_7_Exercise_7._35
{
    class Program
    {
        static void Main(string[] args)
        {
            int sentinel = 1;
            while (sentinel == 1)
            {
                int basenum;
                int exp;
                Console.WriteLine("Enter base number followed by exponent to calculate recursive power");
                Console.WriteLine();
                Console.Write("Enter base number: ");
                basenum = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter exponent number: ");
                exp = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                Console.WriteLine(Power(basenum, exp));
                Console.WriteLine();
                Console.Write("Would you like to enter a new set of numbers? (1 = yes, 2 = no): ");
                sentinel = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
            }
        }
        static int Power(int basenum, int exp)
        {
            if (exp >= 1)
                return basenum * (Power(basenum, exp - 1));
            else
                return 1;
        }
    }
}
