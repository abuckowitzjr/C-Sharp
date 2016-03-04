using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSHARP_Chapter_11_Exercise_11._9
{
    class AccountApplication
    {
        static void Main(string[] args)
        {
            decimal _initbalance = 0;
            decimal _intrate = 0;
            decimal _feeamount = 0;
            int i = 0;
            int j = 0;

            Console.WriteLine("Enter required information to create new account.");
            Console.Write("Enter initial balance: ");
            _initbalance = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Enter interest rate: ");
            _intrate = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Enter fee for transactions: ");
            _feeamount = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("\nAccount created succcessfully.\n");


            while (j == 0)
            {
                Console.WriteLine("Would you like to access Savings or Checking Account?");
                Console.Write("(Enter 1 for Savings, 2 for Checking): ");
                i = Convert.ToInt32(Console.ReadLine());
                while (i == 1)
                {
                    SavingsAccount s1 = new SavingsAccount(_initbalance, _intrate);





                }

                while (i == 2)
                {
                    CheckingAccount c1 = new CheckingAccount(_initbalance, _feeamount);



                }
            }


        }
    }
}
