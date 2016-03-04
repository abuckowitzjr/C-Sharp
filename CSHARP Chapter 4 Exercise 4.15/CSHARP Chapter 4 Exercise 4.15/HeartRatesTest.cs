using System;


public class HeartRatesTest
    {
        static void Main(string[] args)
        {
            string FirstName; //declares FirstName variable
            string LastName; //declares LastName variable
            int BirthYear; //declares BirthYear variable
            int CurrentYear; //declares CurrentYear variable
            
            Console.Write("Enter your first name: "); //write message asking for user input for first name
            FirstName = Console.ReadLine(); //stores user input for first name in first name variable
            Console.Write("Enter your last name: "); //write message asking for user input for last name
            LastName = Console.ReadLine(); //store user input for last name in last name variable
            Console.Write("Enter your year of birth: "); //write message asking for user input for year of birth
            BirthYear = Convert.ToInt32(Console.ReadLine()); //stores user input for year of birth in year of birth variable
            Console.Write("Enter the current year: "); //writes message asking for user input for current year
            CurrentYear = Convert.ToInt32(Console.ReadLine()); //store user input for current year in current year variable

            HeartRates heartrate1 = new HeartRates(FirstName, LastName, BirthYear, CurrentYear); //creates an instance of heart rates

            Console.WriteLine(); //writes blank line
            Console.WriteLine("First Name: {0}", heartrate1.FirstName); //writes first name of tester
            Console.WriteLine("Last Name: {0}", heartrate1.LastName); //writes last name of tester
            Console.WriteLine("Age: {0}", heartrate1.TesterAge); //writes age of tester
            Console.WriteLine("Maximum Heart Rate: {0}", heartrate1.MHR); //writes max heart rate of tester
            Console.WriteLine("Minimum Target Rate: {0}", heartrate1.MinTRate); //writes min target rate of tester
            Console.WriteLine("Maximum Target Rate: {0}", heartrate1.MaxTRate); //writes max target rate of tester
        }
    }

