using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.ZjatkovDV.Sprint2.Task4.V9.Lib
{
    public class DataService : ISprint2Task4V9
    {
        public double Calculate(double x, double y)
        {
            return Math.Round(x + 5 < y / 2 ? Math.Pow(7 + (1 / Math.Pow(x, 2)), y) : Math.Pow(x, 4) - (3 / y), 3);
        }
    }
}
