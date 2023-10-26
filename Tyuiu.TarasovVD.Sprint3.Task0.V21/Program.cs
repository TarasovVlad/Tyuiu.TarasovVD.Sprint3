using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.TarasovVD.Sprint3.Task0.V21.Lib;

namespace Tyuiu.TarasovVD.Sprint3.Task0.V21
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                                         *");
            Console.WriteLine("***************************************************************************");
            double value = 1.5;
            int startValue = 1;
            int stopValue = 13;
            Console.WriteLine("Переменная X = " + value);
            Console.WriteLine("Старт шага = " + startValue);
            Console.WriteLine("Конец шага = " + stopValue);
            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Сумма ряда = " + ds.GetSumSeries(value, startValue, stopValue));



            Console.ReadKey();
        }
    }
}
