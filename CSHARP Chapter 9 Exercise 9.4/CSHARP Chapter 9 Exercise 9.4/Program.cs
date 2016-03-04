using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSHARP_Chapter_9_Exercise_9._4
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] Sentence = new string[1];
            string input = "";
            Console.WriteLine("Enter sentence you wish to split and sort");
            Console.Write("\nEnter sentence: ");
            input = Console.ReadLine();

            var distinctList = input.Split().Distinct();
            Sentence = distinctList.ToArray();

            var words = from e in Sentence
                        let lowercase = e.ToLower()
                        orderby lowercase
                        select lowercase;
            foreach (var element in words)
                Console.WriteLine(element);
        }
    }
}
