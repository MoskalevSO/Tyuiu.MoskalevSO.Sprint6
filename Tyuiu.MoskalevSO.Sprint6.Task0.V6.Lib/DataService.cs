using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.MoskalevSO.Sprint6.Task0.V6.Lib
{
    public class DataService : ISprint6Task0V6
    {
        public double Calculate(int x)
        {
            // y(x) = x / sqrt(x^2 + x)
            double y = x / Math.Sqrt(Math.Pow(x, 2) + x);
            return Math.Round(y, 3);
        }
    }
}
