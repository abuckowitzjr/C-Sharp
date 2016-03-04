//Fig. 4.15: Account.cs
//Account class with a constructor to
//intialize instance variable balance.

public class Account
{
    private decimal balance; //instance variable that stores the balance

    //constructor
    public Account(decimal initialBalance)
    {
        Balance = initialBalance; //set balance using property
    } //end Account constructor

    ////credit (add) an amount to the account
    //public void Credit(decimal amount)
    //{
    //    Balance = Balance + amount; //add amount to balance
    //} //end method Credit

    //debit (subtract) an amount from the account
    public void Debit(decimal amount)
    {
        Balance = Balance - amount; //debits amount from balance
    } //end method Debit

    //a property to get and set the account balance
    public decimal Balance
    {
        get
        {
            return balance;
        } //end get
        set
        {
            //validate that the value is greater than or equal to 0;
            //if it is not, balance is left unchanged
            if (value >= 0)
                balance = value;
        } //end set
    } //end property Balance
} //end class Account