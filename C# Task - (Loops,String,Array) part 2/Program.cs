namespace C__Task____Loops_String_Array__part_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //LOOPS
            //Task 1
            Console.WriteLine("Write input to make pattern");
            int input = int.Parse(Console.ReadLine());
            //Task 2
            //Write a program to print mirrored numbers.
            //ARRAY
            //Task 1
            //Find first subarray (length ≥ 2) with all unique elements.
            int[] arr = { 1, 2, 1, 3, 4 };
            List<int> result = new List<int>();

            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] != arr[i + 1])
                {
                    result.Add(arr[i]);
                    result.Add(arr[i + 1]);

                    break;
                }
            }
            Console.WriteLine($"First unique subarray:  [{string.Join(",", result)}]");
            //Task 2
            //Find elements that appear with equal distance between occurrences.
            //Task 3
            //Split array into chunks where values change.
            int[] ints = { 1, 1, 2, 2, 3, 1 };
            List<int> splitArray = new List<int>();
            for (int i = 0; i < ints.Length; i++)
            {
                splitArray.Add(ints[i]);

                if (i == ints.Length - 1 || ints[i] != ints[i + 1])
                {
                    Console.Write($"[{string.Join(",", splitArray)}] ");
                    splitArray.Clear();
                }
            }
            //Task 3

        }
    }
}
