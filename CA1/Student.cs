using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA1
{
    class Student
    {
        public string Name { get; set; }
        public string DateOfBirth { get; set; }
        public object TheClass { get; set; }
        public object TheOtherClass { get; set; }
        public int Days { get; set; }

        public List<Subject> subjects = new List<Subject>();


        public Student(string name,string date)
        {
            Name = name;
            DateOfBirth = date;

        }
        public Student(string name, string date,object theclass,object theotherclass)
        {
            Name = name;
            DateOfBirth = date;
            TheClass = theclass;
            TheOtherClass = theotherclass;

        }

        public override string ToString()
        {
            return string.Format("Name: {0} Date of Birth: {1} \n{2}\n{3}", Name, DateOfBirth,TheClass,TheOtherClass);
        }

    }
}
