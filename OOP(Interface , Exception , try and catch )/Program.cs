using Microsoft.VisualBasic;
using OOP_Interface___Exception___try_and_catch__.Classes;
using OOP_Interface___Exception___try_and_catch__.Interfaces;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Runtime.Intrinsics.X86;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace OOP_Interface___Exception___try_and_catch__
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //### Task Description

            // 1.Create an * *interface `ICalculator`** with method `Add(int a, int b)`
            //2. Create a class `Calculator` that implements the interface
            //3. Ask the user to enter two numbers
            //4. Use `try-catch` to handle invalid input
            //5. Print the result
            //Calculator myCalc = new Calculator();

            //int num1, num2;

            //while (true)
            //{
            //    try
            //    {
            //        Console.Write("Enter first number: ");
            //        num1 = int.Parse(Console.ReadLine());

            //        Console.Write("Enter second number: ");
            //        num2 = int.Parse(Console.ReadLine());

            //        break; 
            //    }
            //    catch
            //    {
            //        Console.WriteLine("Invalid input! Try again...\n");
            //    }
            //}

            //int result = myCalc.Add(num1, num2);
            //Console.WriteLine("Result = " + result);
            //### Task Description

            //            1.Create a text file `data.txt`
            //2.Write your name and age into the file
            //3.Read the file line by line and print it
            //4.Append a new line to the file
            //5. (Bonus) Use `try-catch` to handle errors
            //Console.WriteLine("----------Read From File----------");
            //var filePath = @"C:\Users\lap top\OneDrive\Desktop\data.txt";
            //var fileStream = File.OpenRead(filePath);
            //var streamReader = new StreamReader(fileStream);
            //string line;
            //while((line = streamReader.ReadLine()) != null)
            //{
            //    Console.WriteLine(line);

            //}
            //streamReader.Close();
            ////Add to file
            //Console.WriteLine("----------Add to File----------");

            //var writer = File.AppendText(filePath);
            //writer.WriteLine("Mechatronics Engineering");
            //writer.Dispose();
            //writer.Close();
            //### Task Description (New)

            //            -Write in a file your name, specialization, age, and a description of your life and the field in which you work.
            //            - You must read all the information you wrote in the file, line by line.
            //-You should print the total number of characters in the file, disregarding spaces between words.
            //- You should print the total number of words in the file, disregarding spaces as well.
            Console.WriteLine("--- Enter Your Information ---");
            var path = @"C:\Users\lap top\OneDrive\Desktop\datauser.txt";

            Console.Write("Name: ");
            string name = Console.ReadLine();

            Console.Write("Specialization: ");
            string spec = Console.ReadLine();

            Console.Write("Age: ");
            string age = Console.ReadLine();

            Console.Write("Describe your life/work field: ");
            string description = Console.ReadLine();
            string content = $"Name: {name}\n" +
                             $"Specialization: {spec}\n" +
                             $"Age: {age}\n" +
                             $"Description: {description}\n" +
                             $"----------------------------\n";
            File.AppendAllText(path, content);
            Console.WriteLine("----Read Data---");
            var fileStream = File.OpenRead(path);
            var streamReader = new StreamReader(fileStream);
            string line;
            while ((line = streamReader.ReadLine()) != null)
            {
                Console.WriteLine(line);

            }

            streamReader.Close();
        }
    }
}
