using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA1
{
    class Subject
    {
        public string Name { get; set; }
        public string Lecturer { get; set; }
        public int Year { get; set; }

        public Subject(string name, string lecture,int year)
        {
            Name = name;
            Lecturer = lecture;
            Year = year;
        }
        public Subject(string name, string lecture): this(name,lecture,0)
        {

        }
        public Subject(string name) : this(name, "Unknown", 0)
        {

        }
        public Subject() : this("Unknown", "Unknown", 0)
        {

        }

        public override string ToString()
        {
            return string.Format("Class Name: {0} Lecturer: {1} Year: {2}",Name,Lecturer,Year );
        }

    }
}
