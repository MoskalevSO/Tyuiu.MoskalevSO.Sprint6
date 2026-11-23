using Tyuiu.MoskalevSO.Sprint6.Task5.V7.Lib;

namespace Tyuiu.MoskalevSO.Sprint6.Task5.V7
{
    public partial class FormMain : Form
    {
        private readonly DataService ds = new DataService();
        private string openFilePath = "";

        public FormMain()
        {
            InitializeComponent();
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
                double[] values = ds.LoadAllValues(openFilePath);

                dataGridViewIn_MSO.Rows.Clear();
                foreach (double value in values)
                {
                    dataGridViewIn_MSO.Rows.Add(value);
                }

                buttonDone_MSO.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Не удалось прочитать файл: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonDone_MSO_Click(object? sender, EventArgs e)
        {
            try
            {
                double[] values5 = ds.LoadFromDataFile(openFilePath);

                dataGridViewOut_MSO.Rows.Clear();
                foreach (double value in values5)
                {
                    dataGridViewOut_MSO.Rows.Add(value);
                }

                barChartValues_MSO.SetData(values5);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка обработки файла: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHelp_MSO_Click(object? sender, EventArgs e)
        {
            MessageBox.Show("Таск 5 выполнил студент группы СМАРТб-26-1 Москалёв Степан Олегович", "Сообщение",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
