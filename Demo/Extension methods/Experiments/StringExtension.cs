using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Experiments
{
   public static class  StringExtension
    {
        public static bool IsNullOrEmpty(String str)
        {

            return (str == null || str.Length == 0);
        }
        public static string IsDateTime(this String str)
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
            public static string ToDateTime(this String str)
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
