using System;
public class Date
{
    private int month;
    private int day;
    private int year;
    private int[] daysPerMonth = { 0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

    public int Year 
    {
        get
        {
            return year;
        }
        private set
        {
            if (value <= DateTime.Now.Year)    
                year = value;
            else
                throw new ArgumentOutOfRangeException("Year", value, "Year must be less than or equal to " + DateTime.Now.Year);
        }
    }

    public Date(int theMonth, int theDay, int theYear)
    {
        Month = theMonth;
        Year = theYear;
        Day = theDay;
        Console.WriteLine("Date object constructor for date {0}", this);
    }
    public int Month
    {
        get
        {
            return month;
        }
        private set
        {
            if (value > 0 && value <= 12)
                month = value;
            else
                throw new ArgumentOutOfRangeException("Month", value, "Month must be 1-12");
        }
    }
    public int Day
    {
        get
        {
            return day;
        }
        private set
        {
            if (value > 0 && value <= daysPerMonth[Month])
                day = value;
            else if (Month == 2 && value == 29 && (Year % 400 == 0 || (Year % 4 == 0 && Year % 100 != 0)))
                day = value;
            else
                throw new ArgumentOutOfRangeException("Day", value, "Day out of range for current month/year");
        }
    }
    public override string ToString()
    {
        return string.Format("{0}/{1}/{2}", Month, Day, Year);
    }

    public void NextDay()
    {
        if (day == daysPerMonth[Month])
            Day = 1;
        else 
            if (day + 1 > 0 && day + 1 <= daysPerMonth[Month])
                Day += 1;
    }
    public void NextMonth()
    {
        if (Month == 12)
            Month = 1;
        else
            if (Month + 1 > 0 && Month + 1 < 12)
                Month += 1;
    }
    public void NextYear()
    {
        if (Year < DateTime.Now.Year)
            Year += 1;
    }
}