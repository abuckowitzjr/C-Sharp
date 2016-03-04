using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSHARP_Chapter_5_Exercise_5._20
{
    class SalaryCalculatorTest
    {
        static void Main(string[] args)
        {
            int HoursWorked; //declares HoursWorked variable
            decimal HourlyRate; //declares HourlyRate variable
            int sentinel = 1; //declares sentinel variable
            string EmpName; //declares EmpName variable

            while (sentinel < 4) //checks value of sentinel to see if program should continue
            {
                Console.Write("Enter employee name: "); //writes message asking for user input for employee name
                EmpName = Console.ReadLine(); //stores user input for employee name in employee name variable
                Console.Write("Enter hours worked: "); //writes message asking for user input for hours worked
                HoursWorked = Convert.ToInt32(Console.ReadLine()); //stores user input for hours worked into hours worked variable
                Console.Write("Enter hourly rate: "); //writes message asking for user input for hourly rate
                HourlyRate = Convert.ToDecimal(Console.ReadLine()); //stores user input for hourly rate into hourly rate variable
                SalaryCalculator salarycalculator1 = new SalaryCalculator(EmpName, HoursWorked, HourlyRate); //creates instance of salarycalculator for emp 1
                sentinel = sentinel + 1; //adds one to sentinel variable
                Console.WriteLine(); //writes blank line
                Console.Write("Enter employee name: "); //writes message asking for user input for employee name
                EmpName = Console.ReadLine(); //stores user input for employee name in employee name variable
                Console.Write("Enter hours worked: "); //writes message asking for user input for hours worked
                HoursWorked = Convert.ToInt32(Console.ReadLine()); //stores user input for hours worked into hours worked variable
                Console.Write("Enter hourly rate: "); //writes message asking for user input for hourly rate
                HourlyRate = Convert.ToDecimal(Console.ReadLine()); //stores user input for hourly rate into hourly rate variable
                SalaryCalculator salarycalculator2 = new SalaryCalculator(EmpName, HoursWorked, HourlyRate); //creates instance of salarycalculator for emp 2
                sentinel = sentinel + 1; //adds one to sentinel variable
                Console.WriteLine(); //writes blank line
                Console.Write("Enter employee name: "); //writes message asking for user input for employee name
                EmpName = Console.ReadLine(); //stores user input for employee name in employee name variable
                Console.Write("Enter hours worked: "); //writes message asking for user input for hours worked
                HoursWorked = Convert.ToInt32(Console.ReadLine()); //stores user input for hours worked into hours worked variable
                Console.Write("Enter hourly rate: "); //writes message asking for user input for hourly rate
                HourlyRate = Convert.ToDecimal(Console.ReadLine()); //stores user input for hourly rate into hourly rate variable
                SalaryCalculator salarycalculator3 = new SalaryCalculator(EmpName, HoursWorked, HourlyRate); //creates instance of salarycalculator for emp 3
                sentinel = sentinel + 1; //adds one to sentinel variable
                Console.WriteLine(); //writes blank line
                Console.WriteLine("Employee Name: {0}", salarycalculator1.EmpName); //displays emp 1 name
                Console.WriteLine("Hours Worked: {0}", salarycalculator1.HoursWorked); //displays emp 1 hours worked
                Console.WriteLine("Hourly Rate: {0:C}", salarycalculator1.HourlyRate); //displays emp 1 hourly rate
                Console.WriteLine("Gross Pay: {0:C}", salarycalculator1.Grosspay); //displays emp 1 grosspay
                Console.WriteLine(); //writes blank line
                Console.WriteLine("Employee Name: {0}", salarycalculator2.EmpName); //displays emp 2 name
                Console.WriteLine("Hours Worked: {0}", salarycalculator2.HoursWorked); //displays emp 2 hours worked
                Console.WriteLine("Hourly Rate: {0:C}", salarycalculator2.HourlyRate); //display emp 2 hourly rate
                Console.WriteLine("Gross Pay: {0:C}", salarycalculator2.Grosspay); //displays emp 2 grosspay
                Console.WriteLine(); //writes blank line
                Console.WriteLine("Employee Name: {0}", salarycalculator3.EmpName); //displays emp 3 name
                Console.WriteLine("Hours Worked: {0}", salarycalculator3.HoursWorked); //displays emp 3 hours worked
                Console.WriteLine("Hourly Rate: {0:C}", salarycalculator3.HourlyRate); //displays emp 3 hourly rate
                Console.WriteLine("Gross Pay: {0:C}", salarycalculator3.Grosspay); //display emp 3 grosspay
            }
        }
    }
}
