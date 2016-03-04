using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSHARP_Chapter_8_Exercise_8._14
{
    class Program
    {
        public static double Product(params double[] numbers)
        {
            double total = 0;
            foreach (double x in numbers)
                if (total == 0)
                    total = x;
                else
                    total *= x;
            return total;
        }
        static void Main(string[] args)
        {   
            int sentinel = 0;
        while (sentinel == 0)
        {
            double num1 = 0;
            double num2 = 0;
            double num3 = 0;
            double num4 = 0;
            double num5 = 0;
            int i = 0;
            Console.Write("How many numbers would you like to multiply? (2 to 5 numbers): ");
            i = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Enter numbers you want to find the product for.");
            Console.WriteLine();
            for (int count = 1; count <= i; count++)
            {
                Console.Write("Number {0}: ", count);
                if (count == 1)
                    num1 = Convert.ToDouble(Console.ReadLine());
                if (count == 2)
                    num2 = Convert.ToDouble(Console.ReadLine());
                if (count == 3)
                    num3 = Convert.ToDouble(Console.ReadLine());
                if (count == 4)
                    num4 = Convert.ToDouble(Console.ReadLine());
                if (count == 5)
                    num5 = Convert.ToDouble(Console.ReadLine());
            }
            Console.WriteLine();
            if (i == 2)
                Console.WriteLine("The product of {0} and {1} is {2}", num1, num2, Product(num1, num2));
            if (i == 3)
                Console.WriteLine("The product of {0}, {1}, and {2} is {3}", num1, num2, num3, Product(num1, num2, num3));
            if (i == 4)
                Console.WriteLine("The product of {0}, {1}, {2}, and {3} is {4}", num1, num2, num3, num4, Product(num1, num2, num3, num4));
            if (i == 5)
                Console.WriteLine("The product of {0}, {1}, {2}, {3}, and {4} is {5}", num1, num2, num3, num4, num5, Product(num1, num2, num3, num4, num5));
            Console.WriteLine();
            Console.WriteLine("Would you like to enter a new set of numbers?");
            Console.Write("(0 for yes, 1 for no): ");
            sentinel = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
        }
        }
    }
}
