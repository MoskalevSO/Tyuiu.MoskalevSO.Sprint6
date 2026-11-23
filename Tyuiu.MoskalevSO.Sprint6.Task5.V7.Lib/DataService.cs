using System.Globalization;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.MoskalevSO.Sprint6.Task5.V7.Lib
{
    public class DataService : ISprint6Task5V7
    {
        // Возвращает все числа из файла, которые больше 5
        public double[] LoadFromDataFile(string path)
        {
            return LoadAllValues(path).Where(v => v > 5).ToArray();
        }

        // Все числа из файла; вещественные округляются до трёх знаков
        public double[] LoadAllValues(string path)
        {
            string text = File.ReadAllText(path);
            string[] items = text.Split(new[] { ' ', '\t', '\r', '\n', ';' }, StringSplitOptions.RemoveEmptyEntries);
            List<double> values = new List<double>();

            foreach (string item in items)
            {
                string value = item.Trim().Replace(',', '.');
                if (double.TryParse(value, NumberStyles.Float, CultureInfo.InvariantCulture, out double number))
                {
                    values.Add(Math.Round(number, 3));
                }
            }

            return values.ToArray();
        }
    }
}
