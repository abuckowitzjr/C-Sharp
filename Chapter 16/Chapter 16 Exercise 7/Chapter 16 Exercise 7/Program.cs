using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Chapter_16_Exercise_7
{
    class Exercise7
    {
        public static void Main(string[] args)
        {
            string input;
            string pattern = @"\b(\w|['-])+\b";
            string result;

            Console.Write("Enter string: ");
            input = Console.ReadLine();
            result = Regex.Replace(input, pattern,
                                m => m.Value[0].ToString().ToUpper() + m.Value.Substring(1));

            Console.WriteLine("{0}", result);
        }
    }
}
