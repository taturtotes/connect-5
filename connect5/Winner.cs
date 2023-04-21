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
    public partial class Winner : Form
    {
        public Winner(playerInfo Player)
        {
            InitializeComponent();

            if(Player.playerID == 1)
            {
                winnerPlayer.BackColor = Color.Red;
            }
            else
            {
                winnerPlayer.BackColor = Color.Yellow;
            }
        }

        private void againButton_Click(object sender, EventArgs e)
        {
            //Closes winner form and presses reset on other screen
            var frm = (board)this.Owner;
            if (frm != null)
                frm.ResetButton.PerformClick();
            this.Close();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //Exits whole program
            Environment.Exit(0);
        }
    }
}
