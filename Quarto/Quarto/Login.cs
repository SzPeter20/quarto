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
    public partial class Login : Form
    {
        static int start1 = 0;
        static int start2 = 0;
        static string name1 = "";
        static string name2 = "";
        static int whostarts = 1;
        public Login()
        {
            InitializeComponent();
        }

        private void lbl_war_Click(object sender, EventArgs e)
        {
            MountainsofChina uj = new MountainsofChina();
            if (txtbx_fighter_1.TextLength==0)
            {
                name1 = "Sun Tzu";
            }
            else
            {
                name1 = txtbx_fighter_1.Text;
            }
            if (txtbx_fighter_2.TextLength == 0)
            {
                name2 = "Erwin Rommel";
            }
            else
            {
                name2 = txtbx_fighter_2.Text;
            }

            this.Hide();
            uj.warriors(name1, name2,whostarts);
            uj.Show();

        }

        private void txtbx_fighter_1_Click(object sender, EventArgs e)
        {
            if (start1==0)
            {
                txtbx_fighter_1.Text = "";
                start1 = 1;
            }
            
        }

        private void txtbx_fighter_2_Click(object sender, EventArgs e)
        {
            if (start2 == 0)
            {
                txtbx_fighter_2.Text = "";
                start2 = 1;
            }
            
        }

        private void Login_HelpButtonClicked(object sender, CancelEventArgs e)
        {
            System.Diagnostics.Process.Start("https://hu.wikipedia.org/wiki/Quarto_(j%C3%A1t%C3%A9k)");
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            whostarts = 2;
            pictureBox1.Image = Properties.Resources.arrow_right;
        }

        private void pink_knight_Click(object sender, EventArgs e)
        {
            whostarts = 1;
            pictureBox1.Image = Properties.Resources.arrow_left;
        }
    }
}
