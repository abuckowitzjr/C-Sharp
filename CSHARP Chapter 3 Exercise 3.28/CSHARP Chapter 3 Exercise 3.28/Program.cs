using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSHARP_Chapter_3_Exercise_3._28
{
    class Program
    {
        static void Main(string[] args)
        {
            int Number; //declares the number variable
            int Wholenumber; //declares the wholenumber variable
            Console.Write("Enter number: "); //writes message asking for user input for number
            Number = Convert.ToInt32(Console.ReadLine()); //stores user input for number in number variable
            Wholenumber = Number / 10000; //divides number by 10000 to get single first digit and stores in wholenumber
            Console.Write("{0}   ", Wholenumber); //writes the single digit followed by 3 spaces
            Number = Number % 10000; //uses remainder to get the remaining digits after the decimal place and stores in number
            Wholenumber = Number / 1000; //divides new number by 1000 to get the new single digit and stores in wholenumber
            Console.Write("{0}   ", Wholenumber); //writes the single digit followed by 3 spaces
            Number = Number % 1000; //uses remainder to get the remaining digits after the decimal place and stores in number
            Wholenumber = Number / 100; //divides number by 100 to get the single digit and stores in wholenumber
            Console.Write("{0}   ", Wholenumber); //writes the single digit followed by 3 spaces
            Number = Number % 100; //uses remainder to get the remaining digits after the decimal place and stores in number
            Wholenumber = Number / 10; //divides number by 10 to get the single digit and stores in wholenumber
            Console.Write("{0}   ", Wholenumber); //writes the single digit followed by 3 spaces
            Number = Number % 10; //uses remainder to get the remaining digits after the decimal place and stores in number
            Wholenumber = Number / 1; //divides number by 1 to get single digit and stores in wholenumber
            Console.WriteLine("{0}   ", Wholenumber); //writes the single digit and carries over to a new line
        }
    }
}
