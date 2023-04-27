using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


//Tells which player is which
public struct playerInfo
{
    public int playerID;
};

namespace connect5
{

    public partial class board : Form
    {

        //THIS MAKES THE BOARD NOT FLASH
        #region .. Double Buffered function ..
        public static void SetDoubleBuffered(System.Windows.Forms.Control c)
        {
            if (System.Windows.Forms.SystemInformation.TerminalServerSession)
                return;
            System.Reflection.PropertyInfo aProp = typeof(System.Windows.Forms.Control).GetProperty("DoubleBuffered", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
            aProp.SetValue(c, true, null);
        }

        #endregion


        #region .. code for Flucuring ..

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;
                return cp;
            }
        }

        #endregion





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

        //board.txt path
        public static string boardFile = System.IO.Path.GetFullPath(Directory.GetCurrentDirectory() + @"\board.txt");


        //Properties of each piece
        struct panelProp
        {
            public int row;
            public int col;
            public int color;
        }

        public board(int row, int col, int time)
        {
            InitializeComponent();


            //Applies selections made in menu screen
            matrix = new int[row, col];
            tick = time;
            lastrow = row;
            lastcol = col;
            SetDoubleBuffered(board1);

            if (col == 10)
            {
                board1.ColumnCount = 10;
                board1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 90));
                board1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 90));
                board1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 90));
                board1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 90));

                TableLayoutColumnStyleCollection styles = this.board1.ColumnStyles;

                foreach(ColumnStyle style in styles)
                {
                    style.SizeType= SizeType.Absolute;
                    style.Width = 70;
                }
            }

            if(col == 9)
            {
                board1.ColumnCount = 9;
                board1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100));
                board1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100));
                board1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100));

                TableLayoutColumnStyleCollection styles = this.board1.ColumnStyles;

                foreach (ColumnStyle style in styles)
                {
                    style.SizeType = SizeType.Absolute;
                    style.Width = 70;
                }
            }

            if(col == 7)
            {
                board1.ColumnCount= 7;
                board1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100));

                TableLayoutColumnStyleCollection styles = this.board1.ColumnStyles;

                foreach (ColumnStyle style in styles)
                {
                    style.SizeType = SizeType.Absolute;
                    style.Width = 70;
                }

            }

            if (row == 7)
            {
                board1.RowCount = 7;
                board1.RowStyles.Add(new RowStyle(SizeType.Absolute, 100));

                TableLayoutRowStyleCollection styles = this.board1.RowStyles;

                foreach (RowStyle style in styles)
                {
                    style.SizeType = SizeType.Absolute;
                    style.Height = 70;
                }

            }

        }

        //Gets the point where human player clicks the board
        void getIndex(TableLayoutPanel board, Point point)
        {

            //Get the width and Height of board
            int w = board.Width;
            int h = board.Height;
            int[] widths = board.GetColumnWidths();

            int i;

            //Get exact width clicked
            for (i = widths.Length - 1; i >= 0 && point.X < w; i--)
            {
                w -= widths[i];
            }
            int col = i + 1;

            int[] heights = board.GetRowHeights();

            //Get exact height clicked
            for (i = heights.Length - 1; i >= 0 && point.Y < h; i--)
            {
                h -= heights[i];
            }
            
            int row = i + 1;

            //Set row inserted and column inserted
            rowInsert = row;
            colInsert = col;

        }

        //MAKE PIECES and drops piece in the last available slot
        Button makePanel(int color, int col, int row)
        {

            Panel piece = new Panel();
            Button b = new Button();
            GraphicsPath p = new GraphicsPath();
            p.AddEllipse(1, 1, 60 - 4, 60 - 4);
            b.Region = new Region(p);
            b.Anchor = AnchorStyles.Top| AnchorStyles.Bottom | AnchorStyles.Right | AnchorStyles.Left;

            SetDoubleBuffered(b);
            bool found = false;
            if (color == 1)
            {

                b.BackColor = Color.Red;
                

            }
            else
            {
                b.BackColor = Color.Yellow;
            }

            b.Visible = false;


            //Finds last available space in column
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

            //Adds piece to board
            board1.Controls.Add(b, col, row);


            //Updates the log
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

            return b;
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

            //Writes to board.txt
            using (StreamWriter writetext = new StreamWriter(boardFile))
            {
                writetext.WriteLine(outBoard);
            }

        }


        //Tells if human
        private void HumanButtonRed_Click(object sender, EventArgs e)
        {
            human1 = true;
        }

        //Tells if human
        private void HumanButton2_Click(object sender, EventArgs e)
        {
            human2 = true;
        }


        //Starts game
        private void startButton_Click(object sender, EventArgs e)
        {

            turnPanel.BackColor = Color.Red;
            File.WriteAllText("log.txt", string.Empty);

            //Starts timer
            timer1.Interval = tick;
            timer1.Start();

            //Starts exe files
            if (computer1 == true)
            {
                //Does the first move
                Process.Start(comp1File);
                //Gets move from move.txt
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

            Button piece = makePanel(turn, colInsert, rowInsert);
            timer1.Stop();
            piece.Visible = true;


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
                //Opens winner form and passes in player / stops timer
                timer1.Stop();
                timer1.Enabled = false;
                timer1.Interval = 1000000000;
                Winner frm = new Winner(Player);
                frm.Show(this);
   
            }
            else if(isTie() == true)
            {
                timer1.Stop();
                timer1.Enabled = false;
                timer1.Interval = 1000000000;
                string message = "Game Over";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                string caption = "Tie!";
                DialogResult result = MessageBox.Show(message, caption, buttons);
                ResetButton.PerformClick();

            }
            else if (human1 == false && human2 == false)
            {

                if (count % 2 == 0)
                {
                    //Computer 1 turn
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
                    //Computer 2 turn
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
                getIndex(board1, board1.PointToClient(Cursor.Position));
            }
            outputBoard();

            //Adds piece to board and stops timer
            Button piece = makePanel(turn, colInsert, rowInsert);
            timer1.Stop();
            piece.Visible = true;


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

           
            if (IsWinner(colInsert, rowInsert, Player) == true)
            {
                //Opens winner form and passes in player / stops timer
                timer1.Stop();
                timer1.Enabled = false;
                timer1.Interval = 1000000000;
                Winner frm = new Winner(Player);
                frm.Show(this);
                
            }
            else if (isTie() == true)
            {
                timer1.Stop();
                timer1.Enabled = false;
                timer1.Interval = 1000000000;
                string message = "Game Over";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                string caption = "Tie!";
                DialogResult result = MessageBox.Show(message, caption, buttons);
                ResetButton.PerformClick();

            }
            else if (computer1 == true && count % 2 == 0)
            {
                //Computer 1 turn
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
                //Computer 2 turn
                Process.Start(comp2File);
                String input = File.ReadAllText("move.txt");
                char c = input[0];
                char r = input[2];
                colInsert = Int32.Parse(c.ToString());
                rowInsert = Int32.Parse(r.ToString());
                computerClick();
            }
            //Restarts timer
            timer1.Start();

        }

        //Resets board timer
        public void ResetButton_Click(object sender, EventArgs e)
        {
            timer1.Enabled= false;
            board b = new board(lastrow, lastcol, tick);
            b.Show();
            this.Dispose(false);

        }


        bool isTie()
        {
            int count0 = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i,j] == 0)
                    {
                        count0++;
                    }
                }
            }

            if(count0 > 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        //Determines if there is a winner
        bool IsWinner(int colInsert, int rowInsert, playerInfo Player)
        {
            // Checks horizontal wins
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 3; col++)
                {
                    if (matrix[row, col] == Player.playerID && matrix[row, col + 1] == Player.playerID && matrix[row, col + 2] == Player.playerID && matrix[row, col + 3] == Player.playerID)
                    {
                        //Five pieces found
                        return true;
                    }
                }
            }

            // Checks vertical wins
            for (int row = 0; row < matrix.GetLength(0) - 3; row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (matrix[row, col] == Player.playerID && matrix[row + 1, col] == Player.playerID && matrix[row + 2, col] == Player.playerID && matrix[row + 3, col] == Player.playerID)
                    {
                        //Five pieces found
                        return true;
                    }
                }
            }

            // Checks downward diagonal
            for (int row = 0; row < matrix.GetLength(0) - 3; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 3; col++)
                {
                    if (matrix[row, col] == Player.playerID && matrix[row + 1, col + 1] == Player.playerID && matrix[row + 2, col + 2] == Player.playerID && matrix[row + 3, col + 3] == Player.playerID)
                    {
                        //Five pieces found
                        return true;
                    }
                }
            }

            // Checks upward diagonal
            for (int row = 0; row < matrix.GetLength(0) - 3; row++)
            {
                for (int col = matrix.GetLength(1) - 1; col >= 3; col--)
                {
                    if (matrix[row, col] == Player.playerID && matrix[row + 1, col - 1] == Player.playerID && matrix[row + 2, col - 2] == Player.playerID && matrix[row + 3, col - 3] == Player.playerID)
                    {
                        //Five pieces found
                        return true;
                    }
                }
            }

            //No winner
            return false;
        }


        //Lets user select computer file
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

        //Lets user select computer file
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

        //Opens log
        private void logButton_Click(object sender, EventArgs e)
        {
            Process.Start("log.txt");
        }

        //Shows that you lost because of running out of time
        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            string message = "You ran out of time!";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            string caption = "You lose";
            DialogResult result = MessageBox.Show(message, caption, buttons);
            ResetButton.PerformClick();
        }

        //Goes back to the menu
        private void menuButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
