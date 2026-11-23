namespace Tyuiu.MoskalevSO.Sprint6.Task6.V22
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
            textBoxIn_MSO = new TextBox();
            groupBoxOut_MSO = new GroupBox();
            textBoxOut_MSO = new TextBox();
            openFileDialogTask_MSO = new OpenFileDialog();
            toolTip_MSO = new ToolTip(components);
            groupBoxTask_MSO.SuspendLayout();
            panelButtons_MSO.SuspendLayout();
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
            groupBoxTask_MSO.Size = new Size(768, 100);
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
            textBoxTask_MSO.Text = "Спринт #6 | Тема: Обработка текстовых файлов | Задание #6 | Вариант #22\r\n\r\nДан файл InPutFileTask6V22.txt, который может находиться в любом месте на диске. Загрузить файл в textBoxIn через openFileDialog. Вывести первое слово каждой строки в результирующую строку и вывести её в textBoxOut.";
            //
            // panelButtons_MSO
            //
            panelButtons_MSO.Controls.Add(buttonHelp_MSO);
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
            toolTip_MSO.SetToolTip(buttonOpenFile_MSO, "Выбрать файл InPutFileTask6V22.txt");
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
            toolTip_MSO.SetToolTip(buttonDone_MSO, "Собрать первые слова каждой строки");
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
            groupBoxIn_MSO.Controls.Add(textBoxIn_MSO);
            groupBoxIn_MSO.Dock = DockStyle.Left;
            groupBoxIn_MSO.Location = new Point(8, 108);
            groupBoxIn_MSO.Name = "groupBoxIn_MSO";
            groupBoxIn_MSO.Size = new Size(384, 301);
            groupBoxIn_MSO.TabIndex = 1;
            groupBoxIn_MSO.TabStop = false;
            groupBoxIn_MSO.Text = "Исходный текст";
            //
            // textBoxIn_MSO
            //
            textBoxIn_MSO.Dock = DockStyle.Fill;
            textBoxIn_MSO.Multiline = true;
            textBoxIn_MSO.Name = "textBoxIn_MSO";
            textBoxIn_MSO.ReadOnly = true;
            textBoxIn_MSO.ScrollBars = ScrollBars.Both;
            textBoxIn_MSO.TabIndex = 0;
            textBoxIn_MSO.WordWrap = false;
            toolTip_MSO.SetToolTip(textBoxIn_MSO, "Содержимое файла");
            //
            // groupBoxOut_MSO
            //
            groupBoxOut_MSO.Controls.Add(textBoxOut_MSO);
            groupBoxOut_MSO.Dock = DockStyle.Fill;
            groupBoxOut_MSO.Location = new Point(392, 108);
            groupBoxOut_MSO.Name = "groupBoxOut_MSO";
            groupBoxOut_MSO.Size = new Size(384, 301);
            groupBoxOut_MSO.TabIndex = 2;
            groupBoxOut_MSO.TabStop = false;
            groupBoxOut_MSO.Text = "Результат";
            //
            // textBoxOut_MSO
            //
            textBoxOut_MSO.Dock = DockStyle.Fill;
            textBoxOut_MSO.Multiline = true;
            textBoxOut_MSO.Name = "textBoxOut_MSO";
            textBoxOut_MSO.ReadOnly = true;
            textBoxOut_MSO.ScrollBars = ScrollBars.Vertical;
            textBoxOut_MSO.TabIndex = 0;
            toolTip_MSO.SetToolTip(textBoxOut_MSO, "Первые слова каждой строки");
            //
            // openFileDialogTask_MSO
            //
            openFileDialogTask_MSO.FileName = "InPutFileTask6V22.txt";
            openFileDialogTask_MSO.Filter = "Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*";
            openFileDialogTask_MSO.Title = "Открыть текстовый файл";
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
            groupBoxOut_MSO.ResumeLayout(false);
            groupBoxOut_MSO.PerformLayout();
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
        private TextBox textBoxIn_MSO;
        private GroupBox groupBoxOut_MSO;
        private TextBox textBoxOut_MSO;
        private OpenFileDialog openFileDialogTask_MSO;
        private ToolTip toolTip_MSO;
    }
}
