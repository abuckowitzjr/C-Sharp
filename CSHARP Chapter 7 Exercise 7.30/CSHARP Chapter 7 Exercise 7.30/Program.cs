using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSHARP_Chapter_7_Exercise_7._30
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random(); //declares random number
            int number;
            int usernumber;
            int sentinel = 1;

            while (sentinel == 1) //verifies loop active if user wants to play again
            {
                number = rnd.Next(1, 1001);
                Console.WriteLine("Try to guess the number. Number can range from 1 to 1000.");
                Console.WriteLine("You have 10 guesses to get it right.");
                Console.WriteLine("Good Luck!");
                for (int counter = 10; counter >= 1; counter--) //allows user 10 attempts to guess the random number
                {
                    Console.WriteLine();
                    Console.WriteLine("Guesses remaining ({0})", counter);
                    Console.Write("Enter your guess: ");
                    usernumber = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();

                    if (usernumber < number) //if user guess is less than number, display message
                    {
                        if (counter == 1)
                            Console.WriteLine("TOO LOW.");
                        else
                            Console.WriteLine("Too LOW. Try again.");
                    }
                    if (usernumber > number) //if user guess is more than number, display message
                    {
                        if (counter == 1)
                            Console.WriteLine("TOO HIGH.");
                        else
                            Console.WriteLine("TOO HIGH. Try again.");
                    }
                    if (counter == 3) //if counter equals 3, display message
                        Console.WriteLine("Your not very good at this!");
                    if (usernumber == number) //if user guess equals number, display message
                    {
                        Console.WriteLine("CONGRATULATIONS. You guessed the number!");
                        Console.WriteLine();
                        Console.Write("Play again? (1 = yes, 2 = no): ");
                        sentinel = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine();
                        break;
                    }
                    if (counter == 1) //if counter hits 1, display message
                    {
                        Console.WriteLine();
                        Console.WriteLine("I am so sorry, you have failed yourself and the world around you!");
                        Console.WriteLine("The number was {0}, better luck next time", number);
                        Console.WriteLine();
                        Console.Write("Play again? (1 = yes, 2 = no): ");
                        sentinel = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine();
                    }
			    }
            }
         }
     }
 }

