using System;

public class CreditLimitCalculator
{
    decimal beginbalance; //declares beginbalance variable
    decimal totalcharged; //declares totalcharged variable
    decimal totalcredits; //declares totalcredits variable

    public CreditLimitCalculator(int accountnumber, decimal beginbalance, decimal totalcharged, decimal totalcredits, decimal creditlimit) //constructor
    {
    BeginningBalance = beginbalance; //passes info to beginningbalance property
    TotalCharged = totalcharged; //passes info to totalcharged property
    TotalCredits = totalcredits; //passes info to totalcredits property
    TotalBalance = CalcTotalBalance(BeginningBalance, TotalCharged, TotalCredits); //passes info to totalbalance via calctotalbalance method 
    AccountNumber = accountnumber;
    CreditLimit = creditlimit;
    }
    public int AccountNumber { get; set; }

    public decimal CreditLimit { get; set; }

    public decimal TotalBalance { get; set; } //TotalBalance property

    public decimal BeginningBalance //BeginningBalance property
    {
    get
    {return beginbalance;}
    set
    {beginbalance = value;}}

    public decimal TotalCharged //TotalCharged property
    {
        get
        { return totalcharged; }
        set
        {totalcharged = value;}}

    public decimal TotalCredits //TotalCredits property
    {
        get
        { return totalcredits; }
        set
        { totalcredits = value; }
    }

    public decimal CalcTotalBalance(decimal beginbalance, decimal totalcharged, decimal totalcredits) //method to calculate totalbalance
    {
        decimal totalbalance;
            totalbalance = beginbalance + TotalCharged - totalcredits;
            return totalbalance;
    }
}

