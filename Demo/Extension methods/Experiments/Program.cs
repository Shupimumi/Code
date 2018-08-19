using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Experiments
{
    class Program
    {
        static void Main(string[] args)
        {
/*Example of entered Dates: Year.Month.Day.Hour.Minute (2018.8.19.18.30) */
            string s /*= null*/;
            Console.WriteLine("Enter string: ");
            s = Convert.ToString(Console.ReadLine());
            Console.WriteLine("First test's result: " + IsNullOrEmpty(s));
            Console.WriteLine("Second test's result: " + IsEmpty(s));
            Console.WriteLine("Third test's result: " + IsDateTime(s));
            Console.ReadLine();
        }
        public static string IsNullOrEmpty(string str)
        {
            
            try
            {
                if (str.Length < 0)
                {
                    return "Null";
                }
                else
                if (str.Length > 0)
                {
                    return "Full";
                }
                else
                    if (str.Length == 0)
                {
                    return "Empty";
                }
            }
            catch (FormatException k)
            {
                return k.Message;
            }
            catch (NullReferenceException k)
            {
                return k.Message;
            }
            return "End";
        }
        public static bool IsEmpty(string str)
        {
            try
            {
                Console.WriteLine("The value of the string is '{0}'", str);
                Console.WriteLine("String length is {0}", str.Length);
                return true;
            }
            catch (NullReferenceException e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }
    //}
    //    public static class StringExtension
    //    {
            public static string IsDateTime(string str)
            {
                try
                {
                    return ToDateTime(str);
                }
                catch (InvalidTimeZoneException a)
                {
                    Console.WriteLine(a.Message);
                    return "False";
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
            public static string ToDateTime(string str)
            {
            Console.WriteLine("\n");  
                Char flag = '.';
                String[] substrings = str.Split(flag);
                for (int i = 0; i < substrings.Length; i++)
                {
                    Console.Write("\t" + substrings[i]);
                }
            Console.WriteLine("\n");
                try
                {
                    int year = Convert.ToInt32(substrings[0]);                    
                    int month = Convert.ToInt32(substrings[1]);                    
                    int day = Convert.ToInt32(substrings[2]);                    
                    int hour = Convert.ToInt32(substrings[3]);                    
                    int minute = Convert.ToInt32(substrings[4]);
                    Console.WriteLine("\nyear: {0}; month: {1}; day: {2}; hour: {3}; minute: {4}.", year, month, day, hour, minute);
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
        }    
}
