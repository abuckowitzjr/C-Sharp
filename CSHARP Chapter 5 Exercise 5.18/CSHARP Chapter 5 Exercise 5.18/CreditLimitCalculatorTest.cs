using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSHARP_Chapter_5_Exercise_5._18
{
    class CreditLimitCalculatorTest
    {
        static void Main(string[] args)
        {
            int AccountNumber; //declares accountnumber variable
            decimal BeginBalance; //declares beginbalance variable
            decimal TotalCharges; //declares totalcharges variable
            decimal TotalCredits; //declares totalcredits variable
            decimal CreditLimit = 0; //declares creditlimit variable
            int sentinel = 1; //declares sentinel variable

            while (sentinel == 1) //checks sentinel variable on whether to continue with new account or quit
            {
                Console.Write("Enter account number: "); //writes message asking for user input for account number
                AccountNumber = Convert.ToInt32(Console.ReadLine()); //stores user input for account number into account number variable
                Console.Write("Enter balance at the beginning of the month: "); //write message asking for user input for beginning balance
                BeginBalance = Convert.ToDecimal(Console.ReadLine()); //stores user input for beginning balance into beginning balance variable
                Console.Write("Enter total monthly charges: "); //writes message asking for user input for total monthly charges
                TotalCharges = Convert.ToDecimal(Console.ReadLine()); //stores user input for total monthly charges into total monthly charges variable
                Console.Write("Enter total monthly credits: "); //writes message asking for user input for total monthly credits
                TotalCredits = Convert.ToDecimal(Console.ReadLine()); //stores user input for total monthly credits into total monthly credits variable
                Console.Write("Enter credit limit: "); //writes message asking for user input for credit limit
                CreditLimit = Convert.ToDecimal(Console.ReadLine()); //stores user input for credit limit into credit limit variable
                CreditLimitCalculator creditlimitcalculator1  = new CreditLimitCalculator(AccountNumber, BeginBalance, TotalCharges, TotalCredits, CreditLimit); //creates new instance of creditlimitcalculator
                Console.WriteLine(); //write blank line
                Console.WriteLine("Account Number: {0}", creditlimitcalculator1.AccountNumber); //displays account number
                Console.WriteLine("Beginning Balance: {0:C}", creditlimitcalculator1.BeginningBalance); //displays beginning balance
                Console.WriteLine("Total Charges: {0:C}", creditlimitcalculator1.TotalCharged); //displays total monthly charges
                Console.WriteLine("Total Credits: {0:C}", creditlimitcalculator1.TotalCredits); //displays total monthly credits
                Console.WriteLine("Credit Limit: {0:C}", creditlimitcalculator1.CreditLimit); //displays credit limit
                Console.WriteLine(); //writes blank line
                if (creditlimitcalculator1.TotalBalance <= CreditLimit) //check to see if balance is less than credit limit
                    Console.WriteLine("Total available credit: {0:C}", CreditLimit - creditlimitcalculator1.TotalBalance); //displays available credit
                if (creditlimitcalculator1.TotalBalance > CreditLimit) //checks to see if balance exceeds credit limit
                    Console.WriteLine("Credit limit exceeded"); //displays that the balance exceeds the credit limit
                Console.WriteLine(); //write blank line
                Console.Write("Enter 1 to enter new account, Enter 2 to quit: "); //writes message asking if user wishes to proceed to new account or quit
                sentinel = Convert.ToInt32(Console.ReadLine()); //stores user input for selection into sentinel
                Console.WriteLine(); //writes blank line
                }
               }
            }
        }
  