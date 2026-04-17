using System.Globalization;
using static C__Task_5.Factorial;

namespace C__Task_5
{
    //Task 1
    public class MyClass
    {
        public MyClass()
        {
            Console.WriteLine("MyClass class has initialized!");
        }
    }
    //Task 2
    public class Person
    {
        public Person(string name)
        {
            Console.WriteLine($"Hello All, I am {name}");
        }
    }
    //Task 3
    public class Factorial
    {
        public Factorial(int num)
        {
            long factorial = 1;
            for(int i = 1; i <= num; i++)
            {
                factorial *= i;
            }
            Console.WriteLine($"The Factorial of {num}! is {factorial}");
        }
        //Task 4
        public class SortArray
        {
            public SortArray(int[] ints)
            {
                Array.Sort(ints);

                Console.Write($"Sorted Array:[{string.Join(",", ints)}]");
            }
        }
        //Task 5
        public class DateDifference
        {
            public DateDifference(DateTime date1, DateTime date2)
            {
                int years = 0;
                int months = 0;
                int days = 0;

                while (date1.AddYears(years + 1) <= date2)
                {
                    years++;
                }

                DateTime tempDate = date1.AddYears(years);
                while (tempDate.AddMonths(months + 1) <= date2)
                {
                    months++;
                }

                tempDate = tempDate.AddMonths(months);
                days = (date2 - tempDate).Days;

                Console.WriteLine($"Difference: {years} years, {months} months, {days} days");
            }
        }



    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //C# and OOP
            //1.	Write a simple C# class which displays the following string. 
            //'MyClass class has initialized!'
            Console.WriteLine("-----------Task 1------------");
            MyClass myObj = new MyClass();
            //2.	Write a simple C# class which displays an introductory message like "Hello All, I am Scott", 
            //where "Scott" is an argument value of the method within the class.
            Console.WriteLine("-----------Task 2------------");
            Person user = new Person("Scott");
            //3.	Write a C# class that calculates the factorial of an integer.
            Console.WriteLine("-----------Task 3------------");
            Factorial factorial = new Factorial(5);
            //4.	Write a C# class that sorts an ordered integer array with the help of the Array.Sort() function.
            //    Sample array: int[] array = { 11, -2, 4, 35, 0, 8, -9 };
            //Output: Sorted array: { -9, -2, 0, 4, 8, 11, 35 }
            Console.WriteLine("-----------Task 4------------");
            int[] array = { 11, -2, 4, 35, 0, 8, -9 };
            SortArray sortArray = new SortArray(array);
            //5. Calculate the difference between two dates using the C# OOP approach.
            //Sample Dates: DateTime date1 = new DateTime(1981, 11, 03);
            //DateTime date2 = new DateTime(2013, 09, 04);
            //Expected Result: Difference: 31 years, 10 months, 1 day.
            Console.WriteLine("-----------Task 5------------");
            //6. Write a C# script to convert a string to Date and DateTime.
            //       Sample Date: string dateString = "12-08-2004";
            //       Expected Output: Converted Date: 2004 - 08 - 12
            //Note: C# considers '/' to mean m/d/yyyy format and '-' to mean d-m-yyyy format.
            Console.WriteLine("-----------Task 6------------");
            static void dateConverter(string dateStr)
        {

                DateTime convertedDate = DateTime.ParseExact(dateStr, "dd-MM-yyyy", null);
                Console.WriteLine($"Converted Date: {convertedDate.ToString("yyyy - MM - dd")}");

        }
            dateConverter("12-08-2004");





    }
    }
}
