using System;
using System.Timers;

public class SalariedEmployee : Employee
{
    private decimal weeklySalary;
    private int _birthMonth;

    public SalariedEmployee(string first, string last, string ssn, int birthMonth, int birthDay, int birthYear, decimal salary)
        : base(first, last, ssn, birthMonth, birthDay, birthYear)
    {
        WeeklySalary = salary;
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

    public decimal WeeklySalary
    {
        get
        {
            return weeklySalary;
        }
        set
        {
            if (value >= 0)
                weeklySalary = value;
            else
                throw new ArgumentOutOfRangeException("WeeklySalary", value, "WeeklySalary must be >= 0");
        }
    }

    public override decimal Earnings()
    {
        if (BirthMonth == DateTime.Now.Month)
            return WeeklySalary + 100;
        else
            return WeeklySalary;
    }

    public override string ToString()
    {
        return string.Format("salaried employee: {0}\n{1}: {2:C}", base.ToString(), "weekly salary", WeeklySalary);
    }
}