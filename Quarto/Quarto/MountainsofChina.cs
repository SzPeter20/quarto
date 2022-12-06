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
            
        }

        private void idegosszeroppanasomazagyfaszmogottbujkal()
        {
            generatemap();
            turns();
        }

        private void turns()
        {
            /*
            if (turn == 1 || turn == 3)
            {
                pctbx_starter.Image = Properties.Resources.arrow;
            }
            */
            if (start==1)
            {
                turn = 1;
                pctbx_starter.Image = Properties.Resources.arrow;
                
            }
            else if(start==2)
            {
                turn = 2;
                pctbx_starter.Image = Properties.Resources.arrow_down;
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


        }

        private void ChooseKatt(object sender, EventArgs e)
        {

            PictureBox kattintottpic = sender as PictureBox;
            if (turn==1)
            {
                imagecsere(pctbx_player2_piece,kattintottpic , lbl_player2_picebane);
                pctbx_starter.Image = Properties.Resources.arrow_down;
                turn = 4;
            }
            else if(turn==2)
            {
                imagecsere(pctbx_player1_piece, kattintottpic, lbl_player1_picebane);
                pctbx_starter.Image = Properties.Resources.arrow;
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
                pctbx_starter.Image = Properties.Resources.arrow;
                if (kattintott.Text=="")
                {
                    kattintott.Image = pctbx_player1_piece.Image;
                    pctbx_player1_piece.Image = null;
                    kattintott.Text = lbl_player1_picebane.Text;
                    lbl_player1_picebane.Text = "";
                    label2.Text = kattintott.Text;
                    victory(turn);
                    
                    turn = 1;
                }
                
            }
            else if (turn==4)
            {
                pctbx_starter.Image = Properties.Resources.arrow_down;
                if (kattintott.Text == "")
                {
                    kattintott.Image = pctbx_player2_piece.Image;
                    pctbx_player2_piece.Image = null;
                    kattintott.Text = lbl_player2_picebane.Text;
                    lbl_player2_picebane.Text = "";
                    label2.Text = kattintott.Text;
                    victory(turn);
                    
                    turn = 2;
                }
            }
        }

        private void victory(int turn)
        {
            string picsize = "";
            string color = "";
            string shape = "";
            string letter = "";
            bool nyert = false;

            for (int i = 0; i < size; i++)
            {
                if (imageek[i, i].Text.Length != 0)
                {
                    shape += imageek[i, i].Text[0].ToString();
                }
                else
                {
                    shape += ".";
                }
                if (imageek[i, i].Text.Length != 0)
                {
                    color += imageek[i, i].Text[1].ToString();
                }
                else
                {
                    color += ".";
                }
                if (imageek[i, i].Text.Length != 0)
                {
                    picsize += imageek[i, i].Text[2].ToString();
                }
                else
                {
                    picsize += ".";
                }
                if (imageek[i, i].Text.Length != 0)
                {
                    letter += imageek[i, i].Text[3].ToString();
                }
                else
                {
                    letter += ".";
                }
            }
            if (shape[0] == shape[1] && shape[1] == shape[2] && shape[2] == shape[3] && shape[0] != '.')
            {
                nyert = true;
            }
            if (color[0] == color[1] && color[1] == color[2] && color[2] == color[3] && color[0] != '.')
            {
                nyert = true;
            }
            if (picsize[0] == picsize[1] && picsize[1] == picsize[2] && picsize[2] == picsize[3] && picsize[0] != '.')
            {
                nyert = true;
            }
            if (letter[0] == letter[1] && letter[1] == letter[2] && letter[2] == letter[3] && letter[0] != '.')
            {
                nyert = true;
            }

            picsize = "";
            color = "";
            shape = "";
            letter = "";


            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (imageek[i, j].Text.Length!=0)
                    {
                        shape += imageek[i, j].Text[0].ToString();
                    }
                    else
                    {
                        shape += ".";
                    }
                    if (imageek[i, j].Text.Length != 0)
                    {
                        color += imageek[i, j].Text[1].ToString();
                    }
                    else
                    {
                        color += ".";
                    }
                    if (imageek[i, j].Text.Length != 0)
                    {
                        picsize += imageek[i, j].Text[2].ToString();
                    }
                    else
                    {
                        picsize += ".";
                    }
                    if (imageek[i, j].Text.Length != 0)
                    {
                        letter += imageek[i, j].Text[3].ToString();
                    }
                    else
                    {
                        letter += ".";
                    }

                }
                if (shape[0]==shape[1]&&shape[1]==shape[2]&&shape[2]==shape[3]&&shape[0]!='.')
                {
                    nyert = true;
                }
                if (color[0] == color[1] && color[1] == color[2] && color[2] == color[3] && color[0] != '.')
                {
                    nyert = true;
                }
                if (picsize[0] == picsize[1] && picsize[1] == picsize[2] && picsize[2] == picsize[3] && picsize[0] != '.')
                {
                    nyert = true;
                }
                if (letter[0] == letter[1] && letter[1] == letter[2] && letter[2] == letter[3] && letter[0] != '.')
                {
                    nyert = true;
                }
                if (!nyert)
                {
                     picsize = "";
                     color = "";
                     shape = "";
                     letter = "";
                }
                else
                {
                    break;
                }
            }

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if (imageek[j, i].Text.Length != 0)
                    {
                        shape += imageek[j, i].Text[0].ToString();
                    }
                    else
                    {
                        shape += ".";
                    }
                    if (imageek[j, i].Text.Length != 0)
                    {
                        color += imageek[j, i].Text[1].ToString();
                    }
                    else
                    {
                        color += ".";
                    }
                    if (imageek[j, i].Text.Length != 0)
                    {
                        picsize += imageek[j, i].Text[2].ToString();
                    }
                    else
                    {
                        picsize += ".";
                    }
                    if (imageek[j, i].Text.Length != 0)
                    {
                        letter += imageek[j, i].Text[3].ToString();
                    }
                    else
                    {
                        letter += ".";
                    }
                }
                if (shape[0] == shape[1] && shape[1] == shape[2] && shape[2] == shape[3] && shape[0] != '.')
                {
                    nyert = true;
                }
                if (color[0] == color[1] && color[1] == color[2] && color[2] == color[3] && color[0] != '.')
                {
                    nyert = true;
                }
                if (picsize[0] == picsize[1] && picsize[1] == picsize[2] && picsize[2] == picsize[3] && picsize[0] != '.')
                {
                    nyert = true;
                }
                if (letter[0] == letter[1] && letter[1] == letter[2] && letter[2] == letter[3] && letter[0] != '.')
                {
                    nyert = true;
                }
                if (!nyert)
                {
                    picsize = "";
                    color = "";
                    shape = "";
                    letter = "";
                }
                else
                {
                    break;
                }
            }

            int k= 3;
            for (int i = 0; i < size; i++)
            {
                if (imageek[i, k].Text.Length != 0)
                {
                    shape += imageek[i, k].Text[0].ToString();
                }
                else
                {
                    shape += ".";
                }
                if (imageek[i, k].Text.Length != 0)
                {
                    color += imageek[i, k].Text[1].ToString();
                }
                else
                {
                    color += ".";
                }
                if (imageek[i, k].Text.Length != 0)
                {
                    picsize += imageek[i, k].Text[2].ToString();
                }
                else
                {
                    picsize += ".";
                }
                if (imageek[i, k].Text.Length != 0)
                {
                    letter += imageek[i, k].Text[3].ToString();
                }
                else
                {
                    letter += ".";
                }
                k--;
            }
            if (shape[0] == shape[1] && shape[1] == shape[2] && shape[2] == shape[3] && shape[0] != '.')
            {
                nyert = true;
            }
            if (color[0] == color[1] && color[1] == color[2] && color[2] == color[3] && color[0] != '.')
            {
                nyert = true;
            }
            if (picsize[0] == picsize[1] && picsize[1] == picsize[2] && picsize[2] == picsize[3] && picsize[0] != '.')
            {
                nyert = true;
            }
            if (letter[0] == letter[1] && letter[1] == letter[2] && letter[2] == letter[3] && letter[0] != '.')
            {
                nyert = true;
            }

            picsize = "";
            color = "";
            shape = "";
            letter = "";

            {
                
                

                if (nyert && turn == 3)
                {
                    Victoria_super_omnia gyozelem = new Victoria_super_omnia();
                    gyozelem.gyoztes(lbl_name_1.Text, lbl_name_2.Text, turn);
                    gyozelem.Show();
                    this.Hide();
                    
                }
                else if (nyert && turn == 4)
                {
                    Victoria_super_omnia gyozelem = new Victoria_super_omnia();
                    gyozelem.gyoztes(lbl_name_1.Text, lbl_name_2.Text, turn);
                    gyozelem.Show();
                    this.Hide();
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
            if (whostarts==1)
            {
                pctbx_starter.Image = Properties.Resources.arrow;
            }
            else if (whostarts==2)
            {
                pctbx_starter.Image = Properties.Resources.arrow_down;
            }
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
