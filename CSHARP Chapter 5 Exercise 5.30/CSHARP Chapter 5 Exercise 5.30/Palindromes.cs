using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSHARP_Chapter_5_Exercise_5._30
{
    class Palindromes
    {
        static void Main(string[] args)
        {
            int number = 0; //declares number variable
            int revnumber = 0; //declares revnumber variable
            decimal pickoffnumber1 = 0; //declares pickoffnumber1 variable
            decimal pickoffnumber2 = 0; //declares pickoffnumber2 variable
            decimal pickoffnumber3 = 0; //declares pickoffnumber3 variable
            decimal pickoffnumber4 = 0; //declares pickoffnumber4 variable
            decimal pickoffnumber5 = 0; //declares pickoffnumber5 variable
            int sentinel = 1; //declares sentinel variable
            bool validnumber = true; //declares validnumber variable

            while (sentinel == 1) //while sentinel is equal to 1, loop is performed
            {
            Console.Write("Enter 5 digit number to check for palindrome: "); //writes message asking for user input for number
            number = Convert.ToInt32(Console.ReadLine()); //stores user input for number into number variable
            Console.WriteLine(); //writes blank line
            validnumber = true; //sets validnumber to true
            if ((number < 10000) || (number > 99999)) //if number is out of range of a 5 digit number, displays error message
            {
                if (number == 00000) //checks if number is 00000, performs operations accordingly
                    validnumber = true;
                else
                {
                    validnumber = false;
                    Console.WriteLine("Invalid input");
                    Console.WriteLine();
                }
            }
            if (validnumber == true) //checks if entered number is valid five digit number, performs operations accordingly
            {
                pickoffnumber5 = Convert.ToDecimal(number / 10000); //following code gets number and revers it to see if a palindrome
                pickoffnumber4 = Convert.ToDecimal((number / 1000) - (pickoffnumber5 * 10)); 
                pickoffnumber3 = Convert.ToDecimal((number / 100) - (pickoffnumber5 * 100) - (pickoffnumber4 * 10));
                pickoffnumber2 = Convert.ToDecimal((number / 10) - (pickoffnumber5 * 1000) - (pickoffnumber4 * 100) - (pickoffnumber3 * 10));
                pickoffnumber1 = Convert.ToDecimal((number / 1) - (pickoffnumber5 * 10000) - (pickoffnumber4 * 1000) - (pickoffnumber3 * 100) - (pickoffnumber2 * 10));
                revnumber = Convert.ToInt32(pickoffnumber1 * 10000 + pickoffnumber2 * 1000 + pickoffnumber3 * 100 + pickoffnumber4 * 10 + pickoffnumber5);
                if (number == 00000) //checks if number is 00000, performs operations accordingly
                    Console.WriteLine("Entered Number: 00000", number);
                else
                    Console.WriteLine("Entered Number: {0}", number);
                if (number == 00000)
                    Console.WriteLine("Number Reversed: 00000");
                if (revnumber < 10)
                {
                    if (number != 00000)
                        Console.WriteLine("Number Reversed: 0000{0}", revnumber);
                }
                else
                    Console.WriteLine("Number Reversed: {0}", revnumber);
                Console.WriteLine();
                if (number == 00000)
                    Console.WriteLine("The number is palindrome");
                else
                {
                    if (revnumber == number) //checks is number and number reversed are equal
                        Console.WriteLine("The number is palindrome");
                    else
                        Console.WriteLine("The number is not palindrome");
                }
                Console.WriteLine();
                Console.Write("Would you like to enter a new number? (Enter 1 for YES, Enter 2 for NO): "); //prompts user for continue or quit
                sentinel = Convert.ToInt32(Console.ReadLine()); //sets entinel variable based on user input
                Console.WriteLine();
            }
            }

        }
    }
}
