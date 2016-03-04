using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSHARP_Chapter_13_Exercise_13._10
{
    class Program
    {
        static void Main(string[] args)
        { 
            decimal _miles;
            decimal _gallons;
            try
            {
            Console.Write("Enter miles driven: ");
            _miles = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Enter gallons used: ");
            _gallons = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("\nMiles Per Gallon: {0}", CalculateMPG(_miles, _gallons));
            }
            catch (FormatException ex)
            {
                Console.WriteLine();
                Console.WriteLine(ex.Message);
            }
        }
        static decimal CalculateMPG(decimal miles, decimal gallons)
        {
            decimal result;
            result = miles / gallons;
            return result;
        }
    }
}

