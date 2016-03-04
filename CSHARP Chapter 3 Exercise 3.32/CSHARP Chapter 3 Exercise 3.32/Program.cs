using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSHARP_Chapter_3_Exercise_3._32
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal TotalMiles; //declares the totalmiles variable
            decimal CostPerGallon; //declare the costpergallon variable
            decimal AvgMilePerGallon; //declares the avgmilepergallon variable
            decimal ParkingFees; // declares the parkingfees variable
            decimal TollsPerDay; //declares the tollsperday variable
            decimal TotalCost; //declares the totalcost variable
            Console.Write("Enter total miles driven per day: "); //writes a message asking for user input for totalmiles
            TotalMiles = Convert.ToDecimal(Console.ReadLine()); //stores user input for totalmiles in totalmiles variable
            Console.Write("Enter cost per gallon of gasoline: $"); //writes a message asking for user input for costpergallon
            CostPerGallon = Convert.ToDecimal(Console.ReadLine()); //stores user input for costpergallon in costpergallon variable
            Console.Write("Enter average miles per gallon: "); //writes a message asking for user input for avgmilepergallon
            AvgMilePerGallon = Convert.ToDecimal(Console.ReadLine()); //stores user input for avgmilepergallon in avgmilepergallon variable
            Console.Write("Enter parking fees per day: $"); //writes a message asking for user input for parkingfees
            ParkingFees = Convert.ToDecimal(Console.ReadLine()); //store user input for parkingfees in parkingfees variable
            Console.Write("Enter tolls per day: $"); //writes a message asking for user input for tollsperday
            TollsPerDay = Convert.ToDecimal(Console.ReadLine()); //stores user input for tollsperday in tollsperday variable
            TotalCost = decimal.Round(((TotalMiles / AvgMilePerGallon) * CostPerGallon) + ParkingFees + TollsPerDay, 2); //calculates totalcost per day and stores in totalcost variable
            Console.WriteLine(""); //writes blank line
            Console.WriteLine("Your current cost per day is {0}", TotalCost.ToString("C")); //writes totalcost based on totalcost variable displaying in currency format
        }
    }
}
