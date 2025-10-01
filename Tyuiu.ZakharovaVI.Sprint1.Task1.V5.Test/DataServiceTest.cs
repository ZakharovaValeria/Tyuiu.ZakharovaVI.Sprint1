using Tyuiu.ZakharovaVI.Sprint1.Task1.V5.Lib;

namespace Tyuiu.ZakharovaVI.Sprint1.Task1.V5.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 2.0;
            double y = 3.0;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(7, res);


        }
    }
}
