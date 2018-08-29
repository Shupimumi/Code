using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Experiments
{
   public static class  StringExtension
    {
        public static bool IsNullOrEmpty(this String str)
        {

            return (str == null || str.Length == 0);
        }
        public static string IsDateTime(this String str)
            {
                try
                {
                    return ToDateTime(str);
                }               
                catch (FormatException a)
                {
                    Console.WriteLine(a.Message);
                    return "False";
                }
                catch (IndexOutOfRangeException a)
                {
                    Console.WriteLine(a.Message);
                    return "False";
                }

            }
            public static string ToDateTime(this String str)
            {
                Console.WriteLine("\n"); 
                Char flag = '.';
                String[] substrings = str.Split(flag);                
                try
                {
                    int year = Convert.ToInt32(substrings[0]);
                    int month = Convert.ToInt32(substrings[1]);
                    int day = Convert.ToInt32(substrings[2]);
                    int hour = Convert.ToInt32(substrings[3]);
                    int minute = Convert.ToInt32(substrings[4]);
                    int second = Convert.ToInt32(substrings[5]);
                DateTime enteredDate = new DateTime(year, month, day, hour, minute, second);
                Console.WriteLine(enteredDate.ToLongDateString());
                Console.WriteLine(enteredDate.ToShortTimeString());
                return "True";
                }
                catch (FormatException a)
                {
                    Console.WriteLine(a.Message);
                    return "False";
                }
                catch (IndexOutOfRangeException a)
                {
                    Console.WriteLine(a.Message);
                    return "False";
                }
                catch (NullReferenceException a)
                {
                    Console.WriteLine(a.Message);
                    return "False";
                }

            }
        public static bool IsEmpty(this String str)
        {
            try
            {
                Console.WriteLine("The value of the string is '{0}'", str);
                Console.WriteLine("String length is {0}", str.Length);
                return true;
            }
            catch (NullReferenceException a)
            {
                Console.WriteLine(a.Message);
                return false;
            }
        }
    }
}
