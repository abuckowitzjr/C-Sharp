using System;

public class BasePlusCommissionEmployee : CommissionEmployee
{
    private decimal baseSalary;
    private int _birthMonth;

    public BasePlusCommissionEmployee(string first, string last, string ssn, int birthMonth, int birthDay, int birthYear, decimal sales, decimal rate, decimal salary)
        : base(first, last, ssn, birthMonth, birthDay, birthYear, sales, rate)
    {
        BaseSalary = salary;
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

    public decimal BaseSalary
    {
        get
        {
            return baseSalary;
        }
        set
        {
            if (value >= 0)
                baseSalary = value;
            else
                throw new ArgumentOutOfRangeException("BaseSalary", value, "BaseSalary must be >= 0");
        }
    }

    public override decimal Earnings()
    {
        if (BirthMonth == DateTime.Now.Month)
            return BaseSalary + 100 + base.Earnings();
        else
            return BaseSalary + base.Earnings();
    }

    public override string ToString()
    {
        return string.Format("base-salaried {0}; base salary: {1:C}", base.ToString(), BaseSalary);
    }



}