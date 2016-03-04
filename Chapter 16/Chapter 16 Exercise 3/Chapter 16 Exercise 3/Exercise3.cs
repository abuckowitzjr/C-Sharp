using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chapter_16_Exercise_3
{
    class Exercise3
    {
        public static void Main(string[] args)
        {
            string string1;
            string string2;

            Console.Write("Enter first string: ");
            string1 = Console.ReadLine();
            Console.Write("Enter second string: ");
            string2 = Console.ReadLine();

            if (string1.CompareTo(string2) == 1)
                Console.WriteLine("{0} is greater than {1}", string1, string2);
            else if (string1.CompareTo(string2) == 0)
                Console.WriteLine("{0} is equal to {1}", string1, string2);
            else
                Console.WriteLine("{0} is less than {1}", string1, string2);
        }
    }
}
