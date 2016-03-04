using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSHARP_Chapter_13_Exercise_13._9
{
    class DeepMethodExceptionTest
    {
        static void Main(string[] args)
        {
            int _num1;
            int _num2;

            Console.Write("Enter any number to represent number 1: ");
            _num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter 0 as second number to test deep method exception: ");
            _num2 = Convert.ToInt32(Console.ReadLine());

            try
            {
                DeepMethodException1 deepMethodExceptionTest = new DeepMethodException1(_num1, _num2);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine();
                Console.WriteLine("MESSAGE");
                Console.WriteLine(ex.Message);
                Console.WriteLine();
                Console.WriteLine("STACK TRACE");
                Console.WriteLine(ex.StackTrace);
            }

        }
    }
}
