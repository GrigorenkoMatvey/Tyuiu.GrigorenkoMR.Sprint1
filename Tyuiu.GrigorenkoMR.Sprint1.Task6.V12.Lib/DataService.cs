using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.GrigorenkoMR.Sprint1.Task6.V12.Lib
{
    public class DataService : ISprint1Task6V12
    {
        public bool CheckLastWordRepetiton(string text)
        {
            string[] words = text.Split(new char[] { ' ', '\t' });
            if (words.Length < 2)
                return false;
            string Lastword = words[words.Length - 1];
            int count = 0;
            foreach(string word in words)
            {
                if (word == Lastword)
                    count++;
            }
            return count > 1;
        }
    }
}
