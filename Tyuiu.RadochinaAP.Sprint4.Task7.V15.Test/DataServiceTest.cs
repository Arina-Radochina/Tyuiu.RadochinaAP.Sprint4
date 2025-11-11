using Tyuiu.RadochinaAP.Sprint4.Task7.V15.Lib;
namespace Tyuiu.RadochinaAP.Sprint4.Task7.V15.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();

            int n = 4; 
            int m = 2; 
            string value = "10293847";

            int res = ds.Calculate(n, m, value);
            int wait = 4;
            Assert.AreEqual(wait, res);

        }
    }
}
