//Fig. 4.16: AccountTest.cs
//Create and manipulate Account objects
using System;

public class AccountTest
{
    //Main method begins execution of C# application
    public static void Main(string[] args)
    {
        Account account1 = new Account(50.00M); //create Account object
        Account account2 = new Account(25.00M); //create Account object

        //display initial balance of each object using a property
        Console.WriteLine("account1 balance: {0:C}",
            account1.Balance); //display Balance property
        Console.WriteLine("account2 balance: {0:C}",
            account2.Balance); //display Balance property

        decimal withdrawlAmount; //withdrawl amount read from user

        //prompt and obtain user input
        Console.Write("Enter debit amount for account1: ");
        withdrawlAmount = Convert.ToDecimal(Console.ReadLine());
   
        if (withdrawlAmount > account1.Balance)
            Console.WriteLine("Debit amount exceeded account balance.");
        if (withdrawlAmount <= account1.Balance)
            Console.WriteLine("Withdrawing {0:C} from account1 balance\n",
                   withdrawlAmount);
            account1.Debit(withdrawlAmount); //add to account1 balance)
        
        //display balances
        Console.WriteLine("account1 balance: {0:C}",
            account1.Balance);
        Console.WriteLine("account2 balance: {0:C}",
            account2.Balance);

        //prompt and obtain user input
        Console.Write("Enter debit amount for account2: ");
        withdrawlAmount = Convert.ToDecimal(Console.ReadLine());
        if (withdrawlAmount > account2.Balance)
            Console.WriteLine("Debit amount exceeded account balance.");
        if (withdrawlAmount <= account2.Balance)
            Console.WriteLine("Withdrawing {0:C} from account2 balance\n",
                withdrawlAmount);
            account2.Debit(withdrawlAmount); //add to account2 balance

        //display balances
        Console.WriteLine("account1 balance: {0:C}", account1.Balance);
        Console.WriteLine("account2 balance: {0:C}", account2.Balance);
    }//end Main
}//end class AccountTest