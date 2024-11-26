using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.HoteevaEV.Sprint3.Task2.V8.Lib
{
    public class DataService : ISprint3Task2V8
    {
        public double GetMultiplySeries(int startValue, int stopValue)
        {
            double proz = 1;
            do
            {
                proz *= (1 / (Math.Pow((Math.Cos(5) + 1), 2)));
                startValue++;

            } while (startValue <= stopValue);
            return Math.Round(proz, 3);
        }
    }
}
