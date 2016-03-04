using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSHARP_Chapter_10_Exercise_10._6
{
    class DateTest
    {
        static void Main(string[] args)
        {
            int month;
            int day;
            int year;
            Console.Write("Enter Month: ");
            month = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Day: ");
            day = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Year: ");
            year = Convert.ToInt32(Console.ReadLine());

            try
            {
                Date d1 = new Date(month, day, year);
                Console.WriteLine("\nThis will loop the next day method 10 times to show it works");
                for (int counter = 1; counter <= 10; counter++) 
                {
                    d1.NextDay();
                    Console.Write("{0} ", d1.Day);
                }
                Console.WriteLine();
                Console.WriteLine("\nThis will loop the next month method 10 times to show it works");
                for (int counter = 1; counter <= 10; counter++)
                {
                    d1.NextMonth();
                    Console.Write("{0} ", d1.Month);
                }
                Console.WriteLine();
                Console.WriteLine("\nThis will loop the next year method 10 times to show it works");
                for (int counter = 1; counter <= 10; counter++)
                {
                    d1.NextYear();
                    Console.Write("{0} ", d1.Year);
                }
                Console.WriteLine();
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message + "\n");
            }
        }
    }
}
