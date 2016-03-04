using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSHARP_Chapter_3_Exercise_3._15
{
    class Program
    {
        static void Main(string[] args)
        {
            int Number1; //declares number1 variable
            int Number2; //declares number2 variable
            int sum; //declares sum variable
            int product; //declares product variable
            int difference; //declares difference variable
            int quotient; //declares quotient variable
            Console.Write("Enter first integer: "); //writes message asking for user input for number1
            Number1 = Convert.ToInt32(Console.ReadLine()); //stores user input for number1 in number1 variable
            Console.Write("Enter second integer: "); //writes message asking for user input for number2
            Number2 = Convert.ToInt32(Console.ReadLine()); //stores user input for number2 in number2 variable
            sum = Number1 + Number2; //adds number1 and number2, storing result in sum
            product = Number1 * Number2; //multiplies number1 and number2, storing result in product
            difference = Number1 - Number2; //subtracts number2 from number1, storing result in difference
            quotient = Number1 / Number2; //divides number1 by number2, stores result in quotient
            Console.WriteLine("Sum is {0}\nProduct is {1}\nDifference is {2}\nQuotient is {3}", sum, product, difference, quotient); //displays the result of sum, product, difference, and quotient in seperate messages.
        }
    }
}
