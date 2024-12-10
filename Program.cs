using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp111
{
    class Program
    {
        /// <summary>
        /// Разработайте программу,
        /// заполняющую массив из n эллементов случайными целыми числами 
        /// находящимся в интервале от 1 до 80.
        /// Выведите на экран компьютера созданный массив
        /// и найдите max и min,а так же осуществить их обмен.
        /// </summary>
        /// <param name="args"></param>
        static int Size()
        {
            Console.Write("Размер одномерного массива");
            int size;
            while (!int.TryParse(Console.ReadLine(), out size) || size <= 0)
            {
                Console.WriteLine("Ошибка");
            }
            return (size);
        }
        static int[] Input(int size)
        {
            int[] omas = new int[size];
            Random rnd = new Random();
            for (int i = 0; i < omas.Length; i++)
            {
                omas[i] = rnd.Next(0, 80);
                Console.WriteLine($"omas[{i}]={omas[i]}");
            }
            return (omas);
        }
        static void Swap(ref int max,ref int min)
        {
            int s =max;
            max = min;
            min = s;
        }
        static void Output(int[] omas)
        {
            for(int i=0; i<omas.Length; i++)
            {
                Console.WriteLine($"{i + 1}элемент массива={omas[i]}");
            }
        }
        static void Main(string[] args)
        {
            int[] omas = Input(Size());
            int max = omas.Max();
            int min = omas.Min();
            Console.WriteLine($"{max}\t{min}");
            Output(omas);
            Console.Read();
        }
    }
}
