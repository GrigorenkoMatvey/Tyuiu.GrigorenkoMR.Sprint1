using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.GrigorenkoMR.Sprint1.Task2.V1.Lib
{
    public class DataService : ISprint1Task2V1
    {
        public double ConvertKmToM(int km)
        {
            return Math.Round(km / 1.609, 3);
        }
    }
}
