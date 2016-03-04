using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSHARP_Chapter_5_Exercise_5._29
{
    class SquareOfAsterisks
    {
        static void Main(string[] args)
        {
            int size; //declares size variable
            int i = 1; //declares i variable
            int j = 2; //declares j variable
            bool newline = false; //declares newline variable

            Console.Write("Enter size of the side of the square: "); //writes message asking for user input for size of side of square
            size = Convert.ToInt32(Console.ReadLine()); //stores user input for size into the size variable
            Console.WriteLine(); //writes blank line

            if (size < 0) //checks if size entered is less than 0
                size = 1; //if less, sets size to 1
            if (size > 20) //checks if size entered is more than 20
                size = 20; //if more, sets size to 20

            if (size == 1) //checks if size equals 1, draws square with one asterisk on each side
            {
                Console.WriteLine(" * ");
                Console.WriteLine("* *");
                Console.WriteLine(" * ");
            }
            else
                if (size > 1) //checks if size is greater than 1
            {
                while (i <= size) //while i is less than or equal to size, performs loop
                {
                    if (i == size) //checks if i equals size, and performs operations accordingly
                        Console.WriteLine("*");
                    else
                        Console.Write("*");
                    i = i + 1;
                }
                i = 1;
                while (j <= size - 1) //while j is less than the size minus one, performs loop
                {
                    if (i == 1) //checks if i is equal to 1, and performs operations accordingly
                    {
                        Console.Write("*");
                        newline = false;
                    }
                    if ((i > 1) && (i < size)) //checks if i is more than 1 and less than size, performs operations accordingly
                        Console.Write(" ");
                    if (i == size) //checks if i is equal to size, performs operations accordingly
                    {
                        Console.WriteLine("*");
                        j = j + 1;
                        i = 1;
                        newline = true;
                    }
                    if (newline == false) //checks if writing has progressed to a newline, sets variable accordingly
                    i = i + 1;
                    }
                }
                i = 1;
                while (i <= size) //while i less than or equal to size, performs loop
                {
                    if (i == size) //if i is equal to size, performs operations accordingly
                        Console.WriteLine("*");
                    else
                        Console.Write("*");
                    i = i + 1;
                }

            }
        }
    }

