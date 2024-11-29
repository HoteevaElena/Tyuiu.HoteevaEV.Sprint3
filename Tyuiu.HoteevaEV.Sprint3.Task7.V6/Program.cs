using Tyuiu.HoteevaEV.Sprint3.Task7.V6.Lib;
namespace Tyuiu.HoteevaEV.Sprint3.Task7.V6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #3 | Выполнила: Хотеева Е. В. | ИИПб-24-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                 *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #6                                                              *");
            Console.WriteLine("* Выполнила: Хотеева Елена Вячеславовна | ИИПб-24-2                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая выводит тaблицу значений функции            *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int start = -5;
            int end = 5;

            Console.WriteLine("Начало диапазона: " + start);
            Console.WriteLine("Конец диапазона: " + end);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            double[] res = new double[end - start + 1];
            res = ds.GetMassFunction(start, end);

            Console.WriteLine("+-----------+------------+");
            Console.WriteLine("|     X     |     f(x)   |");
            Console.WriteLine("+-----------+------------+");


            for (int i = 0; i < res.Length; i++)
            {
                Console.WriteLine("|{0, 6:d}     |   {1, 6:f2}   |", start, res[i]);
                start++;
            }
            Console.WriteLine("+-----------+------------+");

            Console.ReadKey();
        }
    }
}
