using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task001
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // задать двумерный массив размеров m*n, заполненный случайными числами

            Console.WriteLine("Введите размер массива М");
            int m = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите размер массива N");
            int n = int.Parse(Console.ReadLine());

            var random = new Random();

            double[,] array = new double[m, n];

            for (int i = 0; i < m; i++) // генерируем массив
            {
                for (int j = 0; j < n; j++)
                {
                    array[i, j] = random.NextDouble() * 100 + 1;
                    array[i, j] = Math.Round(array[i, j], 2);
                }
            }

            // выводим массив на консоль

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j] + "\t");
                }
                Console.WriteLine();
            }



        }
    }
}
