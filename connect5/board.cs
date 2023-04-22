using System;
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

        //Holds board
        int[,] matrix;

        //Contains name of exe file
        string comp1File;
        string comp2File;


        int tick = 0;
        public static int lastcol = 0;
        public static int lastrow = 0;

        //Properties of each piece
        public static string boardFile = System.IO.Path.GetFullPath(Directory.GetCurrentDirectory() + @"\board.txt");
        public static string newBoardFile = boardFile;

        struct panelProp
        {
            public int row;
            public int col;
            public int color;
        }

        public board(int row, int col, int time)
        {
            InitializeComponent();

            matrix = new int[row, col];
            tick = time;
            lastrow = row;
            lastcol = col;

            if(row == 10)
            {
                board1.RowCount = 10;
                board1.RowStyles.Add(new RowStyle(SizeType.Percent, 10));
                board1.RowStyles.Add(new RowStyle(SizeType.Percent, 10));

                TableLayoutRowStyleCollection styles = this.board1.RowStyles;

                foreach(RowStyle style in styles)
                {
                    style.SizeType= SizeType.Percent;
                    style.Height = 10;
                }
            }

            if(row == 9)
            {
                board1.RowCount = 9;
                board1.RowStyles.Add(new RowStyle(SizeType.Percent, 11));

                TableLayoutRowStyleCollection styles = this.board1.RowStyles;

                foreach (RowStyle style in styles)
                {
                    style.SizeType = SizeType.Percent;
                    style.Height = 11;
                }
            }

            if(col == 7)
            {
                board1.ColumnCount= 7;
                board1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 17));

                TableLayoutColumnStyleCollection styles = this.board1.ColumnStyles;

                foreach (ColumnStyle style in styles)
                {
                    style.SizeType = SizeType.Percent;
                    style.Width = 17;
                }

            }

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
                    if (j == col && row == (lastrow-1))
                    {
                        row = (lastrow - 1);
                        found = true;
                    }
                    else if (i != (lastrow - 1) && j == col && matrix[i + 1, j] != 0)
                    {
                        row = i;
                        found = true;
                    }
                    else
                    {
                        if (j == col && i == (lastrow - 1))
                        {
                            row = i;
                            found = true;
                        }

                    }


                }

            }

            board1.Controls.Add(piece, col, row);

            using (StreamWriter writetext = File.AppendText("log.txt"))
            {
                if(turn == 1)
                {
                    writetext.WriteLine("Red Player placed piece in row: " + row + " col: " + col);
                }
                else if(turn == 2)
                {
                    writetext.WriteLine("Yellow Player placed piece in row: " + row + " col: " + col);
                }
                
            }

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
                        outBoard += "1,";
                    }
                    else if (matrix[i, j] == 2)
                    {
                        //Yellow
                        outBoard += "2,";
                    }
                    else
                    {
                        //Blank
                        outBoard += "0,";
                    }
                }
                outBoard += "\n";
            }

            //string fileName = System.IO.Path.GetFullPath(Directory.GetCurrentDirectory() + @"\board.txt");


            using (StreamWriter writetext = new StreamWriter(boardFile))
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
            File.WriteAllText("log.txt", string.Empty);

            timer1.Interval = tick;
            timer1.Start();

            //Starts exe files
            if (computer1 == true)
            {
                //Does the first move
                Process.Start(comp1File);
                String input = File.ReadAllText("move.txt");
                char c = input[0];
                char r = input[2];
                colInsert = Int32.Parse(c.ToString());
                rowInsert = Int32.Parse(r.ToString());
                computerClick();
            }

            

        }


        //Clicks for the computer
        public void computerClick()
        {
            timer1.Start();

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
            timer1.Stop();
            piece.Visible = true;


            //Outboard
            //If valid make piece visible

            //Delete if not valid

            if (count % 2 == 1)
            {
                //If odd turn then yellow
                turnPanel.BackColor = Color.Yellow;
            }
            else
            {
                //If even turn then red
                turnPanel.BackColor = Color.Red;
            }


            outputBoard();

            //Add logic to determine if it is computer or human turn
            if (IsWinner(colInsert, rowInsert, Player) == true)
            {
                //Opens winner form and passes in player
                Winner frm = new Winner(Player);
                frm.Show(this);
            }
            else if (human1 == false && human2 == false)
            {

                if (count % 2 == 0)
                {
                    Process.Start(comp1File);
                    String input = File.ReadAllText("move.txt");
                    char c = input[0];
                    char r = input[2];
                    colInsert = Int32.Parse(c.ToString());
                    rowInsert = Int32.Parse(r.ToString());
                    computerClick();
                }
                else
                {
                    Process.Start(comp2File);
                    String input = File.ReadAllText("move.txt");
                    char c = input[0];
                    char r = input[2];
                    colInsert = Int32.Parse(c.ToString());
                    rowInsert = Int32.Parse(r.ToString());
                    computerClick();
                }

                

            }

        }


        private void board1_Click(object sender, EventArgs e)
        {

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

            if ((human1 == true && turn == 1) || (human2 == true && turn == 2))
            {
                var cellPos = GetRowColIndex(board1, board1.PointToClient(Cursor.Position));
            }
            outputBoard();


            Panel piece = makePanel(turn, colInsert, rowInsert);
            timer1.Stop();
            piece.Visible = true;


            //Outboard
            //If valid make piece visible

            //Delete if not valid

            if (count % 2 == 1)
            {
                //If odd turn then red
                turnPanel.BackColor = Color.Yellow;
            }
            else
            {
                //If even turn then yellow
                turnPanel.BackColor = Color.Red;
            }


            outputBoard();

            //Add logic to determine if it is computer or human turn
            if (IsWinner(colInsert, rowInsert, Player) == true)
            {
                //Opens winner form and passes in player
                Winner frm = new Winner(Player);
                frm.Show(this);
            }
            else if (computer1 == true && count % 2 == 0)
            {
                Process.Start(comp1File);
                String input = File.ReadAllText("move.txt");
                char c = input[0];
                char r = input[2];
                colInsert = Int32.Parse(c.ToString());
                rowInsert = Int32.Parse(r.ToString());
                computerClick();
            }
            else if (computer2 == true && count % 2 == 1)
            {
                Process.Start(comp2File);
                String input = File.ReadAllText("move.txt");
                char c = input[0];
                char r = input[2];
                colInsert = Int32.Parse(c.ToString());
                rowInsert = Int32.Parse(r.ToString());
                computerClick();
            }
            timer1.Start();

        }

        public void ResetButton_Click(object sender, EventArgs e)
        {
            timer1.Enabled= false;
            board b = new board(lastrow, lastcol, tick);
            b.Show();
            this.Dispose(false);

        }
       
        bool IsWinner(int colInsert, int rowInsert, playerInfo Player)
        {
            // Checks horizontal wins
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 4; col++)
                {
                    if (matrix[row, col] == Player.playerID
                        && matrix[row, col + 1] == Player.playerID
                        && matrix[row, col + 2] == Player.playerID
                        && matrix[row, col + 3] == Player.playerID
                        && matrix[row, col + 4] == Player.playerID)
                    {
                        return true;
                    }
                }
            }

            // Checks vertical wins
            for (int row = 0; row < matrix.GetLength(0) - 4; row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (matrix[row, col] == Player.playerID
                        && matrix[row + 1, col] == Player.playerID
                        && matrix[row + 2, col] == Player.playerID
                        && matrix[row + 3, col] == Player.playerID
                        && matrix[row + 4, col] == Player.playerID)
                    {
                        return true;
                    }
                }
            }

            // Checks downward diagonal
            for (int row = 0; row < matrix.GetLength(0) - 4; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 4; col++)
                {
                    if (matrix[row, col] == Player.playerID
                        && matrix[row + 1, col + 1] == Player.playerID
                        && matrix[row + 2, col + 2] == Player.playerID
                        && matrix[row + 3, col + 3] == Player.playerID
                        && matrix[row + 4, col + 4] == Player.playerID)
                    {
                        return true;
                    }
                }
            }

            // Checks upward diagonal
            for (int row = 0; row < matrix.GetLength(0) - 4; row++)
            {
                for (int col = matrix.GetLength(1) - 1; col >= 4; col--)
                {
                    if (matrix[row, col] == Player.playerID
                        && matrix[row + 1, col - 1] == Player.playerID
                        && matrix[row + 2, col - 2] == Player.playerID
                        && matrix[row + 3, col - 3] == Player.playerID
                        && matrix[row + 4, col - 4] == Player.playerID)
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

        private void logButton_Click(object sender, EventArgs e)
        {
            Process.Start("log.txt");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            string message = "You ran out of time!";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            string caption = "You lose";
            DialogResult result = MessageBox.Show(message, caption, buttons);
            ResetButton.PerformClick();
        }
    }
}
