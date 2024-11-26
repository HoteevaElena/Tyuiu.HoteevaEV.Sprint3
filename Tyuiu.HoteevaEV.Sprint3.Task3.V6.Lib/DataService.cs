using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.HoteevaEV.Sprint3.Task3.V6.Lib
{
    public class DataService : ISprint3Task3V6
    {
        public string ReplaceNumOnChar(string value, char item)
        {
            foreach(char q in value)
            {
                if(Char.IsDigit(q))
                {
                    value = value.Replace(q, item);
                }
            }
            return value;
        }
    }
}
