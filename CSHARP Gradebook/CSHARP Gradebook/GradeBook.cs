//Fig. 4.1: GradeBook.cs
//GradeBook class with a constructor to initialize the course name.
using System;

public class GradeBook
{ 
    //auto-implemented property CourseName implicitly created an
    //instance variable for this GradeBook's course name
    public string CourseName{ get; set; }

    //constructor initializes auto-implemented property
    //CourseName with string supplied as argument
    public GradeBook( string name)
    {
        CourseName = name; //set CourseName to name
    }//end constructor
            
    //display a welcome message to the GradeBook user
    public void DisplayMessage()
    {
        //use auto-implemented property CourseName to get the
        //name of the course that this GradeBook represents
        Console.WriteLine("Welcome to the Grade Book for\n{0}!",
            CourseName ); 
    }//end method DisplayMessage
}//end class GradeBook
