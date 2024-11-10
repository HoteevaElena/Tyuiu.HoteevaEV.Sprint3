﻿using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.HoteevaEV.Sprint3.Task1.V25.Lib
{
    public class DataService : ISprint3Task1V25
    {
        public double GetMultiplySeries(int value, int startValue, int stopValue)
        {
            double sum = 0;
            while(startValue <= stopValue)
            {
                sum += ((Math.Pow(value, startValue) - (1 / 4)) * Math.Cos(5));
                startValue++;
            }
            return Math.Round(sum, 3);
        }
    }
}