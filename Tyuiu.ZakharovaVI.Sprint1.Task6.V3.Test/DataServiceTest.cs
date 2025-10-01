using System.Globalization;
using Tyuiu.ZakharovaVI.Sprint1.Task6.V3.Lib;

namespace Tyuiu.ZakharovaVI.Sprint1.Task6.V3.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string words = "Привет";
            DataService ds = new DataService();
            String result = ds.LastLetterWord(words);
            Assert.AreEqual("т", result);
        }
    }
}
