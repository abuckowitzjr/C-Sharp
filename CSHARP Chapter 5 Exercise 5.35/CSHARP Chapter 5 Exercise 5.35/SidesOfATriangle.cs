using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSHARP_Chapter_5_Exercise_5._35
{
    class SidesOfATriangle
    {
        static void Main(string[] args)
        {
            int sideA = 0; //declares sideA variable
            int sideB = 0; //...
            int sideC = 0;
            bool sideAvalid = false;
            bool sideBvalid = false;
            bool sideCvalid = false;
            bool check1 = false;
            bool check2 = false;
            bool check3 = false;
            int sentinel = 1;

            while (sentinel == 1) //while sentinel equals 1, perform loop
            {
                Console.WriteLine("When prompted, enter numbers to represent sides of a triangle.  The program will determine if they can actually represent a triangle.");
                Console.WriteLine();
                Console.Write("Enter number, except for 0, for side 1: ");
                sideA = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter number, except for 0, for side 2: ");
                sideB = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter number, except for 0, for side 3: ");
                sideC = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                while ((sideAvalid == false) || (sideBvalid == false) || (sideCvalid == false)) //checks that numbers entered are valid
                {
                    if (sideA < 1) //following code reprompts user if number are not valid, continues till all numbers are valid
                    {
                        Console.WriteLine("Invalid input for side 1");
                        Console.Write("Please enter a valid number, except for 0, for side 1: ");
                        sideA = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine();
                    }
                    else
                        sideAvalid = true;
                    if (sideB < 1)
                    {
                        Console.WriteLine("Invalid input for side 2");
                        Console.Write("Please enter a valid number, except for 0, for side 2: ");
                        sideB = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine();
                    }
                    else
                        sideBvalid = true;
                    if (sideC < 1)
                    {
                        Console.WriteLine("Invalid input for side 3");
                        Console.Write("Please enter a valid number, except for 0, for side 3: ");
                        sideC = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine();
                    }
                    else
                        sideCvalid = true;
                }
                while ((sideAvalid == true) || (sideBvalid == true) || (sideCvalid == true)) //if all numbers are valid, performs loop
                {
                    if (sideA < sideB + sideC) //following code checks side to verify if numbers can represent a triangle
                        check1 = true;
                    if (sideB < sideA + sideC)
                        check2 = true;
                    if (sideC < sideA + sideB)
                        check3 = true;
                    Console.WriteLine("Number 1: {0}", sideA);
                    Console.WriteLine("Number 2: {0}", sideB);
                    Console.WriteLine("Number 3: {0}", sideC);
                    Console.WriteLine();
                    if ((check1 == true) && (check2 == true) && (check3 == true))
                        Console.WriteLine("The numbers entered will work for the sides of a triangle.");
                    else
                        Console.WriteLine("The numbers entered will not work for the sides of a triangle.");
                    Console.WriteLine();
                    Console.WriteLine("Would you like to enter another set of numbers?"); //prompts user to continue or quit
                    Console.Write("(Enter 1 for YES, Enter 2 for NO): "); //if user enters 1 program recycles, if 2 program quits
                    sentinel = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();
                    sideAvalid = false;
                    sideBvalid = false;
                    sideCvalid = false;
                    check1 = false;
                    check2 = false;
                    check3 = false;
                }
            }
        }
    }
}


