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
            //tableLayout.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            //menuLayoutPanel.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
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

        private void randomTreeBtn_Click(object sender, EventArgs e)
        {
            Tree<int> tree = new Tree<int>();

            Random rand = new Random(DateTime.Now.Millisecond);
            string order = "";

            for (int i = 0; i < 5; i++)
            {
                int randInt = rand.Next(1, 500);
                tree.Insert(randInt);
                order += randInt + " ";
            }

            consoleTB.Text += "Root: " + tree.Root.Element + Environment.NewLine;
            consoleTB.Text += "Min element: " + tree.FindMin() + Environment.NewLine;
            consoleTB.Text += "Max element: " + tree.FindMax() + Environment.NewLine;
            consoleTB.Text += "Tree: " + tree;

            //string consoleText = consoleTB.Text;
        }
    }
}
