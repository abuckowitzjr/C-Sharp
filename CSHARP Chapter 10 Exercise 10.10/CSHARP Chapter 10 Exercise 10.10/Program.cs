using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSHARP_Chapter_10_Exercise_10._10
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberamount = 0;
            Console.Write("How many numbers would you like to compare?: ");
            numberamount = Convert.ToInt32(Console.ReadLine());

            HugeInteger MyHugeInteger = new HugeInteger(numberamount);
        }
    }
}
