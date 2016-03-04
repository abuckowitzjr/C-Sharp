using System;

public class Account
{
    decimal _accblnc = 0;

    public Account(decimal initbalance)
    {
        Balance = initbalance;
    }

    public bool DebitOccured { get; set; }

    public decimal Balance
    {
        get
        {
            return _accblnc;
        }
        private set
        {
            if (value >= 0)
                _accblnc = value;
            else
                throw new ArgumentOutOfRangeException("Initial balance cannot be less than 0.");
        }
    }

    public decimal CalcCredit(decimal originalbalance, decimal creditamount)
    {
        decimal result;
        result = originalbalance + creditamount;
        return result;
    }

    public bool DebitCheck(decimal originalbalance, decimal debitamount)
    {
        bool result;
        if (debitamount > originalbalance)
        {
            Console.WriteLine("Debit amount exceeded account balance.");
            result = false;
            return result;
        }
        else
        {
            result = true;
            return result;
        }
    }
    public decimal CalcDebit(decimal originalbalance, decimal debitamount)
    {
        decimal result;
        if (debitamount > originalbalance)
        {
            Console.WriteLine("Debit amount exceeded account balance.");
            result = 0;
            return result;
        }
        else
        {
            result = originalbalance - debitamount;
            return result;
        }
    }








}