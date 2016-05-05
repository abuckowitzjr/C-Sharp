using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;

namespace CSHARP_Chapter_10_Exercise_10._10
{
    class Program
    {
        static void Main()
        {
            HugeInteger hugeInteger = new HugeInteger();
            string number1 = "";
            string number2 = "";
            int n = 0;
            int c = 0;
            while (c == 0)
            {
                while (n == 0)
                {
                    Console.Write("Enter the first number, no more than 40 digits in length: "); 
                    number1 = Console.ReadLine();
                    if (number1.Length > 40) //Checks to ensure number is not larger than 40 digits
                    {
                        Console.WriteLine("Number entered has more than 40 digits, try again");
                        Console.WriteLine("");
                    }
                    else
                    {
                        n = 1; //Continues when number is within acceptable range
                    }
                }
                while (n == 1)
                {
                    Console.Write("Enter the second number, no more than 40 digits in length: "); 
                    number2 = Console.ReadLine();
                    if (number2.Length > 40) //Checks to ensure number is not larger than 40 digits
                    {
                        Console.WriteLine("Number entered has more than 40 digits, try again");
                        Console.WriteLine("");
                    }
                    else
                    {
                        Console.WriteLine(""); //Continues when number is within acceptable range
                        n = 2;
                    }
                }
                Console.WriteLine("You have entered the following numbers:");
                Console.WriteLine("First Number: {0}", number1);
                Console.WriteLine("Second Number: {0}", number2);
                Console.WriteLine("Enter 1 if you accept these numbers, or 2 to enter new ones.");
                Console.WriteLine("Keep in mind, all calculations will be done in order.");
                Console.Write("Example (First Number - Second Number = ?) or (Is First Number > Second Number): ");
                if (Console.ReadLine() == "1")
                {
                    c = 1;
                    hugeInteger.Input(number1, number2); //From here down, uses HugeInteger Class heavily to calculate and compare numbers
                    Console.WriteLine("");
                    Console.WriteLine("The following information pertains to the two numbers you entered:");
                    Console.WriteLine("The sum of the numbers: {0}", hugeInteger.ToString(hugeInteger.Add()));
                    Console.WriteLine("The difference of the numbers: {0}", hugeInteger.ToString(hugeInteger.Subtract()));
                    Console.WriteLine("The numbers are equal: {0}", hugeInteger.IsEqualTo());
                    Console.WriteLine("The numbers are not equal: {0}", hugeInteger.IsNotEqualTo());
                    Console.WriteLine("The first number is greater than the second: {0}", hugeInteger.IsGreaterThan());
                    Console.WriteLine("The first number is less than the second: {0}", hugeInteger.IsLessThan());
                    Console.WriteLine("The first number is greater than or equal to the second: {0}", hugeInteger.IsGreaterThanOrEqualTo());
                    Console.WriteLine("The first number is less than or equal to the second: {0}", hugeInteger.IsLessThanOrEqualTo());
                    Console.WriteLine("The first number is zero: {0}", hugeInteger.IsZero("1"));
                    Console.WriteLine("The second number is zero: {0}", hugeInteger.IsZero("2"));
                    Console.WriteLine("The product of the numbers: {0}", hugeInteger.ToString(hugeInteger.Multiply()));
                    if (number2 == "0")
                        Console.WriteLine("The quotient of the numbers: Unable to process, you cannot divide by zero."); //Ensures dividing by 0 does not occur, as it is not possible
                    else
                        Console.WriteLine("The quotient of the numbers: {0}", hugeInteger.ToString(hugeInteger.Divide()));
                    if (number2 == "0")
                        Console.WriteLine("The remainder of the numbers: Unable to process, you cannot divide by zero."); //Ensures dividing by 0 does not occur, as it is not possible
                    else
                        Console.WriteLine("The remainder of the numbers: {0}", hugeInteger.ToString(hugeInteger.Remainder()));
                }
                else
                {
                    hugeInteger.Clear(); //Clears values to enter new numbers
                    Console.WriteLine("");
                    n = 0;
                }  
            }
        }
    }
}
