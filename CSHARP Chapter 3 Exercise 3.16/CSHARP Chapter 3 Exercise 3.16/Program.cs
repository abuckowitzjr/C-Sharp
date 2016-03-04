using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSHARP_Chapter_3_Exercise_3._16
{
    class Program
    {
        static void Main(string[] args)
        {
            int Number1; //declares number1 variable
            int Number2; //declares number2 variable
            Console.Write("Enter first number: "); //writes message asking for user input for number1
            Number1 = Convert.ToInt32(Console.ReadLine()); //stores user input into number1 variable
            Console.Write("Enter second number: "); //writes message asking for user input for number2
            Number2 = Convert.ToInt32(Console.ReadLine()); //stores user input into number2 variable
            if (Number1 > Number2) //determines if number1 is larger than number2
                Console.WriteLine("{0} is larger", Number1); //if number1 is larger, message displays number1 is larger
            if (Number1 < Number2) //determines if number 2 is larger than number1
                Console.WriteLine("{0} is larger", Number2); //if number2 is larger, message displays number2 is larger
            if (Number1 == Number2) //determines if number1 and number2 are equal
                Console.WriteLine("These numbers are equal"); //if number1 and number2 are equal, message displays that the numbers are equal.
        }
    }
}
