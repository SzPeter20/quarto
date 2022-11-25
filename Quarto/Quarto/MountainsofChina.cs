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
        static int start;
        static int turn ;
        public static List<string> pictureN = new List<string>
        {
            //BLUE
            "CBLB","CBLP","CBSB","CBSP","SBLB","SBLP","SBSB","SBSP",
            //PINK
            "CPLB","CPLP","CPSB","CPSP","SPLB","SPLP","SPSB","SPSP"

        }; 
        static string warrior1;
        static string warrior2;
        static int size = 4;
        static Label[,] imageek=new Label[size,size];

        public MountainsofChina()
        {
            InitializeComponent();
            idegosszeroppanasomazagyfaszmogottbujkal();
            
        }

        private void idegosszeroppanasomazagyfaszmogottbujkal()
        {
            generatemap();
            turns();
        }

        private void turns()
        {
            if (start==1)
            {
                turn = 1;   
            }
            else if(start==2)
            {
                turn = 2;
            }


        }

        private void generatemap()
        {
            
            Font LargeFont = new Font("Arial", 16);
            int x = 450;
            int y = 65;
            int picssquare = 40;
            int square = 120;
            int counter = 0;
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Label faszomlabel = new Label();
                    faszomlabel.Location = new Point(x + i * 120, y + j * 120);
                    faszomlabel.Width = square;
                    faszomlabel.Height = square;
                    faszomlabel.BackColor = Color.Firebrick;
                    faszomlabel.BorderStyle = BorderStyle.FixedSingle;
                    faszomlabel.Name = i + "_" + j;
                    faszomlabel.ForeColor = Color.Firebrick;
                    faszomlabel.Click += new EventHandler(Kattintas);
                    this.Controls.Add(faszomlabel);
                    imageek[i, j] = faszomlabel;

                }
            }
            for (int i = 1; i < 3; i++)
            {
                for (int j = 1; j < 9; j++)
                {
                    PictureBox newpicture = new PictureBox();
                    newpicture.Location = new Point(50*i, 50*j);
                    newpicture.Width = picssquare;
                    newpicture.Height = picssquare;
                    newpicture.SizeMode=PictureBoxSizeMode.Zoom;
                    newpicture.Name = imageList1.Images.Keys[counter].ToString().Split('.')[0];
                    newpicture.Image = imageList1.Images[counter];
                    newpicture.BackColor = Color.Transparent;
                    newpicture.Click += new EventHandler(ChooseKatt);
                    this.Controls.Add(newpicture);
                    counter++;
                }
            }


            pictureBox1.SendToBack();
        }

        private void ChooseKatt(object sender, EventArgs e)
        {

            PictureBox kattintottpic = sender as PictureBox;
            if (turn==1)
            {
                imagecsere(pctbx_player2_piece,kattintottpic , lbl_player2_picebane);
                turn = 4;
            }
            else if(turn==2)
            {
                imagecsere(pctbx_player1_piece, kattintottpic, lbl_player1_picebane);
                turn = 3;
            }
        }

        private void imagecsere(PictureBox pctbx_player_piece, PictureBox katt, Label namehordozo)
        {
            namehordozo.Visible = false;
            namehordozo.Text = katt.Name;
            pctbx_player_piece.SizeMode = PictureBoxSizeMode.Zoom;
            pctbx_player_piece.Image = katt.Image;
            katt.Visible = false;
            pctbx_player_piece.Visible = true;

        }

        private void Kattintas(object sender, EventArgs e)
        {
            Label kattintott = sender as Label;
            if (turn==3)
            {
                if (kattintott.Text=="")
                {
                    kattintott.Image = pctbx_player1_piece.Image;
                    pctbx_player1_piece.Image = null;
                    kattintott.Text = lbl_player1_picebane.Text;
                    lbl_player1_picebane.Text = "";
                }
                victory(turn);
                turn = 1;
            }
            else if (turn==4)
            {
                kattintott.Image = pctbx_player2_piece.Image;
                pctbx_player2_piece.Image = null;
                kattintott.Text = lbl_player2_picebane.Text;
                lbl_player2_picebane.Text = "";

                victory(turn);
                turn = 2;
            }



        }

        private void victory(int turn)
        {
            string size = "";
            string color = "";
            string shape = "";
            string letter = "";
            bool nyert = false;
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    shape += imageek[i, j].Text[0];
                    color += imageek[i, j].Text[1];
                    size += imageek[i, j].Text[2];
                    letter += imageek[i, j].Text[3];
                }

            }















            {
                string message = "";
                

                if (nyert && turn == 3)
                {
                    message = lbl_name_1.Text + " a nyertes!  Szeretnétek újat játszani?";
                    string title = "jéj  nyertél";
                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                    DialogResult result = MessageBox.Show(message, title, buttons);
                    if (result == DialogResult.No)
                    {
                        Application.Exit();
                    }
                    else
                    {
                        Application.Restart();
                    }
                }
                else if (nyert && turn == 4)
                {
                    message = lbl_name_2.Text + " a nyertes!  Szeretnétek újat játszani?";
                    string title = "jéj  nyertél";
                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                    DialogResult result = MessageBox.Show(message, title, buttons);
                    if (result == DialogResult.No)
                    {
                        Application.Exit();
                    }
                    else
                    {
                        Application.Restart();
                    }
                }
            }
            
        }

        public void warriors(string player1, string player2,int whostarts)
        {
            warrior1 = player1;
            warrior2 = player2;
            lbl_name_1.Text = warrior1;
            lbl_name_2.Text = warrior2;
            label1.Text = whostarts.ToString();
            start =Convert.ToInt32( label1.Text);
            idegosszeroppanasomazagyfaszmogottbujkal();

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
