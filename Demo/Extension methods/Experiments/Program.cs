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
            String s /*= null*/;
            Console.WriteLine("Enter string: ");
            s = Convert.ToString(Console.ReadLine());
            Console.WriteLine("First test's result: " + StringExtension.IsNullOrEmpty(s));
            Console.WriteLine("Second test's result: " + IsEmpty(s));
            Console.WriteLine("Third test's result: " + StringExtension.IsDateTime(s));
            Console.ReadLine();
        }
        
        public static bool IsEmpty(String str)
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
    }    
}
