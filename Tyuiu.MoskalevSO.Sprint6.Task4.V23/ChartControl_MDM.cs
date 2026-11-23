using System.Drawing.Drawing2D;

namespace Tyuiu.MoskalevSO.Sprint6.Task4.V23
{
    // График функции y = F(x), рисуется средствами GDI+
    public class ChartControl_MSO : Control
    {
        private double[] xs_ = Array.Empty<double>();
        private double[] ys_ = Array.Empty<double>();

        public ChartControl_MSO()
        {
            DoubleBuffered = true;
            ResizeRedraw = true;
            BackColor = Color.White;
        }

        public void SetData(double[] xs, double[] ys)
        {
            xs_ = xs;
            ys_ = ys;
            Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            Rectangle area = new Rectangle(45, 10, Width - 60, Height - 40);
            if (xs_.Length < 2 || area.Width < 20 || area.Height < 20)
            {
                TextRenderer.DrawText(g, "Нажмите «Выполнить», чтобы построить график", Font, ClientRectangle, Color.Gray,
                    TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
                return;
            }

            double minX = xs_.Min(), maxX = xs_.Max();
            double minY = Math.Min(ys_.Min(), 0), maxY = Math.Max(ys_.Max(), 0);
            if (maxY - minY < 1e-9) { maxY = minY + 1; }

            PointF Map(double x, double y) => new PointF(
                area.Left + (float)((x - minX) / (maxX - minX) * area.Width),
                area.Bottom - (float)((y - minY) / (maxY - minY) * area.Height));

            using Pen axisPen = new Pen(Color.Gray);
            using Pen linePen = new Pen(Color.SteelBlue, 2);
            using Brush pointBrush = new SolidBrush(Color.SteelBlue);

            // Оси
            PointF zeroLeft = Map(minX, 0), zeroRight = Map(maxX, 0);
            g.DrawLine(axisPen, zeroLeft, zeroRight);
            if (minX <= 0 && maxX >= 0)
            {
                g.DrawLine(axisPen, Map(0, minY), Map(0, maxY));
            }

            // Подписи
            for (int i = 0; i < xs_.Length; i++)
            {
                PointF p = Map(xs_[i], minY);
                TextRenderer.DrawText(g, xs_[i].ToString(), Font, new Point((int)p.X - 10, area.Bottom + 4), Color.Black);
            }
            TextRenderer.DrawText(g, maxY.ToString("0.##"), Font, new Point(2, area.Top - 6), Color.Black);
            TextRenderer.DrawText(g, minY.ToString("0.##"), Font, new Point(2, area.Bottom - 8), Color.Black);

            // Линия функции
            PointF[] points = xs_.Select((x, i) => Map(x, ys_[i])).ToArray();
            g.DrawLines(linePen, points);
            foreach (PointF p in points)
            {
                g.FillEllipse(pointBrush, p.X - 3, p.Y - 3, 6, 6);
            }
        }
    }
}
