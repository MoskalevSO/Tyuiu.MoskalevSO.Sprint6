using Tyuiu.MoskalevSO.Sprint6.Task2.V24.Lib;

namespace Tyuiu.MoskalevSO.Sprint6.Task2.V24
{
    public partial class FormMain : Form
    {
        private readonly DataService ds = new DataService();

        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonDone_MSO_Click(object? sender, EventArgs e)
        {
            try
            {
                int startValue = Convert.ToInt32(textBoxStart_MSO.Text);
                int stopValue = Convert.ToInt32(textBoxStop_MSO.Text);

                double[] values = ds.GetMassFunction(startValue, stopValue);

                dataGridViewFunction_MSO.Rows.Clear();
                for (int i = 0; i < values.Length; i++)
                {
                    dataGridViewFunction_MSO.Rows.Add(startValue + i, values[i]);
                }
            }
            catch
            {
                MessageBox.Show("Введите корректные целые значения диапазона", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHelp_MSO_Click(object? sender, EventArgs e)
        {
            MessageBox.Show("Таск 2 выполнил студент группы СМАРТб-26-1 Москалёв Степан Олегович", "Сообщение",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
