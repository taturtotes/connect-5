using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
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
        int rowCount = 7;
        int colCount = 6;
        int[,] matrix = new int[7, 6];

        //Properties of each piece
        struct panelProp
        {
           public int row;
           public int col;
           public int color;
        }

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

        //MAKE PIECES
        void makePanel(int color, int col, int row)
        {
            
            Panel piece = new Panel();
            if (color == 1)
            {

                piece.BackColor = Color.Red;

            }
            else
            {
                piece.BackColor = Color.Yellow;
            }

            piece.Visible= false;
            board1.Controls.Add(piece, col, row);
            piece.Visible= true;
        }


        //Outputs board to "board.txt" as string
        void outputBoard()
        {
            panelProp prop = new panelProp();

            string outBoard = "";
            foreach (Control ctrl in board1.Controls)
            {

                prop.row = board1.GetRow(ctrl);
                prop.col = board1.GetColumn(ctrl);
                if (ctrl.BackColor == Color.Red)
                {
                    //Red
                    prop.color = 1;
                }
                else
                {
                    //Yellow
                    prop.color = 2;
                }

                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        if (i == prop.row && j == prop.col)
                        {
                            //Add piece to matrix (0 is blank in this)
                            matrix[i, j] = prop.color;
                        }
                    }
                }

            }

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] == 1)
                    {
                        //Red
                        outBoard += "1";
                    }
                    else if (matrix[i,j] == 2)
                    {
                        //Yellow
                        outBoard += "0";
                    }
                    else
                    {
                        //Blank
                        outBoard += ".";
                    }
                }
            }

            using (StreamWriter writetext = new StreamWriter("board.txt"))
            {
                writetext.WriteLine(outBoard);
            }

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
            var cellPos = GetRowColIndex(board1,board1.PointToClient(Cursor.Position));
            
            //Counting number of turns
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
                //If odd turn then red
                turnPanel.BackColor = Color.Red;
            }
            else
            {
                //If even turn then yellow
                turnPanel.BackColor = Color.Yellow;
            }


            outputBoard();


        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            board1.Controls.Clear();
            turnPanel.BackColor = SystemColors.Control;
        }
        bool IsValid(int colInstert)
        {
            int countCol = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] != 0 && j == colInstert)
                    {
                        countCol++;
                    }
                }
            }

            if(countCol == 7)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
