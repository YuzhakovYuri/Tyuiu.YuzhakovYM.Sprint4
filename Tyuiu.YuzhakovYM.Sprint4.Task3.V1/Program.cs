using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.YuzhakovYM.Sprint4.Task3.V1.Lib;

namespace Tyuiu.YuzhakovYM.Sprint4.Task3.V1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] nArray = { { 3, 4, 3, 4, 1 }, { 8, 1, 6, 6, 9 }, { 9, 8, 5, 1, 3 }, { 1, 8, 7, 1, 2 }, { 9, 9, 7, 5, 6 } };
            int i_o = nArray.GetLength(0); int j_o = nArray.GetLength(1);

            DataService ds = new DataService();
            Console.Title = "Спринт #4 | Выполнил: Южаков Ю. М. | АСОиУб-23-3";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Двумерные массивы. (статический ввод)                             *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #1                                                              *");
            Console.WriteLine("* Выполнил: Южаков Юрий Михайлович | АСОиУб-23-3                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов, заполненный        *");
            Console.WriteLine("* статическими значениями в диапазоне от 1 до 9.                          *");
            Console.WriteLine("* Найдите сумму элементов в последнем столбце массива.                    *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Массив: ");
            for (int i = 0; i < i_o; i++)
            {
                for (int j = 0; j < j_o; j++)
                {
                    Console.Write(" " + nArray[i, j]);
                }

                Console.WriteLine();
            }
            Console.WriteLine();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            int res = ds.Calculate(nArray);
            Console.WriteLine(res);
            Console.ReadKey();

        }
    }
}
