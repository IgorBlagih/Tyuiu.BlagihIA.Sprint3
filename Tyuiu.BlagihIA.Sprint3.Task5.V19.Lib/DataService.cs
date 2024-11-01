using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.BlagihIA.Sprint3.Task5.V19.Lib
{
    public class DataService : ISprint3Task5V19
    {
        public double GetSumSumSeries(int x, int startValue1, int startValue2, int stopValue1, int stopValue2)
        {
            double res = 0;
            for (int j = startValue1; j <= stopValue1; j++)
            {
                for (int k = startValue2; k <= stopValue2; k++)
                {
                    res = res + Math.Pow((x / Math.Cos(x)), k);
                }
            }
            return Math.Round(res,3);
        }
    }
}
