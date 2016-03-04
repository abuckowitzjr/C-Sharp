//Fig. 4.2: GradeBookTest.cs//
//GradeBook constructor used to specify the course name and instructor name at the
//time each GradeBook object is created.
using System;

public class GradeBookTest
{
    //Main method begins program execution
    public static void Main(string[] args)
    {
        //create GradeBook object
        GradeBook gradeBook1 = new GradeBook( //invokes constructor
            "CS101 Introduction to C# Programming", "Arthur Buckowitz");
//display initial value of courseName and instructorname for GradeBook
        Console.WriteLine("Welcome to the Grade Book for\n{0}!",
            gradeBook1.CourseName);
        Console.WriteLine("This course is presented by: {0}",
            gradeBook1.InstructorName);
        }//end Main
}//end class GradeBookTest