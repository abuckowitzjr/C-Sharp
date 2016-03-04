using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSHARP_Chapter_10_Exercise_10._3
{
    class RectangleTest
    {
        static void Main(string[] args)
        { 
            float length = 1;
            float width = 1;
            int sentinel = 1;
            while (sentinel == 1)
            {
            Console.Write("Enter width: ");
            width = (float)(Convert.ToDecimal(Console.ReadLine()));
            Console.Write("Enter length: ");
            length = (float)(Convert.ToDecimal(Console.ReadLine()));
                try
                {
                    Rectangle myrectangle = new Rectangle(length, width);
                    Console.WriteLine("\nThe perimeter of the rectangle is {0}", myrectangle.Perimeter);
                    Console.WriteLine("The area of the rectangle is {0}\n", myrectangle.Area);
                }
                catch (Exception ex)
                {
                Console.WriteLine(ex.Message + "\n");
                }
                Console.WriteLine("Would you like to enter a new set of numbers?");
                Console.Write("(Enter 1 for yes, and 2 for no): ");
                sentinel = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
            }
        }
    }
}
