namespace Tyuiu.ChekaevLA.Sprint5.Task2.V17.Lib
{
    public class DataService : tyuiu.cources.programming.interfaces.Sprint5.ISprint5Task2V17
    {
        public string SaveToFileTextData(int[,] matrix)
        {
            for (int x = 0; x < (matrix.Length-1); x++)
            {
                for (int y = 0; y < (matrix.Length - 1); y++)
                { 
                    if (matrix[x,y] % 2 == 0) { matrix[x, y] = 0; }
                } 
            }
            return Convert.ToString(matrix);
        }
    }
}
