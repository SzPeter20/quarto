using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quarto
{
    public partial class Victoria_super_omnia : Form
    {
        static string player1;
        static string player2;
        static int turn;
        public Victoria_super_omnia()
        {
            InitializeComponent();
            
        }

        private void Victoria_super_omnia_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_replay_Click(object sender, EventArgs e)
        {
            
            MountainsofChina uj = new MountainsofChina();
            this.Hide();
            if (turn==3)
            {
                uj.warriors(player1, player2,2);
            }
            else if (turn == 3)
            {
                uj.warriors(player1, player2,1);
            }
            uj.Show();
            
            
        }

        private void btn_playerchange_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
        public void gyoztes(string player1name, string player2name,int turnloc)
        {
            player1 = player1name;
            player2 = player2name;
            turn = turnloc;
            mnyyeeeeh();

        }

        private void mnyyeeeeh()
        {
            if (turn == 3)
            {
                lbl_gyoztes.Text = player1 + " a győztes! Gratulálunk!";
                pctbx_left_crown.Visible = true;
            }
            else if (turn == 4)
            {
                lbl_gyoztes.Text = player2 + " a győztes! Gratulálunk!";
                pctbx_right_crown.Visible = true;
            }
        }
    }
}
