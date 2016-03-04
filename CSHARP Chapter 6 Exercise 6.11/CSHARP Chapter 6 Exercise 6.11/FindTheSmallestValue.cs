using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSHARP_Chapter_6_Exercise_6._11
{
    class FindTheSmallestValue
    {
        static void Main(string[] args)
        {
            int EnteredNumber; //declares variable
            int NumberCount;
            int Smallest = 0;
            int sentinel = 1; //

            while (sentinel == 1) //checks sentinel value on which to continue loop 
            {
                Console.Write("How many numbers would you like to enter?: "); //asks for user input for how many numbers
                NumberCount = Convert.ToInt32(Console.ReadLine()); //store user input
                Console.WriteLine(); //blank line

                for (int counter = 1; counter <= NumberCount; ++counter) //for loop to cycle through how many numbers entered
                {
                    Console.Write("Enter number {0}: ", counter); //asks for user to enter numbers, in loop so will continue
                    EnteredNumber = Convert.ToInt32(Console.ReadLine());
                    if ((Smallest == 0) || (EnteredNumber < Smallest)) //checks entered number to verify if number entered is smaller than previous
                        Smallest = EnteredNumber; //changes variable if number is in fact smaller
                }
                Console.WriteLine(); //blank line
                Console.WriteLine("{0} is the smallest of all the numbers.", Smallest); //displays smallest number variable
                Console.WriteLine(); //blank line
                Console.Write("Would you like to continue? (enter 1 for yes, enter 2 for no): "); //asks for user to continue or quit
                sentinel = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
            }
        }
    }
}
