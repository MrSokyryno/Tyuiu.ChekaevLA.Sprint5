namespace Tyuiu.ChekaevLA.Sprint5.Task4.V18.Lib
{
    public class DataService : tyuiu.cources.programming.interfaces.Sprint5.ISprint5Task4V18
    {
        public double LoadFromDataFile(string path)
        {
            double f = double.Parse(File.ReadAllText(path));
            return Math.Round(Math.Cos(f)+Math.Pow(f,2)/2,3);
        }
    }
}
