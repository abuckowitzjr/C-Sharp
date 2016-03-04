using System;
using System.Timers;

public class CommissionEmployee : Employee
{
    private decimal grossSales;
    private decimal commissionRate;
    private int _birthMonth;

    public CommissionEmployee(string first, string last, string ssn, int birthMonth, int birthDay, int birthYear, decimal sales, decimal rate)
        : base(first, last, ssn, birthMonth, birthDay, birthYear)
    {
        GrossSales = sales;
        CommissionRate = rate;
        BirthMonth = birthMonth;
    }

    public int BirthMonth
    {
        get
        {
            return _birthMonth;
        }
        private set
        {
            _birthMonth = value;
        }
    }

    public decimal GrossSales
    {
        get
        {
            return grossSales;
        }
        set
        {
            if (value >= 0)
                grossSales = value;
            else
                throw new ArgumentOutOfRangeException("GrossSales", value, "GrossSales must be >= 0");
        }
    }

    public decimal CommissionRate
    {
        get
        {
            return commissionRate;
        }
        set
        {
            if (value > 0 && value < 1)
                commissionRate = value;
            else
                throw new ArgumentOutOfRangeException("CommissionRate", value, "CommissionRate must be > 0 and < 1");
        }
    }

    public override decimal Earnings()
    {
        if (BirthMonth == DateTime.Now.Month)
            return (CommissionRate * GrossSales) + 100;
        else
            return CommissionRate * GrossSales;
    }

    public override string ToString()
    {
        return string.Format("{0}: {1}\n{2}: {3:C}\n{4}: {5:F2}", "commission employee", base.ToString(), "gross sales", GrossSales, "commission rate", CommissionRate);
    }
}