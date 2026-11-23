using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.MoskalevSO.Sprint6.Task7.V8.Lib
{
    public class DataService : ISprint6Task7V8
    {
        // Загружает матрицу из CSV и меняет в восьмом столбце значения, не равные 5, на -1
        public int[,] GetMatrix(string path)
        {
            int[,] matrix = LoadMatrix(path);

            if (matrix.GetLength(1) > 7)
            {
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    if (matrix[i, 7] != 5)
                    {
                        matrix[i, 7] = -1;
                    }
                }
            }

            return matrix;
        }

        // Читает матрицу целых чисел из CSV-файла (разделитель ;)
        public int[,] LoadMatrix(string path)
        {
            string[] lines = File.ReadAllLines(path)
                .Where(l => !string.IsNullOrWhiteSpace(l))
                .ToArray();

            int rows = lines.Length;
            int columns = rows > 0 ? lines[0].Split(';').Length : 0;
            int[,] matrix = new int[rows, columns];

            for (int i = 0; i < rows; i++)
            {
                string[] cells = lines[i].Split(';');
                for (int j = 0; j < columns; j++)
                {
                    matrix[i, j] = Convert.ToInt32(cells[j].Trim());
                }
            }

            return matrix;
        }

        // Сохраняет матрицу в CSV-файл
        public void SaveMatrix(int[,] matrix, string path)
        {
            List<string> lines = new List<string>();

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                string[] cells = new string[matrix.GetLength(1)];
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    cells[j] = matrix[i, j].ToString();
                }
                lines.Add(string.Join(";", cells));
            }

            File.WriteAllLines(path, lines);
        }
    }
}
