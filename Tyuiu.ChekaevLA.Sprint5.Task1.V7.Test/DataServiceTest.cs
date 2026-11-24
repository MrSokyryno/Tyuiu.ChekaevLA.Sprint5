using Tyuiu.ChekaevLA.Sprint5.Task1.V7.Lib;

namespace Tyuiu.ChekaevLA.Sprint5.Task1.V7.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService dataService = new DataService();
            Assert.AreEqual("7,83\t6,22\t6,36\t6,96\t-0,52\t0\t-3,3\t-5,53\t-6,25\t-6,63", dataService.SaveToFileTextData(-5,5));
        }
    }
}
