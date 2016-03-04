using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSHARP_Chapter_10_Exercise_10._7
{
    class ComplexNumbersTest
    {
        static void Main(string[] args)
        {
            float c1r;
            float c1i;
            float c2r;
            float c2i;

            Console.WriteLine("This program will perform arithmetic with complex numbers");
            Console.WriteLine("Example... (real part) + (imaginary part) * i...");
            Console.WriteLine("The arithmetic will be performed on two complex numbers that you enter\n");
            Console.Write("Enter number for Complex Number 1 (real part): ");
            c1r = (float)Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter number for Complex Number 1 (imaginary part): ");
            c1i = (float)Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter number for Complex Number 2 (real part): ");
            c2r = (float)Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter number for Complex Number 2 (imaginary part): ");
            c2i = (float)Convert.ToInt32(Console.ReadLine());

            ComplexNumbers MyComp = new ComplexNumbers(c1r, c1i, c2r, c2i);
            Console.WriteLine("\nThe numbers {0} + {1} * i and {2} + {3} * i will be added and subtracted", c1r, c1i, c2r, c2i);
            Console.WriteLine("\nThe result of adding them is {0} + {1} which equals {2}", MyComp.AddReal, MyComp.AddImag, MyComp.AddReal + MyComp.AddImag);
            Console.WriteLine("\nThe result of subtracting them is {0} + {1} which equals {2}", MyComp.SubReal, MyComp.SubImag, MyComp.SubReal + MyComp.SubImag);
            Console.WriteLine("\nThis is an example of string containing the real numbers and imaginary numbers: ({0}, {1}) and ({2}, {3})", c1r, c1i, c2r, c2i);
        }
    }
}
