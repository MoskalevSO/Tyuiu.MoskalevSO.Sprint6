using Tyuiu.MoskalevSO.Sprint6.Task1.V4.Lib;

namespace Tyuiu.MoskalevSO.Sprint6.Task1.V4
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

                textBoxResult_MSO.Clear();
                textBoxResult_MSO.AppendText("+----------+------------+" + Environment.NewLine);
                textBoxResult_MSO.AppendText("|    X     |    F(X)    |" + Environment.NewLine);
                textBoxResult_MSO.AppendText("+----------+------------+" + Environment.NewLine);

                for (int i = 0; i < values.Length; i++)
                {
                    textBoxResult_MSO.AppendText(string.Format("|{0,9} | {1,10} |", startValue + i, values[i]) + Environment.NewLine);
                }

                textBoxResult_MSO.AppendText("+----------+------------+");
            }
            catch
            {
                MessageBox.Show("Введите корректные целые значения диапазона", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHelp_MSO_Click(object? sender, EventArgs e)
        {
            MessageBox.Show("Таск 1 выполнил студент группы СМАРТб-26-1 Москалёв Степан Олегович", "Сообщение",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
