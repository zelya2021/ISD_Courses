using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int[] arr = new int[] { 4, 14, 4, 69, 48, 3, 8, 6, 321, 44444, 78, 56, 23 };
            Console.WriteLine("Массив перед сортировкой:");
            foreach (int a in arr)
            {
                Console.WriteLine(a);
            }
            Console.WriteLine("Если вы хотите отсортировать массив по возрастанию, то введите 0, если по убыванию, то 1.");
            if (Console.ReadLine() == "0")
            {
                arr.SortByBool(0, arr.Length - 1, true);
                foreach (int a in arr)
                {
                    Console.WriteLine(a);
                }
            }
            else if (Console.ReadLine() == "1")
            {
                arr.SortByBool(0, arr.Length - 1, false);
                foreach (int a in arr)
                {
                    Console.WriteLine(a);
                }
            }
            else
                Console.WriteLine("Некорректный ввод!");
        }
    
    }
}
