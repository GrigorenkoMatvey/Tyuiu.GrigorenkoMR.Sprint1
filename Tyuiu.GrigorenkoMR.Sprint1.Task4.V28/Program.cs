using Tyuiu.GrigorenkoMR.Sprint1.Task4.V28.Lib;

namespace Tyuiu.GrigorenkoMR.Sprint1.Task4.V28
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #1 | Выполнил: Григоренко М. Р. | ИСПб - 26 - 1";
            Console.WriteLine("********************************************************************************************");
            Console.WriteLine("* Спринт #1                                                                                *");
            Console.WriteLine("* Тема: Class Math                                                                         *");
            Console.WriteLine("* Задание #4                                                                               *");
            Console.WriteLine("* Вариант #28                                                                              *");
            Console.WriteLine("* Выполнил: Григоренко Матвей Романович | ИСПб - 26 - 1                                    *");
            Console.WriteLine("********************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                                 *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные,                  *");
            Console.WriteLine("* вычисляет результат по формуле cos(60*pi / 2) / Exp(2 * x + y) и печатает его на экране. *");
            Console.WriteLine("*                                                                                          *");
            Console.WriteLine("********************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                         *");
            Console.WriteLine("********************************************************************************************");

            double x, y;

            Console.WriteLine("Введите значение переменной X:");
            x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите значение переменной Y:");
            y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("********************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                               *");
            Console.WriteLine("********************************************************************************************");
            Console.WriteLine(ds.Calculate(x, y));
            Console.ReadLine();
        }
    }
}