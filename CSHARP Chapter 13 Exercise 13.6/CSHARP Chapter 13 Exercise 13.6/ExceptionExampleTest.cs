using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSHARP_Chapter_13_Exercise_13._6
{
    class ExceptionExampleTest
    {
        static void Main(string[] args)
        {
            int _int;
            decimal _dec;
            string _str;

            Console.WriteLine("This will test exception passing from constructor to main program.");
            Console.Write("Enter integer less than 0 to test exception: ");
            _int = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter decimal less than 0 to test exception: ");
            _dec = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Enter string of nothing to test exception: ");
            _str = Console.ReadLine();

            try
            {
                ExceptionExample exceptionExample = new ExceptionExample(_int, _dec, _str);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
