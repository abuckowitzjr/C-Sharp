using System;

namespace CSHARP_Chapter_6_Exercise_6._14
{
    public class MCIP
    {
        public static void Main(string[] args)
        {
            decimal amount; //declares variables
            decimal principal = 1000;
            double rate = 0.05; //...

            for (int counter = 1; counter <= 5; ++counter) //checks that counter in less than or equal to 5, continues loop
            {
                Console.WriteLine("Year{0,20}", "Amount on deposit"); //writes heading
                for (int year = 1; year <= 10; year++) 
                {
                    amount = principal * ((decimal)Math.Pow(1.0 + rate, year));
                    Console.WriteLine("{0,4}{1,20:C}", year, amount);
                }
                Console.WriteLine(); //blank line
                rate = rate + .01; //increases rate by .01 everytime after a table is printed, until 5 have been printed
            }
        }
    }
}
