using Tyuiu.MoskalevSO.Sprint6.Task0.V6.Lib;

namespace Tyuiu.MoskalevSO.Sprint6.Task0.V6
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
                int x = Convert.ToInt32(textBoxX_MSO.Text);
                textBoxResult_MSO.Text = Convert.ToString(ds.Calculate(x));
            }
            catch
            {
                MessageBox.Show("Введите целое значение x", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHelp_MSO_Click(object? sender, EventArgs e)
        {
            MessageBox.Show("Таск 0 выполнил студент группы СМАРТб-26-1 Москалёв Степан Олегович", "Сообщение",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
