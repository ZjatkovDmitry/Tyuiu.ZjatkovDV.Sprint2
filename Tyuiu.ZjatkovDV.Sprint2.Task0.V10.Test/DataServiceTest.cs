using Tyuiu.ZjatkovDV.Sprint2.Task0.V10.Lib;

namespace Tyuiu.ZjatkovDV.Sprint2.Task0.V10.Test
{
    public class DataServiceTest
    {
        [Fact]
        public void CheckGetCompareOperations()
        {
            var result = new DataService();
            Assert.Equal([false, true, false, true, false, true], result.GetCompareOperations(1305, 475));
        }
    }
}