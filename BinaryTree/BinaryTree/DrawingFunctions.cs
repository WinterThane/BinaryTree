using System.Drawing;
using System.Windows.Forms;

namespace BinaryTree
{
    class DrawingFunctions
    {
        public static void DrawText(PaintEventArgs e, string text, Font font, Brush brush, PointF location)
        {
            Graphics g = e.Graphics;
            g.DrawString(text, font, brush, location);
        }

        public static SizeF GetStringSize(PaintEventArgs e, string text, Font font)
        {
            SizeF stringSize = new SizeF();
            stringSize = e.Graphics.MeasureString(text, font);
            return stringSize;
        }
    }
}
