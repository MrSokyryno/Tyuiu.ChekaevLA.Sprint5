using Tyuiu.ChekaevLA.Sprint5.Task3.V27.Lib;

namespace Tyuiu.ChekaevLA.Sprint5.Task3.V27.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService dataService = new DataService();
            Assert.AreEqual("0", dataService.SaveToFileTextData(0));
        }
    }
}
