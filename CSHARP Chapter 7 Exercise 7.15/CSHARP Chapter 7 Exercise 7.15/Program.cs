using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSHARP_Chapter_7_Exercise_7._15
{
    class Program
    {
        static void Main(string[] args)
        {
            double T1S1;
            double T1S2;
            double T2S1;
            double T2S2;
            double T3S1;
            double T3S2;

            Console.WriteLine("Triangle 1");
            Console.Write("Enter side 1 for triangle 1: ");
            T1S1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter side 2 for triangle 1: ");
            T1S2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Triangle 2");
            Console.Write("Enter side 1 for triangle 2: ");
            T2S1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter side 2 for triangle 2: ");
            T2S2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Triangle 3");
            Console.Write("Enter side 1 for triangle 3: ");
            T3S1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter side 2 for triangle 3: ");
            T3S2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Hypotenuse of triangle 1: {0}", GetHypotenuse(T1S1, T1S2));
            Console.WriteLine("Hypotenuse of triangle 2: {0}", GetHypotenuse(T2S1, T2S2));
            Console.WriteLine("Hypotenuse of triangle 3: {0}", GetHypotenuse(T3S1, T3S2));
        }

            static double GetHypotenuse(double side1, double side2)
            {
                double result;
                result = Math.Sqrt(Math.Pow(side1, 2) + Math.Pow(side2, 2));
                return result;
            }
        }
        
    }

