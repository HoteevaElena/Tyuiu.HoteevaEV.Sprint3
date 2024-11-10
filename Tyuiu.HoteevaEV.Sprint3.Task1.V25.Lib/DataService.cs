using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.HoteevaEV.Sprint3.Task1.V25.Lib
{
    public class DataService : ISprint3Task1V25
    {
        public double GetMultiplySeries(int value, int startValue, int stopValue)
        {
            double umn = 1;
            while(startValue <= stopValue)
            {
                umn *= (((Math.Pow(value, startValue)) - (0.25)) * Math.Cos(5));
                startValue++;
            }
            return Math.Round(umn, 3);
        }
    }
}
