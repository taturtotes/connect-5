using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace connect5
{

    public partial class board : Form
    {
        bool human1;
        bool human2;
        int rowInsert;
        int colInsert;
        int count;
        int turn;
        public board()
        {
            InitializeComponent();
        }

        Point? GetRowColIndex(TableLayoutPanel tlp, Point point)
        {
            if (point.X > tlp.Width || point.Y > tlp.Height)
                return null;

            int w = tlp.Width;
            int h = tlp.Height;
            int[] widths = tlp.GetColumnWidths();

            int i;
            for (i = widths.Length - 1; i >= 0 && point.X < w; i--)
                w -= widths[i];
            int col = i + 1;

            int[] heights = tlp.GetRowHeights();
            for (i = heights.Length - 1; i >= 0 && point.Y < h; i--)
                h -= heights[i];

            int row = i + 1;

            rowInsert = row;
            colInsert = col;

            return new Point(col, row);
        }

        void makePanel(int color, int col, int row)
        {
            
            Panel piece = new Panel();
            if (color == 1)
            {
                //piece = redPiece;
                //piece.Visible = true;

                piece.BackColor = Color.Red;

            }
            else
            {
                piece.BackColor = Color.Yellow;
            }


            board1.Controls.Add(piece, col, row);

        }

        private void HumanButtonRed_Click(object sender, EventArgs e)
        {
            human1= true;
        }

        private void HumanButton2_Click(object sender, EventArgs e)
        {
            human2= true;
        }

        private void startButton_Click(object sender, EventArgs e)
        {

            turnPanel.BackColor = Color.Red;

        }

        private void board1_Click(object sender, EventArgs e)
        {
            var cellPos = GetRowColIndex(
            board1,
            board1.PointToClient(Cursor.Position));
            count++;

            if(count % 2 == 1)
            {
                //Red
                turn = 1;
            }
            else
            {
                //Yellow
                turn = 0;
            }
            
           makePanel(turn, colInsert, rowInsert);

            if(count % 2 == 1)
            {
                turnPanel.BackColor = Color.Red;
            }
            else
            {
                turnPanel.BackColor = Color.Yellow;
            }

        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            board1.Controls.Clear();
            turnPanel.BackColor = SystemColors.Control;
        }
    }
}
