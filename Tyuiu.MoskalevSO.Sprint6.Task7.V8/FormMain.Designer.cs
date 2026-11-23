namespace Tyuiu.MoskalevSO.Sprint6.Task7.V8
{
    partial class FormMain
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            groupBoxTask_MSO = new GroupBox();
            textBoxTask_MSO = new TextBox();
            panelButtons_MSO = new Panel();
            buttonOpenFile_MSO = new Button();
            buttonDone_MSO = new Button();
            buttonSaveFile_MSO = new Button();
            buttonHelp_MSO = new Button();
            groupBoxIn_MSO = new GroupBox();
            dataGridViewIn_MSO = new DataGridView();
            groupBoxOut_MSO = new GroupBox();
            dataGridViewOut_MSO = new DataGridView();
            openFileDialogTask_MSO = new OpenFileDialog();
            saveFileDialogTask_MSO = new SaveFileDialog();
            toolTip_MSO = new ToolTip(components);
            groupBoxTask_MSO.SuspendLayout();
            panelButtons_MSO.SuspendLayout();
            groupBoxIn_MSO.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewIn_MSO).BeginInit();
            groupBoxOut_MSO.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOut_MSO).BeginInit();
            SuspendLayout();
            //
            // groupBoxTask_MSO
            //
            groupBoxTask_MSO.Controls.Add(textBoxTask_MSO);
            groupBoxTask_MSO.Dock = DockStyle.Top;
            groupBoxTask_MSO.Location = new Point(8, 8);
            groupBoxTask_MSO.Name = "groupBoxTask_MSO";
            groupBoxTask_MSO.Size = new Size(768, 125);
            groupBoxTask_MSO.TabIndex = 0;
            groupBoxTask_MSO.TabStop = false;
            groupBoxTask_MSO.Text = "Условие";
            //
            // textBoxTask_MSO
            //
            textBoxTask_MSO.BackColor = SystemColors.Control;
            textBoxTask_MSO.Dock = DockStyle.Fill;
            textBoxTask_MSO.Multiline = true;
            textBoxTask_MSO.Name = "textBoxTask_MSO";
            textBoxTask_MSO.ReadOnly = true;
            textBoxTask_MSO.TabStop = false;
            textBoxTask_MSO.Text = "Спринт #6 | Тема: Добавление к решению итоговых проектов по спринту | Задание #7 | Вариант #8\r\n\r\nДан файл InPutFileTask7V8.csv, в котором хранится матрица целочисленных значений. Загрузить файл через openFileDialog в dataGridViewIn. Изменить в восьмом столбце значения, не равные 5, на -1. Результат вывести в dataGridViewOut. Сохранить результат в файл OutPutFileTask7.csv через saveFileDialog.";
            //
            // panelButtons_MSO
            //
            panelButtons_MSO.Controls.Add(buttonHelp_MSO);
            panelButtons_MSO.Controls.Add(buttonSaveFile_MSO);
            panelButtons_MSO.Controls.Add(buttonDone_MSO);
            panelButtons_MSO.Controls.Add(buttonOpenFile_MSO);
            panelButtons_MSO.Dock = DockStyle.Bottom;
            panelButtons_MSO.Location = new Point(8, 409);
            panelButtons_MSO.Name = "panelButtons_MSO";
            panelButtons_MSO.Size = new Size(768, 44);
            panelButtons_MSO.TabIndex = 3;
            //
            // buttonOpenFile_MSO
            //
            buttonOpenFile_MSO.Location = new Point(4, 8);
            buttonOpenFile_MSO.Name = "buttonOpenFile_MSO";
            buttonOpenFile_MSO.Size = new Size(120, 30);
            buttonOpenFile_MSO.TabIndex = 0;
            buttonOpenFile_MSO.Text = "Открыть файл";
            toolTip_MSO.SetToolTip(buttonOpenFile_MSO, "Загрузить матрицу из файла CSV");
            buttonOpenFile_MSO.UseVisualStyleBackColor = true;
            buttonOpenFile_MSO.Click += buttonOpenFile_MSO_Click;
            //
            // buttonDone_MSO
            //
            buttonDone_MSO.Enabled = false;
            buttonDone_MSO.Location = new Point(132, 8);
            buttonDone_MSO.Name = "buttonDone_MSO";
            buttonDone_MSO.Size = new Size(120, 30);
            buttonDone_MSO.TabIndex = 1;
            buttonDone_MSO.Text = "Выполнить";
            toolTip_MSO.SetToolTip(buttonDone_MSO, "Заменить в восьмом столбце значения, не равные 5, на -1");
            buttonDone_MSO.UseVisualStyleBackColor = true;
            buttonDone_MSO.Click += buttonDone_MSO_Click;
            //
            // buttonSaveFile_MSO
            //
            buttonSaveFile_MSO.Enabled = false;
            buttonSaveFile_MSO.Location = new Point(260, 8);
            buttonSaveFile_MSO.Name = "buttonSaveFile_MSO";
            buttonSaveFile_MSO.Size = new Size(120, 30);
            buttonSaveFile_MSO.TabIndex = 2;
            buttonSaveFile_MSO.Text = "Сохранить файл";
            toolTip_MSO.SetToolTip(buttonSaveFile_MSO, "Сохранить результат в файл OutPutFileTask7.csv");
            buttonSaveFile_MSO.UseVisualStyleBackColor = true;
            buttonSaveFile_MSO.Click += buttonSaveFile_MSO_Click;
            //
            // buttonHelp_MSO
            //
            buttonHelp_MSO.Location = new Point(388, 8);
            buttonHelp_MSO.Name = "buttonHelp_MSO";
            buttonHelp_MSO.Size = new Size(40, 30);
            buttonHelp_MSO.TabIndex = 3;
            buttonHelp_MSO.Text = "?";
            toolTip_MSO.SetToolTip(buttonHelp_MSO, "О программе");
            buttonHelp_MSO.UseVisualStyleBackColor = true;
            buttonHelp_MSO.Click += buttonHelp_MSO_Click;
            //
            // groupBoxIn_MSO
            //
            groupBoxIn_MSO.Controls.Add(dataGridViewIn_MSO);
            groupBoxIn_MSO.Dock = DockStyle.Left;
            groupBoxIn_MSO.Location = new Point(8, 108);
            groupBoxIn_MSO.Name = "groupBoxIn_MSO";
            groupBoxIn_MSO.Size = new Size(384, 301);
            groupBoxIn_MSO.TabIndex = 1;
            groupBoxIn_MSO.TabStop = false;
            groupBoxIn_MSO.Text = "Исходная матрица";
            //
            // dataGridViewIn_MSO
            //
            dataGridViewIn_MSO.AllowUserToAddRows = false;
            dataGridViewIn_MSO.AllowUserToDeleteRows = false;
            dataGridViewIn_MSO.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewIn_MSO.ColumnHeadersVisible = false;
            dataGridViewIn_MSO.Dock = DockStyle.Fill;
            dataGridViewIn_MSO.Name = "dataGridViewIn_MSO";
            dataGridViewIn_MSO.ReadOnly = true;
            dataGridViewIn_MSO.RowHeadersVisible = false;
            dataGridViewIn_MSO.TabIndex = 0;
            //
            // groupBoxOut_MSO
            //
            groupBoxOut_MSO.Controls.Add(dataGridViewOut_MSO);
            groupBoxOut_MSO.Dock = DockStyle.Fill;
            groupBoxOut_MSO.Location = new Point(392, 108);
            groupBoxOut_MSO.Name = "groupBoxOut_MSO";
            groupBoxOut_MSO.Size = new Size(384, 301);
            groupBoxOut_MSO.TabIndex = 2;
            groupBoxOut_MSO.TabStop = false;
            groupBoxOut_MSO.Text = "Результат";
            //
            // dataGridViewOut_MSO
            //
            dataGridViewOut_MSO.AllowUserToAddRows = false;
            dataGridViewOut_MSO.AllowUserToDeleteRows = false;
            dataGridViewOut_MSO.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewOut_MSO.ColumnHeadersVisible = false;
            dataGridViewOut_MSO.Dock = DockStyle.Fill;
            dataGridViewOut_MSO.Name = "dataGridViewOut_MSO";
            dataGridViewOut_MSO.ReadOnly = true;
            dataGridViewOut_MSO.RowHeadersVisible = false;
            dataGridViewOut_MSO.TabIndex = 0;
            //
            // openFileDialogTask_MSO
            //
            openFileDialogTask_MSO.FileName = "InPutFileTask7V8.csv";
            openFileDialogTask_MSO.Filter = "Файлы CSV (*.csv)|*.csv|Все файлы (*.*)|*.*";
            openFileDialogTask_MSO.Title = "Открыть матрицу";
            //
            // saveFileDialogTask_MSO
            //
            saveFileDialogTask_MSO.DefaultExt = "csv";
            saveFileDialogTask_MSO.FileName = "OutPutFileTask7.csv";
            saveFileDialogTask_MSO.Filter = "Файлы CSV (*.csv)|*.csv";
            saveFileDialogTask_MSO.Title = "Сохранить результат";
            //
            // FormMain
            //
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 461);
            Controls.Add(groupBoxOut_MSO);
            Controls.Add(groupBoxIn_MSO);
            Controls.Add(panelButtons_MSO);
            Controls.Add(groupBoxTask_MSO);
            MinimumSize = new Size(640, 420);
            Name = "FormMain";
            Padding = new Padding(8);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт #6 | Выполнил: Москалёв С. О. | СМАРТб-26-1";
            Resize += FormMain_Resize;
            groupBoxTask_MSO.ResumeLayout(false);
            groupBoxTask_MSO.PerformLayout();
            panelButtons_MSO.ResumeLayout(false);
            groupBoxIn_MSO.ResumeLayout(false);
            groupBoxIn_MSO.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewIn_MSO).EndInit();
            groupBoxOut_MSO.ResumeLayout(false);
            groupBoxOut_MSO.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOut_MSO).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxTask_MSO;
        private TextBox textBoxTask_MSO;
        private Panel panelButtons_MSO;
        private Button buttonOpenFile_MSO;
        private Button buttonDone_MSO;
        private Button buttonSaveFile_MSO;
        private Button buttonHelp_MSO;
        private GroupBox groupBoxIn_MSO;
        private DataGridView dataGridViewIn_MSO;
        private GroupBox groupBoxOut_MSO;
        private DataGridView dataGridViewOut_MSO;
        private OpenFileDialog openFileDialogTask_MSO;
        private SaveFileDialog saveFileDialogTask_MSO;
        private ToolTip toolTip_MSO;
    }
}
