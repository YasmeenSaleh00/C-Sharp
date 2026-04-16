using System;
using System.ComponentModel;
using System.Reflection.Metadata;
using System.Runtime.Intrinsics.X86;
using System.Security.Cryptography;
using System.Threading;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Function_Part1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1) Write a function that takes an integer minutes and converts it to seconds.
            Console.WriteLine("----------Task 1-----------");

            Console.WriteLine("Write muints");
            int minutes = int.Parse(Console.ReadLine());
            static int convertMinutesToSeconds(int minutes)
            {
                int seconds = minutes * 60;
                return seconds;

            }
            Console.WriteLine($" {minutes} m = {convertMinutesToSeconds(minutes)} s");
            //2) Create a function that takes a number as an argument, increments the number by +1 and
            //returns the result.
            Console.WriteLine("----------Task 2-----------");

            Console.WriteLine("Write Number");
            int value = int.Parse(Console.ReadLine());
            static int incrementNumber(int value)
            {
                return value = value + 1;
            }
            Console.WriteLine($"The increment value of {value} is {incrementNumber(value)}");
            //3) Create a function that takes an array containing only numbers and return the first element.
            Console.WriteLine("----------Task 3-----------");

            List<int> numbers = new List<int>();
            Console.WriteLine("How many numbers do you want to add?");
            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                Console.Write($"Enter number {i + 1}: ");
                numbers.Add(int.Parse(Console.ReadLine()));
            }

            if (numbers.Count > 0)
            {
                int firstElement = GetFirstElement(numbers);
                Console.WriteLine($"The first element is: {firstElement}");
            }
            else
            {
                Console.WriteLine("The list is empty!");
            }
            static int GetFirstElement(List<int> list)
            {
                return list[0];

            }
            //4) Write a function that takes the base and height of a triangle and return its area
            Console.WriteLine("----------Task 4-----------");

            Console.WriteLine("Enter Height");
            double height = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter The Base");
            double triangleBase = double.Parse(Console.ReadLine());
            static double calculateTheArea(double height, double triangleBase)
            {

                return (height * triangleBase) / 2;



            }
            Console.WriteLine($"The Area of triangle with height {height} and Base {triangleBase} is  {calculateTheArea(height, triangleBase)}");
            //5) Create a function called evenNumberEvenIndex
            // that accept an array of nums
            // and return a new array that have the even number in even index
            //var nums = [5, 2, 2, 1, 8, 66, 55, 77, 34, 9, 55, 1]
            //Ex: evenNumberEvenIndex (nums) => [2, 8, 34]
            Console.WriteLine("----------Task 5-----------");

            static List<int> evenNumberEvenIndex(int[] ints)
            {
                List<int> evenNumberEvenIndexArr = new List<int>();

                for (int i = 0; i < ints.Length; i++)
                {
                    if (ints[i] % 2 == 0 && i % 2 == 0)
                    {

                        evenNumberEvenIndexArr.Add(ints[i]);

                    }
                }
                return evenNumberEvenIndexArr;
            }
            var result = evenNumberEvenIndex(([5, 2, 2, 1, 8, 66, 55, 77, 34, 9, 55, 1]));
            Console.WriteLine("[" + string.Join(", ", result) + "]");
            //6) Create a function called evenIndexOddLength that accept an array of strings
            // and return a new array that have the string with odd length in even index
            //var strings = ["alex", "mercer", "madrasa", "rashed2", "emad", "hala"]
            //Ex: evenIndexOddLength (strings) => ["madrasa"]
            Console.WriteLine("----------Task 6-----------");

            static List<string> evenIndexOddLength(string[] names)
            {
                List<string> evenIndexOddLengthArr = new List<string>();
                for (int i = 0; i < names.Length; i++)
                {
                    if (names[i].Length % 2 != 0 && i % 2 == 0)
                    {
                        evenIndexOddLengthArr.Add(names[i]);
                    }
                }
                return evenIndexOddLengthArr;
            }
            var arr = evenIndexOddLength(["alex", "mercer", "madrasa", "rashed2", "emad", "hala"]);
            Console.Write(string.Join(", ", arr));
            // 7) Create a function called powerElementIndex that accept an array of number
            //and return a new array that have the element power by the index of it self
            //var nums = [44, 5, 4, 3, 2, 10]
            //Ex: powerElementIndex (nums) => [0, 5, 16, 27, 16, 100000]
            Console.WriteLine("\n----------Task 7-----------");
            static List<double> powerElementIndex(double[] numbers)
            {
                List<double> powerArr = new List<double>();
                for (int i = 0; i < numbers.Length; i++)
                {
                    double power = Math.Pow(numbers[i], i);
                    powerArr.Add(power);
                }
                return powerArr;

            }
            Console.WriteLine(string.Join(",", powerElementIndex([44, 5, 4, 3, 2, 10])));
            //8) Write a function called multiplication2
            //that takes two parameters
            //and return the multiplication of them
            //you need to use only sum
            //multiplication2(5, 4) => 20
            //multiplication2(2, 8) => 16
            //multiplication2(7, 6) => 42
            Console.WriteLine("----------Task 8 -----------");
            Console.WriteLine("Enter the First num :");
            double firstNum = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Second num :");
            double secondNum = double.Parse(Console.ReadLine());
            static double multiplication2(double firstNum, double secondNum)
            {
                return firstNum * secondNum;

            }
            //Console.WriteLine($"The multiplication of {firstNum} and {secondNum} = {multiplication2(firstNum,secondNum)} ");
            //9) Create a function called muti2
            //  that take two parameter
            //and will return the multiplication
            //from the first number to the second number
            //Ex: muti2(4, 5); => 4 * 5 => 20
            //Ex: muti2(3, 6); => 3 * 4 * 5 * 6 => 360
            Console.WriteLine("Enter first num;");
            double first = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter second num;");
            double second = double.Parse(Console.ReadLine());
            static double  muti2 (double first , double second)
            {
                double result = 1;
                for(double i = first;i<= second; i++)
                {
                    result *= i;

                }
                return result;
            }
            Console.WriteLine($"The result of multiplication between {first} to {second} = {muti2(first,second)}");

            //10)Create a function called aveArray
            // that accept an array and return the average of the numbers inside this array
            // var nums = [1, 2, 3, 8, 9]
            //Ex: aveArray (nums) => 4.6s
            //var nums2 = [1, 2, 3, 8, 9, 77]
            //Ex: aveArray (nums) => 16.6
             static double aveArray(double[] array)
            {
                double sum = 0;

                for(int i = 0; i < array.Length; i++)
                {
                    sum += array[i];

                }
                return sum / array.Length;

            }
            Console.WriteLine($"The Avarage of Array is {Math.Round( aveArray([1, 2, 3, 8, 9, 77]),2)}");
  



        }




    }
}
