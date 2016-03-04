using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSHARP_Chapter_3_Exercise_3._25
{
    class Program
    {
        static void Main(string[] args)
        {
            int Number1; //declares number1 variable
            int Number2; //declares number2 variable
            Console.Write("Enter multiple number: "); //writes a message asking for user input for multiple number
            Number1 = Convert.ToInt32(Console.ReadLine()); //stores user input for multiple number in number1 variable
            Console.Write("Enter number to check for multiple: "); //writes a message asking for user input for number being checked for multiple
            Number2 = Convert.ToInt32(Console.ReadLine()); //stores user input for number being checked in number 2 variable
            if (Number2 % Number1 == 0) //checks to see if number2 is divisable by number1 with no remainder
                Console.WriteLine("{0} is a multiple of {1}", Number1, Number2); //if there is no remainder, displays message that number1 is a multiple of number2
            if (Number2 % Number1 != 0) //checks to see if number2 is divisable by number1 with a remainder
                Console.WriteLine("{0} is not a multiple of {1}", Number1, Number2); //if there is a remainder left, displays message that number1 is not a multiple of number2 
        }
    }
}
