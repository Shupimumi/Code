using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_with_List
{
    class Program
    {
        static void Main(string[] args)
        {
            int first_pos, second_pos;
            List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Console.WriteLine("Array before any changes:");
            foreach (int k in numbers)
            {
                Console.WriteLine(k);
            }
            Console.WriteLine("--------------------------------");
            do
            {
                Console.WriteLine("Enter first number of range: ");
                first_pos = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter second number of range: ");
                second_pos = int.Parse(Console.ReadLine());
            } while ((first_pos <= 0) || (second_pos <= 0) || (first_pos > 10) || (second_pos > 10));
            if (first_pos == second_pos)
            {
                numbers.Remove(first_pos);
            }
            if (first_pos < second_pos)
            {
                for (int i = first_pos + 1; i < second_pos; i++)
                {
                    numbers.Remove(i);
                }
                
            }
            if (first_pos > second_pos)
            {
                for (int i = second_pos + 1; i < first_pos; i++)
                {
                    numbers.Remove(i);
                }
            }
            Console.WriteLine("----------------------------------");
            foreach (int k in numbers)
                {
                    Console.WriteLine(k);
                }


            Console.ReadKey();
        }
        }
    }

