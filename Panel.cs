using System.Drawing;
using System.Windows.Forms;

namespace CircleMovementApp
{
    public class DrawingPanel : Panel
    {
        private readonly Circle circle;

        public DrawingPanel(Circle circle)
        {
            this.circle = circle;
            this.BorderStyle = BorderStyle.FixedSingle;
            this.Paint += DrawingPanel_Paint;
        }

        private void DrawingPanel_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            g.FillEllipse(Brushes.Blue, circle.X - circle.Radius, circle.Y - circle.Radius, circle.Radius * 2, circle.Radius * 2);
        }

        public void Redraw()
        {
            this.Invalidate();
        }
    }
}