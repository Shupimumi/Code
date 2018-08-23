using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example
{
    //class Program
    //{
    //    public static void Main()
    //    {
    //        //String value = Convert.ToString(Console.ReadLine());
    //        //Char flag = '.';
    //        //String[] substrings = value.Split(flag);                      
    //        //for (int i = 0; i < substrings.Length; i++)
    //        //{
    //        //    Console.WriteLine(substrings[i]);
    //        //}
    //        //try
    //        //{
    //        //    int year = Convert.ToInt32(substrings[0]);
    //        //    Console.WriteLine(year);
    //        //    int month = Convert.ToInt32(substrings[1]);
    //        //    Console.WriteLine(month);
    //        //    int day = Convert.ToInt32(substrings[2]);
    //        //    Console.WriteLine(day);
    //        //    int hour = Convert.ToInt32(substrings[3]);
    //        //    Console.WriteLine(hour);
    //        //    int minute = Convert.ToInt32(substrings[4]);
    //        //    Console.WriteLine(minute);

    //        //}
    //        //catch (FormatException e)
    //        //{
    //        //    Console.WriteLine(e.Message);
    //        //}
    //        //catch (IndexOutOfRangeException e)
    //        //{
    //        //    Console.WriteLine(e.Message);
    //        //}
    //        //Console.ReadLine();
        class Program
        {
            static void Main(string[] args)
            {
            //String s = null;
            int s = int.Parse(Console.ReadLine());
            string str = Convert.ToString(s);
            Console.WriteLine("First test's result: " + StringExtension.IsNullOrEmpty(str));
            Console.ReadLine();
            }
        }
    public static class StringExtension
    {
        public static bool IsNullOrEmpty(String str)
        {

            return (str == null || str.Length == 0);
        }
    }
    //public static class StringExtension
    //{
    //    public static int WordCount(this string str, char c)
    //    {
    //        int counter = 0;
    //        for (int i = 0; i < str.Length; i++)
    //        {
    //            if (str[i] == c)
    //                counter++;
    //        }
    //        return counter;
    //    }
    //}

}
        
//    }
//}

