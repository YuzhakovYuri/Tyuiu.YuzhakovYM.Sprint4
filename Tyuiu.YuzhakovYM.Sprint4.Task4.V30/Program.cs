using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.YuzhakovYM.Sprint4.Task4.V30.Lib;

namespace Tyuiu.YuzhakovYM.Sprint4.Task4.V30
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] nMatrix = new int[5, 5] { { 3, 4, 6, 6, 5 }, { 6, 7, 6, 3, 5 }, { 5, 3, 5, 7, 6 }, { 6, 4, 7, 6, 6 }, { 7, 4, 3, 4, 5 } };
            int i_o = nMatrix.GetLength(0); int j_o = nMatrix.GetLength(1);

            DataService ds = new DataService();
            Console.Title = "Спринт #4 | Выполнил: Южаков Ю. М. | АСОиУб-23-3";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Двумерные массивы. (ввод с клавиатуры)                            *");
            Console.WriteLine("* Задание #4                                                              *");
            Console.WriteLine("* Вариант #30                                                             *");
            Console.WriteLine("* Выполнил: Южаков Юрий Михайлович | АСОиУб-23-3                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов, заполненный        *");
            Console.WriteLine("* значениями с клавиатуры в диапазоне от 3 до 7. Заменить нечетные        *");
            Console.WriteLine("* элементы массива на 0.                                                  *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Массив: ");
            for (int i = 0; i < i_o; i++)
            {
                for (int j = 0; j < j_o; j++)
                {
                    Console.Write(" " + nMatrix[i, j]);
                }

                Console.WriteLine();
            }
            Console.WriteLine();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Результат: ");
            int[,] res = ds.Calculate(nMatrix);

            for (int i1 = 0; i1 < res.GetLength(0); i1++)
            {
                for (int j1 = 0; j1 < res.GetLength(1); j1++)
                {
                    Console.Write(" " + nMatrix[i1, j1]);
                }

                Console.WriteLine();
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
