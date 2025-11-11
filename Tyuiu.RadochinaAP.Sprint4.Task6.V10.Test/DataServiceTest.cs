using Tyuiu.RadochinaAP.Sprint4.Task6.V10.Lib;
namespace Tyuiu.RadochinaAP.Sprint4.Task6.V10.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();

            string[] array = { "Компьютер", "Телефон", "Мышь", "Клавиатура", "Монитор", "Принтер" };
            string[] res = ds.Calculate(array);

            // Элементы длиной < 7: только "Мышь"
            string[] wait = { "Мышь" };
            CollectionAssert.AreEqual(wait, res);

        }
    }
}
