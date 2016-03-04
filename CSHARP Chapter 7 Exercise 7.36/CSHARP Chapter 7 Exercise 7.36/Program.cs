using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSHARP_Chapter_7_Exercise_7._36
{
    class Program
    {
        static void Main(string[] args)
        {
            int j = 1;
            int i = 1;
            int x = 1;
            int from = 1, xtra = 2, to = 3;
            while (i == 1)
            {
                Console.WriteLine("This program will show, step by step, how to win at Tower of Hanoi.");
                
                while (j == 1)
                {
                    Console.Write("Would you like your disks to start on peg 1, 2, or 3: ");
                    from = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();
                    if ((from < 1) || (from > 3))
                    {
                        Console.WriteLine("Invalid input");
                        Console.WriteLine();
                    }
                    else
                        j = 2;
                }
                while (j == 2)
                {
                    Console.Write("Would you like to end on peg ");
                    if (from == 1)
                    {
                        Console.Write("2 or 3: ");
                        to = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine();
                        if (to == Convert.ToInt32(2))
                        xtra = Convert.ToInt32(3);
                    else
                        xtra = Convert.ToInt32(2);
                    }
                    if (from == Convert.ToInt32(2))
                    {
                        Console.Write("1 or 3: ");
                        to = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine();
                        if (to == Convert.ToInt32(1))
                            xtra = Convert.ToInt32(3);
                        else
                            xtra = Convert.ToInt32(1);
                    }
                    if (from == Convert.ToInt32(3))
                    {
                        Console.Write("1 or 2: ");
                        to = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine();
                        if (to == Convert.ToInt32(1))
                            xtra = Convert.ToInt32(2);
                        else
                            xtra = Convert.ToInt32(1);
                    }
                    if ((to < 1) || (to > 3))
                    {
                        Console.WriteLine("Invalid input");
                        Console.WriteLine();
                    }
                    else
                        j = 3;
                }
                while (j == 3)
                {
                    Console.Write("Enter number of disks: ");
                    x = Int32.Parse(Console.ReadLine());
                    Console.WriteLine();
                    if (x <= 0)
                    {
                        Console.WriteLine("Invalid input");
                        Console.WriteLine();
                    }
                    else
                        j = 4;
                }
                
                {
                    process(x, from, to, xtra);
                    Console.WriteLine();
                    Console.Write("Would you like to enter a new number? (1 = yes, 2 = no): ");
                    i = Convert.ToInt32(Console.ReadLine());
                    j = i;
                    Console.WriteLine();
                }

            }
        }
        static void process(int x, int from, int to, int xtra)
        {
            if (x > 0)
            {
                process(x - 1, from, xtra, to);
                moveinfo(x, from, to);
                process(x - 1, xtra, to, from);
            }
        }
        static void moveinfo(int x, int from, int to)
        {
            Console.WriteLine("Move disk "+x+" from peg "+from+" to peg "+to);
        }
    }
}


