using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSHARP_Chapter_7_Exercise_7._17
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            int sentinel = 1;
            while (sentinel == 1)
            {
            Console.WriteLine("Enter number to check if even or odd");
            Console.Write("(Enter any number besides 0 to check, or enter 0 to quit): ");
            number = Convert.ToInt32(Console.ReadLine());
            if (number == 0)
                sentinel = 0;
            else
            {
                Console.WriteLine();
                if (IsEven(number) == true)
                    Console.WriteLine("The number {0} is even", number);
                else
                    Console.WriteLine("The number {0} is odd", number);
                Console.WriteLine();
            }
           }
        }
        static bool IsEven(int number)
        {
            bool result;
            if (number % 2 == 0)
                result = true;
            else
                result = false;
            return result;
        }
    }
}
