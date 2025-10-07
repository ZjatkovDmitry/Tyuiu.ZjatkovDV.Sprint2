using Tyuiu.ZjatkovDV.Sprint2.Task6.V13.Lib;

namespace Tyuiu.ZjatkovDV.Sprint2.Task6.V13.Test
{
    public class DataServiceTest
    {
        [Fact]
        public void CheckFindDateOfNextDay()
        {
            var result = new DataService();
            Assert.Equal("29.02.2024", result.FindDateOfNextDay(2024, 2, 28));
        }
    }
}