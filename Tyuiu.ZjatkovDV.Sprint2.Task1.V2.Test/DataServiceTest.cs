using Tyuiu.ZjatkovDV.Sprint2.Task1.V2.Lib;

namespace Tyuiu.ZjatkovDV.Sprint2.Task1.V2.Test
{
    public class DataServiceTest
    {
        [Fact]
        public void CheckGetLogicOperations()
        {
            var result = new DataService();
            Assert.Equal([true, true, true, true, true, false], result.GetLogicOperations(135, 156, 154, 174));
        }
    }
}