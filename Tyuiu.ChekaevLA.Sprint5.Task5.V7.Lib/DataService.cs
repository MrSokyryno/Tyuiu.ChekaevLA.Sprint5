using System.Diagnostics;

namespace Tyuiu.ChekaevLA.Sprint5.Task5.V7.Lib
{
    public class DataService : tyuiu.cources.programming.interfaces.Sprint5.ISprint5Task5V7
    {
        public double LoadFromDataFile(string path)
        {
            string file = File.ReadAllText(path);
            string[] list = file.Split(' ');
            double res = 1.0;
            foreach (string s in list)
            { 
                if (s.Contains('.') == false) 
                {
                    for (int i = 1; i < double.Parse(s)+1; i++) { res *= i; }
                    break;
                }
            }
            return res;

        }
    }
}
