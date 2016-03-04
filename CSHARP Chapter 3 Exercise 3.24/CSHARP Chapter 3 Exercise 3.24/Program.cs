using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSHARP_Chapter_3_Exercise_3._24
{
    class Program
    {
        static void Main(string[] args)
        {
            int Number; //declares the number variable
            Console.Write("Enter number: "); //writes message asking for user input for number
            Number = Convert.ToInt32(Console.ReadLine()); //stores user input for number in number variable
            if (Number % 2 == 0) //checks to see if number is divisable by 2 with no remainder
                Console.WriteLine("The number is even"); //if remainder is 0, displays that the number is even
            if (Number % 2 != 0) //checks to see if number is divisable by 2 with a remainder
                Console.WriteLine("The number is odd"); //if remainder exists, displays that the number is odd
            }
    }
}
