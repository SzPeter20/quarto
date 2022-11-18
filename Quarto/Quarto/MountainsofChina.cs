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
    public partial class MountainsofChina : Form
    {
        static string warrior1;
        static string warrior2;
        static int size = 4;
        static Label[,] labelek=new Label[size,size];

        public MountainsofChina()
        {
            InitializeComponent();
            generatemap();
        }


        private void generatemap()
        {
            
            Font LargeFont = new Font("Arial", 16);
            int x = 450;
            int y = 45;
            int square = 120;
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Label newlabel = new Label();
                    newlabel.Location = new Point(x + i * 120, y + j * 120);
                    newlabel.Width = square;
                    newlabel.Height = square;
                    newlabel.BackColor = Color.Firebrick;
                    newlabel.BorderStyle = BorderStyle.FixedSingle;
                    newlabel.Name = i + "_" + j;
                    newlabel.Text = "";
                    newlabel.AutoSize = false;
                    newlabel.Font = LargeFont;
                    newlabel.TextAlign = ContentAlignment.MiddleCenter;
                    newlabel.Click += new EventHandler(Kattintas);
                    this.Controls.Add(newlabel);
                    labelek[i, j] = newlabel;

                }
            }


            pictureBox1.SendToBack();
        }

        private void Kattintas(object sender, EventArgs e)
        {
            Label kattintott = sender as Label;






        }

        public void warriors(string player1, string player2)
        {
            warrior1 = player1;
            warrior2 = player2;
            lbl_name_1.Text = warrior1;
            lbl_name_2.Text = warrior2;

        }

        private void MountainsofChina_HelpButtonClicked(object sender, CancelEventArgs e)
        {
            System.Diagnostics.Process.Start("https://hu.wikipedia.org/wiki/Quarto_(j%C3%A1t%C3%A9k)");
        }

        private void MountainsofChina_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
