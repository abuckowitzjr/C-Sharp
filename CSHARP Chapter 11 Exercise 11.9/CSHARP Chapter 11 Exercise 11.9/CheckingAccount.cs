using System;

public class CheckingAccount : Account
{
    decimal _feecharged = 0;
    decimal _finalbalance = 0;
    decimal _initbalance = 0;

    public CheckingAccount(decimal initbalance, decimal feeamount) : base(initbalance)
    {
        FeeAmount = feeamount;
        InitialBalance = initbalance;

    }

    public decimal InitialBalance { get; set; }

    public decimal FinalBalance { get; set; }

    public decimal FeeAmount { get; set; }

    public decimal Debit(decimal balance, decimal debitamount)
    {
        decimal result;
        if (

        return result;
    }





}