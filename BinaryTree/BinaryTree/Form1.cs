using System;
using System.Windows.Forms;
using System.Drawing;

namespace BinaryTree
{
    public partial class Form1 : Form
    {
        private const string menuText = "operations";
        private const string titleText = "testing front drawing";

        public Form1()
        {
            InitializeComponent();
            titlePanel.Paint += TitlePanel;
            menuTitlePanel.Paint += MenuTitlePanel;
            treePanel.Paint += TreePanel;
            tableLayout.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            menuLayoutPanel.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
        }

        private void TreePanel(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen pen = new Pen(Color.Red);
            Rectangle rect = new Rectangle(50, 50, 200, 200);
            g.DrawRectangle(pen, rect);
        }

        #region Drawn text

        private void MenuTitlePanel(object sender, PaintEventArgs e)
        {
            DrawingFunctions.DrawText(e, menuText, new Font("Tahoma", 12, FontStyle.Italic), new SolidBrush(Color.DodgerBlue), new Point(5, 20));
        }

        private void TitlePanel(object sender, PaintEventArgs e)
        {
            Font font = new Font("Tahoma", 22);
            SizeF stringSize = DrawingFunctions.GetStringSize(e, titleText, font);
            DrawingFunctions.DrawText(e, titleText, font, new SolidBrush(Color.DodgerBlue), new Point((titlePanel.Width / 2) - ((int)stringSize.Width / 2), 5));
        }

        #endregion

        private void ExitBtn_Click(object sender, System.EventArgs e)
        {
            Application.Exit();
        }
    }
}
