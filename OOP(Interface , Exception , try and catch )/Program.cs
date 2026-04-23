using OOP_Interface___Exception___try_and_catch__.Classes;
using OOP_Interface___Exception___try_and_catch__.Interfaces;
using System.Diagnostics.Metrics;
using System.Threading.Tasks;

namespace OOP_Interface___Exception___try_and_catch__
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //### Task Description

            //            1.Create an * *interface `ICalculator`** with method `Add(int a, int b)`
            //2. Create a class `Calculator` that implements the interface
            //3. Ask the user to enter two numbers
            //4. Use `try-catch` to handle invalid input
            //5. Print the result
            Calculator myCalc = new Calculator();
            bool isCorrectInput = false;

            while (!isCorrectInput)
            {
                try
                {
                    Console.Write("Enter the first number ");
                    int n1 = int.Parse(Console.ReadLine());

                    Console.Write("Enter the second number ");
                    int n2 = int.Parse(Console.ReadLine());

                    int result = myCalc.Add(n1, n2);

                    Console.WriteLine($"The result {result}");
                    isCorrectInput = true; 
                }
                catch (FormatException ex)
                {
                    Console.WriteLine(ex.ToString());                }
              
            }
        }
    }
}
