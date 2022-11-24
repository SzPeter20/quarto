
namespace Quarto
{
    partial class MountainsofChina
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MountainsofChina));
            this.lbl_name_1 = new System.Windows.Forms.Label();
            this.lbl_name_2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_name_1
            // 
            this.lbl_name_1.AutoSize = true;
            this.lbl_name_1.BackColor = System.Drawing.Color.White;
            this.lbl_name_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_name_1.Location = new System.Drawing.Point(668, 9);
            this.lbl_name_1.Name = "lbl_name_1";
            this.lbl_name_1.Size = new System.Drawing.Size(51, 20);
            this.lbl_name_1.TabIndex = 0;
            this.lbl_name_1.Text = "label1";
            // 
            // lbl_name_2
            // 
            this.lbl_name_2.AutoSize = true;
            this.lbl_name_2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lbl_name_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_name_2.Location = new System.Drawing.Point(668, 576);
            this.lbl_name_2.Name = "lbl_name_2";
            this.lbl_name_2.Size = new System.Drawing.Size(51, 20);
            this.lbl_name_2.TabIndex = 1;
            this.lbl_name_2.Text = "label2";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Quarto.Properties.Resources.MOCBackground;
            this.pictureBox1.Location = new System.Drawing.Point(-5, -10);
            this.pictureBox1.MaximumSize = new System.Drawing.Size(982, 622);
            this.pictureBox1.MinimumSize = new System.Drawing.Size(982, 622);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(982, 622);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "CBLB.png");
            this.imageList1.Images.SetKeyName(1, "CBLP.png");
            this.imageList1.Images.SetKeyName(2, "CBSB.png");
            this.imageList1.Images.SetKeyName(3, "CBSP.png");
            this.imageList1.Images.SetKeyName(4, "SBLB.png");
            this.imageList1.Images.SetKeyName(5, "SBLP.png");
            this.imageList1.Images.SetKeyName(6, "SBSB.png");
            this.imageList1.Images.SetKeyName(7, "SBSP.png");
            this.imageList1.Images.SetKeyName(8, "CPLB.png");
            this.imageList1.Images.SetKeyName(9, "CPLP.png");
            this.imageList1.Images.SetKeyName(10, "CPSB.png");
            this.imageList1.Images.SetKeyName(11, "CPSP.png");
            this.imageList1.Images.SetKeyName(12, "SPLB.png");
            this.imageList1.Images.SetKeyName(13, "SPLP.png");
            this.imageList1.Images.SetKeyName(14, "SPSB.png");
            this.imageList1.Images.SetKeyName(15, "SPSP.png");
            // 
            // MountainsofChina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(970, 605);
            this.Controls.Add(this.lbl_name_2);
            this.Controls.Add(this.lbl_name_1);
            this.Controls.Add(this.pictureBox1);
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(986, 644);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(986, 644);
            this.Name = "MountainsofChina";
            this.Text = "Mountains of China";
            this.HelpButtonClicked += new System.ComponentModel.CancelEventHandler(this.MountainsofChina_HelpButtonClicked);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MountainsofChina_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_name_1;
        private System.Windows.Forms.Label lbl_name_2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ImageList imageList1;
    }
}