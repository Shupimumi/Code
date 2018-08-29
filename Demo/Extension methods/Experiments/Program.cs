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
            int choose;
            Console.WriteLine("Just choose your variant and enter 1 or 2. \n1.I want to enter any date. \n2.I want to enter any other string.");
            do
            {
                choose = int.Parse(Console.ReadLine());
            } while (choose < 1 || choose > 2);
            if (choose == 1)
            {
                Console.WriteLine("Enter string: ");
                s = Convert.ToString(Console.ReadLine());
                Console.WriteLine("<Null or Empty> test's result: " + s.IsNullOrEmpty());
                Console.WriteLine("<Is empty?, lenght, value> test's result: " + s.IsEmpty());
            }
            if (choose == 2)
            {
                Console.WriteLine("Enter string (example: YYYY.MM.DD.HH.MM.SS): ");
                s = Convert.ToString(Console.ReadLine());
                Console.WriteLine("<DateTime> test's result: " + s.IsDateTime());
            }                         
         Console.ReadLine();
        }
        
        
    }    
}
