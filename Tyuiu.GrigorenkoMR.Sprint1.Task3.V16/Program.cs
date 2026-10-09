using Tyuiu.GrigorenkoMR.Sprint1.Task3.V16.Lib;

namespace Tyuiu.GrigorenkoMR.Sprint1.Task3.V16
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #1 | Выполнил: Григоренко М. Р. | ИСПб - 26 - 1";
            Console.WriteLine("*********************************************************************************");
            Console.WriteLine("* Спринт #1                                                                     *");
            Console.WriteLine("* Тема: Операторы составного присваивания                                       *");
            Console.WriteLine("* Задание #3                                                                    *");
            Console.WriteLine("* Вариант #16                                                                   *");
            Console.WriteLine("* Выполнил: Григоренко Матвей Романович | ИСПб - 26 - 1                         *");
            Console.WriteLine("*********************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                      *");
            Console.WriteLine("* Написать программу, которая вычисляет и печатает коэффициент приведенного     *");
            Console.WriteLine("* квадратного уравнения, корнями которого являются (b = -x1 - x2).              *");
            Console.WriteLine("*                                                                               *");
            Console.WriteLine("*********************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                              *");
            Console.WriteLine("*********************************************************************************");

            double x1, x2;
            
            Console.WriteLine("Введите значение первого корня X1:");
            x1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите значение первого корня X2:");
            x2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("*********************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                    *");
            Console.WriteLine("*********************************************************************************");

            Console.WriteLine(ds.CoeffOfQuadraticEquation(x1, x2));
            Console.ReadLine();
        }
    }
}