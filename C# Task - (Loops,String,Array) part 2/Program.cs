namespace C__Task____Loops_String_Array__part_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //LOOPS
            //Task 1
            //Console.WriteLine("-------------------Task 1 (loops) ----------------");
            //Console.WriteLine("Enter Number To Make pattern");
            //int row = int.Parse(Console.ReadLine());
            ////اللعب على الاسطر الفردية بدها تنطبع بالعكس
            //for (int i = 0; i < row; i++)
            //{
            //    if (i % 2 != 0)
            //    {
            //        for (int j = i + 1; j >= 1; j--)
            //        {
            //            Console.Write(j);
            //        }
            //    }
            //    else
            //    {
            //        for (int j = 1; j <= i + 1; j++)
            //        {
            //            Console.Write(j);
            //        }
            //    }


            //    Console.WriteLine();
            //}
            //Task 4
            //Console.WriteLine("-------------------Task 4 (loops) ----------------");
            //Console.WriteLine("Enter Number To Make pattern");
            //int row = int.Parse(Console.ReadLine());
            //for(int i = 0; i < row; i++)
            //{
            //    //ضربنا i ب 2 عشان اعوض الارقام الي عملتلها تجاهل
            //    //لانه نصف الارقام راحت
            //    for (int j = 0; j < i * 2; j++)
            //    {
            //        if (j % 2 == 0)
            //        {
            //            continue;
            //        }
            //        Console.Write(j);

            //    }
            //    Console.WriteLine();

            //}

            //Task 6
            //Console.WriteLine("-------------------Task 6 (loops) ----------------");
            //Console.WriteLine("Enter Number To Make pattern");
            //int row = int.Parse(Console.ReadLine());
            //for(int i = 0; i < row; i++)
            //{
            //    if(i % 2 == 0)
            //    {
            //        for(int j = 1; j <= i+1; j++)
            //        {
            //            Console.Write(j);
            //        }

            //    }
            //    else
            //    {
            //        for(int j = i+1; j >= 1; j--)
            //        {
            //            Console.Write(j);
            //        }
            //    }
            //    Console.WriteLine();    
            //}



            ////Task 9
            //Console.WriteLine("-------------------Task 9 (loops) ----------------");
            //Console.WriteLine("Enter Number To Make pattern");
            //int n = int.Parse(Console.ReadLine());
            //int counter = 0;
            //for(int i = 0; i < n; i++)
            //{
            //    for(int j = 0; j <= i; j++)
            //    {
            //        counter++;
            //        Console.Write(counter);
            //    }
            //    Console.WriteLine();
            //}

            //ARRAY
            //Task 1
            //Find first subarray (length ≥ 2) with all unique elements.
            //Console.WriteLine("-------------------Task 1 (Array) ----------------");

            //int[] arr = { 1, 2, 1, 3, 4 };
            //List<int> result = new List<int>();

            //for (int i = 0; i < arr.Length - 1; i++)
            //{
            //    if (arr[i] != arr[i + 1])
            //    {
            //        result.Add(arr[i]);
            //        result.Add(arr[i + 1]);

            //        break;
            //    }
            //}
            //Console.WriteLine($"First unique subarray:  [{string.Join(",", result)}]");
            //Task 3
            //Split array into chunks where values change.
            //Console.WriteLine("-------------------Task 3 (Array) ----------------");
            //int[] ints = { 1, 1, 2, 2, 3, 1 };
            //List<int> splitArray = new List<int>();
            //for (int i = 0; i < ints.Length; i++)
            //{
            //    splitArray.Add(ints[i]);

            //    if (i == ints.Length - 1 || ints[i] != ints[i + 1])
            //    {
            //        Console.Write($"[{string.Join(",", splitArray)}] ");
            //        splitArray.Clear();
            //    }
            //}
            //Task 7
            //Console.WriteLine("-------------------Task 7 (Array) ----------------");
            //Console.WriteLine("Enter the size of your array");
            //int size = int.Parse(Console.ReadLine());
            //List<int> ints1 = new List<int>();
            //for(int i =0; i< size; i++)
            //{
            //    Console.Write($"Enter number {i+1} : ");
            //    ints1.Add(int.Parse(Console.ReadLine()));

            //}
            //List<int> resultArr = new List<int>();
            //for(int i = 0;i< size; i++)
            //{
            //    //مافي رقم قبلخ ينطرح
            //    if (i == 0)
            //    {
            //        resultArr.Add(ints1[i]);
            //    }
            //    else
            //    {

            //        resultArr.Add(ints1[i] - ints1[i - 1]);
            //    }


            //}
            //Console.WriteLine($"[{string.Join(",",resultArr)}]");
            ////Task 8
            //Console.WriteLine("-------------------Task 8 (Array) ----------------");
            //List<int > list = new List<int>() {1,4,-2,3,-8 };
            //List<int> postive = new List<int>();
            //List<int> negative = new List<int>();

            //for (int i =0 ; i < list.Count; i++)
            //{
            //    if(list[i] < 0)
            //    {
            //        negative.Add(list[i]);
            //    }
            //    else
            //    {
            //        postive.Add(list[i]);
            //    }
            //}
            //List<int> alternativeArr= new List<int>();
            //int pIdx = 0;
            //int nIdx = 0;
            //// العددادين مشان انا ما بعرف طول كل مصفوفة احتباط مشان EXEPTION OUT OF RANGE
            //for (int i = 0 ; i < list.Count; i++)
            //{
            //    //حطيا الشرط مشان ترتيب الارقام ب index  الموجب حط الارقام الموجبة و العكس لسوالب
            //    if(i % 2 == 0 && pIdx < postive.Count)
            //    {
            //        //pIdx ==> عداد للموجب مشان ما ادخل بمشكلة outofrange
            //        alternativeArr.Add(postive[pIdx]);
            //        pIdx++;
            //    }
            //    else if( nIdx < negative.Count)
            //    {
            //        alternativeArr.Add(negative[nIdx]);
            //        nIdx++;
            //    }
            //}
            //Console.WriteLine($"The input [{string.Join(", ",list)}] => [{string.Join(", ", alternativeArr)}]");
            
           




        }
    }
}
