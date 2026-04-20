using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Advanced_OOP
{
    public class Person
    {
        public string Name { get; set; }
        private int age ;
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        public void PrintUserInfo()
        {
            Console.WriteLine($"The Name of person is {Name} and his Age is {Age} ");

        }
    }
}
