using System;

public class MilesPerGallon
{
    decimal mpg; //declares mpg variable

    public MilesPerGallon(decimal miles, decimal gallons)
    {
        MilesDriven = miles; //set MilesDriven property with miles
        GallonsUsed = gallons; //set GallonUsed property with gallons
        MPG = CalculateMPG(MilesDriven, GallonsUsed); //sets MPG via the CalculateMPG method
    }
   
    public decimal MilesDriven { get; set; } //property for MilesDriven

    public decimal GallonsUsed { get; set; } //property for GallonsUsed

    public decimal MPG //property for MPG
    {
        get
    {
            return mpg;
        }
        set
        {
            mpg = value;
        }
    } 

    public decimal CalculateMPG(decimal miles, decimal gallons) //method to calculate miles per gallon
    {
        decimal mpg;
        mpg = miles / gallons;
        return mpg;
    }
}