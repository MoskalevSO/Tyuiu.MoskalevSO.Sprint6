namespace Tyuiu.MoskalevSO.Sprint6.Task3.V15
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
            buttonDone_MSO = new Button();
            buttonHelp_MSO = new Button();
            groupBoxIn_MSO = new GroupBox();
            dataGridViewIn_MSO = new DataGridView();
            groupBoxOut_MSO = new GroupBox();
            dataGridViewOut_MSO = new DataGridView();
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
            groupBoxTask_MSO.Size = new Size(718, 100);
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
            textBoxTask_MSO.Text = "Спринт #6 | Тема: Матрицы | Задание #3 | Вариант #15\r\n\r\nДан массив 5 на 5 элементов. Выполнить сортировку по возрастанию в третьем столбце. Результат вывести в DataGridView.";
            //
            // panelButtons_MSO
            //
            panelButtons_MSO.Controls.Add(buttonHelp_MSO);
            panelButtons_MSO.Controls.Add(buttonDone_MSO);
            panelButtons_MSO.Dock = DockStyle.Bottom;
            panelButtons_MSO.Location = new Point(8, 393);
            panelButtons_MSO.Name = "panelButtons_MSO";
            panelButtons_MSO.Size = new Size(718, 44);
            panelButtons_MSO.TabIndex = 3;
            //
            // buttonDone_MSO
            //
            buttonDone_MSO.Location = new Point(4, 8);
            buttonDone_MSO.Name = "buttonDone_MSO";
            buttonDone_MSO.Size = new Size(120, 30);
            buttonDone_MSO.TabIndex = 0;
            buttonDone_MSO.Text = "Выполнить";
            toolTip_MSO.SetToolTip(buttonDone_MSO, "Отсортировать третий столбец по возрастанию");
            buttonDone_MSO.UseVisualStyleBackColor = true;
            buttonDone_MSO.Click += buttonDone_MSO_Click;
            //
            // buttonHelp_MSO
            //
            buttonHelp_MSO.Location = new Point(132, 8);
            buttonHelp_MSO.Name = "buttonHelp_MSO";
            buttonHelp_MSO.Size = new Size(40, 30);
            buttonHelp_MSO.TabIndex = 1;
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
            groupBoxIn_MSO.Size = new Size(355, 285);
            groupBoxIn_MSO.TabIndex = 1;
            groupBoxIn_MSO.TabStop = false;
            groupBoxIn_MSO.Text = "Ввод данных";
            //
            // dataGridViewIn_MSO
            //
            dataGridViewIn_MSO.AllowUserToAddRows = false;
            dataGridViewIn_MSO.AllowUserToDeleteRows = false;
            dataGridViewIn_MSO.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewIn_MSO.ColumnHeadersVisible = false;
            dataGridViewIn_MSO.Dock = DockStyle.Fill;
            dataGridViewIn_MSO.Name = "dataGridViewIn_MSO";
            dataGridViewIn_MSO.RowHeadersVisible = false;
            dataGridViewIn_MSO.TabIndex = 0;
            toolTip_MSO.SetToolTip(dataGridViewIn_MSO, "Исходный массив (значения можно изменить)");
            //
            // groupBoxOut_MSO
            //
            groupBoxOut_MSO.Controls.Add(dataGridViewOut_MSO);
            groupBoxOut_MSO.Dock = DockStyle.Fill;
            groupBoxOut_MSO.Location = new Point(363, 108);
            groupBoxOut_MSO.Name = "groupBoxOut_MSO";
            groupBoxOut_MSO.Size = new Size(363, 285);
            groupBoxOut_MSO.TabIndex = 2;
            groupBoxOut_MSO.TabStop = false;
            groupBoxOut_MSO.Text = "Вывод данных";
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
            toolTip_MSO.SetToolTip(dataGridViewOut_MSO, "Результат");
            //
            // FormMain
            //
            AcceptButton = buttonDone_MSO;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(734, 445);
            Controls.Add(groupBoxOut_MSO);
            Controls.Add(groupBoxIn_MSO);
            Controls.Add(panelButtons_MSO);
            Controls.Add(groupBoxTask_MSO);
            MinimumSize = new Size(700, 450);
            Name = "FormMain";
            Padding = new Padding(8);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт #6 | Выполнил: Москалёв С. О. | СМАРТб-26-1";
            Load += FormMain_Load;
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
        private Button buttonDone_MSO;
        private Button buttonHelp_MSO;
        private GroupBox groupBoxIn_MSO;
        private DataGridView dataGridViewIn_MSO;
        private GroupBox groupBoxOut_MSO;
        private DataGridView dataGridViewOut_MSO;
        private ToolTip toolTip_MSO;
    }
}
