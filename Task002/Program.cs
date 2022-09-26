using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Task002
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // программа принимает на вход позиции элемента в двумерном массиве
            // и возвращает значение этого элемента или указание, что такого элемента нет



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

            // запрашиваем данные для генерирования массива

            int sizeVertical = 0;
            int sizeHorizontal = 0;
            int valueStart = 0;
            int valueFinish = 0;



            Console.WriteLine("Введите размер массива M"); // количество строк
            try
            {
                sizeVertical = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Вы ввели некорректные данные");
            }


            Console.WriteLine("Введите размер массива N"); // количество столбцов
            try
            {
                sizeHorizontal = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Вы ввели некорректные данные");
            }

            Console.WriteLine("Введите начало диапазона элементов"); // ввод старта
            try
            {
                valueStart = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Вы ввели некорректные данные");
            }


            Console.WriteLine("Введите конец диапазона элементов"); // ввод финиша
            try
            {
                valueFinish = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Вы ввели некорректные данные");
            }

            int[,] myArray = GetTwoDimArray(sizeVertical, sizeHorizontal, valueStart, valueFinish); // генерируем массив


            Console.WriteLine("Введите координату элемента массива Y"); // запрашиваем данные для элемента

            int y = 0;
            int x = 0;

            try
            {
                y = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Вы ввели некорректные данные");
            }

            Console.WriteLine("Введите координату элемента массива X");
            try
            {
                x = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Вы ввели некорректные данные");

            }



            if (y <= sizeVertical && x <= sizeHorizontal)
            {
                Console.WriteLine($"Значение заданного элемента в массиве равно {myArray[y, x]}");
            }
            else
            {
                Console.WriteLine("Данных координат не существует в массиве");
            }
        }

    }
}
