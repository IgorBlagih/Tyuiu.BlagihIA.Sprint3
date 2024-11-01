using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.BlagihIA.Sprint3.Task7.V5.Lib
{
    public class DataService : ISprint3Task7V5
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int len = (stopValue- startValue) +1;

            double[] vArray;
            vArray = new double[len];

            double y;
            int count = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                y = Math.Round(((2 * (Math.Sin(x)))/(3*x+1.2))+Math.Cos(x)- 7 *x * 2,2); 
                vArray[count] = y;
                count++;
            }
            return vArray;
        
        }

    }
}
