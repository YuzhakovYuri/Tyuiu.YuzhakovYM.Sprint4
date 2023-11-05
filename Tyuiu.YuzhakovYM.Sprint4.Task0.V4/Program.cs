using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.YuzhakovYM.Sprint4.Task0.V4.Lib;

namespace Tyuiu.YuzhakovYM.Sprint4.Task0.V4
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #4 | Выполнил: Южаков Ю. М. | АСОиУб-23-3";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Одномерные массивы (статический ввод)                             *");
            Console.WriteLine("* Задание #0                                                              *");
            Console.WriteLine("* Вариант #4                                                              *");
            Console.WriteLine("* Выполнил: Южаков Юрий Михайлович | АСОиУб-23-3                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан одномерный целочисленный массив на 10 элементов заполненный         *");
            Console.WriteLine("* статическими значениями в диапазоне от 0 до 9; подсчитать произведение  *");
            Console.WriteLine("* четных элементов массива.  {5 ,3 ,7 ,1 ,3 ,9 ,8 ,7 ,9 ,4}               *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Массив: {5 ,3 ,7 ,1 ,3 ,9 ,8 ,7 ,9 ,4}");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            int[] nArray = { 5, 3, 7, 1, 3, 9, 8, 7, 9, 4 };

            Console.WriteLine("Результат = " + ds.GetMultEvenArrEl(nArray));
            Console.ReadKey();

        }
    }
}
