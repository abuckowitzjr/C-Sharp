using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSHARP_Chapter_7_Exercise_7._22
{
    class Program
    {
        static void Main(string[] args)
        {
            int sentinel = 1;
            int inputnumber;
            double temperature;
            while (sentinel == 1)
            {
                Console.WriteLine("Enter temperature to convert");
                Console.Write("(Enter 1 for Celsius to Fahrenheit, enter 2 for Fahrenheit to Celsius, or enter 0 to quit): ");
                inputnumber = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                if (inputnumber == 1)
                {
                    Console.Write("Enter Celsius temperature: ");
                    temperature = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("{0} degrees Celsius is equal to {1} degrees Fahrenheit", temperature, Fahrenheit(temperature));
                    Console.WriteLine();
                }
                if (inputnumber == 2)
                {
                    Console.Write("Enter Fahrenheit temperature: ");
                    temperature = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("{0} degrees Fahrenheit is equal to {1} degrees Celsius", temperature, Celsius(temperature));
                    Console.WriteLine();
                }
                if (inputnumber == 0)
                    sentinel = 0;
            }
        }

        static double Celsius(double temperature)
        {
            double result;
            result = 5.0 / 9.0 * (temperature - 32);
            return result;
        }

        static double Fahrenheit(double temperature)
        {
            double result;
            result = 9.0 / 5.0 * temperature + 32;
            return result;
        }
    }
}
