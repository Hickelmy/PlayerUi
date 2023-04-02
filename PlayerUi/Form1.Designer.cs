﻿namespace PlayerUi
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panelSideMenu = new Panel();
            btnEqualizer = new Button();
            panelPlaylistSubmenu = new Panel();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            btnPlaylist = new Button();
            panelMediaSubmenu = new Panel();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            btnMedia = new Button();
            panelLogo = new Panel();
            panelPlayer = new Panel();
            panelChildForm = new Panel();
            pictureBox1 = new PictureBox();
            panelSideMenu.SuspendLayout();
            panelPlaylistSubmenu.SuspendLayout();
            panelMediaSubmenu.SuspendLayout();
            panelChildForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panelSideMenu
            // 
            panelSideMenu.AutoScroll = true;
            panelSideMenu.BackColor = Color.FromArgb(17, 7, 11);
            panelSideMenu.Controls.Add(btnEqualizer);
            panelSideMenu.Controls.Add(panelPlaylistSubmenu);
            panelSideMenu.Controls.Add(btnPlaylist);
            panelSideMenu.Controls.Add(panelMediaSubmenu);
            panelSideMenu.Controls.Add(btnMedia);
            panelSideMenu.Controls.Add(panelLogo);
            panelSideMenu.Dock = DockStyle.Left;
            panelSideMenu.Location = new Point(0, 0);
            panelSideMenu.Name = "panelSideMenu";
            panelSideMenu.Padding = new Padding(0, 0, 0, 50);
            panelSideMenu.Size = new Size(250, 553);
            panelSideMenu.TabIndex = 0;
            // 
            // btnEqualizer
            // 
            btnEqualizer.Cursor = Cursors.Hand;
            btnEqualizer.Dock = DockStyle.Top;
            btnEqualizer.FlatAppearance.BorderSize = 0;
            btnEqualizer.FlatStyle = FlatStyle.Flat;
            btnEqualizer.ForeColor = Color.Gainsboro;
            btnEqualizer.Location = new Point(0, 524);
            btnEqualizer.Name = "btnEqualizer";
            btnEqualizer.Padding = new Padding(10, 0, 0, 0);
            btnEqualizer.Size = new Size(229, 45);
            btnEqualizer.TabIndex = 4;
            btnEqualizer.Text = "Equalizer";
            btnEqualizer.TextAlign = ContentAlignment.MiddleLeft;
            btnEqualizer.UseVisualStyleBackColor = true;
            btnEqualizer.Click += btnEqualizer_Click;
            // 
            // panelPlaylistSubmenu
            // 
            panelPlaylistSubmenu.BackColor = Color.FromArgb(35, 32, 39);
            panelPlaylistSubmenu.Controls.Add(button6);
            panelPlaylistSubmenu.Controls.Add(button7);
            panelPlaylistSubmenu.Controls.Add(button8);
            panelPlaylistSubmenu.Controls.Add(button9);
            panelPlaylistSubmenu.Dock = DockStyle.Top;
            panelPlaylistSubmenu.Location = new Point(0, 357);
            panelPlaylistSubmenu.Name = "panelPlaylistSubmenu";
            panelPlaylistSubmenu.Size = new Size(229, 167);
            panelPlaylistSubmenu.TabIndex = 3;
            // 
            // button6
            // 
            button6.Cursor = Cursors.Hand;
            button6.Dock = DockStyle.Top;
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatStyle = FlatStyle.Flat;
            button6.ForeColor = Color.LightGray;
            button6.Location = new Point(0, 120);
            button6.Name = "button6";
            button6.Padding = new Padding(35, 0, 0, 0);
            button6.Size = new Size(229, 40);
            button6.TabIndex = 3;
            button6.Text = "button6";
            button6.TextAlign = ContentAlignment.MiddleLeft;
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Cursor = Cursors.Hand;
            button7.Dock = DockStyle.Top;
            button7.FlatAppearance.BorderSize = 0;
            button7.FlatStyle = FlatStyle.Flat;
            button7.ForeColor = Color.LightGray;
            button7.Location = new Point(0, 80);
            button7.Name = "button7";
            button7.Padding = new Padding(35, 0, 0, 0);
            button7.Size = new Size(229, 40);
            button7.TabIndex = 2;
            button7.Text = "button7";
            button7.TextAlign = ContentAlignment.MiddleLeft;
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.Cursor = Cursors.Hand;
            button8.Dock = DockStyle.Top;
            button8.FlatAppearance.BorderSize = 0;
            button8.FlatStyle = FlatStyle.Flat;
            button8.ForeColor = Color.LightGray;
            button8.Location = new Point(0, 40);
            button8.Name = "button8";
            button8.Padding = new Padding(35, 0, 0, 0);
            button8.Size = new Size(229, 40);
            button8.TabIndex = 1;
            button8.Text = "button8";
            button8.TextAlign = ContentAlignment.MiddleLeft;
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button9
            // 
            button9.Cursor = Cursors.Hand;
            button9.Dock = DockStyle.Top;
            button9.FlatAppearance.BorderSize = 0;
            button9.FlatStyle = FlatStyle.Flat;
            button9.ForeColor = Color.LightGray;
            button9.Location = new Point(0, 0);
            button9.Name = "button9";
            button9.Padding = new Padding(35, 0, 0, 0);
            button9.Size = new Size(229, 40);
            button9.TabIndex = 0;
            button9.Text = "button9";
            button9.TextAlign = ContentAlignment.MiddleLeft;
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // btnPlaylist
            // 
            btnPlaylist.Cursor = Cursors.Hand;
            btnPlaylist.Dock = DockStyle.Top;
            btnPlaylist.FlatAppearance.BorderSize = 0;
            btnPlaylist.FlatStyle = FlatStyle.Flat;
            btnPlaylist.ForeColor = Color.Gainsboro;
            btnPlaylist.Location = new Point(0, 312);
            btnPlaylist.Name = "btnPlaylist";
            btnPlaylist.Padding = new Padding(10, 0, 0, 0);
            btnPlaylist.Size = new Size(229, 45);
            btnPlaylist.TabIndex = 2;
            btnPlaylist.Text = "Playlist";
            btnPlaylist.TextAlign = ContentAlignment.MiddleLeft;
            btnPlaylist.UseVisualStyleBackColor = true;
            btnPlaylist.Click += btnPlaylist_Click;
            // 
            // panelMediaSubmenu
            // 
            panelMediaSubmenu.BackColor = Color.FromArgb(35, 32, 39);
            panelMediaSubmenu.Controls.Add(button5);
            panelMediaSubmenu.Controls.Add(button4);
            panelMediaSubmenu.Controls.Add(button3);
            panelMediaSubmenu.Controls.Add(button2);
            panelMediaSubmenu.Dock = DockStyle.Top;
            panelMediaSubmenu.Location = new Point(0, 145);
            panelMediaSubmenu.Name = "panelMediaSubmenu";
            panelMediaSubmenu.Size = new Size(229, 167);
            panelMediaSubmenu.TabIndex = 1;
            panelMediaSubmenu.Paint += panelMediaSubmenu_Paint;
            // 
            // button5
            // 
            button5.Cursor = Cursors.Hand;
            button5.Dock = DockStyle.Top;
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.ForeColor = Color.LightGray;
            button5.Location = new Point(0, 120);
            button5.Name = "button5";
            button5.Padding = new Padding(35, 0, 0, 0);
            button5.Size = new Size(229, 40);
            button5.TabIndex = 3;
            button5.Text = "button5";
            button5.TextAlign = ContentAlignment.MiddleLeft;
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button4
            // 
            button4.Cursor = Cursors.Hand;
            button4.Dock = DockStyle.Top;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.ForeColor = Color.LightGray;
            button4.Location = new Point(0, 80);
            button4.Name = "button4";
            button4.Padding = new Padding(35, 0, 0, 0);
            button4.Size = new Size(229, 40);
            button4.TabIndex = 2;
            button4.Text = "button4";
            button4.TextAlign = ContentAlignment.MiddleLeft;
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.Cursor = Cursors.Hand;
            button3.Dock = DockStyle.Top;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.ForeColor = Color.LightGray;
            button3.Location = new Point(0, 40);
            button3.Name = "button3";
            button3.Padding = new Padding(35, 0, 0, 0);
            button3.Size = new Size(229, 40);
            button3.TabIndex = 1;
            button3.Text = "button3";
            button3.TextAlign = ContentAlignment.MiddleLeft;
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Cursor = Cursors.Hand;
            button2.Dock = DockStyle.Top;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.LightGray;
            button2.Location = new Point(0, 0);
            button2.Name = "button2";
            button2.Padding = new Padding(35, 0, 0, 0);
            button2.Size = new Size(229, 40);
            button2.TabIndex = 0;
            button2.Text = "button2";
            button2.TextAlign = ContentAlignment.MiddleLeft;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // btnMedia
            // 
            btnMedia.Cursor = Cursors.Hand;
            btnMedia.Dock = DockStyle.Top;
            btnMedia.FlatAppearance.BorderSize = 0;
            btnMedia.FlatStyle = FlatStyle.Flat;
            btnMedia.ForeColor = Color.Gainsboro;
            btnMedia.Location = new Point(0, 100);
            btnMedia.Name = "btnMedia";
            btnMedia.Padding = new Padding(10, 0, 0, 0);
            btnMedia.Size = new Size(229, 45);
            btnMedia.TabIndex = 0;
            btnMedia.Text = "Media";
            btnMedia.TextAlign = ContentAlignment.MiddleLeft;
            btnMedia.UseVisualStyleBackColor = true;
            btnMedia.Click += btnMedia_Click;
            // 
            // panelLogo
            // 
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(229, 100);
            panelLogo.TabIndex = 0;
            // 
            // panelPlayer
            // 
            panelPlayer.BackColor = Color.FromArgb(23, 21, 32);
            panelPlayer.Dock = DockStyle.Bottom;
            panelPlayer.Location = new Point(250, 477);
            panelPlayer.Name = "panelPlayer";
            panelPlayer.Size = new Size(997, 76);
            panelPlayer.TabIndex = 1;
            // 
            // panelChildForm
            // 
            panelChildForm.BackColor = Color.FromArgb(22, 30, 45);
            panelChildForm.Controls.Add(pictureBox1);
            panelChildForm.Dock = DockStyle.Fill;
            panelChildForm.Location = new Point(250, 0);
            panelChildForm.Name = "panelChildForm";
            panelChildForm.Size = new Size(997, 477);
            panelChildForm.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(337, 93);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(336, 288);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(1247, 553);
            Controls.Add(panelChildForm);
            Controls.Add(panelPlayer);
            Controls.Add(panelSideMenu);
            Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load_1;
            panelSideMenu.ResumeLayout(false);
            panelPlaylistSubmenu.ResumeLayout(false);
            panelMediaSubmenu.ResumeLayout(false);
            panelChildForm.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelSideMenu;
        private Panel panelMediaSubmenu;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button btnMedia;
        private Panel panelLogo;
        private Button btnEqualizer;
        private Panel panelPlaylistSubmenu;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button btnPlaylist;
        private Panel panelPlayer;
        private Panel panelChildForm;
        private PictureBox pictureBox1;
    }
}