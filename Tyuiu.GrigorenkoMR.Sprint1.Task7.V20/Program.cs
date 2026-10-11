using Tyuiu.GrigorenkoMR.Sprint1.Task7.V20.Lib;

namespace Tyuiu.GrigorenkoMR.Sprint1.Task7.V20
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #1 | Выполнил: Григоренко М. Р. | ИСПб - 26 - 1";
            Console.WriteLine("*********************************************************************");
            Console.WriteLine("* Спринт #1                                                         *");
            Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту           *");
            Console.WriteLine("* Задание #7                                                        *");
            Console.WriteLine("* Вариант #20                                                       *");
            Console.WriteLine("* Выполнил: Григоренко Матвей Романович | ИСПб - 26 - 1             *");
            Console.WriteLine("*********************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                          *");
            Console.WriteLine("*           2 + cos^2(x + y)                                        *");
            Console.WriteLine("* z = ---------------------------- + xy                             *");
            Console.WriteLine("*     1 + |x - (3x / 1 + x^2*y^2)|                                  *");
            Console.WriteLine("*********************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                  *");
            Console.WriteLine("*********************************************************************");

            double x, y;
            
            Console.WriteLine("Введите значение переменной X:");
            x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите значение переменной Y:");
            y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("*********************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                        *");
            Console.WriteLine("*********************************************************************");

            Console.WriteLine(ds.Calculate(x, y));
            Console.ReadLine();
        }
    }
}