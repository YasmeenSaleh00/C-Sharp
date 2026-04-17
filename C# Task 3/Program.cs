using System;
using System.ComponentModel;
using System.Numerics;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace C__Task_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //C## Task / loops
            //1-Correct the syntax error:
            //•	string[] ARR = [1, 7  9  45,]
            //•	int arr2 = ["Str" "alex","moh"
            //•	string arr3= 'the','fox' 'over' lazy, 'dog',  ]
            Console.WriteLine("##########Task 1 ###########");
            Console.WriteLine("The Correct Syntax from \n 1- string[] ARR = [1, 7  9  45,] ===> int[] arr = [1,7,9,45]; \n " +
                "2-  int arr2 = [\"Str\" \"alex\",\"moh\" ===> string[] arr2 = [\"Str\" \"alex\",\"moh\"];\n" +
                "3- string arr3= 'the','fox' 'over' lazy, 'dog',  ] ===> string[] arr3 = [\"the\",\"fox\", \"over\", \"lazy\", \"dog\"]; ");
            //2-	What the index of "Banana","Tomato"?
            //String[] fruits = ["Tomato", "Banana", "Watermelon"];
            Console.WriteLine("##########Task 2 ###########");
            Console.WriteLine("String[] fruits = [\"Tomato\", \"Banana\", \"Watermelon\"]\n" +
                "The index of Banana ==> 1 \n" +
                "The index of Tomato ==> 0");
            //3-	Create an multiple arrays that represents your:
            //•	Favorite Food(5 item)
            //•	Favorite Sport(3 item)
            //•	Favorite Movie(4 item)
            //Then, print each array using foreach, and Loop Through an Array
            Console.WriteLine("##########Task 3 ###########");
            string[] favoriteFood = { "Pizza", "Kabsa", "Shawarma", "Fish", "Mandi" };

            string[] favoriteSport = { "Football", "Swimming", "Tennis" };

            string[] favoriteMovies = { "Parasite", "Train to Busan", "Oldboy", "The Wailing" };

            Console.WriteLine("--- My Favorite Food ---");
            foreach (string food in favoriteFood)
            {
                Console.WriteLine("- " + food);
            }

            Console.WriteLine("--- My Favorite Sports ---");
            foreach (string sport in favoriteSport)
            {
                Console.WriteLine("- " + sport);
            }

            Console.WriteLine("--- My Favorite Korean Movies ---");
            foreach (string movie in favoriteMovies)
            {
                Console.WriteLine("- " + movie);
            }
            //4-	Write a program in C# to calculate the sum of three numbers with getting input in one line separated by a comma
            //•	Expected Output:
            //•	Input three numbers separated by comma: 5,10,15
            //•	The sum of three numbers: 30.
            Console.WriteLine("##########Task 4 ###########");
            Console.Write("Input three numbers separated by comma (e.g., 5,10,15): ");
            string input = Console.ReadLine();
            string[] parts = input.Split(',');
            int sum = 0;
            foreach (string part in parts)
            {
                sum += int.Parse(part);
            }

            //Console.WriteLine($"The sum is: {sum}");
            //5-	Write a program in C# to display the n terms of odd number and their sum from [1- 100 ]. 
            //•	Test Data
            //•	The odd numbers are1 3 5 7 9 11 13 15 17 19……
            //•	The Sum of odd Numbers is: …...
            Console.WriteLine("##########Task 5 ###########");
            List<int> ints = new List<int>();
            int sumOdd = 0;
            for (int i = 1; i <= 100; i++)
            {
                if (i % 2 != 0)
                {
                    ints.Add(i);
                    sumOdd += i;
                }
            }
            Console.WriteLine(string.Join(",", ints));
            Console.WriteLine($"The Sum Of Odd Number is {sumOdd}");
            //6-	Write a program in C## to display the pattern like right angle triangle using an asterisk. Go to the editor
            //  The pattern like:
            //  *
            // **
            //***
            Console.WriteLine("##########Task 6 ###########");
            Console.WriteLine("Enter number of rows");
            int rows = int.Parse(Console.ReadLine());
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            // 7 - Write a program in C# to make such a pattern like right angle triangle with number increased by 1. Go to the editor
            //The pattern like :

            //     1
            //   2 3
            //  4 5 6
            //7 8 9 10
            Console.WriteLine("##########Task 7 ###########");
            int counter = 0;
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    counter++;
                    Console.Write(counter + " ");
                }
                Console.WriteLine();
            } 





        }
    }
}
