using Tyuiu.ChekaevLA.Sprint5.Task0.V15.Lib;

namespace Tyuiu.ChekaevLA.Sprint5.Task0.V15.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService dataService = new DataService();
            Assert.AreEqual(dataService.SaveToFileTextData(1), "0.333");
        }
    }
}
