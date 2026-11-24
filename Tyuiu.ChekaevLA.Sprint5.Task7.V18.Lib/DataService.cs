namespace Tyuiu.ChekaevLA.Sprint5.Task7.V18.Lib
{
    public class DataService : tyuiu.cources.programming.interfaces.Sprint5.ISprint5Task7V18
    {
        public string LoadDataAndSave(string path)
        {
            string file = File.ReadAllText(path);
            file = file.Replace("н", "нн");
            return file;
        }
    }
}
