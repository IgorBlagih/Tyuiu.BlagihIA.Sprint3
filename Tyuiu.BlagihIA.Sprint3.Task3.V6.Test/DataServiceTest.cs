using Tyuiu.BlagihIA.Sprint3.Task3.V6.Lib;
namespace Tyuiu.BlagihIA.Sprint3.Task3.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string str = "123 t 1r4";
            char i = 't';
            string res = ds.ReplaceNumOnChar(str, i);
            string wait = "ttt t trt";

            Assert.AreEqual(wait, res);
        }
    }
}