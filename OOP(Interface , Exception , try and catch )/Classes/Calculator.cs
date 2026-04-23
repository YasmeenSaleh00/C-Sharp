using OOP_Interface___Exception___try_and_catch__.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Interface___Exception___try_and_catch__.Classes
{
    public class Calculator : ICalculator
    {
        public int Add(int x, int y)
        {
            return x + y;
        }
        //public int Add(int x, int y)
        //{
        //    try
        //    {
        //        Console.WriteLine("Enter first number");
        //         x = int.Parse(Console.ReadLine());
        //        Console.WriteLine("Enter second number");
        //        y = int.Parse(Console.ReadLine());
        //        return x + y;
        //    }
        //    catch (Exception e)
        //    {
        //        Console.WriteLine(e.ToString());
        //        Add(x, y);
        //    }
        //}
    }
}
