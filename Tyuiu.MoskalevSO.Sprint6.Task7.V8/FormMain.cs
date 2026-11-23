using Tyuiu.MoskalevSO.Sprint6.Task7.V8.Lib;

namespace Tyuiu.MoskalevSO.Sprint6.Task7.V8
{
    public partial class FormMain : Form
    {
        private readonly DataService ds = new DataService();
        private string openFilePath = "";
        private int[,]? resultMatrix;

        public FormMain()
        {
            InitializeComponent();
        }

        // Левая и правая панели делят окно пополам
        private void FormMain_Resize(object? sender, EventArgs e)
        {
            groupBoxIn_MSO.Width = (ClientSize.Width - Padding.Horizontal) / 2;
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

        private void buttonOpenFile_MSO_Click(object? sender, EventArgs e)
        {
            if (openFileDialogTask_MSO.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            try
            {
                openFilePath = openFileDialogTask_MSO.FileName;
                ShowMatrix(dataGridViewIn_MSO, ds.LoadMatrix(openFilePath));

                dataGridViewOut_MSO.Rows.Clear();
                resultMatrix = null;
                buttonDone_MSO.Enabled = true;
                buttonSaveFile_MSO.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Не удалось прочитать матрицу: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonDone_MSO_Click(object? sender, EventArgs e)
        {
            try
            {
                resultMatrix = ds.GetMatrix(openFilePath);
                ShowMatrix(dataGridViewOut_MSO, resultMatrix);
                buttonSaveFile_MSO.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка обработки матрицы: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonSaveFile_MSO_Click(object? sender, EventArgs e)
        {
            if (resultMatrix == null || saveFileDialogTask_MSO.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            try
            {
                ds.SaveMatrix(resultMatrix, saveFileDialogTask_MSO.FileName);
                MessageBox.Show("Файл " + saveFileDialogTask_MSO.FileName + " сохранён успешно", "Сообщение",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Не удалось сохранить файл: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHelp_MSO_Click(object? sender, EventArgs e)
        {
            MessageBox.Show("Таск 7 выполнил студент группы СМАРТб-26-1 Москалёв Степан Олегович", "Сообщение",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
