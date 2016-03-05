using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;

namespace CSHARP_Chapter_10_Exercise_10._10
{
    class Program
    {
        static void Main()
        {
            HugeInteger hugeInteger = new HugeInteger();
            int n = 0;
            int c = 0;
            string number1 = "";
            string number2 = "";
            while (c == 0)
            {
                while (n == 0)
                {
                    Console.Write("Enter the first number, no more than 40 digits in length: ");
                    number1 = Console.ReadLine();
                    if (number1.Length > 40)
                    {
                        Console.WriteLine("Number entered has more than 40 digits, try again");
                        Console.WriteLine("");
                    }
                    else
                        n = 1;
                }
                while (n == 1)
                {
                    Console.Write("Enter the second number, no more than 40 digits in length: ");
                    number2 = Console.ReadLine();
                    if (number2.Length > 40)
                    {
                        Console.WriteLine("Number entered has more than 40 digits, try again");
                        Console.WriteLine("");
                    }
                    else
                        Console.WriteLine("");
                        n = 2;
                }
                Console.WriteLine("You have entered the following numbers:");
                Console.WriteLine("First Number: {0}", number1);
                Console.WriteLine("Second Number: {0}", number2);
                Console.Write("Enter 1 if you accept these numbers, or 2 to enter new ones: ");
                if (Console.ReadLine() == "1")
                {
                    c = 1;
                    Console.WriteLine("");
                    Console.WriteLine("The following information pertains to the two numbers you entered:");
                    Console.WriteLine("Sum of the numbers: {0}", hugeInteger.Add(hugeInteger.Input(number1), hugeInteger.Input(number2)));
                    Console.WriteLine("Difference of the numbers: {0}", hugeInteger.Subtract(hugeInteger.Input(number1), hugeInteger.Input(number2)));
                }
                else
                    Console.WriteLine("");
                n = 0;
            }
        }
    }
}
