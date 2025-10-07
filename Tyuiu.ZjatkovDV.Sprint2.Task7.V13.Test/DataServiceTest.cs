using Tyuiu.ZjatkovDV.Sprint2.Task7.V13.Lib;

namespace Tyuiu.ZjatkovDV.Sprint2.Task7.V13.Test
{
    public class DataServiceTest
    {
        [Fact]
        public void CheckCheckDotInShadedArea()
        {
            var result = new DataService();
            Assert.Equal(true, result.CheckDotInShadedArea(0.5, -0.7));
        }
    }
}