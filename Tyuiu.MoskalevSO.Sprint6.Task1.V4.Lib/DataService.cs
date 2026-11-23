using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.MoskalevSO.Sprint6.Task1.V4.Lib
{
    public class DataService : ISprint6Task1V4
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int len = stopValue - startValue + 1;
            double[] values = new double[len];

            for (int i = 0; i < len; i++)
            {
                int x = startValue + i;
                double denominator = x + 1.2;

                // F(x) = sin(x) / (x + 1.2) - sin(x) * 2 - 2x; при делении на ноль — 0
                double y = denominator == 0
                    ? 0
                    : Math.Sin(x) / denominator - Math.Sin(x) * 2 - 2 * x;

                values[i] = Math.Round(y, 2);
            }

            return values;
        }
    }
}
