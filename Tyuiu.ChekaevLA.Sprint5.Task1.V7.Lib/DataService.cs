namespace Tyuiu.ChekaevLA.Sprint5.Task1.V7.Lib
{
    public class DataService : tyuiu.cources.programming.interfaces.Sprint5.ISprint5Task1V7
    {
        public string SaveToFileTextData(int startValue, int stopValue)
        {
            string res = "";
            for (int i = startValue; i < stopValue; i++)
            { 
                double y = Math.Round(Math.Sin(i) / (i+1.2) - Math.Sin(i) * 2 - 2 * i, 2);
                res += $"{y}\n";
            }
            return res;
        }
    }
}
