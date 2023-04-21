using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using connect5;
using static System.Net.Mime.MediaTypeNames;

namespace computer_AI
{
    //This will be the exe file
    internal class Program
    {
        //Get Board from file
        public static int[,] getBoard()
        {
            string[] fileLines = File.ReadAllLines("board.txt");
            int[,] board = new int[fileLines.Length-1, fileLines[0].Split(',').Length-1];
            for (int i = 0; i < fileLines.Length-1; ++i)
            {
                string line = fileLines[i];
                for (int j = 0; j < board.GetLength(1); ++j)
                {
                    string[] split = line.Split(',');
                    board[i, j] = Convert.ToInt32(split[j]);
                }
            }
            return board;
        }


        //Put move into file
        public static void putMove(int col, int row)
        {
            using (StreamWriter writetext = new StreamWriter("move.txt"))
            {
                writetext.WriteLine(col + " " + row);
            }
        }

        static void Main(string[] args)
        {
            int[,] board = getBoard();

            putMove(7, 6);

        }
    }
}
