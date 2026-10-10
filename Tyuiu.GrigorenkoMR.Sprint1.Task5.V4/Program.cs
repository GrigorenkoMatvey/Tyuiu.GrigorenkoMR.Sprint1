using Tyuiu.GrigorenkoMR.Sprint1.Task5.V4.Lib;

namespace Tyuiu.GrigorenkoMR.Sprint1.Task5.V4
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #1 | Выполнил: Григоренко М. Р. | ИСПб - 26 - 1";
            Console.WriteLine("*********************************************************************");
            Console.WriteLine("* Спринт #1                                                         *");
            Console.WriteLine("* Тема: Преобразование типов и класс Convert                        *");
            Console.WriteLine("* Задание #5                                                        *");
            Console.WriteLine("* Вариант #4                                                        *");
            Console.WriteLine("* Выполнил: Григоренко Матвей Романович | ИСПб - 26 - 1             *");
            Console.WriteLine("*********************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                          *");
            Console.WriteLine("* Идет k-я секунда суток. Определить, сколько полных часов (h)      *");
            Console.WriteLine("* прошло к этому моменту (например, h=3, если k=13257).             *");
            Console.WriteLine("*                                                                   *");
            Console.WriteLine("*********************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                  *");
            Console.WriteLine("*********************************************************************");

            int k;

            Console.WriteLine("Введите номер секунды суток K:");
            k = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("*********************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                        *");
            Console.WriteLine("*********************************************************************");

            Console.WriteLine(ds.SecondsToHours(k));
            Console.ReadLine();
        }
    }
}