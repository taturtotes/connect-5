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
    public partial class Menu : Form
    {

        int row = 0;
        int col = 0;
        int time = 0;
        public Menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(check76.Checked == true)
            {
                row = 7;
                col = 6;
            }

            if (check97.Checked == true)
            {
                row = 9;
                col = 7;
            }

            if (check107.Checked == true)
            {
                row = 10;
                col = 7;
            }

            if(checkBox5.Checked == true)
            {
                time = 5 * 1000;
            }

            if (checkBox10.Checked == true)
            {
                time = 10 * 1000;
            }

            if (checkBox15.Checked == true)
            {
                time = 15 * 1000;
            }

            board frm = new board(row, col, time);
            frm.Show(this);
        }
    }
}
