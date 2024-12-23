﻿using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.BlagihIA.Sprint3.Task2.V9.Lib
{
    public class DataService : ISprint3Task2V9
    {
        public double GetSumSeries(int value, int startValue, int stopValue)
        {
            double res = 0;
            do
            {
                res = res + Math.Pow((1 / (Math.Pow(value, startValue))), 2);
                startValue++;
            } while (startValue <= stopValue);
            return Math.Round(res, 3);
        }
    }
}
