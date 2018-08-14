using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example
{
    class Program
    {
        static void Main(string[] args)
        {
           
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());          
            for (; a - 1 != b; b--) // цикл для удаления элементов внутри диапазона
            {
                for (int g = b; g <= 9; g++) 
                {

                    arr[g - 1] = arr[g];

                }

            }
            // цикл для заполнения последних элементов массива нулём 

            for (int k = 9; k >= 0; k--)
            {
                if (arr[k] == 10)
                {
                    if (arr[k - 1] == arr[k])
                    {
                        arr[k] = 0;
                    }

                }
            }
            for (int l = 0; l < arr.Length; l++) // цикл для вывода массива на экран
            {
                Console.WriteLine("{0}", arr[l]);
            }
            
            Console.ReadLine();

        }
    }
}
