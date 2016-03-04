using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSHARP_Chapter_7_Exercise_7._24
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program displays the perfect numbers between 2 and 1000");
            Console.WriteLine("The factors of the displayed perfect numbers will also be displayed");
            Console.WriteLine();
            Console.WriteLine("Perfect numbers are as follows:");
            Console.WriteLine();
            for (int counter = 2; counter <= 1000; counter++) //runs loops through number 2 to 1000
            {
                if (counter % 2 == 0) //since perfect numbers are mostly even, checks for even numbers
                {
                    if (CheckForPerfect(counter) == true) //checks even number to see if its perfect
                    { //if the number is a perfect number, find factors of the number, write info to console
                        Console.WriteLine("{0} is a perfect number", counter); 
                        Console.Write("It's factors are: ");
                        Factors(counter);
                        Console.WriteLine();
                        Console.WriteLine();
                    }
                }
            }
        }
        static void Factors(int num) //method to find factors
        {
            for (int enterednum = num; enterednum >= 1; enterednum--)
            {
                for (int factor = 1; factor <= num; factor++)
                {
                    if (factor * enterednum == num)
                    {
                        Console.Write("{0} ", factor);
                    }
                }
            }
        }
        static bool CheckForPerfect(int num) //method to check if perfect number
        {
            bool result = false;
            int sumoffactors = 0;
            for (int enterednum = num; enterednum >= 1; enterednum--)
            {
                for (int checknum = 1; checknum <= num; checknum++)
                {
                    if (checknum * enterednum == num)
                    {
                        sumoffactors = sumoffactors + checknum;
                    }
                }
            }
            if (num == sumoffactors - num)
            {
                result = true;
            }
            return result;
        }
    }
}


