using Tyuiu.GrigorenkoMR.Sprint1.Task2.V1.Lib;

namespace Tyuiu.GrigorenkoMR.Sprint1.Task2.V1
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #1 | Выполнил: Григоренко М. Р. | ИСПб - 26 - 1";
            Console.WriteLine("*********************************************************************************");
            Console.WriteLine("* Спринт #1                                                                     *");
            Console.WriteLine("* Тема: Арифметические операторы в C#                                           *");
            Console.WriteLine("* Задание #2                                                                    *");
            Console.WriteLine("* Вариант #1                                                                    *");
            Console.WriteLine("* Выполнил: Григоренко Матвей Романович | ИСПб - 26 - 1                         *");
            Console.WriteLine("*********************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                      *");
            Console.WriteLine("* Известно расстояние в километрах. Вычислить расстояние в милях.               *");
            Console.WriteLine("* При условии, что 1 миля = 1,609 км. Ответ округлите до 3 знаков после запятой *");
            Console.WriteLine("*                                                                               *");
            Console.WriteLine("*********************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                              *");
            Console.WriteLine("*********************************************************************************");

            int km;
            Console.WriteLine("Введите расстояние в километрах:");
            km = Convert.ToInt32((Console.ReadLine()));

            Console.WriteLine("*********************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                    *");
            Console.WriteLine("*********************************************************************************");

            Console.WriteLine(ds.ConvertKmToM(km));
            Console.ReadLine();
        }
    }
}