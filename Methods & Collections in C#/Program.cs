using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Reflection.Metadata;
using System.Runtime.Intrinsics.X86;
using System.Xml.Linq;
using static System.Formats.Asn1.AsnWriter;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Methods___Collections_in_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task 1 – Method
            // Create a method:

            // -Name: `CalculateAverage`
            //-Takes 3 numbers
            //- Returns the average
            Console.WriteLine("------------------Task 1--------------");

            static double CalculateAverage(double firstNum, double secondNum, double thirdNum)
            {
                double avarage = (firstNum + secondNum + thirdNum) / 3;
                return avarage;
            }
            Console.WriteLine($"The Avarage is {CalculateAverage(2, 4, 5)}");
            // Task 2 – List

            //Create a list of **student names * *:

            //-Add 5 names
            //- Print all names
            //-Remove one name
            Console.WriteLine("------------------Task 2--------------");

            List<string> userNames =new List<string>();
            userNames.Add("Yasmeen");
            userNames.Add("Ahmad");
            userNames.Add("Omar");
            userNames.Add("Yousef");
            userNames.Add("Abeer");
            foreach (var item in userNames)
            {
                Console.WriteLine(item);
                
            }
            userNames.Remove("Omar");
            //Task 3 Dictionary
            // Create a dictionary:

            //  -Key: `int`
            //-Value: `string`
            //-Store 3 users(ID → Name)
            //- Print all users
            Console.WriteLine("------------------Task 3--------------");
            Dictionary<int, string> users = new Dictionary<int, string>();

            users.Add(1, "Ali");
            users.Add(2, "Omar");
            users.Add(3, "Yasmeen");
            foreach (var item in users)
            {
                Console.WriteLine(item.Key + " - " + item.Value);
            }
            //Task 4 – LINQ
            //Create a C# program that uses LINQ to perform the following operations on an array.
            int[] numbers = { 5, 10, 15, 20, 25, 30 };
            string[] names = { "Ahmad", "Ali", "Sara", "Mona", "Omar" };
            //### 1️⃣ Filter Numbers

            // -Get all numbers greater than 15 using LINQ
            //-Print the result
            Console.WriteLine("-------Fitler Numbers > 15------- ");
            int[] filteredNum= numbers.Where(x => x > 15).ToArray();
            foreach (var num in filteredNum)
            {
                Console.WriteLine(num);
            }

            ////### Even Numbers

            //  -Get all even numbers from the array
            //-Print them

            Console.WriteLine("-------Fitler Numbers (even) ------- ");
            int[] evenNum = numbers.Where(x => x % 2 ==0).ToArray();
            foreach (var num in evenNum)
            {
                Console.WriteLine(num);
            }
            //### Sorting

            //  -Sort the numbers in ascending order
            //-Then sort them in descending order
            Console.WriteLine("-------Sort Numbers (ascending) ------- ");
            int[] sortNumAsc = numbers.OrderBy(x=>x).ToArray();
            foreach (var num in sortNumAsc)
            {
                Console.WriteLine(num);
            }
            Console.WriteLine("-------Sort Numbers (descending) ------- ");

            int[] sortNumDesc = numbers.OrderByDescending(x => x).ToArray();
            foreach (var num in sortNumDesc)
            {
                Console.WriteLine(num);
            }
            //### Names Filtering

            //-Get all names that start with the letter * *'A' * *
            //-Print the result
            Console.WriteLine("-------Names fitering  (Start wit A) ------- ");
            string[] namesFitering = names.Where(x=>x.StartsWith("A")).ToArray();
            foreach (var name in namesFitering)
            {
                Console.WriteLine(name);
            }
            //### First Value

            //-Get the first number greater than 10 using
            Console.WriteLine("-------Numbers fitering  (Grater than 10) ------- ");
            int grater = numbers.FirstOrDefault(z => z > 10);
            Console.WriteLine($"The first value grater than 10 is {grater}");
            //### Bonus Challenge (Optional)

            //-Use `Select()` to create a new array where each number is multiplied by 2
            //- Print the new values
            Console.WriteLine("-------Bonus Challenge (Optional) ------- ");
            int[] muliplyArrayByTwo = numbers.Select(x=> x * 2).ToArray();
            foreach(var mul in muliplyArrayByTwo)
            {
                Console.Write(mul + "  ");
            }
            //## Task 5 – Methods

            //### 🎯 Objective

            //Practice creating and calling different types of methods in C#.

            //-- -

            //### 📝 Task Description

            //1.Create a** method without parameters**that prints “Welcome!”
            //2.Create a** method with parameters**that prints a greeting for a user name
            //3.Create a * *method with default parameter * * for age
            //4.Create a * *method that returns the sum * *of two numbers
            //5.Create a * *method with an array parameter * *that prints all elements
            //6.Call all methods from `Main()` and test different arguments

            Console.WriteLine("\n------1- Welcome Method-----");
            static void printWelcome()
            {
                Console.WriteLine("Welcome");
            }
            printWelcome();
            Console.WriteLine("------2-prints a greeting for a user name-----");
            static void printGreeting(string userName)
            {
                Console.WriteLine($"Welcome {userName}");
                
            }
            Console.WriteLine("Enter Your Name :");
            string userName = Console.ReadLine();

            printGreeting(userName);
            Console.WriteLine("------3- default parameter * * for age-----");
            static void printAge(int age = 0)
            {
                Console.WriteLine("The age is "+ age);

            }
            printAge(50);
            printAge();
            Console.WriteLine("------ 4- method that returns the sum * *of two numbers-----");
            static double sum(double x , double y)
            {
                return x + y;
            }
            Console.WriteLine("Enter The first Number");
            double x = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter The second Number");
            double y = double.Parse(Console.ReadLine());


           Console.WriteLine($"The sum of ({x},{y}) is:  {sum(x, y)}");

            Console.WriteLine("------ 5- method with an array parameter * *that prints all elements-----");
            static void printAllElements(int[] ints)
            {
                foreach(int i in ints)
                {
                   Console.Write(i + " ");
                }
            }
             printAllElements([1, 5, 9]);

        }
    }
}
