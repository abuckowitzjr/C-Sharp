using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_17_Exercise_3
{
    public class Data
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int ID { get; set; }
        public string Class { get; set; }
        public string Grade { get; set; }
        public Data()
            : this(string.Empty, string.Empty, 0, string.Empty, string.Empty)
        {
        }

        public Data (string FirstNameValue, string LastNameValue, int IDValue, string ClassValue,
            string GradeValue)
        {
            FirstName = FirstNameValue;
            LastName = LastNameValue;
            ID = IDValue;
            Class = ClassValue;
            Grade = GradeValue;
        }
    }
}
