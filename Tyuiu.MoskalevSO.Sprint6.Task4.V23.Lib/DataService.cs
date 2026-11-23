using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.MoskalevSO.Sprint6.Task4.V23.Lib
{
    public class DataService : ISprint6Task4V23
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int len = stopValue - startValue + 1;
            double[] values = new double[len];

            for (int i = 0; i < len; i++)
            {
                int x = startValue + i;
                double denominator = 2 * x - 2;

                // F(x) = 4 - 2x + (2 + cos(x)) / (2x - 2); при делении на ноль — 0
                double y = denominator == 0
                    ? 0
                    : 4 - 2 * x + (2 + Math.Cos(x)) / denominator;

                values[i] = Math.Round(y, 2);
            }

            return values;
        }

        // Сохраняет таблицу значений в файл и возвращает путь к нему
        public string SaveToFile(int startValue, int stopValue, string path)
        {
            double[] values = GetMassFunction(startValue, stopValue);
            string[] lines = new string[values.Length];

            for (int i = 0; i < values.Length; i++)
            {
                lines[i] = (startValue + i) + ";" + values[i];
            }

            File.WriteAllLines(path, lines);
            return path;
        }
    }
}
