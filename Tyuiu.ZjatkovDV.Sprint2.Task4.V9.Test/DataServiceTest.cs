using Tyuiu.ZjatkovDV.Sprint2.Task4.V9.Lib;

namespace Tyuiu.ZjatkovDV.Sprint2.Task4.V9.Test
{
    public class DataServiceTest
    {
        [Fact]
        public void CheckCalc()
        {
            var result = new DataService();
            Assert.Equal(-0.5, result.Calculate(1, 2));
        }
    }
}