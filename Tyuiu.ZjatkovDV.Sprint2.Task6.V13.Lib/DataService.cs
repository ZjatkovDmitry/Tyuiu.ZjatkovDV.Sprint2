using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.ZjatkovDV.Sprint2.Task6.V13.Lib
{
    public class DataService : ISprint2Task6V13
    {
        public string FindDateOfNextDay(int g, int m, int n)
        {
            var (nextG, nextM, nextN) = (m, n) switch
            {
                (2, 29) => (g, 3, 1),
                (12, 31) => (g + 1, 1, 1),
                (1 or 3 or 5 or 7 or 8 or 10 or 12, 31) => (g, m + 1, 1),
                (4 or 6 or 9 or 11, 30) => (g, m + 1, 1),
                _ => (g, m, n + 1)
            };

            return $"{nextN:00}.{nextM:00}.{nextG}";
        }
    }
}
