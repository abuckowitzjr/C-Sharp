//Fig. 4.1: GradeBook.cs
using System;

public class GradeBook
{
    //auto-implemented properties CourseName and InstructorName implicitly created an
    //instance variable for this GradeBook's course name and instructor name
    public string CourseName { get; set; }
    public string InstructorName { get; set; }
    //constructor initializes auto-implemented property
    //CourseName with string and InstructorName with string supplied as argument
    public GradeBook(string coursename, string instructorname)
    {
        CourseName = coursename; //set CourseName to name
        InstructorName = instructorname;
    }//end constructor
}//end class GradeBook
