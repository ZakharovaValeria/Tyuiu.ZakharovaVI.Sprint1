using Tyuiu.ZakharovaVI.Sprint1.Task5.V6.Lib;

namespace Tyuiu.ZakharovaVI.Sprint1.Task5.V6.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            int k = 14;
            DataService ds = new DataService();
            int day = ds.Calculate(k);
            int res = Convert.ToInt32(day);

            string[] days = { "понедельник", "вторник", "среда", "четверг", "пятница", "суббота", "воскресенье" };


            Assert.AreEqual(7, res);

        }
    }
}
