namespace Methods_List_LINQ_LinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Section 1: List 
            //Task 1: Even Numbers Filter
            Console.WriteLine("--------Task 1---------");
            List<int> list = [12,14,55,89,90];
            List<int> evenNumbers = list.Where(x=> x % 2 == 0).ToList();
            foreach (int x in evenNumbers)
            {
                Console.WriteLine(x);
            }
            //Task 2: Remove Duplicates
            Console.WriteLine("--------Task 2---------");
            List<int> list1 = [14, 14, 55, 89, 55 , 30 , 14];
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
            List<int> reversedList= list.OrderByDescending(x=>x).ToList();
            foreach (int x in reversedList)
            {
                Console.WriteLine(x);
            }
            //Task 5: Count Numbers Greater Than X
            Console.WriteLine("--------Task 5---------");
            int count = list.Where(x=>x>50).Count();
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
          var result = studentsScore.Where(x=>x.Value > 80).ToList();
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
            LinkedList<string> strings = new LinkedList<string>() {"swsan" , "Abeer" };
            strings.AddFirst("Ahmad");
            strings.AddLast("Khalid");
            foreach (var item in strings)
            {
                Console.WriteLine(item);
                
            }



        }
    }
}
