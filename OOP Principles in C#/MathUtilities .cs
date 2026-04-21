using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Principles_in_C_
{
    public static class MathUtilities
    {
       public static double ClaculateSquarenumber(double number)
        {
            return Math.Pow(number, 2);

        }
        public static double CalculateTheSquareRoot(double number)
        {
            return Math.Sqrt(number);
        }
        public static double FindTheMaximumBetweenTwoNumbers(double firstNumber , double secondNumber)
        {
            if(firstNumber > secondNumber)
            {
                return firstNumber;
            }
            else
            {
                return secondNumber;
            }
        }
    }
}
