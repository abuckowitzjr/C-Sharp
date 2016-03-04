using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSHARP_Chapter_3_Exercise_3._26
{
    class Program
    {
        static void Main(string[] args)
        {
            int Radius; //declares the radius variable
            Console.Write("Enter radius: "); //writes message asking for user input for radius
            Radius = Convert.ToInt32(Console.ReadLine()); //stores the user input for radius in radius variable
            Console.WriteLine("Diameter is {0}", 2 * Radius); //writes the diameter using math and radius variable
            Console.WriteLine("Circumference is {0}", 2 * Math.PI * Radius); //writes the circumference using math and radius variable
            Console.WriteLine("Area is {0}", Math.PI * Math.Pow(Radius, 2)); //writes the area using math and radius variable
        }
    }
}
