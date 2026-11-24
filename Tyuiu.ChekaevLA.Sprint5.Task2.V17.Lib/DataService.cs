namespace Tyuiu.ChekaevLA.Sprint5.Task2.V17.Lib
{
    public class DataService : tyuiu.cources.programming.interfaces.Sprint5.ISprint5Task2V17
    {
        public string SaveToFileTextData(int[,] matrix)
        {
            string line = "";
            for (int x = 0; x < 3; x++)
            {
                for (int y = 0; y < 3; y++)
                { 
                    if (matrix[x,y] % 2 == 1) { line += " 0"; }
                    else { line += " " + Convert.ToString(matrix[x, y]); }
                } 
            }
            return line;
        }
    }
}
