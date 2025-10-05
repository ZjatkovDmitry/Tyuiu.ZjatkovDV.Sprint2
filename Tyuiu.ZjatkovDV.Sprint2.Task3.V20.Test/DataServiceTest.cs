using Tyuiu.ZjatkovDV.Sprint2.Task3.V20.Lib;

namespace Tyuiu.ZjatkovDV.Sprint2.Task3.V20.Test
{
    public class DataServiceTest
    {
        [Fact]
        public void CheckCalc()
        {
            var result = new DataService();
            Assert.Equal(18, result.Calculate(2));
        }
    }
}