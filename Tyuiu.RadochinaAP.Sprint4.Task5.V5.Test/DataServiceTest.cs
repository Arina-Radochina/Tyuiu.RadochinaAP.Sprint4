using Tyuiu.RadochinaAP.Sprint4.Task5.V5.Lib;
namespace Tyuiu.RadochinaAP.Sprint4.Task5.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            int[,] mas2 = new int[5, 5] {
                { 3, -2, 7, 1, -4 },
                { 5, 0, 8, -1, 2 },
                { -3, 4, 6, -5, 3 },
                { 2, 7, -2, 0, 1 },
                { 8, -4, 5, 2, 6 }
            };
            int res = ds.Calculate(mas2);
            int wait = 70;
            Assert.AreEqual(wait, res);
        }
    }
}
