using System.Collections.Generic;
using static System.Collections.Specialized.BitVector32;

namespace Methods_List_LINQ_LinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Section 1: List 
            //Task 1: Even Numbers Filter
            Console.WriteLine("--------Task 1---------");
            List<int> list = [12, 14, 55, 89, 90];
            List<int> evenNumbers = list.Where(x => x % 2 == 0).ToList();
            foreach (int x in evenNumbers)
            {
                Console.WriteLine(x);
            }
            //Task 2: Remove Duplicates
            Console.WriteLine("--------Task 2---------");
            List<int> list1 = [14, 14, 55, 89, 55, 30, 14];
            List<int> filterdList = list1.Distinct().ToList();
            foreach (int x in filterdList)
            {
                Console.WriteLine(x);
            }
            //Task 3: Find Maximum Number
            Console.WriteLine("--------Task 3---------");
            int maxValue = list.Max();
            Console.WriteLine(maxValue);
            //Task 4: Reverse List
            Console.WriteLine("--------Task 4---------");
            List<int> reversedList = list.OrderByDescending(x => x).ToList();
            foreach (int x in reversedList)
            {
                Console.WriteLine(x);
            }
            //Task 5: Count Numbers Greater Than X
            Console.WriteLine("--------Task 5---------");
            int count = list.Where(x => x > 50).Count();
            Console.WriteLine(count);
            // Section 2: Dictionary
            //Task 6: Student Scores
            Console.WriteLine("--------Task 6---------");
            Dictionary<string, int> studentsScore = new Dictionary<string, int>()
            {
                ["Yasmeen"] = 90,
                ["Ahmad"] = 85,
                ["Khalid"] = 77
            };
            var result = studentsScore.Where(x => x.Value > 80).ToList();
            foreach (var student in result)
            {
                Console.WriteLine($"{student.Key} : {student.Value}");
            }
            //Task 7: Search by Key
            Console.WriteLine("--------Task 7---------");

            string name = "Ahmad";

            if (studentsScore.ContainsKey(name))
            {
                Console.WriteLine($"{name} : {studentsScore[name]}");
            }
            else
            {
                Console.WriteLine("Not found");
            }
            // Task 8: Sum of Values
            Console.WriteLine("--------Task 8---------");

            var results = studentsScore.Sum(x => x.Value);
            Console.WriteLine(results);
            //Task 9: Remove Low Scores
            Console.WriteLine("--------Task 9---------");
            var toRemove = studentsScore
     .Where(x => x.Value < 50)
     .Select(x => x.Key)
     .ToList();
            foreach (var key in toRemove)
            {
                studentsScore.Remove(key);
            }
            foreach (var item in studentsScore)
            {
                Console.WriteLine($"{item.Key} : {item.Value}");
            }
            // Task 10: Highest Score
            Console.WriteLine("--------Task 10---------");
            var heighestScore = studentsScore.Max(x => x.Value);
            Console.WriteLine(heighestScore);
            //Section 3: LinkedList
            //Task 11: Add Elements
            Console.WriteLine("--------Task 11---------");
            LinkedList<string> strings = new LinkedList<string>();
            strings.AddFirst("Yasmeen");
            strings.AddLast("swsan");
            strings.AddLast("Abeer");
            foreach (var item in strings)
            {
                Console.WriteLine(item);

            }
            //Task 12: Remove Middle Element
            Console.WriteLine("--------Task 12---------");
            var resulta = strings.Remove("swsan");
            foreach (var item in strings)
            {
                Console.WriteLine(item);

            }
            //Task 13: Add Before/After
            Console.WriteLine("--------Task 13---------");

            LinkedListNode<string> targetNode = strings.Find("Abeer");

            if (targetNode != null)
            {
                strings.AddBefore(targetNode, "Laila");
            }
            LinkedListNode<string> targetNodeAfter = strings.Find("Abeer");
            if (targetNode != null)
            {
                strings.AddAfter(targetNodeAfter, "Heba");
            }

            foreach (var item in strings)
            {
                Console.WriteLine(item);

            }

            // Task 14: Traverse LinkedList
            Console.WriteLine("--------Task 14---------");
            foreach (var item in strings)
            {
                Console.WriteLine(item);

            }
            //Task 15: First and Last
            Console.WriteLine("--------Task 15---------");
            Console.WriteLine("First: " + strings.First.Value);
            Console.WriteLine("Last: " + strings.Last.Value);
            //Section 4: LINQ (مهم جداً)
            //Task 16: Odd Numbers
            Console.WriteLine("--------Task 16---------");
            List<int> numbers = [9,12, 33, 128, 66, 90, 3 , 13,200];
            List<int> filterdNumbers = numbers.Where(x => x % 2 != 0).ToList();
            Console.WriteLine(string.Join(",",filterdNumbers));
            //Task 17: Multiply All Numbers
            Console.WriteLine("--------Task 17---------");
            List<int> multiply = numbers.Select(x=> x * 2 ).ToList();
            Console.WriteLine(string.Join(",", multiply));
            //Task 18: Sort Descending
            Console.WriteLine("--------Task 18---------");
            List<int> sortList = numbers.OrderByDescending(x=>x).ToList();
            Console.WriteLine(string.Join(", ", sortList));
            //Task 19: First Number Greater Than 100
            Console.WriteLine("--------Task 19---------");
            int first = numbers.FirstOrDefault(x => x > 100);
            Console.WriteLine(first);
            //Task 20: Average Calculation
            Console.WriteLine("--------Task 20---------");
            double avarge = numbers.Average(x => x);
            Console.WriteLine(Math.Round(avarge,2));
            // Section 5: Mixed
            //Task 21: Compare Two Lists
            Console.WriteLine("--------Task 21 ---------");
            List<int> list2 = new List<int>([10, 20, 30, 40, 50]);

            List<int> list3 = new List<int>([30, 50, 70, 90]);


            foreach (int number in list2)
            {
                if (list3.Contains(number))
                {
                    Console.WriteLine($"The number {number} in both lists.");
                }
            }
            // Task 22: Merge Two Lists
            Console.WriteLine("--------Task 22 ---------");
            List<int> mergedList = list2.Concat(list3).ToList();
            Console.WriteLine($"[{string.Join(",", mergedList)}]");
            //Task 23: Unique Values Only
            Console.WriteLine("--------Task 23---------");
            List<int> uniqueList = mergedList.Distinct().ToList();
            Console.WriteLine(string.Join(",", uniqueList));
            //Task 24: Dictionary to List
            Console.WriteLine("--------Task 24---------");
            Dictionary<string, int> items = new Dictionary<string, int>
{
    { "Apple", 10 },
    { "Banana", 20 },
    { "Orange", 30 }
};
 
            List<string> valuesList = new List<string>(items.Keys);

            foreach (var val in valuesList)
            {
                Console.WriteLine(val);
            }
            //Task 25: Filter Dictionary
            Console.WriteLine("--------Task 25---------");
            string value = "Apple";
            if (items.ContainsKey(value))
            {
                int val = items["Apple"];
                Console.WriteLine($"{value}: {val}");
            }









        }
    }
}