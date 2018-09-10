using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExperimentsLib
{
    public static class StringExtension
    {
        public static bool IsNullOrEmpty(this String str)
        {

            return (str == null || str.Length == 0);
        }
        public static bool IsDateTime(this String str)
        {
            try
            {
                DateTime date = str.ToDateTime();
                return true;
            }
            catch (FormatException a)
            {
                Console.WriteLine(a.Message);
                return false;
            }
            catch (IndexOutOfRangeException a)
            {
                Console.WriteLine(a.Message);
                return false;
            }

        }
        public static DateTime ToDateTime(this String str)
        {
            Console.WriteLine("\n");
            Char flag = '.';
            String[] substrings = str.Split(flag);
            int year = Convert.ToInt32(substrings[0]);
            int month = Convert.ToInt32(substrings[1]);
            int day = Convert.ToInt32(substrings[2]);
            int hour = Convert.ToInt32(substrings[3]);
            int minute = Convert.ToInt32(substrings[4]);
            int second = Convert.ToInt32(substrings[5]);
            DateTime enteredDate = new DateTime(year, month, day, hour, minute, second);
            return enteredDate;        
            
        }
        public static bool IsEmpty(this String str)
        {
            if (str.Length == 0)
            {
                return true;
            }
            else {
                Console.WriteLine("The value of the string is '{0}'", str);
                Console.WriteLine("String length is {0}", str.Length);
                return false;
            }
        }
    }
}
