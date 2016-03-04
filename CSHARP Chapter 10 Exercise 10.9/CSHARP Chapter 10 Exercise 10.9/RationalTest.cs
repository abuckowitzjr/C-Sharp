using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSHARP_Chapter_10_Exercise_10._9
{
    class RationalTest
    {
        static void Main(string[] args)
        {
            int numerator1;
            int denominator1;
            int numerator2;
            int denominator2;
            int decimalplaces;
            Console.Write("Enter numerator for rational number 1: ");
            numerator1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter denominator for rational number 1: ");
            denominator1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter numerator for rational number 2: ");
            numerator2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter denominator for rational number 2: ");
            denominator2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nHow many decimal places would you like to display for decimal result?: ");
            decimalplaces = Convert.ToInt32(Console.ReadLine());

            Rational MyRational = new Rational(numerator1, denominator1, numerator2, denominator2, decimalplaces);

            Console.WriteLine("\nThe sum of {0}/{1} and {2}/{3} is {4}, {5} as decimal form", numerator1, denominator1, numerator2, denominator2, MyRational.Add, MyRational.CalcDecimalA);
            Console.WriteLine("\nThe difference of {0}/{1} and {2}/{3} is {4}, {5} as decimal form", numerator1, denominator1, numerator2, denominator2, MyRational.Subtract, MyRational.CalcDecimalS);
            Console.WriteLine("\nThe product of {0}/{1} and {2}/{3} is {4}, {5} as decimal form", numerator1, denominator1, numerator2, denominator2, MyRational.Multiply, MyRational.CalcDecimalM);
            Console.WriteLine("\nThe quotient of {0}/{1} and {2}/{3} is {4}, {5} as decimal form", numerator1, denominator1, numerator2, denominator2, MyRational.Divide, MyRational.CalcDecimalD);

        }
    }
}
