using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.MoskalevSO.Sprint6.Task2.V24.Lib
{
    public class DataService : ISprint6Task2V24
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int len = stopValue - startValue + 1;
            double[] values = new double[len];

            for (int i = 0; i < len; i++)
            {
                int x = startValue + i;
                double denominator = 2 - x;

                // F(x) = sin(x) + (cos(x) + 1) / (2 - x) + 2x; при делении на ноль — 0
                double y = denominator == 0
                    ? 0
                    : Math.Sin(x) + (Math.Cos(x) + 1) / denominator + 2 * x;

                values[i] = Math.Round(y, 2);
            }

            return values;
        }
    }
}
