using System.ComponentModel;
using System.Xml.Linq;

namespace C__Task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////C# Task / Conditional statement
            //// 1.Write a C# program that accept two integers and display the smaller. 
            //Console.WriteLine("#################Task 1##############");
            //Console.WriteLine("Enter first number");
            //double firstNum = double.Parse(Console.ReadLine());
            //Console.WriteLine("Enter second number");
            //double secondNum = double.Parse(Console.ReadLine());
            //if (firstNum < secondNum)
            //{
            //    Console.WriteLine($"The smaller one is {firstNum}");

            //}
            //else if (secondNum == firstNum)
            //{
            //    Console.WriteLine($"They are equel {firstNum} = {secondNum}");

            //}
            //else
            //{
            //    Console.WriteLine($"The smaller one is {secondNum}");

            //}
            ////2.Write a C# conditional statement to find the sign  of input  number. Display sign. Go 
            ////•	Sample numbers: -7
            ////•	Output: The sign is -
            //Console.WriteLine("#################Task 2##############");
            //Console.WriteLine("Enter a number:");

            //double number = double.Parse(Console.ReadLine());

            //if (number > 0)
            //{
            //    Console.WriteLine("The sign is +");
            //}
            //else if (number < 0)
            //{
            //    Console.WriteLine("The sign is -");
            //}
            //else
            //{
            //    Console.WriteLine("The number is zero (no sign)");
            //}
            ////3.	Write a C# conditional statement to sort three numbers ascending. Use console to display the result.
            ////•	Sample numbers: 0, -1, 4
            ////•	Output: 4, 0, -1
            //Console.WriteLine("#################Task 3##############");
            //Console.WriteLine("Enter first number");
            //double firstNum = double.Parse(Console.ReadLine());
            //Console.WriteLine("Enter second number");
            //double secondNum = double.Parse(Console.ReadLine());
            //Console.WriteLine("Enter third number");
            //double thirdNum = double.Parse(Console.ReadLine());
            //if (firstNum < secondNum && firstNum < thirdNum)
            //{
            //    if (secondNum < thirdNum)
            //    {
            //        Console.WriteLine($"{firstNum}, {secondNum}, {thirdNum}");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"{firstNum}, {thirdNum}, {secondNum}");

            //    }
            //}
            //else if (secondNum < firstNum && secondNum < thirdNum)
            //{
            //    if (firstNum < thirdNum)
            //        Console.WriteLine($"{secondNum}, {firstNum}, {thirdNum}");
            //    else
            //        Console.WriteLine($"{secondNum}, {thirdNum}, {firstNum}");
            //}
            //else
            //{
            //    if (firstNum < secondNum)
            //        Console.WriteLine($"{thirdNum}, {firstNum}, {secondNum}");
            //    else
            //        Console.WriteLine($"{thirdNum}, {secondNum}, {firstNum}");
            //}
            ////4.	Write a C# conditional statement to find the max of five numbers. Use console to display the result.
            ////•	Sample numbers: -5, -2, -6, 0, -1
            ////•	Output: 0
            //Console.WriteLine("#################Task 4##############");
            //Console.WriteLine("Enter first number");
            //double firstNum = double.Parse(Console.ReadLine());
            //Console.WriteLine("Enter second number");
            //double secondNum = double.Parse(Console.ReadLine());
            //Console.WriteLine("Enter third number");
            //double thirdNum = double.Parse(Console.ReadLine());
            //Console.WriteLine("Enter fourth number");
            //double fourthNum = double.Parse(Console.ReadLine());
            //Console.WriteLine("Enter five number");
            //double fiveNum = double.Parse(Console.ReadLine());
            //Console.WriteLine("#################Task 4##############");

            //double max = firstNum;

            //if (secondNum > max) max = secondNum;

            //if (thirdNum > max) max = thirdNum;

            //if (fourthNum > max) max = fourthNum;

            //if (fiveNum > max) max = fiveNum;

            //Console.WriteLine($"The Max number is {max}");
            // //5.	 Write a C# program that converts kilometers per hour to miles per hour.  
            // //            Expected Output:
            // //•	Input kilometers per hour: 15.
            // //•	9.320568 miles per hour
            //Console.WriteLine("#################Task 5 ##############");
            // Console.WriteLine("Enter kilometers per hour:");
            // double kilometer = double.Parse(Console.ReadLine());
            // double miles = kilometer * 0.621371;
            // Console.WriteLine($"{kilometer} kilometers per hour = {miles} miles per hour");
            ////6.	Write a C# program that takes hours and minutes as input and calculates the total number of minutes.
            ////•	Input hours: 5
            ////•	Input minutes: 37
            ////•	Total: 337 minutes.
            //Console.WriteLine("#################Task 6 ##############");
            //Console.WriteLine("Enter Hours");
            //int hours = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter minutes");
            //int minutes = int.Parse(Console.ReadLine());
            //int totalMinutes = (hours * 60) + minutes;
            //Console.WriteLine($" {hours} Hours and {minutes} Minutes => {totalMinutes} Total Minutes ");
            ////7.	Write a program in C# that takes minutes as input and display the total number of hours and minutes. 
            ////•	Input minutes: 546
            ////•	9 Hours, 6 Minutes
            //Console.WriteLine("#################Task 7 ##############");
            //Console.WriteLine("Enter minutes");
            //int minutes = int.Parse(Console.ReadLine());
            //double hours =(double) ( minutes / 60);
            //double minut = (double) (minutes %  60);    
            //Console.WriteLine($" {minutes} => {hours} Hours , {minut} Minutes");
            //            // 8.Create string of array that contains 5 element of different sentence with different length.
            //            //Print all elements with fixed length for each sentence.
            //            Console.WriteLine("#################Task 8 ##############");
            //            string[] sentences = {
            //    "Learning C# is fun",
            //    "Programming",
            //    "Hi",
            //    "This is a test",
            //    "Welcome to the course"
            //};
            //            int lengthToKeep = 5;
            //            string newWordWithFixedLength = "";
            //            for(int i = 0; i < sentences.Length; i++)
            //            {
            //                if (sentences[i].Length >= lengthToKeep)
            //                { newWordWithFixedLength = sentences[i].Substring(0, lengthToKeep);
            //                Console.WriteLine($"{sentences[i]} ==> {newWordWithFixedLength}");
            //                }
            //                else
            //                {
            //                    newWordWithFixedLength = sentences[i];
            //                    Console.WriteLine(newWordWithFixedLength);
            //                }

            //            }
            //9.Given a string, reverse all the words which have odd length. The even length words are not changed. 
            //       reverseOdd("Bananas") ➞ "sananaB" 
            Console.WriteLine("#################Task 9 ##############");
            static string reverseOdd(string s)
            {
                string[] strings = s.Split(" ");
                List<char> newChars = new List<char>();

                for (int i =0; i < strings.Length; i++)
                {
                    if (strings[i].Length % 2 != 0)
                    {
                        char[] chars = strings[i].ToCharArray();
                       Array.Reverse(chars);
                        strings[i] = new string(chars);
                    }
                 
                
                }
                return string.Join(" ", strings);
            }
            Console.WriteLine(reverseOdd("One two three four"));



        }
    }
}