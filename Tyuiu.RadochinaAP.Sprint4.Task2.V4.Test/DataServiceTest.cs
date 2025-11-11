using Tyuiu.RadochinaAP.Sprint4.Task2.V4.Lib;
namespace Tyuiu.RadochinaAP.Sprint4.Task2.V4.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int[] numsArray = { 3, 4, 5, 7, 2, 9, 6, 3, 8, 5, 7, 4, 9 };

            int res = ds.Calculate(numsArray);
            int wait = 48;

            Assert.AreEqual(wait, res);

        }
    }
}
