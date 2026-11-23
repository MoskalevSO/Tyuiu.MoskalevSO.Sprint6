namespace Tyuiu.MoskalevSO.Sprint6.Task2.V24
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
            groupBoxIn_MSO = new GroupBox();
            labelStart_MSO = new Label();
            textBoxStart_MSO = new TextBox();
            labelStop_MSO = new Label();
            textBoxStop_MSO = new TextBox();
            buttonDone_MSO = new Button();
            buttonHelp_MSO = new Button();
            groupBoxOut_MSO = new GroupBox();
            dataGridViewFunction_MSO = new DataGridView();
            columnX_MSO = new DataGridViewTextBoxColumn();
            columnFx_MSO = new DataGridViewTextBoxColumn();
            toolTip_MSO = new ToolTip(components);
            groupBoxTask_MSO.SuspendLayout();
            groupBoxIn_MSO.SuspendLayout();
            groupBoxOut_MSO.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFunction_MSO).BeginInit();
            SuspendLayout();
            //
            // groupBoxTask_MSO
            //
            groupBoxTask_MSO.Controls.Add(textBoxTask_MSO);
            groupBoxTask_MSO.Dock = DockStyle.Top;
            groupBoxTask_MSO.Location = new Point(8, 8);
            groupBoxTask_MSO.Name = "groupBoxTask_MSO";
            groupBoxTask_MSO.Size = new Size(668, 110);
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
            textBoxTask_MSO.Text = "Спринт #6 | Тема: Табулирование функции | Задание #2 | Вариант #24\r\n\r\nВывести таблицу значений функции F(x) = sin(x) + (cos(x) + 1) / (2 - x) + 2x на диапазоне [-5; 5] с шагом 1. При делении на ноль вернуть 0. Значения занести в DataGridView, округлить до двух знаков после запятой.";
            //
            // groupBoxIn_MSO
            //
            groupBoxIn_MSO.Controls.Add(buttonHelp_MSO);
            groupBoxIn_MSO.Controls.Add(buttonDone_MSO);
            groupBoxIn_MSO.Controls.Add(textBoxStop_MSO);
            groupBoxIn_MSO.Controls.Add(labelStop_MSO);
            groupBoxIn_MSO.Controls.Add(textBoxStart_MSO);
            groupBoxIn_MSO.Controls.Add(labelStart_MSO);
            groupBoxIn_MSO.Dock = DockStyle.Left;
            groupBoxIn_MSO.Location = new Point(8, 118);
            groupBoxIn_MSO.Name = "groupBoxIn_MSO";
            groupBoxIn_MSO.Size = new Size(250, 335);
            groupBoxIn_MSO.TabIndex = 1;
            groupBoxIn_MSO.TabStop = false;
            groupBoxIn_MSO.Text = "Ввод данных";
            //
            // labelStart_MSO
            //
            labelStart_MSO.AutoSize = true;
            labelStart_MSO.Location = new Point(12, 28);
            labelStart_MSO.Name = "labelStart_MSO";
            labelStart_MSO.Text = "Старт шага:";
            //
            // textBoxStart_MSO
            //
            textBoxStart_MSO.Location = new Point(12, 48);
            textBoxStart_MSO.Name = "textBoxStart_MSO";
            textBoxStart_MSO.Size = new Size(120, 23);
            textBoxStart_MSO.TabIndex = 0;
            textBoxStart_MSO.Text = "-5";
            toolTip_MSO.SetToolTip(textBoxStart_MSO, "Начало диапазона");
            //
            // labelStop_MSO
            //
            labelStop_MSO.AutoSize = true;
            labelStop_MSO.Location = new Point(12, 80);
            labelStop_MSO.Name = "labelStop_MSO";
            labelStop_MSO.Text = "Конец шага:";
            //
            // textBoxStop_MSO
            //
            textBoxStop_MSO.Location = new Point(12, 100);
            textBoxStop_MSO.Name = "textBoxStop_MSO";
            textBoxStop_MSO.Size = new Size(120, 23);
            textBoxStop_MSO.TabIndex = 1;
            textBoxStop_MSO.Text = "5";
            toolTip_MSO.SetToolTip(textBoxStop_MSO, "Конец диапазона");
            //
            // buttonDone_MSO
            //
            buttonDone_MSO.Location = new Point(12, 140);
            buttonDone_MSO.Name = "buttonDone_MSO";
            buttonDone_MSO.Size = new Size(120, 30);
            buttonDone_MSO.TabIndex = 2;
            buttonDone_MSO.Text = "Выполнить";
            toolTip_MSO.SetToolTip(buttonDone_MSO, "Протабулировать функцию");
            buttonDone_MSO.UseVisualStyleBackColor = true;
            buttonDone_MSO.Click += buttonDone_MSO_Click;
            //
            // buttonHelp_MSO
            //
            buttonHelp_MSO.Location = new Point(140, 140);
            buttonHelp_MSO.Name = "buttonHelp_MSO";
            buttonHelp_MSO.Size = new Size(40, 30);
            buttonHelp_MSO.TabIndex = 3;
            buttonHelp_MSO.Text = "?";
            toolTip_MSO.SetToolTip(buttonHelp_MSO, "О программе");
            buttonHelp_MSO.UseVisualStyleBackColor = true;
            buttonHelp_MSO.Click += buttonHelp_MSO_Click;
            //
            // groupBoxOut_MSO
            //
            groupBoxOut_MSO.Controls.Add(dataGridViewFunction_MSO);
            groupBoxOut_MSO.Dock = DockStyle.Fill;
            groupBoxOut_MSO.Location = new Point(258, 118);
            groupBoxOut_MSO.Name = "groupBoxOut_MSO";
            groupBoxOut_MSO.Size = new Size(418, 335);
            groupBoxOut_MSO.TabIndex = 2;
            groupBoxOut_MSO.TabStop = false;
            groupBoxOut_MSO.Text = "Вывод данных";
            //
            // dataGridViewFunction_MSO
            //
            dataGridViewFunction_MSO.AllowUserToAddRows = false;
            dataGridViewFunction_MSO.AllowUserToDeleteRows = false;
            dataGridViewFunction_MSO.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewFunction_MSO.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewFunction_MSO.Columns.AddRange(new DataGridViewColumn[] { columnX_MSO, columnFx_MSO });
            dataGridViewFunction_MSO.Dock = DockStyle.Fill;
            dataGridViewFunction_MSO.Name = "dataGridViewFunction_MSO";
            dataGridViewFunction_MSO.ReadOnly = true;
            dataGridViewFunction_MSO.RowHeadersVisible = false;
            dataGridViewFunction_MSO.TabIndex = 0;
            //
            // columnX_MSO
            //
            columnX_MSO.HeaderText = "X";
            columnX_MSO.Name = "columnX_MSO";
            columnX_MSO.ReadOnly = true;
            //
            // columnFx_MSO
            //
            columnFx_MSO.HeaderText = "F(X)";
            columnFx_MSO.Name = "columnFx_MSO";
            columnFx_MSO.ReadOnly = true;
            //
            // FormMain
            //
            AcceptButton = buttonDone_MSO;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(684, 461);
            Controls.Add(groupBoxOut_MSO);
            Controls.Add(groupBoxIn_MSO);
            Controls.Add(groupBoxTask_MSO);
            MinimumSize = new Size(640, 450);
            Name = "FormMain";
            Padding = new Padding(8);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт #6 | Выполнил: Москалёв С. О. | СМАРТб-26-1";
            groupBoxTask_MSO.ResumeLayout(false);
            groupBoxTask_MSO.PerformLayout();
            groupBoxIn_MSO.ResumeLayout(false);
            groupBoxIn_MSO.PerformLayout();
            groupBoxOut_MSO.ResumeLayout(false);
            groupBoxOut_MSO.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFunction_MSO).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxTask_MSO;
        private TextBox textBoxTask_MSO;
        private GroupBox groupBoxIn_MSO;
        private Label labelStart_MSO;
        private TextBox textBoxStart_MSO;
        private Label labelStop_MSO;
        private TextBox textBoxStop_MSO;
        private Button buttonDone_MSO;
        private Button buttonHelp_MSO;
        private GroupBox groupBoxOut_MSO;
        private DataGridView dataGridViewFunction_MSO;
        private DataGridViewTextBoxColumn columnX_MSO;
        private DataGridViewTextBoxColumn columnFx_MSO;
        private ToolTip toolTip_MSO;
    }
}
