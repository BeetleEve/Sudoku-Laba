using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Sudoku
{
    public class RoundedLabel : Label
    {
        private int _cornerRadius = 15; // Маленький радиус скругления

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            GraphicsPath path = GetRoundedRectanglePath(ClientRectangle, _cornerRadius);
            using (SolidBrush brush = new SolidBrush(this.BackColor))
            {
                e.Graphics.FillPath(brush, path);
            }
            TextRenderer.DrawText(e.Graphics, this.Text, this.Font, ClientRectangle, this.ForeColor, TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            this.Region = new Region(GetRoundedRectanglePath(ClientRectangle, _cornerRadius));
            this.Invalidate(); // Перерисовываем элемент
        }

        private GraphicsPath GetRoundedRectanglePath(Rectangle rect, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            int diameter = radius * 2;
            if (diameter > rect.Width) diameter = rect.Width;
            if (diameter > rect.Height) diameter = rect.Height;

            Rectangle arc = new Rectangle(rect.Location, new Size(diameter, diameter));

            // Верхний левый угол
            path.AddArc(arc, 180, 90);

            // Верхняя сторона
            arc.X = rect.Right - diameter;
            path.AddArc(arc, 270, 90);

            // Нижний правый угол
            arc.Y = rect.Bottom - diameter;
            path.AddArc(arc, 0, 90);

            // Нижняя сторона
            arc.X = rect.Left;
            path.AddArc(arc, 90, 90);

            path.CloseFigure();
            return path;
        }
    }
}