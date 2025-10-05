using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.ZjatkovDV.Sprint2.Task1.V2.Lib
{
    public class DataService : ISprint2Task1V2
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            bool[] result = new bool[6];
            result[0] = a < b | b > c;
            result[1] = a != c & c < d;
            result[2] = a <= b || b >= c;
            result[3] = a == a && b != d;
            result[4] = !(a > d) && c < d;
            result[5] = a < c ^ b < d;

            return result;
        }
    }
}
