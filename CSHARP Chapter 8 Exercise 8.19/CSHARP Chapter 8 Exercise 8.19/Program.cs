using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSHARP_Chapter_8_Exercise_8._19
{
    class Program
    {
        static void Main(string[] args)
        {
            bool[] Seats = new bool[10];
            int input = 0;
            while (input == 0)
            {
                Console.WriteLine("-----------------------------------------------------------------------------");
                Console.WriteLine();
                Console.WriteLine("Welcome to Bucko Airlines!");
                Console.WriteLine();
                if ((Seats[0]) && (Seats[1]) && (Seats[2]) && (Seats[3]) && (Seats[4]) == true)
                {
                    if ((Seats[5]) && (Seats[6]) && (Seats[7]) && (Seats[8]) && (Seats[9]) == true)
                    {
                        Console.WriteLine("All seats have been filled.");
                        Console.WriteLine("Next flight leaves in 3 hours.");
                        input = 4;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("All First Class seating has been filled, would you like a seat in Economy?");
                        Console.Write("Enter 1 for yes, enter 2 for no: ");
                        input = Convert.ToInt32(Console.ReadLine());
                        if (input == 1)
                            input = 2;
                        else
                            input = 3;
                    }
                }
                if ((Seats[5]) && (Seats[6]) && (Seats[7]) && (Seats[8]) && (Seats[9]) == true)
                {
                    if ((Seats[0]) && (Seats[1]) && (Seats[2]) && (Seats[3]) && (Seats[4]) == true)
                    {
                        Console.WriteLine("All seats have been filled.");
                        Console.WriteLine("Next flight leaves in 3 hours.");
                        input = 4;
                        break;
                    }
                        else
                        {
                            Console.WriteLine("All Economy seating has been filled, would you like a seat in First Class?");
                            Console.Write("Enter 1 for yes, enter 2 for no: ");
                            input = Convert.ToInt32(Console.ReadLine());
                            if (input == 1)
                                input = 1;
                            else
                                input = 3;
                        }
                }
                if (input == 0)
                {
                    Console.WriteLine("Which section would you like to be seated in for today's flight?");
                    Console.WriteLine();
                    Console.Write("Enter 1 to sit in First Class, enter 2 to sit in Economy: ");
                    input = Convert.ToInt32(Console.ReadLine());
                }
                while ((input == 1) || (input == 2))
                {
                    if (input == 1)
                    {
                        Console.WriteLine();
                        Console.WriteLine("-----------------------------------------------------------------------------");
                        Console.WriteLine();
                        Console.WriteLine("Welcome to First Class seating!");
                        Console.WriteLine();
                        Console.WriteLine("Checking for available seats.....");
                        Console.WriteLine();
                        for (int fccount = 0; fccount <= 4; fccount++)
                        {
                            if (Seats[fccount] != true)
                            {
                                Seats[fccount] = true;
                                Console.WriteLine("Thank you, your seat has been booked, enjoy your flight!");
                                input = 0;
                                Console.WriteLine();
                                break;
                            }
                            if (Seats[4] == true)
                            {
                                Console.WriteLine("All First Class seats have been booked, we are sorry for the inconvienience.");
                                Console.WriteLine();
                                Console.WriteLine("Would it be ok to book you a seat in Economy?");
                                Console.Write("Enter 1 for yes, enter 2 for no: ");
                                input = Convert.ToInt32(Console.ReadLine());
                                if (input == 1)
                                    input = 2;
                                else
                                    input = 3;
                            }
                        }
                    }
                    if (input == 2)
                    {
                        Console.WriteLine();
                        Console.WriteLine("-----------------------------------------------------------------------------");
                        Console.WriteLine();
                        Console.WriteLine("Welcome to Economy seating!");
                        Console.WriteLine();
                        Console.WriteLine("Checking for available seats.....");
                        Console.WriteLine();
                        for (int ecount = 5; ecount <= 9; ecount++)
                        {
                            if (Seats[ecount] != true)
                            {
                                Seats[ecount] = true;
                                Console.WriteLine("Thank you, your seat has been booked, enjoy your flight!");
                                input = 0;
                                Console.WriteLine();
                                break;
                            }
                            if (ecount == 9)
                            {
                                Console.WriteLine("All Economy seats have been booked, we are sorry for the inconvienience.");
                                Console.WriteLine();
                                Console.WriteLine("Would it be ok to book you a seat in First Class?");
                                Console.Write("Enter 1 for yes, enter 2 for no: ");
                                input = Convert.ToInt32(Console.ReadLine());
                                if (input == 1)
                                    input = 1;
                                else
                                    input = 3;
                            }
                        }
                    }
                }
                while (input == 3)
                {
                    Console.WriteLine("We are sorry for any troubles this may have caused.");
                    Console.WriteLine("The next flight leaves in 3 hours.");
                    input = 0;
                }
            }
        }
    }
}
