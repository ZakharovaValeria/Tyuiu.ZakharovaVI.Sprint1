using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.ZakharovaVI.Sprint1.Task4.V7.Lib
{
    public class DataService : ISprint1Task4V7
    {
        public double Calculate(double x, double y)
        {
            var res = (1 + Math.Sqrt(x * y)) / ((x - 3 * y) * (x - 3 * y));
            return Math.Floor(res * 1000) / 1000;  
        }
    }
}
