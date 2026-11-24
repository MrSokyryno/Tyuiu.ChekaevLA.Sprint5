using Tyuiu.ChekaevLA.Sprint5.Task2.V17.Lib;

namespace Tyuiu.ChekaevLA.Sprint5.Task2.V17.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService dataService = new DataService();
            int[,] matrix = { { 1, 0, 0 }, { 0, 1, 0 }, { 0, 0, 1 } };
            int[,] res = { { 0, 0, 0 }, { 0, 0, 0 }, { 0, 0, 0 } };
            AssertExtensions.Equals(matrix, res);
        }
    }
}
