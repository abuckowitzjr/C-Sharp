using System;

public class SalaryCalculator
{
    int hoursworked; //declares hoursworked variable
    decimal hourlyrate; //declares hourlyrate variable

    public SalaryCalculator(string empname, int hoursworked, decimal hourlyrate) //constructor
    {
        EmpName = empname; //passes info to EmpName property
        HoursWorked = hoursworked; //passes info to HoursWorked property
        HourlyRate = hourlyrate; //passes info to HourlyRate property
        Grosspay = CalcGrossPay(HoursWorked, HourlyRate); //passes info to GrossPay property
    }
    public string EmpName { get; set; } //EmpName property

    public decimal Grosspay { get; set; } //GrossPay property

    public int HoursWorked //HoursWorked property
    {
        get
        { return hoursworked; }
        set
        { hoursworked = value; }
    }

    public decimal HourlyRate //HourlyRate property
    {
        get
        { return hourlyrate; }
        set
        { hourlyrate = value; }
    }

    public decimal CalcGrossPay(int hoursworked, decimal hourlyrate) //method for calculating grosspay
    {
        decimal grosspay = 0; //declares grosspay variable
        int overtimehours = 0; //declares overtimehours variable
        decimal overtimerate = 0; //declares overtimerate variable
        overtimerate = hourlyrate / 2 + hourlyrate; //calculates rate for overtime pay
        if (hoursworked > 40) //checks hoursworked to see if overtime hours were worked
        {
            overtimehours = hoursworked - 40; //determines how many overtime hours were worked
            grosspay = 40 * hourlyrate + overtimehours * overtimerate; //calculates grosspay with overtime work
        }
        if (hoursworked <= 40) //checks hoursworked to see if no overtime hours were worked
            grosspay = Convert.ToDecimal(hoursworked) * hourlyrate; //calculates grosspay for regular hours worked
            return grosspay; //returns result
    }
}