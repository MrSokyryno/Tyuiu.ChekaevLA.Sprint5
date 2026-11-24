namespace Tyuiu.ChekaevLA.Sprint5.Task3.V27.Lib
{
    public class DataService : tyuiu.cources.programming.interfaces.Sprint5.ISprint5Task3V27
    {
        public string SaveToFileTextData(int x)
        {
            return Convert.ToString(Math.Round(Math.Pow((x - 1), 3 * x + 1),3));
        }
    }
}
