using System;
using System.Numerics;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Function_Part3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //// 1) Given a number, n, return a function which adds n to the number passed to it.
            //Console.WriteLine("----------Task 1---------");
            //Console.WriteLine("Enter N (The incrementer):");
            //int n = int.Parse(Console.ReadLine());
            //  //حفظنا بالدالة مقدار الاضافة 
            //var adderFunc = Add(n);
            //   //خلينا يدخل الرقم 
            //Console.WriteLine("Enter Num to add to it:");
            //int num = int.Parse(Console.ReadLine());
            ////هون الدالة اصلا حفظت كم مقدار الزيادة و رجعنا بعتنالها الرقم الي بدي اضيف عليه
            //int result = adderFunc(num);

            //Console.WriteLine($"The Result is: {result}");
            ////هاد عبارة عن clouser fun  بتوخد int ,  و بترجع int  
            //static Func<int, int> Add(int n)
            //{
            //    return (x) => n + x;
            //}
            //2) Create a function that takes in a number as a string n and returns the number without 
            //trailing and  leading zeros. 
            //Console.WriteLine("----------Task 2---------");
            //Console.WriteLine("Enter Number:");
            //string number = Console.ReadLine();
            //static string removeLeadingTrailing(string n)
            //{
            //    //بغض النظر في فاصلة او لا احذف من البداية
            //    string res = n.TrimStart('0');
            //    //في حال بتحتوي على نقطة وهذا  يدل انه عشري احذف من النهاية و احذف ز اذا كانت بالنهاية 
            //    if (res.Contains("."))
            //    {
            //        res = res.TrimEnd('0').TrimEnd('.');
            //    }

            //    return res == "" ? "0" : res;
            //}
            //Console.WriteLine(removeLeadingTrailing(number));
            //3)Create a function that takes an array of numbers and returns the second largest number. 
            //Console.WriteLine("----------Task 3---------");
            //List<double> numbers = new List<double>();
            //Console.WriteLine("Enter The size ");
            //int size = int.Parse(Console.ReadLine());
            //for (int i = 0; i < size; i++)
            //{
            //    Console.Write($"Enter The Number {i + 1} : ");
            //    numbers.Add(double.Parse(Console.ReadLine()));

            //}
            //static double secondLargest(List<double> numbers)
            //{

            //    double result = numbers.Distinct().OrderByDescending(x => x).Skip(1).FirstOrDefault();
            //    return result;

            //}
            //Console.WriteLine($"The second Largest number is {secondLargest(numbers)} ");
            //4) A repdigit is a positive number composed out of the same digit. Create a function that 
            //takes an integer and returns whether it's a repdigit or not. 
            //Console.WriteLine("----------Task 4---------");
            //Console.WriteLine("Enter The number");
            //int num = int.Parse(Console.ReadLine());
            //static bool isRepdigit(int num)
            //{
            //    if(num < 0)
            //    {
            //        return false;
            //    }
            //    if (num == 0)
            //    { return true;
            //    }
            //    string number = num.ToString();
            //    char[] chars = number.ToCharArray();
            //    for(int i = 0; i< chars.Length; i++)
            //    {
            //        if (chars[0] != chars[i])
            //        {
            //            return false;
            //        }
            //    }

            //    return true;
            //}
            //Console.WriteLine($"Is The Number {num} Repeated Digit   =>  {isRepdigit(num)}");

            ////5) Given an input string, reverse the string word by word, the first word will be the last, and 
            ////so on. 
            //Console.WriteLine("----------Task 5---------");
            //Console.WriteLine("Enter The Sentence");
            //string sentence = Console.ReadLine().Trim(' ');
            //static string reverseWords(string word)
            //{
            //    string[] words = word.Split(' ');
            //     List<string> result = new List<string>() ;
            //    for (int i = words.Length -1; i>=0; i--)
            //    {
            //        result.Add(words[i]) ;
            //    }
            //    return string.Join(' ',result);

            //}
            //Console.WriteLine($"The reverse of {sentence} => {reverseWords(sentence)}");
            //6) Create a function that takes an array of numbers and return "Boom!" if the digit 7 
            // appears in the array.  
            //Otherwise, return "there is no 7 in the array".
            //Console.WriteLine("----------Task 6 ---------");
            //static string sevenBoom(int[] ints)
            //{
            //    string s = string.Join("",ints);
            //    char[] chars = s.ToCharArray();

            //        for(int j = 0;j< chars.Length; j++)
            //        {
            //          if (chars[j] == '7' )
            //        {
            //            return "Boom!";
            //        }
            //        }


            //    return "there is no 7 in the array";
            //}
            //Console.WriteLine(sevenBoom([2, 55, 60, 97, 86]));
            //7) Write a function that inserts a white space between every instance of a lower 
            //character followed immediately by an upper character.
            // Console.WriteLine("----------Task 7 ---------");
            //Console.WriteLine("Write the text");
            //string text = Console.ReadLine();   
            //static string insertWhitespace(string text)
            //{
            //    var result = new StringBuilder();
            //    for (int i =0;i< text.Length  ;i++)
            //    {
            //        result.Append(text[i]);
            //        if(i<text.Length -1 &&  char.IsLower(text[i]) && char.IsUpper(text[i + 1])){

            //            result.Append(" ");
            //        }
            //    }
            //    return result.ToString();
            //}
            //Console.WriteLine($"{text} = > {insertWhitespace(text)}" );
            //8) Create a function which returns the number of true values there are in an array. 
            //Console.WriteLine("----------Task 8 ---------");
            //Console.WriteLine("Enter the size for your array");
            //int size = int.Parse(Console.ReadLine());                           
            //List<bool> bools= new List<bool> ();
            //for (int i =0;i< size;i++)
            //{
            //    Console.Write($"Enter the value  {i+1}:  ");
            //    bools.Add(bool.Parse(Console.ReadLine().ToLower()));  


            //}
            //static int countTrue(List<bool> bools)
            //{
            //    int count = 0;
            //    for(int i = 0;i<bools.Count; i++)
            //    {
            //   if (bools[i])
            //    {
            //        count++;
            //    }
            //    }

            //    return count;
            //}

            //Console.WriteLine(countTrue(bools));
            //9) Create a function that moves all capital letters to the front of a word. 
            //Console.WriteLine("----------Task 9 ---------");
            //Console.WriteLine("Write your Sentence");
            //string s = Console.ReadLine();
            //static string capToFront(string s)
            //{
            //    char[] chars = s.ToCharArray();
            //    var result = new StringBuilder();
            //    for (int i = 0; i < chars.Length; i++)
            //    {
            //        if (char.IsUpper(chars[i])) {
            //            result.Append(chars[i]);

            //        }

            //    }
            //    for (int i = 0; i < chars.Length; i++)
            //    {
            //        if (char.IsLower(chars[i]))
            //        {
            //            result.Append(chars[i]);

            //        }

            //    }

            //    return result.ToString();
            //}
            //Console.WriteLine($"{s} => {capToFront(s)}" );
            //10) Create a function that takes an array of items and checks if the last item matches 
            //the rest of the array concatenated together.
            //  Console.WriteLine("----------Task 10 ---------");
            //static bool matchLastItem(object[] strings)
            //{
            //    string lastElement = strings.Last().ToString().ToLower();
            //    var restOfArray = strings.Take( strings.Length - 1);

            //    if (! (string.Join("", restOfArray).ToLower()).Equals(lastElement))
            //    {
            //        return false;

            //    }
            //    return true;
            //}
            //Console.WriteLine(matchLastItem([8, "thunder", true, "8thundertrue"]));
            //11) Create a function to find NaN in an array of numbers. The return value should be the 
            //index where NaN is found.If NaN is not found in the array, then return -1.
            // Console.WriteLine("----------Task 11 ---------");
            //static int findNaN(object[] objects)
            //{
            //    for(int i = 0; i < objects.Length; i++)
            //    {
            //        //بشيك اذا double  شيك  عليه
            //        //IsNaN accsept only double value
            //        if (objects[i] is double d && double.IsNaN(d))
            //        {
            //            return i;
            //        }
            //    }
            //    return -1;
            //}
            //Console.WriteLine(findNaN([1, 2, double.NaN]));
            //12) Create a function that takes an array of items, removes all duplicate items and 
            //returns a new array in the same sequential order as the old array(minus duplicates). 
            // Console.WriteLine("----------Task 12 ---------");

            //static string removeDups(List<object> objects)
            //{
            //    List<object> list = new List<object>();
            //    for(int i =0; i < objects.Count  ; i++)
            //    {
            //        if (!list.Contains(objects[i]))
            //        {
            //            list.Add(objects[i]);
            //        }

            //    }
            //    return string.Join(",",list);
            //}
            //Console.WriteLine($"[{removeDups(["The", "big", "cat"])}]");
            //13) Write a function that receives the time in 12-hour AM/PM format and returns a 
            //string representation of the time in military(24 - hour) format.
            Console.WriteLine("----------Task 13 ---------");
            static string convertTime(string time)
            {
                string period = time.Substring(time.Length - 2); // AM أو PM

                int hours = int.Parse(time.Substring(0, 2));
                string minutesAndSeconds = time.Substring(2, 6); // الدقائق و الثواني


                if (period == "AM")
                {
                    if (hours == 12)
                    { hours = 0; }
                }
                else
                {
                    //PM
                    if (hours != 12)
                    { hours += 12; }
                }
                //D2 => هون يعني DECIMAL  بخانتين عشان اذا خانة يضيف وحدة
                return hours.ToString("D2") + minutesAndSeconds;
            }
            Console.WriteLine(convertTime("01:40:22PM"));
            //14) Write a function that removes the last vowel in each word in a sentence. 
            Console.WriteLine("----------Task 14 ---------");
            static string removeLastVowel(string sentence)
            {
                string vowels = "aeiouAEIOU";
                string[] words = sentence.Split(' ');

                for (int i = 0; i < words.Length; i++)
                {
                    //اخدنا الكلمة الحالية
                    string word = words[i];
                    //عملنا لوب عكسي
                    for (int j = word.Length - 1; j >= 0; j--)
                    {
                        if (vowels.Contains(word[j]))
                        {
                            //remove(startindex, count)
                            //count => كم حرف نحذف
                            word = word.Remove(j, 1);
                            break;
                        }
                    }

                    words[i] = word;
                }

                return string.Join(" ", words);
            }
            Console.WriteLine(removeLastVowel("Those who dare to fail miserably can achieve greatly."));

            //15) Create a function that takes in an array of numbers and returns the sum of its cubes. 
            Console.WriteLine("----------Task 15 ---------");
            static double sumOfCubes(double[] nums)
            {
                double sum = 0;
                for (int i = 0; i < nums.Length; i++)
                {
                    sum += Math.Pow(nums[i], 3);

                }
                return sum;
            }
            Console.WriteLine($"The Sum of cubes is {sumOfCubes([1, 5, 9,3])}");


        }
    }
}
