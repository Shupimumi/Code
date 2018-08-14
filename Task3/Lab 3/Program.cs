using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
    class Program
    {
        private static int RemoveElementsInRange(int[] arr, int from, int to)
        {
            int i = 0, j = 0;
            int length = arr.Length;
            while (i < arr.Length)
            {
                if (arr[i] >= from && arr[i] <= to)
                {
                    if (j + 1 < arr.Length)
                    {
                        arr[i] = arr[++j];
                    }
                    else
                    {
                        i = arr.Length;
                    }
                    --length;
                }
                else if (i < j)
                {
                    if (j + 1 < arr.Length)
                    {
                        arr[++i] = arr[++j];
                    }
                    else
                    {
                        i = arr.Length;
                    }
                }
                else
                {
                    ++i;
                    ++j;
                }
            }

            i = length;
            while (i < arr.Length)
            {
                arr[i] = 0;
                ++i;
            }
            return length;
        }

        public static int[] RemoveInRange(int[] arr, int from, int to)
        {
            var copy = new int[arr.Length];
            Array.Copy(arr, copy, arr.Length);

            int length = RemoveElementsInRange(copy, from, to);
            if (length == copy.Length)
                return copy;

            var result = new int[length];
            Array.Copy(copy, result, length);
            return result;
        }

        static void Main(string[] args)
        {

            int[] arr = { 1, 2, 3, 4, 5, 0, 6, 1, 2, 10 };
            const int a = 50, b = 100;
            // e.g. [a, b]
            //a = int.Parse(Console.ReadLine());
            //b = int.Parse(Console.ReadLine());

            // Shuffle array using list and random generator
            //var rand = new Random();
            //var list = new List<int>(arr);
            //arr = list.OrderBy(x => rand.Next()).ToArray();

            for (int index = 0; index < arr.Length; ++index)
            {
                Console.Write(arr[index]);
                Console.Write(',');
            }

            arr = RemoveInRange(arr, a, b);

            Console.WriteLine();
            for (int index = 0; index < arr.Length; ++index)
            {
                Console.Write(arr[index]);
                Console.Write(',');
            }
            Console.ReadLine();
        }
    }
}
