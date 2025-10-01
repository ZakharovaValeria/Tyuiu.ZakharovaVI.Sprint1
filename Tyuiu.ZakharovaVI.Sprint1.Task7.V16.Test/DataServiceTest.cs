using Tyuiu.ZakharovaVI.Sprint1.Task7.V16.Lib;

namespace Tyuiu.ZakharovaVI.Sprint1.Task7.V16.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 5;
            double wait = 0.026;
            var res = ds.Calculate(x);
            Assert.AreEqual(wait, res);
        }
    }
}
