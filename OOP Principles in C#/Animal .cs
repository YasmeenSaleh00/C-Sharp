using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Principles_in_C_
{
    //Create a base class Animal with virtual method Speak()
    public class Animal
    {
        public virtual void Speak()
        {
            Console.WriteLine("The animal makes a sound");
        }
    }
}
