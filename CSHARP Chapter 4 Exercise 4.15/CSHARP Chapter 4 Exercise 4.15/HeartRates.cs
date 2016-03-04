using System;

public class HeartRates
{
    private int yearofbirth; //declares yearofbirth variable
    private int currentyear; //declares currentyear variable
    private int maxhr; //declares maxhr variable
    
    public HeartRates(string firstname, string lastname, int birthyear, int currentyear) //constructor
    {
        FirstName = firstname; //uses FirstName property for instance first name
        LastName = lastname; //uses LastName property for instance last name
        YearOfBirth = yearofbirth; //uses YearOfBirth property for instance year of birth
        CurrentYear = currentyear; //uses CurrentYear property for instance current year
        TesterAge = Age(birthyear, currentyear); //uses TesterAge property for instance test age
        MHR = MaxHeartRate(TesterAge); //uses MHR property for instance max heart rate
        MinTRate = MinTargetRate(maxhr); //uses MinTRate property for instance min target rate
        MaxTRate = MaxTargetRate(maxhr); //uses MaxTRate property for instance max target rate
    } //end constructor

    public decimal MaxTRate { get; set; } //MaxTRate property

    public decimal MinTRate { get; set; } //MinTRate property

    public int MHR //MHR property
    {
        get
        { return maxhr; }
        set
        {maxhr = value;}}

    public int TesterAge { get; set; } //TesterAge property

    public string FirstName { get; set; } //FirstName property

    public string LastName { get; set; } //LastName property

    public int YearOfBirth // YearOfBirth property
    {get
        {return yearofbirth;}
        set
        {yearofbirth = value;}}

    public int CurrentYear //CurretnYear property
    {get
        {return currentyear;}
        set
        {currentyear = value;}}

    public int Age(int birthyear, int presentyear) //method for calculating testers age
    {
        int age;
        age = presentyear - birthyear;
        return age;
    }

    public int MaxHeartRate(int age) //method for calculating max heart rate
    {
        int MHR;
        MHR = 220 - age;
        return MHR;
    }

    public int MinTargetRate(int maxheart) //method for calculating min target rate
    {
        int MinTR;
        MinTR = maxheart * 50 / 100;
        return MinTR;
    }

    public int MaxTargetRate(int maxheart) //method for calculating max target rate
    {
        int MaxTR;
        MaxTR = maxheart * 85 / 100;
        return MaxTR;
    }







}