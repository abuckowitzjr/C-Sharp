using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSHARP_Chapter_8_Exercise_8._20
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int[ , ] sales = new int[3,5];
            int empid = 0;
            int productnum = 0;
            int totalsales = 0;
            int prodtot = 0;
            int emp1totsales = 0;
            int emp2totsales = 0;
            int emp3totsales = 0;
            int input = 1;

            while (input == 1)
            {   
                Console.Write("Enter salesperson ID number: ");
                empid = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter product number: ");
                productnum = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter total sales: ");
                totalsales = Convert.ToInt32(Console.ReadLine());

                sales[empid -1, productnum -1] += totalsales;

                Console.WriteLine("\nWould you like to enter more, or display results?");
                Console.Write("(Enter 1 to continue, 2 to show results): ");
                input = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
            }
            while (input == 2)
            {
                Console.WriteLine("Total sales of each product by salesperson ID\n");
                Console.WriteLine("        Sales ID#");
                for (int ID = 1; ID <= 3; ID++)
                {
                    if (ID == 1)
                    Console.Write("      {0}", ID);
                    else
                    Console.Write("     {0}", ID);
                }
                for (int pid = 0; pid <= 4; pid++)
                {
                    if (pid == 0)
                        Console.Write("\n{0}     ", pid + 1);
                    else
                        Console.Write("{0}     ", pid + 1);
                    for (int emp = 0; emp <= 2; emp++)
                    {
                        prodtot += sales[emp, pid];
                        if (emp == 2)
                        {
                            Console.Write("{0}     {1}\n", sales[emp, pid], prodtot);
                            prodtot = 0;
                        }
                        else
                            Console.Write("{0}     ", sales[emp, pid]);
                    }
                    emp1totsales += sales[0, pid];
                    emp2totsales += sales[1, pid];
                    emp3totsales += sales[2, pid];
                }
                Console.WriteLine("      {0}     {1}     {2}", emp1totsales, emp2totsales, emp3totsales);
                input = 3;
            }
        }
    }
}


