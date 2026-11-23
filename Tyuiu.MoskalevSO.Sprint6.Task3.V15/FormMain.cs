using Tyuiu.MoskalevSO.Sprint6.Task3.V15.Lib;

namespace Tyuiu.MoskalevSO.Sprint6.Task3.V15
{
    public partial class FormMain : Form
    {
        private readonly DataService ds = new DataService();

        private static readonly int[,] SourceMatrix =
        {
            { 33, 28, 31, 19, 4 },
            { 1, 32, -3, -17, -12 },
            { 24, -19, 26, 31, -3 },
            { 30, -16, 29, 28, 8 },
            { 30, 5, 11, 7, 32 }
        };

        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object? sender, EventArgs e)
        {
            ShowMatrix(dataGridViewIn_MSO, SourceMatrix);
        }

        private static void ShowMatrix(DataGridView grid, int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int columns = matrix.GetLength(1);

            grid.ColumnCount = columns;
            grid.RowCount = rows;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    grid.Rows[i].Cells[j].Value = matrix[i, j];
                }
            }
        }

        private void buttonDone_MSO_Click(object? sender, EventArgs e)
        {
            try
            {
                int rows = dataGridViewIn_MSO.RowCount;
                int columns = dataGridViewIn_MSO.ColumnCount;
                int[,] matrix = new int[rows, columns];

                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        matrix[i, j] = Convert.ToInt32(dataGridViewIn_MSO.Rows[i].Cells[j].Value);
                    }
                }

                ShowMatrix(dataGridViewOut_MSO, ds.Calculate(matrix));
            }
            catch
            {
                MessageBox.Show("В исходном массиве должны быть целые числа", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHelp_MSO_Click(object? sender, EventArgs e)
        {
            MessageBox.Show("Таск 3 выполнил студент группы СМАРТб-26-1 Москалёв Степан Олегович", "Сообщение",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
