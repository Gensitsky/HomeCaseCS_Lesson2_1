/*Сжать массив, удалив из него все 0 и, заполнить ос-
вободившиеся справа элементы значениями –1*/
using System;
using System.Linq;

namespace HomeCaseCS_Lesson2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = 10;
            Random rnd = new Random();
            int[] arr = new int[length];

            Console.WriteLine("Source array: ");
            for (int i = 0; i < length; i++)
            {
                arr[i] = rnd.Next(2);
                Console.Write(arr[i] + " | ");
            }
            do
            {
                int j = 0;
                while (j < length)
                {
                    if (arr[j] == 0)
                    {
                        for (int i = j; i < length - 1; i++)
                        {
                            arr[i] = arr[i + 1];
                        }
                        arr[length - 1] = -1;
                    }
                    j++;
                }
            } while (arr.Contains<int>(0));
            
            Console.WriteLine("\n\nCompressed array:");
            foreach (var item in arr)
            {
                Console.Write(item + " | ");
            }

            Console.ReadKey();
        }
    }
}