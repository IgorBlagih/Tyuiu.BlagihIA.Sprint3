﻿using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.BlagihIA.Sprint3.Task6.V23.Lib
{
    public class DataService : ISprint3Task6V23
    {
        public int GetSumTheDivisors(int startValue, int stopValue)
        {
            int sumd = 0;
            for (int i = startValue; i <= stopValue; i++)
            {
                for (int d = 1; d < 11; d++)
                {
                    if (i % d == 0)
                    {
                        sumd++;
                    }
                }
            }
            return sumd;
        }
    }
}
