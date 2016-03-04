using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSHARP_Chapter_9_Exercise_9._5
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            Random rnd = new Random();
            List< char > Letters = new List< char >();

            for (int counter = 1; counter <= 30; counter++)
            {
                num = rnd.Next(0, 26);
                char let = (char)('a' + num);
                Letters.Add(let);
            }
            Letters.Sort();
            Console.WriteLine("Displays 30 random letters in ascending order using LINQ Query\n"); 
            foreach (char element in Letters)
                Console.Write("{0} ", element);
            Console.WriteLine();

            Letters.Reverse();
            Console.WriteLine("\nDisplays 30 random letters in descending order using LINQ Query\n");
            foreach (char element in Letters)
                Console.Write("{0} ", element);
            Console.WriteLine();

            List< char > NoDupLetters = Letters.Distinct().ToList();
            NoDupLetters.Sort();
            Console.WriteLine("\nDisplays random letters in ascending order, minus duplicates, using LINQ Query\n");
            foreach (char element in NoDupLetters)
                Console.Write("{0} ", element);
            Console.WriteLine();
        }
    }
}
