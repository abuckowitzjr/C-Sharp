using System;

public class SavingsAccount : Account
{
    decimal _intrate = 0;
    decimal _finalbalance = 0;

    public SavingsAccount(decimal initbalance, decimal interestrate) : base(initbalance)
    {
        InterestRate = interestrate;


    }

    public decimal FinalBalance
    {
        get
        {
            return _finalbalance;
        }
        private set
        {
            _finalbalance = value;
        }
    }

    public decimal InterestRate
    {
        get
        {
            return _intrate;
        }
        private set
        {
            _intrate = value;
        }
    }

    public decimal CalculateInterest(decimal accountbalance, decimal interestrate)
    {
        decimal result;
        result = interestrate * accountbalance;
        return result;
    }
}