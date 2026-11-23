using Tyuiu.MoskalevSO.Sprint6.Task4.V23.Lib;

namespace Tyuiu.MoskalevSO.Sprint6.Task4.V23
{
    public partial class FormMain : Form
    {
        private readonly DataService ds = new DataService();

        public FormMain()
        {
            InitializeComponent();
        }

        private bool TryReadRange(out int startValue, out int stopValue)
        {
            bool ok = int.TryParse(textBoxStart_MSO.Text, out startValue) &
                      int.TryParse(textBoxStop_MSO.Text, out stopValue);

            if (!ok || startValue > stopValue)
            {
                MessageBox.Show("Введите корректный целочисленный диапазон", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void buttonDone_MSO_Click(object? sender, EventArgs e)
        {
            if (!TryReadRange(out int startValue, out int stopValue))
            {
                return;
            }

            double[] values = ds.GetMassFunction(startValue, stopValue);
            double[] xs = new double[values.Length];

            textBoxResult_MSO.Clear();
            textBoxResult_MSO.AppendText("+------+----------+" + Environment.NewLine);
            textBoxResult_MSO.AppendText("|  X   |   F(X)   |" + Environment.NewLine);
            textBoxResult_MSO.AppendText("+------+----------+" + Environment.NewLine);

            for (int i = 0; i < values.Length; i++)
            {
                xs[i] = startValue + i;
                textBoxResult_MSO.AppendText(string.Format("|{0,5} | {1,8} |", xs[i], values[i]) + Environment.NewLine);
            }

            textBoxResult_MSO.AppendText("+------+----------+");
            chartFunction_MSO.SetData(xs, values);
        }

        private void buttonSave_MSO_Click(object? sender, EventArgs e)
        {
            if (!TryReadRange(out int startValue, out int stopValue))
            {
                return;
            }

            try
            {
                string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask4V23.txt");
                ds.SaveToFile(startValue, stopValue, path);
                MessageBox.Show("Файл " + path + " сохранён успешно", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Не удалось сохранить файл: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHelp_MSO_Click(object? sender, EventArgs e)
        {
            MessageBox.Show("Таск 4 выполнил студент группы СМАРТб-26-1 Москалёв Степан Олегович", "Сообщение",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
