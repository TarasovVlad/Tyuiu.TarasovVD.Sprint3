﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.TarasovVD.Sprint3.Task5.V17.Lib;

namespace Tyuiu.TarasovVD.Sprint3.Task5.V17
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                                         *");
            Console.WriteLine("***************************************************************************");

            int x = 2;
            int startValue1 = 1;
            int stopValue1 = 3;
            int startValue2 = 1;
            int stopValue2 = 12;
            Console.WriteLine("Переменная X = " + x);
            Console.WriteLine("Старт шага первой суммы ряда = " + startValue1);
            Console.WriteLine("Конец шага первой суммы ряда= " + stopValue1);
            Console.WriteLine("Старт шага второй суммы ряда = " + startValue2);
            Console.WriteLine("Конец шага второй суммы ряда= " + stopValue2);
            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Сумма ряда = " + ds.GetSumSumSeries(x, startValue1, startValue2, stopValue1, stopValue2));



            Console.ReadKey();
        }
    }
}
