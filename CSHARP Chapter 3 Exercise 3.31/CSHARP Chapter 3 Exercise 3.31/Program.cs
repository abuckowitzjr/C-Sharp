using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSHARP_Chapter_3_Exercise_3._31
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal Height; //declares the height variable
            int Weight; //declares the weight variable
            decimal BMI; //declares the BMI variable
            Console.Write("Enter your height in inches: "); //writes a message asking for user input for height in inches
            Height = Convert.ToDecimal(Console.ReadLine()); //stores user input for height in the height variable
            Console.Write("Enter your weight in pounds: "); //writes a message asking for user input for weight in pounds
            Weight = Convert.ToInt32(Console.ReadLine()); //stores user input for weight in the weight variable
            BMI = decimal.Round((Weight * 703) / (Height * Height), 2); //calculates BMI and stores in the BMI variable rounded to 2 decimal places
            Console.WriteLine(""); //writes an empty line
            Console.WriteLine("Your BMI is {0}", BMI); //writes the BMI info based on user input
            Console.WriteLine(""); //writes an empty line
            Console.WriteLine("BMI VALUES"); //the following code writes the Department of Health and Human Services information
            Console.WriteLine("Underweight: less than 18.5");
            Console.WriteLine("Normal: between 18.5 and 24.9");
            Console.WriteLine("Overweight: between 25 and 29.9");
            Console.WriteLine("Obese: 30 or greater");
        }
    }
}
