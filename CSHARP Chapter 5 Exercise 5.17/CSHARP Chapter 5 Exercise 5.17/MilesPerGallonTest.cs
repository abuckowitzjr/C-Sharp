using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSHARP_Chapter_5_Exercise_5._17
{
    class MilesPerGallonTest
    {
        
        public static void Main(string[] args)
        {
            decimal MilesDriven; //declares MilesDriven variable
            decimal GallonsUsed; //declares GallonsUsed variable
            int sentinel = 1; //declares sentinel variable
            decimal avgmpg = 0; //declares avgmpg variable
            decimal totalmpg = 0; //declares totalmpg variable
            int count = 0; //declares count variable

            while (sentinel == 1) //loop that looks for input from user to add another set of information, or not
                {
                    Console.Write("Enter miles driven: "); //writes message asking for use input for miles driven
                    MilesDriven = Convert.ToDecimal(Console.ReadLine()); //stores user input for miles driven into MilesDriven variable
                    Console.Write("Enter gallons of gas used: "); //writes message asking for user input for gallons of gas used
                    GallonsUsed = Convert.ToDecimal(Console.ReadLine()); //stores user input for gallons used into the GallonsUsed variable
                    MilesPerGallon milespergallon1 = new MilesPerGallon(MilesDriven, GallonsUsed); //creates new instance of MilePerGallon
                    count = count + 1; //tracks how many tankfuls have been entered by the user
                    totalmpg = totalmpg + milespergallon1.MPG; //calculates total mpg for all tankfuls input
                    Console.WriteLine(); //writes empty line
                    Console.WriteLine("Miles Per Gallon for tankful: {0:F}", milespergallon1.MPG); //displays miles per gallon for input tankful
                    Console.WriteLine(); //writes empty line
                    Console.Write("Do you wish to calculate more? (Enter 1 for yes, 2 for no): "); //writes message asking for user input for continue or not
                    sentinel = Convert.ToInt32(Console.ReadLine()); //stores user input for sentinel into setinel variable
                    Console.WriteLine(); //writes empty line
                    avgmpg = totalmpg / count; //calculates avg for all tankfuls based on totalmpg and count
                }

                Console.WriteLine("Average Miles Per Gallon for all tankfuls: {0:F}", avgmpg); //if user chooses not to continue, displays average mpg for all tankfuls
        }
    }
}


