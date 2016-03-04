using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_17_Exercise_3
{
    [Serializable]
    public class DataSerializable
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int ID { get; set; }
        public string Class { get; set; }
        public string Grade { get; set; }
        public DataSerializable()
            : this(string.Empty, string.Empty, 0, string.Empty, string.Empty)
        {
        }

        public DataSerializable (string FirstNameValue, string LastNameValue, int IDValue, string ClassValue,
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
