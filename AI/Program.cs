using System;
using System.ComponentModel;
using System.Numerics;
using connect5;

namespace AI
{
    internal class Program
    {

        public static int[,] getBoard()
        {
            string fileName = System.IO.Path.GetFullPath(Directory.GetCurrentDirectory() + @"\board.txt");
            //string path = Path.Combine(Environment.CurrentDirectory, @"connect5\bin\Debug\", fileName);
            String input = File.ReadAllText(fileName);

            int i = 0, j = 0;
            int[,] board = new int[10, 10];
            foreach (var row in input.Split('\n'))
            {
                j = 0;
                foreach (var col in row.Trim().Split(' '))
                {
                    board[i, j] = int.Parse(col.Trim());
                    j++;
                }
                i++;
            }


            return board;
        }

        static void Main(string[] args)
        {
            int[,] board = getBoard();
        }
    }
}
