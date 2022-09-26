using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task003
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // задать двумерный массив целых чисел и найти среднее арифм элементов в каждом столбце

            
            
            // метод генерирует массив
            int[,] GetTwoDimArray(int m, int n, int start, int finish)
            {
                int[,] array = new int[m, n];

                var random = new Random();

                for (int i = 0; i < m; i++)
                {
                    for (int j = 0; j < m; j++)
                    {
                        array[i, j] = random.Next(start, finish);
                    }
                }
                return array;
            }

            double[] GetAverage(int[,] array) // метод считает среднее арифм в столбцах и генерирует новый массив из значений
            {
                double[] arrayAverage = new double[array.GetLength(1)]; // новый массив для значений

                double sum = 0;

                for (int i = 0; i < array.GetLength(0); i++)
                {
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        sum = sum + array[j, i];
                    }
                    arrayAverage[i] = sum / array.GetLength(0);
                }
                return arrayAverage;
       
            }

            // метод вывода на консоль двумерного массива
            void PrintTwoDimArray(int[,] array)
            {
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        Console.Write(array[i, j] + "\t");
                    }
                    Console.WriteLine();
                }
            }

            // метод вывода на консоль одномерного массива

            void PrintArray(double[]array)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    Console.Write(array[i] + "\t");
                }
            }




            // генерируем массив

            int[,] myArray = GetTwoDimArray(5, 5, 1, 10);

            PrintTwoDimArray(myArray);

            double [] myArrayAverage = GetAverage(myArray);

            Console.WriteLine("Среднее арифметическое столбцов двумерного массива: ");

            PrintArray(myArrayAverage);
        }
    }
}
