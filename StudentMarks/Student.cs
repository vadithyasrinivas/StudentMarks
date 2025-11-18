using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentMarks
// Student class to hold student details and calculate total and average marks
{
    public class Student
    {
        public string Name { get; set; }
        public int Mark1 { get; set; }
        public int Mark2 { get; set; }
        public int Mark3 { get; set; }
        public int GetTotal()
        {
            int TotalMarks = Mark1 + Mark2 + Mark3;
            Console.WriteLine("Total Marks: " + TotalMarks);
            return TotalMarks;
        }
        public double GetAvarege()
        {
            double Avarege = (Mark1 + Mark2 + Mark3) / 3;
            Console.WriteLine("Avarege Marks: "+Avarege);
            return Avarege;
        }
    }
}
