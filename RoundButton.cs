using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sudoku
{
    public class RoundButton : Button
    {
        // отвечает за то на сколько скруглены будут углы
        private int _cornerRadius = 15; 

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            GraphicsPath path = GetRoundedRectanglePath(ClientRectangle, _cornerRadius);
            this.Region = new Region(path);
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
