using System.Collections.Generic;
using System.Diagnostics.Metrics;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace OOP_Principles_in_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////First Task 
            ////## **Task Description: Static Class**
            //// Create a `static class` called `MathUtilities` that includes helper methods such as:

            ////- A method to calculate the square of a number
            ////- A method to calculate the square root
            ////- A method to find the maximum between two numbers

            ////** Requirements:**

            ////- Prevent creating objects from the class
            ////- Call the methods inside `Main`

            ////Task 1
            //Console.WriteLine("----------Task Description: Static Class -------------");
            //Console.WriteLine("------------Task 1------------");
            //Console.WriteLine("Enter number to calculate square");
            //double num = double.Parse(Console.ReadLine());
            //Console.WriteLine($"The square of number {num} = {MathUtilities.ClaculateSquarenumber(num)}");
            ////Task 2
            //Console.WriteLine("------------Task 2------------");
            //Console.WriteLine("Enter number to calculate square root");
            //double number = double.Parse(Console.ReadLine());
            //Console.WriteLine($"The square root of number {number} = {MathUtilities.CalculateTheSquareRoot(number)}");

            ////Task 3
            //Console.WriteLine("------------Task 3------------");
            //Console.WriteLine("Enter first number to find max number ");
            //double firstNum = double.Parse(Console.ReadLine());
            //Console.WriteLine("Enter second number to find max number");
            //double secondNum = double.Parse(Console.ReadLine());
            //Console.WriteLine($"The max number between {firstNum} and {secondNum} is {MathUtilities.FindTheMaximumBetweenTwoNumbers(firstNum,secondNum)}");
            ////Second Task
            ////## **Task Description: Static Method**
            //// Create a regular class called `Converter` that contains `static methods` to convert:
            ////- Celsius to Fahrenheit
            ////- Kilometers to Miles
            ////** Requirements:**
            ////- Call methods without creating an object
            ////- Print the results
            //Console.WriteLine("------------Task Description: Static Method ---------");
            //Console.WriteLine("------------Task 1------------");
            //Console.WriteLine("Enter number to convert from Celsius to ahrenheit");
            //double numbers = double.Parse(Console.ReadLine());
            //Console.WriteLine($" {numbers} C = {Converter.ConvertFormCelsiusToFahrenheit(numbers)} F");
            //Console.WriteLine("Enter number to convert from kilometers to Miles");
            //double nums= double.Parse(Console.ReadLine());
            //Console.WriteLine($"{nums} Km = {Converter.ConvertFormKilometersToMiles(nums)} M ");
            // //## 📝 **Task Description: Static Field**

            // //            Create a class `VisitorCounter` that contains:

            // //- A `static field` to store the number of visitors
            // //- Each time a new object is created, increment the counter

            // //** Requirements:**

            // //- Display the number of visitors after creating multiple objects
            // Console.WriteLine("------------Task Description: Static Field---------------");
            //Console.WriteLine("------------Task 1------------");
            // VisitorCounter visitorOne = new VisitorCounter();
            // VisitorCounter visitorTwo = new VisitorCounter();
            // VisitorCounter visitorThree = new VisitorCounter();
            // VisitorCounter visitorFour = new VisitorCounter();
            // Console.WriteLine($"Total Visitors: {VisitorCounter.Count}");
            //## **Task Description: Static Property**

            // Create a class `Company` that includes:

            //- A `static property` representing the company name
            //- A `non-static property` representing the employee name

            //**Requirements:**

            //- Set the company name once
            //- Create multiple employees and print the company name with each employee
             Console.WriteLine("------------Task Description: Static Proptry---------------");

            Company.Name = "Orange";
            Company employeeOne = new Company();
            employeeOne.EmployeeName = "Ahmad";
            Company employeeTwo = new Company();
            employeeTwo.EmployeeName = "Yasmeen";
            Console.WriteLine($" Employee Number one {employeeOne.EmployeeName } from {Company.Name} Compny");
            Console.WriteLine($"Employee Number Two {employeeTwo.EmployeeName} from {Company.Name} Compny");

            //### Task Description

            //   1.Create a class with **method overloading** (e.g., `Add`)
            //2. Create a base class `Animal` with virtual method `Speak()`
            //3. Create a derived class `Cat` and override `Speak()`
            //4. Create a class `Person` with private field and property(Encapsulation)
            //5. Create an **abstract class `Shape`** with method `GetArea()`
            //6. Create a class `Rectangle` that inherits from `Shape`

            






        }
    }
}
