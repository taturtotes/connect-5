﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

public struct playerInfo
{
    public int playerID;
};

namespace connect5
{

    public partial class board : Form
    {
        //Tells type of player
        bool human1;
        bool human2;
        bool computer1;
        bool computer2;

        //Row piece was inserted in
        int rowInsert;
        //Column piece was inserted in
        int colInsert;

        //Counts number of turns
        int count;

        //Tells whose turn it is
        int turn;

        int rowCount = 7;
        int colCount = 6;

        //Holds board
        int[,] matrix = new int[7, 6];

        //Contains name of exe file
        string comp1File;
        string comp2File;

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

        //MAKE PIECES and drops piece in the last available slot
        Panel makePanel(int color, int col, int row)
        {

            Panel piece = new Panel();
            bool found = false;
            if (color == 1)
            {

                piece.BackColor = Color.Red;

            }
            else
            {
                piece.BackColor = Color.Yellow;
            }

            piece.Visible = false;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                if (found == true)
                {
                    break;
                }
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (j == col && row == 6)
                    {
                        row = 6;
                        found = true;
                    }
                    else if (i != 6 && j == col && matrix[i + 1, j] != 0)
                    {
                        row = i;
                        found = true;
                    }
                    else
                    {
                        if (j == col && i == 6)
                        {
                            row = i;
                            found = true;
                        }

                    }


                }

            }


            board1.Controls.Add(piece, col, row);

            return piece;
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
                        outBoard += "1 ";
                    }
                    else if (matrix[i, j] == 2)
                    {
                        //Yellow
                        outBoard += "2 ";
                    }
                    else
                    {
                        //Blank
                        outBoard += "0 ";
                    }
                }
                outBoard += "\n";
            }

            using (StreamWriter writetext = new StreamWriter("board.txt"))
            {
                writetext.WriteLine(outBoard);
            }

        }


        private void HumanButtonRed_Click(object sender, EventArgs e)
        {
            human1 = true;
        }

        private void HumanButton2_Click(object sender, EventArgs e)
        {
            human2 = true;
        }

        private void startButton_Click(object sender, EventArgs e)
        {

            turnPanel.BackColor = Color.Red;

            //Starts exe files
            if (computer1 == true)
            {
                Process.Start(comp1File);
            }

            if (computer2 == true)
            {
                Process.Start(comp1File);
            }


        }

        private void board1_Click(object sender, EventArgs e)
        {
            var cellPos = GetRowColIndex(board1, board1.PointToClient(Cursor.Position));
            playerInfo Player = new playerInfo();

            //Counting number of turns
            count++;

            if (count % 2 == 1)
            {
                //Red
                turn = 1;
                Player.playerID = 1;
            }
            else
            {
                //Yellow
                turn = 2;
                Player.playerID = 2;
            }

            outputBoard();

            Panel piece = makePanel(turn, colInsert, rowInsert);
            piece.Visible = true;


            //Outboard
            //If valid make piece visible

            //Delete if not valid

            if (count % 2 == 1)
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

            IsWinner(colInsert, rowInsert, Player);

            //if (IsWinner(colInsert, rowInsert, Player))
            //{
            //    //Show game over screen & call reset
            //}


        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            foreach (Control ctrl in board1.Controls)
            {
                ctrl.Visible = false;
            }

            board1.Controls.Clear();
            turnPanel.BackColor = SystemColors.Control;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = 0;
                }
            }

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

            if (countCol == 7)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        bool IsWinner(int colInsert, int rowInsert, playerInfo Player)
        {
            int currPlayer = Player.playerID;

            for (int i = 6; i >= 1; --i)
            {
                for (int j = 5; j >= 1; --j)
                {
                    if (matrix[i, j] == currPlayer && matrix[i - 1, j - 1] == currPlayer && matrix[i - 2, j - 2] == currPlayer &&
                        matrix[i - 3, j - 3] == currPlayer && matrix[i - 4, j - 4] == currPlayer)
                    {
                        return true;
                    }
                    if (matrix[i, j] == currPlayer && matrix[i, j - 1] == currPlayer && matrix[i, j - 2] == currPlayer &&
                        matrix[i, j - 3] == currPlayer && matrix[i, j - 4] == currPlayer)
                    {
                        return true;
                    }
                    if (matrix[i, j] == currPlayer && matrix[i - 1, j] == currPlayer && matrix[i - 2, j] == currPlayer &&
                       matrix[i - 3, j] == currPlayer && matrix[i - 4, j] == currPlayer)
                    {
                        return true;
                    }
                    if (matrix[i, j] == currPlayer && matrix[i - 1, j + 1] == currPlayer && matrix[i - 2, j + 2] == currPlayer &&
                       matrix[i - 3, j + 3] == currPlayer && matrix[i - 4, j + 4] == currPlayer)
                    {
                        return true;
                    }
                    if (matrix[i, j] == currPlayer && matrix[i, j + 1] != 0 && matrix[i, j + 2] == currPlayer &&
                       matrix[i, j + 3] == currPlayer && matrix[i, j + 4] == currPlayer)
                    {
                        return true;
                    }
                }
            }
            return false;
        }



        private void ComputerButton1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            DialogResult result = openFileDialog1.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
            {
                comp1File = openFileDialog1.FileName;
                computer1 = true;

            }
        }

        private void ComputerButton2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            DialogResult result = openFileDialog1.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
            {
                comp2File = openFileDialog1.FileName;
                computer2 = true;

            }
        }
    }
}
