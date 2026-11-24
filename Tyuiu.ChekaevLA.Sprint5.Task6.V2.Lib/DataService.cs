using System.Diagnostics.CodeAnalysis;

namespace Tyuiu.ChekaevLA.Sprint5.Task6.V2.Lib
{
    public class DataService : tyuiu.cources.programming.interfaces.Sprint5.ISprint5Task6V2
    {
        public int LoadFromDataFile(string path)
        {
            int sum = 0;
            string list = "йцукенгшщзхъфывапролджэячсмитьбюёЙЦУКЕНГШЩЗХЪФЫВАПРОЛДЖЭЯЧСМИТЬБЮЁ";
            string file = File.ReadAllText(path);
            foreach (char c in file) 
            {
                if (list.Contains(c)) { sum += 1; }
            }
            return sum;

        }
    }
}
