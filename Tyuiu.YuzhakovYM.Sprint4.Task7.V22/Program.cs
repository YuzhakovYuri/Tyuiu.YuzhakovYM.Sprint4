using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.YuzhakovYM.Sprint4.Task7.V22.Lib;

namespace Tyuiu.YuzhakovYM.Sprint4.Task7.V22
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 3;
            int m = 5;
            int[,] matrix = new int[n, m];

            string str = "695324951753684";

            DataService ds = new DataService();
            Console.Title = "Спринт #4 | Выполнил: Южаков Ю. М. | АСОиУб-23-3";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Базовые навыки работы в C#                                        *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #22                                                             *");
            Console.WriteLine("* Выполнил: Южаков Юрий Михайлович | АСОиУб-23-3                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дана строка из одноразрядных цифр '695324951753684'. Преобразуйте ее в  *");
            Console.WriteLine("* матрицу 5 на 3 и подсчитайте произведение четных чисел.                 *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int index = 0;
            Console.WriteLine("\nМассив:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write($"{str[index]} \t");
                    index++;
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            int res = ds.Calculate(n, m, str);

            Console.WriteLine("Произведение четных чисел = " + res);
            Console.ReadKey();
        }
    }
}
