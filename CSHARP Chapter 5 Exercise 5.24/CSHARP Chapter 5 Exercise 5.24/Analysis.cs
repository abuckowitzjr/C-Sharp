//Fig. 5.12: Analysis.cs
//Analysis of examination results, using nested control statements.
using System;

namespace CSHARP_Chapter_5_Exercise_5._24
{
    class Analysis
    {
        public static void Main(string[] args)
        {
            //initialize variables in declarations
            int passes = 0; //number of passes
            int failures = 0; //number of failures
            int studentCounter = 1; //student counter
            int result; //one exam result from user

            //process 10 students using counter-controlled reptition
            while (studentCounter <= 10)
            {
                //prompt user for input and obtain a value from the user
                Console.Write("Enter result (1 = pass, 2 = fail): ");
                result = Convert.ToInt32(Console.ReadLine());
                if ((result < 1) || (result > 2)) //checks if input is valid number, if anything other than 1 or 2, displays error message
                    Console.WriteLine("Invalid Input");
                else
                {
                    //if...else nested in while
                    if (result == 1) //if result 1
                        passes = passes + 1; //increment passes
                    else //else result is not 1, so
                        failures = failures + 1; //increment failures

                    //increment studentCounter so loop eventually terminates
                    studentCounter = studentCounter + 1;
                }
            } //end while
            //termination phase; prepare and display results
            Console.WriteLine("Passed: {0}\nFailed: {1}", passes, failures);

            //determines whether more than 8 students passed
            if (passes > 8)
                Console.WriteLine("Bonus to instructor!");
        } //end main
    } //end class Analysis
}
