using System;

public abstract class Employee
{
    private string birthDate;
    private int month;
    private int day;
    private int year;

    public int Month { get; private set; }

    public int Day { get; private set; }

    public int Year { get; private set; }

    public string BirthDate { get; private set; }

    public string FirstName { get; private set; }

    public string LastName { get; private set; }

    public string SocialSecurityNumber { get; private set; }

    public Employee(string first, string last, string ssn, int birthMonth, int birthDay, int birthYear)
    {
        FirstName = first;
        LastName = last;
        SocialSecurityNumber = ssn;
        Month = birthMonth;
        Day = birthDay;
        Year = birthYear;
        Date empbirthday = new Date(Month, Day, Year);
        BirthDate = empbirthday.ToString();
    }

    public override string ToString()
    {
        return string.Format("{0} {1}\nsocial security number: {2}\ndate of birth: {3}", FirstName, LastName, SocialSecurityNumber, BirthDate );
    }

    public abstract decimal Earnings();
}