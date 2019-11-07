using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
            Subject class1 = new Subject("Object", "Keith", 4);
            Subject class2 = new Subject("DataBase", "Colm");
            Subject class3 = new Subject("Maths");
            Subject class4 = new Subject();



            //Console.WriteLine(class1); testing

            Student st1 = new Student("Paul", "2/3/1996",class1,class2);
            Student st2 = new Student("Ben", "3/5/1990",class3,class4);



            Console.WriteLine(st1);
            Console.WriteLine();
            Console.WriteLine(st2);

            //Here would be display days work in progress

            //DisplayAgeInDays(st1.DateOfBirth,st2.DateOfBirth);

        }
        //static void DisplayAgeInDays(string st1,string st2)
        //{
        //    DateTime day1 = DateTime.Parse(st1);
        //    day1 = (DateTime.Now - day1).TotalDays;

        //    Console.WriteLine(day1);
        //}
    }
}
