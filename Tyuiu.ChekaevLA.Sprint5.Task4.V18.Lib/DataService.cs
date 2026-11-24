using System.Globalization;

namespace Tyuiu.ChekaevLA.Sprint5.Task4.V18.Lib
{
    public class DataService : tyuiu.cources.programming.interfaces.Sprint5.ISprint5Task4V18
    {
        public double LoadFromDataFile(string path)
        {
            string raw = File.ReadAllText(path).Trim().Replace(',', '.');
            double f = Convert.ToDouble(raw, CultureInfo.InvariantCulture);
            return Math.Round(Math.Cos(f) + Math.Pow(f, 2) / 2, 3);
        }
    }
}