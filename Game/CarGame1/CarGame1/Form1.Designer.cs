namespace CarGame1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.bg1 = new System.Windows.Forms.PictureBox();
            this.bg2 = new System.Windows.Forms.PictureBox();
            this.player = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.enemy1 = new System.Windows.Forms.PictureBox();
            this.enemy2 = new System.Windows.Forms.PictureBox();
            this.btnRestart = new System.Windows.Forms.Button();
            this.coin = new System.Windows.Forms.PictureBox();
            this.labelCoins = new System.Windows.Forms.Label();
            this.labelLose = new System.Windows.Forms.PictureBox();
            this.enemy3 = new System.Windows.Forms.PictureBox();
            this.enemy4 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.bg1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bg2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.labelLose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy4)).BeginInit();
            this.SuspendLayout();
            // 
            // bg1
            // 
            this.bg1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bg1.BackgroundImage")));
            this.bg1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bg1.Location = new System.Drawing.Point(0, 0);
            this.bg1.Margin = new System.Windows.Forms.Padding(2);
            this.bg1.Name = "bg1";
            this.bg1.Size = new System.Drawing.Size(840, 650);
            this.bg1.TabIndex = 0;
            this.bg1.TabStop = false;
            // 
            // bg2
            // 
            this.bg2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bg2.BackgroundImage")));
            this.bg2.Location = new System.Drawing.Point(0, -630);
            this.bg2.Margin = new System.Windows.Forms.Padding(2);
            this.bg2.Name = "bg2";
            this.bg2.Size = new System.Drawing.Size(840, 650);
            this.bg2.TabIndex = 1;
            this.bg2.TabStop = false;
            // 
            // player
            // 
            this.player.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(121)))), ((int)(((byte)(137)))));
            this.player.Image = ((System.Drawing.Image)(resources.GetObject("player.Image")));
            this.player.Location = new System.Drawing.Point(447, 566);
            this.player.Margin = new System.Windows.Forms.Padding(2);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(39, 73);
            this.player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.player.TabIndex = 2;
            this.player.TabStop = false;
            this.player.Click += new System.EventHandler(this.player_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 5;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // enemy1
            // 
            this.enemy1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(121)))), ((int)(((byte)(137)))));
            this.enemy1.Image = ((System.Drawing.Image)(resources.GetObject("enemy1.Image")));
            this.enemy1.Location = new System.Drawing.Point(190, -347);
            this.enemy1.Margin = new System.Windows.Forms.Padding(2);
            this.enemy1.Name = "enemy1";
            this.enemy1.Size = new System.Drawing.Size(44, 154);
            this.enemy1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.enemy1.TabIndex = 5;
            this.enemy1.TabStop = false;
            // 
            // enemy2
            // 
            this.enemy2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(121)))), ((int)(((byte)(137)))));
            this.enemy2.Image = ((System.Drawing.Image)(resources.GetObject("enemy2.Image")));
            this.enemy2.InitialImage = null;
            this.enemy2.Location = new System.Drawing.Point(356, -519);
            this.enemy2.Margin = new System.Windows.Forms.Padding(2);
            this.enemy2.Name = "enemy2";
            this.enemy2.Size = new System.Drawing.Size(40, 75);
            this.enemy2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.enemy2.TabIndex = 6;
            this.enemy2.TabStop = false;
            // 
            // btnRestart
            // 
            this.btnRestart.AutoSize = true;
            this.btnRestart.BackColor = System.Drawing.Color.Transparent;
            this.btnRestart.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRestart.BackgroundImage")));
            this.btnRestart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnRestart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRestart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRestart.ForeColor = System.Drawing.Color.Transparent;
            this.btnRestart.Location = new System.Drawing.Point(255, 383);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(330, 67);
            this.btnRestart.TabIndex = 8;
            this.btnRestart.UseVisualStyleBackColor = false;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // coin
            // 
            this.coin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(121)))), ((int)(((byte)(137)))));
            this.coin.Image = ((System.Drawing.Image)(resources.GetObject("coin.Image")));
            this.coin.Location = new System.Drawing.Point(701, -297);
            this.coin.Margin = new System.Windows.Forms.Padding(2);
            this.coin.Name = "coin";
            this.coin.Size = new System.Drawing.Size(32, 32);
            this.coin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.coin.TabIndex = 9;
            this.coin.TabStop = false;
            // 
            // labelCoins
            // 
            this.labelCoins.AutoSize = true;
            this.labelCoins.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(51)))), ((int)(((byte)(35)))));
            this.labelCoins.Font = new System.Drawing.Font("Segoe UI Symbol", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCoins.ForeColor = System.Drawing.Color.White;
            this.labelCoins.Location = new System.Drawing.Point(12, 9);
            this.labelCoins.Name = "labelCoins";
            this.labelCoins.Size = new System.Drawing.Size(151, 47);
            this.labelCoins.TabIndex = 10;
            this.labelCoins.Text = "Coins: 0";
            // 
            // labelLose
            // 
            this.labelLose.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelLose.Image = ((System.Drawing.Image)(resources.GetObject("labelLose.Image")));
            this.labelLose.Location = new System.Drawing.Point(255, 184);
            this.labelLose.Margin = new System.Windows.Forms.Padding(2);
            this.labelLose.Name = "labelLose";
            this.labelLose.Size = new System.Drawing.Size(330, 183);
            this.labelLose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.labelLose.TabIndex = 11;
            this.labelLose.TabStop = false;
            // 
            // enemy3
            // 
            this.enemy3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(121)))), ((int)(((byte)(137)))));
            this.enemy3.Image = ((System.Drawing.Image)(resources.GetObject("enemy3.Image")));
            this.enemy3.Location = new System.Drawing.Point(686, -300);
            this.enemy3.Margin = new System.Windows.Forms.Padding(2);
            this.enemy3.Name = "enemy3";
            this.enemy3.Size = new System.Drawing.Size(40, 75);
            this.enemy3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.enemy3.TabIndex = 12;
            this.enemy3.TabStop = false;
            this.enemy3.Click += new System.EventHandler(this.enemy3_Click);
            // 
            // enemy4
            // 
            this.enemy4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(121)))), ((int)(((byte)(137)))));
            this.enemy4.Image = ((System.Drawing.Image)(resources.GetObject("enemy4.Image")));
            this.enemy4.Location = new System.Drawing.Point(524, -130);
            this.enemy4.Margin = new System.Windows.Forms.Padding(2);
            this.enemy4.Name = "enemy4";
            this.enemy4.Size = new System.Drawing.Size(40, 75);
            this.enemy4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.enemy4.TabIndex = 13;
            this.enemy4.TabStop = false;
            this.enemy4.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 650);
            this.Controls.Add(this.enemy4);
            this.Controls.Add(this.enemy3);
            this.Controls.Add(this.labelLose);
            this.Controls.Add(this.labelCoins);
            this.Controls.Add(this.coin);
            this.Controls.Add(this.btnRestart);
            this.Controls.Add(this.enemy2);
            this.Controls.Add(this.enemy1);
            this.Controls.Add(this.player);
            this.Controls.Add(this.bg2);
            this.Controls.Add(this.bg1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.bg1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bg2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.labelLose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox bg1;
        private System.Windows.Forms.PictureBox bg2;
        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox enemy1;
        private System.Windows.Forms.PictureBox enemy2;
        private System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.PictureBox coin;
        private System.Windows.Forms.Label labelCoins;
        private System.Windows.Forms.PictureBox labelLose;
        private System.Windows.Forms.PictureBox enemy3;
        private System.Windows.Forms.PictureBox enemy4;
    }
}

