using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.ShtolVA.Sprint3.Task5.V26.Lib;

namespace Tyuiu.ShtolVA.Sprint3.Task5.V26
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #3 | Выполнила: Штоль В.А | ИИПб-23-3";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Алгоритмы циклической структуры  C#                               *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #26                                                             *");
            Console.WriteLine("* Выполнил: Штоль Виктория Алексеевна | ИИПб-23-3                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ: Найти значение выражения                                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int x = 2;
            int startValue1 = 1;
            int stopValue1 = 3;
            int startValue2 = 1;
            int stopValue2 = 13;

            Console.WriteLine(" Значение Х = " + x);
            Console.WriteLine(" Старт шага первой суммы ряда = " + startValue1);
            Console.WriteLine(" Конец шага первой суммы ряда = " + stopValue1);
            Console.WriteLine(" Старт шага второй суммы ряда = " + startValue2);
            Console.WriteLine(" Конец шага второйсуммы ряда = " + stopValue2);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(" Сумма ряда  = " + ds.GetSumSumSeries(x, startValue1, startValue2, stopValue1, stopValue2));
            Console.ReadKey();
        }
    }
}
