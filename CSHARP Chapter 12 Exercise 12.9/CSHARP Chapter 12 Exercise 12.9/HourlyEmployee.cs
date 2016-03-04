using System;
using System.Timers;

public class HourlyEmployee : Employee
{
    private decimal wage;
    private decimal hours;
    private int _birthMonth;

    public HourlyEmployee(string first, string last, string ssn, int birthMonth, int birthDay, int birthYear, decimal hourlyWage, decimal hoursWorked)
        : base(first, last, ssn, birthMonth, birthDay, birthYear)
    {
        Wage = hourlyWage;
        Hours = hoursWorked;
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
    public decimal Wage
    {
        get
        {
            return wage;
        }
        set
        {
            if (value >= 0)
                wage = value;
            else
                throw new ArgumentOutOfRangeException("Wage", value, "Wage must be >= 0");
        }
    }

    public decimal Hours
    {
        get
        {
            return hours;
        }
        set
        {
            if (value >= 0)
                hours = value;
            else
                throw new ArgumentOutOfRangeException("Hours", value, "Hours must be >= 0 and <= 168");
        }
    }

    public override decimal Earnings()
    {
        if (Hours <= 40)
            if (BirthMonth == DateTime.Now.Month)
                return (Wage * Hours) + 100;
            else
                return Wage * Hours;
        else
            if (BirthMonth == DateTime.Now.Month)
                return (40 * Wage) + ((Hours - 40) * Wage * 1.5M) + 100;
            else
                return (40 * Wage) + ((Hours - 40) * Wage * 1.5M);
    }

    public override string ToString()
    {
        return string.Format("hourly employee: {0}\n{1}: {2:C}; {3}: {4:F2}", base.ToString(), "hourly wage", Wage, "hours worked", Hours);
    }
}