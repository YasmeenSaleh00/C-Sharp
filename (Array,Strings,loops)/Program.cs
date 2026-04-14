namespace _Array_Strings_loops_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task 1
            //### Task 1 :  Analyze an Array with Loops

            //**Objective:**Practice using loops to analyze and manipulate an array.
            //* *Instructions:**

            //            Write a program that:

            //            1.Creates an array of integers.
            //2.Uses a loop to:
            //            -Count how many numbers are **even * *.

            //            - Count how many numbers are **odd * *.

            //            - Calculate the** sum**of all numbers.
            //3.Then, use another loop to create a **new array** that contains only the numbers greater than the average.
            //4.Print:
            //    -The number of even values
            //    -The number of odd values
            //    -The total sum
            //    -The average
            //    - The new filtered array
            //int[] nums = [10, 15, 22, 7, 8, 13, 30];
            //int countEven = 0;
            //int countOdd = 0;
            //int sum = 0;
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    sum += nums[i];
            //    if (nums[i] % 2 == 0)
            //    {
            //        countEven++;
            //    }
            //    else
            //    {
            //        countOdd++;
            //    }
            //}
            //double avarage = sum / nums.Length; ;
            //List<int> filteredList = new List<int>();

            //for (int i = 0; i < nums.Length; i++)
            //{
            //    if (nums[i] > avarage)
            //    {
            //        filteredList.Add(nums[i]);
            //    }
            //}
            //int[] filteredArray = filteredList.ToArray();
            //Console.WriteLine($"The count of Even Numbers {countEven}");
            //Console.WriteLine($"The count of Odd Numbers {countOdd}");
            //Console.WriteLine($"The sum of nums {sum}");
            //Console.WriteLine($"The Avarage of nums {avarage}");
            //Console.WriteLine($"The numbers grater than avarage [{string.Join(',', filteredArray)}]");
            //### Task 2 :  Find the Largest Number in an Array

            //**Objective:** Use a loop to find the maximum value in an array.

            //**Instructions:**

            //Write a program that:

            //1. Creates an array of numbers.
            //2. Uses a loop to compare all elements.
            //3. Finds and prints the largest number in the array.

            //**Example Input:**

            //```
            //[12, 45, 7, 23, 56, 19]
            //```### Task 2 :  Find the Largest Number in an Array

            //**Objective:** Use a loop to find the maximum value in an array.

            //**Instructions:**

            //Write a program that:

            //1. Creates an array of numbers.
            //2. Uses a loop to compare all elements.
            //3. Finds and prints the largest number in the array.

            //**Example Input:**

            //```
            //[12, 45, 7, 23, 56, 19]
            //```
            //Console.Write("Enter the number of elements: ");
            //int size = int.Parse(Console.ReadLine());

            //int[] nummers = new int[size];
            //for (int i = 0; i < size; i++)
            //{
            //    Console.Write($"Enter number {i + 1}: ");
            //    nummers[i] = int.Parse(Console.ReadLine());


            //}
            //int max = nummers[0];
            //int min = nummers[0];

            //for (int i = 1; i < nummers.Length; i++)
            //{
            //    if (nummers[i] > max)
            //    {
            //        max = nummers[i];
            //    }

            //    if (nummers[i] < min)
            //    {
            //        min = nummers[i]; 
            //    }
            //}
            //Console.WriteLine($"The max num is {max}");
            //Console.WriteLine($"The min num is {min}");
            //### Task 3

            //Using a loop:

            //-Print numbers from 1 → 10
            //- Print only even numbers
            //for(int i = 1;i <=10;i++)
            //{
            //    if(i % 2== 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}
            //Write a C# program that asks the user to enter the following information:

            //1.Full Name
            //2.Age
            //3.Height(in meters, e.g., 1.75)
            //4.Is Employed(true / false)

            //-- -

            //### ⚙️ Requirements

            //-Use `Console.ReadLine()` to get input from the user
            //-Use `Convert` methods to convert data into:
            //            - `int` (for age)
            //                - `double` (for height)
            //                - `bool` (for employment status)
            //                -Print all the information in a clear format
            //Console.WriteLine("Enter Full Name :");
            //string name = Console.ReadLine();
            //Console.WriteLine("Enter Your height");
            //double height = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Are You Employee :(true / false)");

            //bool employmentStatus = Convert.ToBoolean(Console.ReadLine());
            //Console.WriteLine("--- User Profile ---");
            //Console.WriteLine($"Hello {name} \n your height is {height} \n employment status {employmentStatus} ");
            //Write a C# program that:

            //            ---

            //### ❓ Requirements

            //            1️⃣ Ask the user to enter their name

            //2️⃣ Convert the name to:

            //-Upper case
            //-Lower case

            //3️⃣ Ask the user to enter their age

            //4️⃣ Print a sentence using:

            //-Concatenation
            //- String Interpolation

            //5️⃣ Print the **first letter** of the name

            //6️⃣ Print the following format using special characters:
            Console.WriteLine("Enter Full Name :");
            string userName = Console.ReadLine();
            Console.WriteLine(userName.ToUpper());
            Console.WriteLine(userName.ToLower());
            Console.WriteLine("Enter Your Age");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("Your Name is " + userName + "Your Age :  " + age);
            Console.WriteLine($"The Fisrt letter is {userName[0]}");

            //### Task Description

            //            Write a C# program that:

            //1.Loops from 1 to 10
            //2.Skips printing** numbers divisible by 3 * * using `continue`
            //3.Stops the loop completely if the number** reaches 8 * * using `break`
            for (int i = 1; i <= 10; i++)
            {
                if (i % 3 == 0)
                {
                    continue;
                }
                if (i == 8)
                {
                    break;
                }
                Console.WriteLine(i);
            }
        }
    }
}
