using Tyuiu.MoskalevSO.Sprint6.Task6.V22.Lib;

namespace Tyuiu.MoskalevSO.Sprint6.Task6.V22
{
    public partial class FormMain : Form
    {
        private readonly DataService ds = new DataService();
        private string openFilePath = "";

        public FormMain()
        {
            InitializeComponent();
        }

        // Левая и правая панели делят окно пополам
        private void FormMain_Resize(object? sender, EventArgs e)
        {
            groupBoxIn_MSO.Width = (ClientSize.Width - Padding.Horizontal) / 2;
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
                textBoxIn_MSO.Text = File.ReadAllText(openFilePath);
                textBoxOut_MSO.Clear();
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
                textBoxOut_MSO.Text = ds.CollectTextFromFile(openFilePath);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка обработки файла: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHelp_MSO_Click(object? sender, EventArgs e)
        {
            MessageBox.Show("Таск 6 выполнил студент группы СМАРТб-26-1 Москалёв Степан Олегович", "Сообщение",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
