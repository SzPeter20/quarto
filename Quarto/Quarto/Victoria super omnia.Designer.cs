
namespace Quarto
{
    partial class Victoria_super_omnia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Victoria_super_omnia));
            this.pink_knight = new System.Windows.Forms.PictureBox();
            this.blue_knight = new System.Windows.Forms.PictureBox();
            this.pctbx_left_crown = new System.Windows.Forms.PictureBox();
            this.lbl_gyoztes = new System.Windows.Forms.Label();
            this.pctbx_right_crown = new System.Windows.Forms.PictureBox();
            this.btn_replay = new System.Windows.Forms.Button();
            this.btn_playerchange = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pink_knight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blue_knight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctbx_left_crown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctbx_right_crown)).BeginInit();
            this.SuspendLayout();
            // 
            // pink_knight
            // 
            this.pink_knight.BackColor = System.Drawing.Color.Transparent;
            this.pink_knight.Image = global::Quarto.Properties.Resources.pink_removebg_preview;
            this.pink_knight.Location = new System.Drawing.Point(21, 189);
            this.pink_knight.Name = "pink_knight";
            this.pink_knight.Size = new System.Drawing.Size(287, 246);
            this.pink_knight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pink_knight.TabIndex = 11;
            this.pink_knight.TabStop = false;
            // 
            // blue_knight
            // 
            this.blue_knight.BackColor = System.Drawing.Color.Transparent;
            this.blue_knight.Image = global::Quarto.Properties.Resources.blue_removebg_preview2;
            this.blue_knight.Location = new System.Drawing.Point(508, 189);
            this.blue_knight.Name = "blue_knight";
            this.blue_knight.Size = new System.Drawing.Size(271, 246);
            this.blue_knight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.blue_knight.TabIndex = 10;
            this.blue_knight.TabStop = false;
            // 
            // pctbx_left_crown
            // 
            this.pctbx_left_crown.BackColor = System.Drawing.Color.Transparent;
            this.pctbx_left_crown.Image = global::Quarto.Properties.Resources.crown;
            this.pctbx_left_crown.Location = new System.Drawing.Point(65, 89);
            this.pctbx_left_crown.Name = "pctbx_left_crown";
            this.pctbx_left_crown.Size = new System.Drawing.Size(225, 94);
            this.pctbx_left_crown.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctbx_left_crown.TabIndex = 12;
            this.pctbx_left_crown.TabStop = false;
            this.pctbx_left_crown.Visible = false;
            // 
            // lbl_gyoztes
            // 
            this.lbl_gyoztes.AutoSize = true;
            this.lbl_gyoztes.BackColor = System.Drawing.Color.Transparent;
            this.lbl_gyoztes.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_gyoztes.ForeColor = System.Drawing.Color.Red;
            this.lbl_gyoztes.Location = new System.Drawing.Point(214, 30);
            this.lbl_gyoztes.Name = "lbl_gyoztes";
            this.lbl_gyoztes.Size = new System.Drawing.Size(403, 31);
            this.lbl_gyoztes.TabIndex = 14;
            this.lbl_gyoztes.Text = "Sun-Tsu a győztes! Gratulálunk!";
            // 
            // pctbx_right_crown
            // 
            this.pctbx_right_crown.BackColor = System.Drawing.Color.Transparent;
            this.pctbx_right_crown.Image = global::Quarto.Properties.Resources.crown;
            this.pctbx_right_crown.Location = new System.Drawing.Point(530, 77);
            this.pctbx_right_crown.Name = "pctbx_right_crown";
            this.pctbx_right_crown.Size = new System.Drawing.Size(225, 94);
            this.pctbx_right_crown.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctbx_right_crown.TabIndex = 15;
            this.pctbx_right_crown.TabStop = false;
            this.pctbx_right_crown.Visible = false;
            // 
            // btn_replay
            // 
            this.btn_replay.BackColor = System.Drawing.Color.HotPink;
            this.btn_replay.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn_replay.Location = new System.Drawing.Point(378, 189);
            this.btn_replay.Name = "btn_replay";
            this.btn_replay.Size = new System.Drawing.Size(59, 60);
            this.btn_replay.TabIndex = 16;
            this.btn_replay.Text = "Újabb játék";
            this.btn_replay.UseVisualStyleBackColor = false;
            this.btn_replay.Click += new System.EventHandler(this.btn_replay_Click);
            // 
            // btn_playerchange
            // 
            this.btn_playerchange.BackColor = System.Drawing.Color.DarkViolet;
            this.btn_playerchange.ForeColor = System.Drawing.Color.Lime;
            this.btn_playerchange.Location = new System.Drawing.Point(378, 278);
            this.btn_playerchange.Name = "btn_playerchange";
            this.btn_playerchange.Size = new System.Drawing.Size(59, 60);
            this.btn_playerchange.TabIndex = 17;
            this.btn_playerchange.Text = "Játékos csere";
            this.btn_playerchange.UseVisualStyleBackColor = false;
            this.btn_playerchange.Click += new System.EventHandler(this.btn_playerchange_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_exit.ForeColor = System.Drawing.Color.HotPink;
            this.btn_exit.Location = new System.Drawing.Point(378, 375);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(59, 60);
            this.btn_exit.TabIndex = 18;
            this.btn_exit.Text = "Kilépés";
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // Victoria_super_omnia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Quarto.Properties.Resources.back1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_playerchange);
            this.Controls.Add(this.btn_replay);
            this.Controls.Add(this.pctbx_right_crown);
            this.Controls.Add(this.lbl_gyoztes);
            this.Controls.Add(this.pctbx_left_crown);
            this.Controls.Add(this.pink_knight);
            this.Controls.Add(this.blue_knight);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(816, 489);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "Victoria_super_omnia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Victoria super omnia";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Victoria_super_omnia_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pink_knight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blue_knight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctbx_left_crown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctbx_right_crown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pink_knight;
        private System.Windows.Forms.PictureBox blue_knight;
        private System.Windows.Forms.PictureBox pctbx_left_crown;
        private System.Windows.Forms.Label lbl_gyoztes;
        private System.Windows.Forms.PictureBox pctbx_right_crown;
        private System.Windows.Forms.Button btn_replay;
        private System.Windows.Forms.Button btn_playerchange;
        private System.Windows.Forms.Button btn_exit;
    }
}