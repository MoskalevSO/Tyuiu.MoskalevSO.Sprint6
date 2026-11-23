namespace Tyuiu.MoskalevSO.Sprint6.Task5.V7
{
    // Столбчатая диаграмма значений, рисуется средствами GDI+
    public class BarChartControl_MSO : Control
    {
        private double[] values_ = Array.Empty<double>();

        public BarChartControl_MSO()
        {
            DoubleBuffered = true;
            ResizeRedraw = true;
            BackColor = Color.White;
        }

        public void SetData(double[] values)
        {
            values_ = values;
            Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;

            Rectangle area = new Rectangle(10, 20, Width - 20, Height - 45);
            if (values_.Length == 0 || area.Width < 20 || area.Height < 20)
            {
                TextRenderer.DrawText(g, "Нет данных для диаграммы", Font, ClientRectangle, Color.Gray,
                    TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
                return;
            }

            double max = Math.Max(values_.Max(), 0);
            double min = Math.Min(values_.Min(), 0);
            if (max - min < 1e-9) { max = min + 1; }

            float zeroY = area.Bottom - (float)((0 - min) / (max - min) * area.Height);
            float slot = (float)area.Width / values_.Length;
            float barWidth = Math.Max(slot * 0.6f, 2);

            using Brush positive = new SolidBrush(Color.SteelBlue);
            using Brush negative = new SolidBrush(Color.IndianRed);
            using Pen axisPen = new Pen(Color.Gray);

            for (int i = 0; i < values_.Length; i++)
            {
                float valueY = area.Bottom - (float)((values_[i] - min) / (max - min) * area.Height);
                float x = area.Left + i * slot + (slot - barWidth) / 2;
                float top = Math.Min(valueY, zeroY);
                float height = Math.Max(Math.Abs(zeroY - valueY), 1);

                g.FillRectangle(values_[i] >= 0 ? positive : negative, x, top, barWidth, height);

                string label = values_[i].ToString();
                Size size = TextRenderer.MeasureText(label, Font);
                float labelY = values_[i] >= 0 ? top - size.Height : top + height;
                TextRenderer.DrawText(g, label, Font, new Point((int)(x + barWidth / 2 - size.Width / 2), (int)labelY), Color.Black);
            }

            g.DrawLine(axisPen, area.Left, zeroY, area.Right, zeroY);
        }
    }
}
