using System;
using System.Runtime.Intrinsics.X86;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace C__Task_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////Note: you must use method concept.
            ////1-Write a function in C# that accept 10 numbers and return sum and average.
            ////•	Test Data :
            ////•	Input the 10 numbers:
            ////•	Number - 1 :2
            ////•	Number - 10 :2
            ////•	Expected Output :
            ////•	The sum of 10 no is : 55
            ////•	The Average is : 5.500000
            //Console.WriteLine("########## Task 1 ###########");
            //List<int> numbers = new List<int>();
            //for(int i = 0; i < 10; i++)
            //{
            //    Console.Write($"Write number {i+1}: ");
            //    numbers.Add(int.Parse(Console.ReadLine()));


            //}
            //static void calculateNum(List<int> numbers)
            //{
            //    int sum = 0;
            //    foreach(int i in numbers)
            //    {
            //        sum += i;
            //    }
            //    Console.WriteLine("The Sum Of Number is "+ sum);
            //    double average = (double) sum / numbers.Count;
            //    Console.WriteLine($"The Avarge Of Number is {average}");



            //}
            //calculateNum(numbers);
            ////2-	Write a program in C to display the cube of the number up to given an integer.
            ////•	Test Data:
            ////•	Input number of terms : 5
            ////•	Expected Output :
            ////•	Number is : 1 and cube of the 1 is :1
            ////•	Number is : 2 and cube of the 2 is :8
            ////•	Number is : 3 and cube of the 3 is :27
            ////•	Number is : 4 and cube of the 4 is :64
            ////•	Number is : 5 and cube of the 5 is :125
            //Console.WriteLine("########## Task 2 ###########");
            //Console.WriteLine("Enter Number: ");
            //int num = int.Parse(Console.ReadLine());

            //static void cubesOfNum(int num)
            //{
            //    for(int i = 1;i <= num;i++)
            //    {
            //        Console.WriteLine($"Number is : {i} and cube of the {i} is :{Math.Pow(i,3)}");
            //    }
            //}
            //cubesOfNum(num);
            ////3-	Write a program in C# return only numbers in the years array greater than 1950.
            //Console.WriteLine("########## Task 3 ###########");
            //int[] years =  [1763, 1972, 1925, 1916, 1984, 1124, 1950, 2020];

            //static string getYears(int[] years)
            //{
            //    List<int> filterdYears = new List<int>();

            //    for (int i  = 0; i < years.Length; i++)
            //    {
            //        if(years[i] > 1950)
            //        {
            //            filterdYears.Add(years[i]);
            //        }
            //    }
            //    return string.Join(",", filterdYears);
            //}
            //Console.WriteLine($"The Years grater than 1950 [{getYears(years)}]");
            ////4-	Create a function that takes the age in years and returns the age in days.
            //Console.WriteLine("########## Task 4 ###########");
            //Console.WriteLine("Enter your Age :");
            //int age = int.Parse(Console.ReadLine());
            //static double convertAgeInYearsToDays(int age)
            //{
            //    double result = age * 365.25;
            //    return result;
            //}
            //Console.WriteLine(convertAgeInYearsToDays(age));
            ////5-	a farmer is asking you to tell him how many legs can be counted among all his animals. The farmer breeds three species:
            //// a.chickens = 2 legs
            ////b.cows = 4 legs
            ////c.pigs = 4 legs
            ////animals(2, 3, 5) ➞ 36

            //Console.WriteLine("########## Task 5 ###########");
            //Console.WriteLine("Write how many chickens you have");
            //int chickens =int.Parse(Console.ReadLine());
            //Console.WriteLine("Write how many cows you have");
            //int cows = int.Parse(Console.ReadLine());
            //Console.WriteLine("Write how many pigs you have");
            //int pigs = int.Parse(Console.ReadLine());
            //try
            //{
            //    int totalLegs = CalculateLegs(chickens, cows, pigs);
            //    Console.WriteLine($"Total legs: {totalLegs}"); 
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}

            //static int CalculateLegs(int chickens, int cows, int pigs)
            //{
            //    if (chickens < 0 || cows < 0 || pigs < 0)
            //    {
            //        throw new Exception("Error: Animal count cannot be negative!");
            //    }


            //    int result = (chickens * 2) + (cows * 4) + (pigs * 4);

            //    return result;
            //}
            //  //6-	create function login, that accept two parameters and return pass or failed for success login. 
            //  //•	You must predefine some users in to be pass in array inside the function
            //  Console.WriteLine("########## Task 6 ###########");
            //  Console.WriteLine("Enter Your User Name");
            //  string username = Console.ReadLine();
            //  Console.WriteLine("Enter Your Password");
            //  string password = Console.ReadLine();

            //  static string login(string username, string password)
            //  {


            //      Dictionary<string, string> users = new Dictionary<string, string>
            //  {
            //      { "admin", "12345" },
            //      { "sara", "p@ssword" }
            //  };


            //      if (users.ContainsKey(username) && users[username] == password)
            //      {
            //          return "Pass";
            //      }
            //      else
            //      {
            //          return "Failed";
            //      }

            //  }
            //Console.WriteLine(  login(username, password));
            ////7-	Create function that calc the power of numbers.
            // Console.WriteLine("########## Task 7 ###########");
            //Console.WriteLine("Write the how much number you want to add");
            //int size = int.Parse(Console.ReadLine());
            //List<int> ints = new List<int>();
            //for(int i = 0; i < size; i++)
            //{
            //    Console.Write($"Write number {i + 1} : ");
            //    ints.Add(int.Parse(Console.ReadLine()));
            //}
            //static double SumOfSquares(List<int> ints)
            //{
            //    double total = 0;
            //    foreach (int item in ints)
            //    {
            //        total += Math.Pow(item, 2);   
            //    }
            //    return total;
            //}
            ////Console.WriteLine(SumOfSquares(ints));
            ////8-	Create function that accept year from range 1900-2024 and return the leap year.
            //Console.WriteLine("########## Task 8 ###########");
            //static List<int> getAllLeapYears()
            //{
            //    List<int> leapYears = new List<int>();
            //    for (int i = 1900; i <= 2024; i++)
            //    {
            //        if ((i % 4 == 0 && i % 100 != 0) || (i % 400 == 0))
            //        {
            //            leapYears.Add(i);
            //        }
            //    }
            //    return leapYears;
            //}

            //var allLeaps = getAllLeapYears();
            //Console.WriteLine("Leap years between 1900 and 2024: " + string.Join(", ", allLeaps));
            ////9-	Create function that accept number to check the prime numbers.
            //Console.WriteLine("########## Task 9 ###########");
            //Console.WriteLine("Enter number");
            //int num = int.Parse(Console.ReadLine());
            //static bool checkPrimeNumber(int num)
            //{
            //    bool isPrime = true;
            //    if (num < 2)
            //    {
            //        isPrime = false;
            //        return isPrime;
            //    }
            //    for (int i = 2; i <= Math.Sqrt(num); i++) {
            //        if (num % i == 0)
            //        {
            //            isPrime = false;
            //            return isPrime;
            //        }


            //    }
            //    return isPrime;

            //}
            //Console.WriteLine($"Is The Number {num} Prime ? {checkPrimeNumber(num)}");
            //10-	Create function that accept a sentence, and return the number of words without using the extended method(count)
            Console.WriteLine("########## Task 10 ###########");
            Console.WriteLine("Write the sentence : ");
            string sentence = Console.ReadLine();
            static int countWords( string sentence)
            {
                char[] charArray = sentence.ToCharArray();
                int count = 1;
                for(int i = 0; i < charArray.Length; i++)
                {
                    if (char.IsWhiteSpace(charArray[i]))
                    {
                        if (i  < charArray.Length -1 && !char.IsWhiteSpace(charArray[i + 1]))
                        {
                            count++;
                        }
                    }
                }
                return count;
            }
            Console.WriteLine(countWords(sentence));











        }
    }
}
