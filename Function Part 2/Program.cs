using Microsoft.VisualBasic;
using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Function_Part2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1) Create a function that takes two dates and returns the number of days between the first
            ////and second date.
            //Console.WriteLine("----------Task 1-----------");

            //Console.WriteLine("Enter The First Date Example (June 14, 2019)");
            //DateTime firstDate = Convert.ToDateTime(Console.ReadLine());
            //Console.WriteLine("Enter The Second Date");
            //DateTime SecondDate = Convert.ToDateTime(Console.ReadLine());
            //static int getDaysBetween(DateTime firstDate , DateTime SecondDate)
            //{
            //    TimeSpan difference = SecondDate - firstDate;
            //    return Math.Abs(difference.Days);

            //}
            //Console.WriteLine($"The Difference between {firstDate.ToString()} and {SecondDate.ToString()} is {getDaysBetween(firstDate, SecondDate)}");
            //// 2) Create a function that takes an array of strings and returns an array with only the strings
            ////that have numbers in them.If there are no strings containing numbers, return an empty
            ////array.
            //Console.WriteLine("----------Task 2-----------");

            //static List<string> numInStr(string[] strings)
            //{
            //    List<string> filteredList = new List<string>();
            //  filteredList=  strings.Where(x => x.Any(char.IsDigit)).ToList();
            //    return filteredList;

            //}
            //Console.WriteLine($"The Filterd List is [{string.Join(",", numInStr(["1a", "a", "2b", "b"]))}]");
            ////3) Given a string, reverse all the words which have odd length. The even length words are 
            ////not changed. 
            ////Console.WriteLine("----------Task 3-----------");

            //Console.WriteLine("Enter your words ");
            //string input = Console.ReadLine();
            //static string reverseOdd(string input)
            //{
            //    string[] words = input.Split(' ');

            //    for (int i = 0; i < words.Length; i++)
            //    {
            //        if (words[i].Length % 2 != 0)
            //        {
            //            char[] charArray = words[i].ToCharArray();
            //            Array.Reverse(charArray);
            //            words[i] = new string(charArray);
            //        }
            //    }
            //    return string.Join(" ", words);
            //}

            //Console.WriteLine(reverseOdd(input));

            //4) A pandigital number contains all digits(0 - 9) at least once.Write a function that takes an
            //integer, returning true if the integer is pandigital, and false otherwise
            Console.WriteLine("----------Task 4-----------");
            Console.WriteLine("enter your number");
            double num = double.Parse(Console.ReadLine());    
            static bool isPandigital(double num)
            {
                string numStr = num.ToString();
                for(int i = 0; i <= 9; i++)
                {
                    if (!numStr.Contains(i.ToString()))
                    {
                        return false;
                    }
                }
                return true;
            }
            Console.WriteLine(isPandigital(num));



        }
    }
}
