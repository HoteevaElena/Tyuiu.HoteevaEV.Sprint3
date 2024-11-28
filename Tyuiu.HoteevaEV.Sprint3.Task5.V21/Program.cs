using Tyuiu.HoteevaEV.Sprint3.Task5.V21.Lib;
namespace Tyuiu.HoteevaEV.Sprint3.Task5.V21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #3 | Выполнила: Хотеева Е. В. | ИИПб-24-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Вложенные циклы                                                   *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #21                                                             *");
            Console.WriteLine("* Выполнила: Хотеева Елена Вячеславовна | ИИПб-24-2                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая вычисляет сумму сумм ряда                   *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int x = 2;
            int start1 = 1;
            int end1 = 3;
            int start2 = 1;
            int end2 = 10;

            Console.WriteLine("Переменная Х: " + x);
            Console.WriteLine("Старт шага первой суммы ряда: " + start1);
            Console.WriteLine("Конец шага первой суммы ряда: " + end1);
            Console.WriteLine("Старт шага второй суммы ряда: " + start2);
            Console.WriteLine("Конец шага второй суммы ряда: " + end2);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            double res = ds.GetSumSumSeries(x, start1, start2, end1, end2);

            Console.WriteLine("Сумма сумм ряда: " + res);

            Console.ReadKey();
        }
    }
}
