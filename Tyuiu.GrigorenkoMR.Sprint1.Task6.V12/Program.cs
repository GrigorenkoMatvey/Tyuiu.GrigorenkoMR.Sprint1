using Tyuiu.GrigorenkoMR.Sprint1.Task6.V12.Lib;

namespace Tyuiu.GrigorenkoMR.Sprint1.Task6.V12
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #1 | Выполнил: Григоренко М. Р. | ИСПб - 26 - 1";
            Console.WriteLine("*********************************************************************");
            Console.WriteLine("* Спринт #1                                                         *");
            Console.WriteLine("* Тема: Работа со строками класс String                             *");
            Console.WriteLine("* Задание #6                                                        *");
            Console.WriteLine("* Вариант #12                                                       *");
            Console.WriteLine("* Выполнил: Григоренко Матвей Романович | ИСПб - 26 - 1             *");
            Console.WriteLine("*********************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                          *");
            Console.WriteLine("* Пользователь вводит текст. Проверить, что последнее слово строки  *");
            Console.WriteLine("* входит в нее еще раз.                                             *");
            Console.WriteLine("*                                                                   *");
            Console.WriteLine("*********************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                  *");
            Console.WriteLine("*********************************************************************");

            string text;
            Console.WriteLine("Введите текст:");
            text = Console.ReadLine();

            Console.WriteLine("*********************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                        *");
            Console.WriteLine("*********************************************************************");

            Console.WriteLine(ds.CheckLastWordRepetiton(text));
            Console.ReadLine();
        }
    }
}