namespace Tyuiu.MoskalevSO.Sprint6.Task0.V6
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
            labelX_MSO = new Label();
            textBoxX_MSO = new TextBox();
            buttonDone_MSO = new Button();
            buttonHelp_MSO = new Button();
            groupBoxOut_MSO = new GroupBox();
            labelResult_MSO = new Label();
            textBoxResult_MSO = new TextBox();
            toolTip_MSO = new ToolTip(components);
            groupBoxTask_MSO.SuspendLayout();
            groupBoxIn_MSO.SuspendLayout();
            groupBoxOut_MSO.SuspendLayout();
            SuspendLayout();
            //
            // groupBoxTask_MSO
            //
            groupBoxTask_MSO.Controls.Add(textBoxTask_MSO);
            groupBoxTask_MSO.Dock = DockStyle.Top;
            groupBoxTask_MSO.Location = new Point(8, 8);
            groupBoxTask_MSO.Name = "groupBoxTask_MSO";
            groupBoxTask_MSO.Size = new Size(568, 110);
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
            textBoxTask_MSO.Text = "Спринт #6 | Тема: Создание Desktop приложения на базе WinForms. Расчет выражения | Задание #0 | Вариант #6\r\n\r\nДано выражение y(x) = x / sqrt(x^2 + x), вычислить его значение при x = 3, результат вывести в TextBox. Округлить до трёх знаков после запятой.";
            //
            // groupBoxIn_MSO
            //
            groupBoxIn_MSO.Controls.Add(buttonHelp_MSO);
            groupBoxIn_MSO.Controls.Add(buttonDone_MSO);
            groupBoxIn_MSO.Controls.Add(textBoxX_MSO);
            groupBoxIn_MSO.Controls.Add(labelX_MSO);
            groupBoxIn_MSO.Dock = DockStyle.Left;
            groupBoxIn_MSO.Location = new Point(8, 118);
            groupBoxIn_MSO.Name = "groupBoxIn_MSO";
            groupBoxIn_MSO.Size = new Size(250, 235);
            groupBoxIn_MSO.TabIndex = 1;
            groupBoxIn_MSO.TabStop = false;
            groupBoxIn_MSO.Text = "Ввод данных";
            //
            // labelX_MSO
            //
            labelX_MSO.AutoSize = true;
            labelX_MSO.Location = new Point(12, 28);
            labelX_MSO.Name = "labelX_MSO";
            labelX_MSO.Text = "Значение x:";
            //
            // textBoxX_MSO
            //
            textBoxX_MSO.Location = new Point(12, 48);
            textBoxX_MSO.Name = "textBoxX_MSO";
            textBoxX_MSO.Size = new Size(120, 23);
            textBoxX_MSO.TabIndex = 0;
            textBoxX_MSO.Text = "3";
            toolTip_MSO.SetToolTip(textBoxX_MSO, "Целое значение x");
            //
            // buttonDone_MSO
            //
            buttonDone_MSO.Location = new Point(12, 90);
            buttonDone_MSO.Name = "buttonDone_MSO";
            buttonDone_MSO.Size = new Size(120, 30);
            buttonDone_MSO.TabIndex = 1;
            buttonDone_MSO.Text = "Выполнить";
            toolTip_MSO.SetToolTip(buttonDone_MSO, "Вычислить F(x)");
            buttonDone_MSO.UseVisualStyleBackColor = true;
            buttonDone_MSO.Click += buttonDone_MSO_Click;
            //
            // buttonHelp_MSO
            //
            buttonHelp_MSO.Location = new Point(140, 90);
            buttonHelp_MSO.Name = "buttonHelp_MSO";
            buttonHelp_MSO.Size = new Size(40, 30);
            buttonHelp_MSO.TabIndex = 2;
            buttonHelp_MSO.Text = "?";
            toolTip_MSO.SetToolTip(buttonHelp_MSO, "О программе");
            buttonHelp_MSO.UseVisualStyleBackColor = true;
            buttonHelp_MSO.Click += buttonHelp_MSO_Click;
            //
            // groupBoxOut_MSO
            //
            groupBoxOut_MSO.Controls.Add(textBoxResult_MSO);
            groupBoxOut_MSO.Controls.Add(labelResult_MSO);
            groupBoxOut_MSO.Dock = DockStyle.Fill;
            groupBoxOut_MSO.Location = new Point(258, 118);
            groupBoxOut_MSO.Name = "groupBoxOut_MSO";
            groupBoxOut_MSO.Size = new Size(318, 235);
            groupBoxOut_MSO.TabIndex = 2;
            groupBoxOut_MSO.TabStop = false;
            groupBoxOut_MSO.Text = "Вывод данных";
            //
            // labelResult_MSO
            //
            labelResult_MSO.AutoSize = true;
            labelResult_MSO.Location = new Point(12, 28);
            labelResult_MSO.Name = "labelResult_MSO";
            labelResult_MSO.Text = "Результат F(x):";
            //
            // textBoxResult_MSO
            //
            textBoxResult_MSO.Location = new Point(12, 48);
            textBoxResult_MSO.Name = "textBoxResult_MSO";
            textBoxResult_MSO.ReadOnly = true;
            textBoxResult_MSO.Size = new Size(150, 23);
            textBoxResult_MSO.TabIndex = 0;
            toolTip_MSO.SetToolTip(textBoxResult_MSO, "Результат, округлённый до трёх знаков");
            //
            // FormMain
            //
            AcceptButton = buttonDone_MSO;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 361);
            Controls.Add(groupBoxOut_MSO);
            Controls.Add(groupBoxIn_MSO);
            Controls.Add(groupBoxTask_MSO);
            MinimumSize = new Size(600, 400);
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
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxTask_MSO;
        private TextBox textBoxTask_MSO;
        private GroupBox groupBoxIn_MSO;
        private Label labelX_MSO;
        private TextBox textBoxX_MSO;
        private Button buttonDone_MSO;
        private Button buttonHelp_MSO;
        private GroupBox groupBoxOut_MSO;
        private Label labelResult_MSO;
        private TextBox textBoxResult_MSO;
        private ToolTip toolTip_MSO;
    }
}
