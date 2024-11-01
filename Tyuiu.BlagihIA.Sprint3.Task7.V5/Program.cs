using Tyuiu.BlagihIA.Sprint3.Task7.V5.Lib;
namespace Tyuiu.BlagihIA.Sprint3.Task7.V5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Базовые навыки  работы в С#                                       *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #23                                                             *");
            Console.WriteLine("* Выполнил: Благих Игорь Александрович | ИИПб-24-2                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Напишите программу, которая ищет среди целых чисел, принадлежащих       *");
            Console.WriteLine("* числовому отрезку [18, 28] количество всех делителей меньше 11          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int start = -5;
            int stop = 5;

            Console.WriteLine("Старт шага =" + start);
            Console.WriteLine("Конец шага =" + stop);


            int len = ds.GetMassFunction(start, stop).Length;
            double[] valueA;

            valueA = new double[len];

            valueA = ds.GetMassFunction(start, stop);


            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("+----------+----------+");
            Console.WriteLine("|    X     |    f(X)  |");
            Console.WriteLine("+----------+----------+");
            for (int i = 0; i < len; i++)
            {
             Console.WriteLine("|{0,5:d}     |  {1, 5:f2}   |", start, valueA[i]);
            }
            Console.WriteLine("+----------+----------+");
            Console.ReadKey();
        }
    }
}
