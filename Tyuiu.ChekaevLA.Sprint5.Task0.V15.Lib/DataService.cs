namespace Tyuiu.ChekaevLA.Sprint5.Task0.V15.Lib
{
    public class DataService : tyuiu.cources.programming.interfaces.Sprint5.ISprint5Task0V15
    {
        public string SaveToFileTextData(int x)
        {
            double y = x / (Math.Pow(x, 3) + 2);
            return Convert.ToString(Math.Round(y, 3));
        }
    }
}
