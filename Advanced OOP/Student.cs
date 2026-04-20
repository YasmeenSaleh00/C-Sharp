using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_OOP
{
    public class Student : Person
    {
        public double Mark {  get; set; }
        public void PrintStudentInfo()
        {
            Console.WriteLine($"The Name of student is {Name} and his Age is {Age} And his Mark is {Mark}");
        }
    }
}
