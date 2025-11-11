using Tyuiu.RadochinaAP.Sprint4.Task4.V10.Lib;
namespace Tyuiu.RadochinaAP.Sprint4.Task4.V10.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();

            int[,] mas2 = new int[5, 5] {
                { 6, 6, 5, 3, 3 },
                { 5, 7, 4, 6, 4 },
                { 1, 2, 4, 1, 5 },
                { 1, 7, 2, 5, 7 },
                { 4, 2, 6, 5, 6 }
            };

            int[,] res = ds.Calculate(mas2);

            int[,] wait = new int[5, 5] {
                { 6, 6, 0, 0, 0 },
                { 0, 0, 4, 6, 4 },
                { 0, 2, 4, 0, 0 },
                { 0, 0, 2, 0, 0 },
                { 4, 2, 6, 0, 6 }
            };

            CollectionAssert.AreEqual(wait, res);


        }
    }
}
