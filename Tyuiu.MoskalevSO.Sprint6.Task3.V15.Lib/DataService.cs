using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.MoskalevSO.Sprint6.Task3.V15.Lib
{
    public class DataService : ISprint6Task3V15
    {
        public int[,] Calculate(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int columns = matrix.GetLength(1);
            int[,] result = (int[,])matrix.Clone();

            if (columns < 3)
            {
                return result;
            }

            // Сортировка по возрастанию значений третьего столбца (индекс 2)
            int[] column = new int[rows];
            for (int i = 0; i < rows; i++)
            {
                column[i] = matrix[i, 2];
            }

            Array.Sort(column);

            for (int i = 0; i < rows; i++)
            {
                result[i, 2] = column[i];
            }

            return result;
        }
    }
}
