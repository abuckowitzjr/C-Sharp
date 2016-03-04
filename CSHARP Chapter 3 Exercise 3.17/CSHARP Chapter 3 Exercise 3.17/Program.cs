using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSHARP_Chapter_3_Exercise_3._17
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int Number1; //declares number1 variable
                int Number2; //declares number2 variable
                int Number3; //declares number3 variable
                int Sum; //declares sum variable
                int Average; //declares average variable
                int Product; //declares product variable
                Console.Write("Enter first number: "); //displays message asking for user input for number1
                Number1 = Convert.ToInt32(Console.ReadLine()); //stores user input for number1 in number1 variable
                Console.Write("Enter second number: "); //displays message asking for user input for number2
                Number2 = Convert.ToInt32(Console.ReadLine()); //stores user input for number2 in  number2 variable
                Console.Write("Enter third number: "); //displays message asking for user input for number3
                Number3 = Convert.ToInt32(Console.ReadLine()); //stores user input for number3 in number3 variable
                Sum = Number1 + Number2 + Number3; //determines and stores the sum of all 3 numbers
                Console.WriteLine("Sum is {0}", Sum); //writes the sum of the 3 numbers
                Average = (Number1 + Number2 + Number3) / 3; //determines and stores the average of all 3 numbers
                Console.WriteLine("Average is {0}", Average); //writes the average of the 3 numbers
                Product = Number1 * Number2 * Number3; //determines and stores the product of all 3 numbers
                Console.WriteLine("Product is {0}", Product); //writes the product of the 3 numbers
                if (Number1 < Number2 && Number1 < Number3) //the following code determines which number is the smallest
                    Console.WriteLine("{0} is the smallest", Number1);
                if (Number2 < Number1 && Number2 < Number3)
                    Console.WriteLine("{0} is the smallest", Number2);
                if (Number3 < Number1 && Number3 < Number2)
                    Console.WriteLine("{0} is the smallest", Number3);
                if (Number1 == Number2 && Number1 < Number3)
                    Console.WriteLine("{0} is the smallest", Number1);
                if (Number1 == Number3 && Number1 < Number2)
                    Console.WriteLine("{0} is the smallest", Number1);
                if (Number2 == Number3 && Number2 < Number1)
                    Console.WriteLine("{0} is the smallest", Number2);
                if (Number1 == Number2 && Number1 == Number3)
                    Console.WriteLine("{0} is the smallest", Number1);
                if (Number1 > Number2 && Number1 > Number3) //the following code determines which number is the largest
                    Console.WriteLine("{0} is the largest", Number1);
                if (Number2 > Number1 && Number2 > Number3)
                    Console.WriteLine("{0} is the largest", Number2);
                if (Number3 > Number1 && Number3 > Number2)
                    Console.WriteLine("{0} is the largest", Number3);
                if (Number1 == Number2 && Number1 > Number3)
                    Console.WriteLine("{0} is the largest", Number1);
                if (Number1 == Number3 && Number1 > Number2)
                    Console.WriteLine("{0} is the largest", Number1);
                if (Number2 == Number3 && Number2 > Number1)
                    Console.WriteLine("{0} is the largest", Number2);
                if (Number1 == Number2 && Number1 == Number3)
                    Console.WriteLine("{0} is the largest", Number1);
            }
           catch (Exception e)
            {
              Console.WriteLine("Numbers must be whole number, decimals are not allowed.");
          }
        }
    }
}
