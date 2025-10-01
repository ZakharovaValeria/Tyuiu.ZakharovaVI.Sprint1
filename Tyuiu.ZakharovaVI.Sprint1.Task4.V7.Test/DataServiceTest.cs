using System.Net.WebSockets;
using Tyuiu.ZakharovaVI.Sprint1.Task4.V7.Lib;

namespace Tyuiu.ZakharovaVI.Sprint1.Task4.V7.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 3;
            double y = 3; 
            double wait = 0.111;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);

        }
    }
}
