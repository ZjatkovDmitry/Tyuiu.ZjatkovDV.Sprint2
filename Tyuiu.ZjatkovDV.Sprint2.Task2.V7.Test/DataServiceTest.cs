using Tyuiu.ZjatkovDV.Sprint2.Task2.V7.Lib;

namespace Tyuiu.ZjatkovDV.Sprint2.Task2.V7.Test
{
    public class DataServiceTest
    {
        [Fact]
        public void Test1()
        {
            var result = new DataService();
            Assert.Equal(true, result.CheckDotInShadedArea(7, 7));
        }
    }
}