using Tyuiu.ZjatkovDV.Sprint2.Task5.V3.Lib;

namespace Tyuiu.ZjatkovDV.Sprint2.Task5.V3.Test
{
    public class DataServiceTest
    {
        [Fact]
        public void CheckFindDayName()
        {
            var result = new DataService();
            Assert.Equal("�����", result.FindDayName(3));
        }
    }
}