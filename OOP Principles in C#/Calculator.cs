using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Principles_in_C_
{
    //Create a class with method overloading (e.g., Add)
    //📝 Task Description: Polymorphism (Method Overloading)
    public class Calculator
    {
        public int Add(int firstNum , int secondNum)
        {
            return firstNum + secondNum;
        }
        public int Add(int firstNum, int secondNum,int thirdNum)
        {
            return firstNum + secondNum + thirdNum;        }
        public double Add(double firstNum, double secondNum)
        {
            return firstNum + secondNum;        }
        public decimal Add(decimal firstNum, decimal secondNum)
        {
            return firstNum + secondNum;
        }
    }
}
