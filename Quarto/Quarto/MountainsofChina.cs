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
        public static List<string> pictureN = new List<string>
        {
            //BLUE
            "foundation_circle","foundation_circle_blue_large_B","foundation_circle_blue_large_P","foundation_circle_blue_small_B","foundation_circle_blue_small_P",
            "square_blue_large_B","square_blue_large_P","square_blue_small_B","square_blue_small_P",
            //PINK
            "CPLB","CPLP","CPSB","foundation_circle_pink","foundation_circle_pink_small_P","square_pink_large_B","square_pink_large_P","square_pink_small_B",
            "square_pink_small_P"

        };
        protected Graphics myGraphics;
        private int currentImage = 0;
        static string warrior1;
        static string warrior2;
        static int size = 4;
        static Label[,] labelek=new Label[size,size];

        public MountainsofChina()
        {
            imageList1.ImageSize = new Size(255, 255);
            imageList1.TransparentColor = Color.White;
            myGraphics = Graphics.FromHwnd(panel1.Handle);
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (imageList1.Images.Empty != true)
            {
                if (imageList1.Images.Count - 1 > currentImage)
                {
                    currentImage++;
                }
                else
                {
                    currentImage = 0;
                }
                panel1.Refresh();

                // Draw the image in the panel.
                imageList1.Draw(myGraphics, 10, 10, currentImage);

                // Show the image in the PictureBox.
                pictureBox1.Image = imageList1.Images[currentImage];
                label3.Text = "Current image is " + currentImage;
                listBox1.SelectedIndex = currentImage;
                label5.Text = "Image is " + listBox1.Text;
            }
        }
    }
    }

