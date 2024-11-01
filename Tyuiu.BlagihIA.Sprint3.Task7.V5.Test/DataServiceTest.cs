using Tyuiu.BlagihIA.Sprint3.Task7.V5.Lib;
namespace Tyuiu.BlagihIA.Sprint3.Task7.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int start = -5;
            int stop = 5;

            double[] var;

            int len = (stop - start) + 1;

            var = new double[len];

            var[0] = 35.14;
            var[1] = 27.21;
            var[2] = 20.05;
            var[3] = 13.96;
            var[4] = 8.48;
            var[5] = 1;
            var[6] = -6.06;
            var[7] = -14.16;
            var[8] = -21.96;
            var[9] = -28.77;
            var[10] = -34.83;


            double[] res;
            res = new double[len];
            res = ds.GetMassFunction(start, stop);

            CollectionAssert.AreEqual(var, res);



        }
    }
}