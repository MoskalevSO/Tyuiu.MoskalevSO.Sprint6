namespace Tyuiu.MoskalevSO.Sprint6.Task5.V7
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
            buttonHelp_MSO = new Button();
            groupBoxIn_MSO = new GroupBox();
            dataGridViewIn_MSO = new DataGridView();
            columnInValue_MSO = new DataGridViewTextBoxColumn();
            groupBoxOut_MSO = new GroupBox();
            barChartValues_MSO = new BarChartControl_MSO();
            dataGridViewOut_MSO = new DataGridView();
            columnOutValue_MSO = new DataGridViewTextBoxColumn();
            openFileDialogTask_MSO = new OpenFileDialog();
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
            groupBoxTask_MSO.Size = new Size(868, 100);
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
            textBoxTask_MSO.Text = "Спринт #6 | Тема: Чтение данных из файла | Задание #5 | Вариант #7\r\n\r\nПрочитать данные из файла InPutFileTask5V7.txt. Вывести в DataGridView. Дан список из 20 чисел. Вывести все числа больше 5. Построить диаграмму по этим значениям. У вещественных значений округлить до трёх знаков после запятой.";
            //
            // panelButtons_MSO
            //
            panelButtons_MSO.Controls.Add(buttonHelp_MSO);
            panelButtons_MSO.Controls.Add(buttonDone_MSO);
            panelButtons_MSO.Controls.Add(buttonOpenFile_MSO);
            panelButtons_MSO.Dock = DockStyle.Bottom;
            panelButtons_MSO.Location = new Point(8, 449);
            panelButtons_MSO.Name = "panelButtons_MSO";
            panelButtons_MSO.Size = new Size(868, 44);
            panelButtons_MSO.TabIndex = 3;
            //
            // buttonOpenFile_MSO
            //
            buttonOpenFile_MSO.Location = new Point(4, 8);
            buttonOpenFile_MSO.Name = "buttonOpenFile_MSO";
            buttonOpenFile_MSO.Size = new Size(120, 30);
            buttonOpenFile_MSO.TabIndex = 0;
            buttonOpenFile_MSO.Text = "Открыть файл";
            toolTip_MSO.SetToolTip(buttonOpenFile_MSO, "Выбрать файл InPutFileTask5V7.txt");
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
            toolTip_MSO.SetToolTip(buttonDone_MSO, "Вывести числа больше 5 и построить диаграмму");
            buttonDone_MSO.UseVisualStyleBackColor = true;
            buttonDone_MSO.Click += buttonDone_MSO_Click;
            //
            // buttonHelp_MSO
            //
            buttonHelp_MSO.Location = new Point(260, 8);
            buttonHelp_MSO.Name = "buttonHelp_MSO";
            buttonHelp_MSO.Size = new Size(40, 30);
            buttonHelp_MSO.TabIndex = 2;
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
            groupBoxIn_MSO.Size = new Size(180, 341);
            groupBoxIn_MSO.TabIndex = 1;
            groupBoxIn_MSO.TabStop = false;
            groupBoxIn_MSO.Text = "Данные из файла";
            //
            // dataGridViewIn_MSO
            //
            dataGridViewIn_MSO.AllowUserToAddRows = false;
            dataGridViewIn_MSO.AllowUserToDeleteRows = false;
            dataGridViewIn_MSO.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewIn_MSO.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewIn_MSO.Columns.AddRange(new DataGridViewColumn[] { columnInValue_MSO });
            dataGridViewIn_MSO.Dock = DockStyle.Fill;
            dataGridViewIn_MSO.Name = "dataGridViewIn_MSO";
            dataGridViewIn_MSO.ReadOnly = true;
            dataGridViewIn_MSO.RowHeadersVisible = false;
            dataGridViewIn_MSO.TabIndex = 0;
            //
            // columnInValue_MSO
            //
            columnInValue_MSO.HeaderText = "Значение";
            columnInValue_MSO.Name = "columnInValue_MSO";
            columnInValue_MSO.ReadOnly = true;
            //
            // groupBoxOut_MSO
            //
            groupBoxOut_MSO.Controls.Add(barChartValues_MSO);
            groupBoxOut_MSO.Controls.Add(dataGridViewOut_MSO);
            groupBoxOut_MSO.Dock = DockStyle.Fill;
            groupBoxOut_MSO.Location = new Point(188, 108);
            groupBoxOut_MSO.Name = "groupBoxOut_MSO";
            groupBoxOut_MSO.Size = new Size(688, 341);
            groupBoxOut_MSO.TabIndex = 2;
            groupBoxOut_MSO.TabStop = false;
            groupBoxOut_MSO.Text = "Числа больше 5 и диаграмма";
            //
            // barChartValues_MSO
            //
            barChartValues_MSO.Dock = DockStyle.Fill;
            barChartValues_MSO.Name = "barChartValues_MSO";
            barChartValues_MSO.TabIndex = 1;
            toolTip_MSO.SetToolTip(barChartValues_MSO, "Диаграмма чисел больше 5");
            //
            // dataGridViewOut_MSO
            //
            dataGridViewOut_MSO.AllowUserToAddRows = false;
            dataGridViewOut_MSO.AllowUserToDeleteRows = false;
            dataGridViewOut_MSO.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewOut_MSO.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOut_MSO.Columns.AddRange(new DataGridViewColumn[] { columnOutValue_MSO });
            dataGridViewOut_MSO.Dock = DockStyle.Left;
            dataGridViewOut_MSO.Name = "dataGridViewOut_MSO";
            dataGridViewOut_MSO.ReadOnly = true;
            dataGridViewOut_MSO.RowHeadersVisible = false;
            dataGridViewOut_MSO.Size = new Size(140, 319);
            dataGridViewOut_MSO.TabIndex = 0;
            //
            // columnOutValue_MSO
            //
            columnOutValue_MSO.HeaderText = "Число > 5";
            columnOutValue_MSO.Name = "columnOutValue_MSO";
            columnOutValue_MSO.ReadOnly = true;
            //
            // openFileDialogTask_MSO
            //
            openFileDialogTask_MSO.FileName = "InPutFileTask5V7.txt";
            openFileDialogTask_MSO.Filter = "Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*";
            openFileDialogTask_MSO.Title = "Открыть файл с данными";
            //
            // FormMain
            //
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(884, 501);
            Controls.Add(groupBoxOut_MSO);
            Controls.Add(groupBoxIn_MSO);
            Controls.Add(panelButtons_MSO);
            Controls.Add(groupBoxTask_MSO);
            MinimumSize = new Size(700, 460);
            Name = "FormMain";
            Padding = new Padding(8);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт #6 | Выполнил: Москалёв С. О. | СМАРТб-26-1";
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
        private Button buttonHelp_MSO;
        private GroupBox groupBoxIn_MSO;
        private DataGridView dataGridViewIn_MSO;
        private DataGridViewTextBoxColumn columnInValue_MSO;
        private GroupBox groupBoxOut_MSO;
        private BarChartControl_MSO barChartValues_MSO;
        private DataGridView dataGridViewOut_MSO;
        private DataGridViewTextBoxColumn columnOutValue_MSO;
        private OpenFileDialog openFileDialogTask_MSO;
        private ToolTip toolTip_MSO;
    }
}
