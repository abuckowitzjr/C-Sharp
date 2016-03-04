using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSHARP_Chapter_6_Exercise_6._16
{
    class BarChartPrinting
    {
        static void Main(string[] args)
        {
            int number = 0;
            bool validnumber = false;

            while (validnumber == false)
            {
                Console.Write("Enter number between 1 and 30 to represent number of asterisks to print: ");
                number = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                if ((number < 1) || (number > 30))
                {
                    Console.WriteLine("Invalid Input");
                    Console.WriteLine();
                }
                else
                    validnumber = true;
                }
                for (int counter = 1; counter <= number; ++counter)
                        Console.Write("*");
                Console.WriteLine();
                Console.WriteLine();
            }
        }
    }

