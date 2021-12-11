using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(@"Сформировать одномерный массив из 7 элементов. Заполнить массив числами, 
вводимыми с клавиатуры, определить среднее арифметическое элементов.");
            Console.WriteLine("");

            
            int[] array = new int[7];

            for (int i = 1; i < 8; i++)
            {
                Console.Write("Введите элемент массива №" + i + ": ");
                                array[i - 1] = Convert.ToInt32(Console.ReadLine());
            }

           
            int Sum = 0;

            
            foreach (int j in array)
            {
                Sum += j;
            }

            
            double MeanValue = Sum / (double)array.Length;

            Console.Write("Среднее арифметическое: " + MeanValue);

            Console.ReadKey();

        }
    }
}
