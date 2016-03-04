using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSHARP_Chapter_6_Exercise_6._12
{
    class ProductOfOddIntegers
    {
        static void Main(string[] args)
        {
            int product = 0; //declare product variable
            Console.WriteLine("Odd numbers between 1 and 7:"); //writes message...
            for (int counter = 1; counter <= 7; ++counter) // loop through numbers 1 to 7
            {
                if (counter % 2 != 0) //check numbers 1 through 7 for odd numbers
                {
                    if (product == 0) //if product is 0, set product to number instead of multiplying by 0, which would be 0 
                        product = counter;
                    else //if other than 0, multiply product by new odd number
                        product = product * counter;
                    Console.Write("{0}, ", counter); //each cycle prints new odd number to screen
                }
            }
            Console.WriteLine();
            Console.WriteLine("The product of the numbers is: {0}", product); //displays the product of all the odd numbers
        }
    }
}
