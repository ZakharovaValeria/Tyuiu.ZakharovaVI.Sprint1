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
            double x = 2;
            double y = 2; 
            double wait = 0.187; 
            var res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);

        }
    }
}
