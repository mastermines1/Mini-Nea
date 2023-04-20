namespace NEA_mini
{
    partial class Form1
    {

        int level, livesRemaining, score;
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            picHudson = new PictureBox();
            tmrSwerv = new System.Windows.Forms.Timer(components);
            tmrSwerving = new System.Windows.Forms.Timer(components);
            tmrFall = new System.Windows.Forms.Timer(components);
            picWakeyWines = new PictureBox();
            tmrEnemySpawnFast = new System.Windows.Forms.Timer(components);
            tmrEnemySpawnSlow = new System.Windows.Forms.Timer(components);
            picReturn = new PictureBox();
            pictureBox25 = new PictureBox();
            lblScore = new Label();
            tmrScore = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)picHudson).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picWakeyWines).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picReturn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox25).BeginInit();
            SuspendLayout();
            // 
            // picHudson
            // 
            picHudson.Image = (Image)resources.GetObject("picHudson.Image");
            picHudson.Location = new Point(481, 425);
            picHudson.Name = "picHudson";
            picHudson.Size = new Size(29, 44);
            picHudson.SizeMode = PictureBoxSizeMode.StretchImage;
            picHudson.TabIndex = 0;
            picHudson.TabStop = false;
            // 
            // tmrSwerv
            // 
            tmrSwerv.Enabled = true;
            tmrSwerv.Interval = 4000;
            tmrSwerv.Tick += tmrSwerv_Tick;
            // 
            // tmrSwerving
            // 
            tmrSwerving.Interval = 10;
            tmrSwerving.Tick += tmrSwerving_Tick;
            // 
            // tmrFall
            // 
            tmrFall.Enabled = true;
            tmrFall.Interval = 10;
            tmrFall.Tick += tmrFall_Tick;
            // 
            // picWakeyWines
            // 
            picWakeyWines.BackgroundImage = (Image)resources.GetObject("picWakeyWines.BackgroundImage");
            picWakeyWines.Image = (Image)resources.GetObject("picWakeyWines.Image");
            picWakeyWines.Location = new Point(0, 0);
            picWakeyWines.Name = "picWakeyWines";
            picWakeyWines.Size = new Size(982, 64);
            picWakeyWines.SizeMode = PictureBoxSizeMode.StretchImage;
            picWakeyWines.TabIndex = 2;
            picWakeyWines.TabStop = false;
            // 
            // tmrEnemySpawnFast
            // 
            tmrEnemySpawnFast.Enabled = true;
            tmrEnemySpawnFast.Interval = 1;
            tmrEnemySpawnFast.Tick += tmrEnemySpawnFast_Tick;
            // 
            // tmrEnemySpawnSlow
            // 
            tmrEnemySpawnSlow.Enabled = true;
            tmrEnemySpawnSlow.Interval = 1;
            tmrEnemySpawnSlow.Tick += tmrEnemySpawnSlow_Tick;
            // 
            // picReturn
            // 
            picReturn.BackColor = Color.White;
            picReturn.Image = (Image)resources.GetObject("picReturn.Image");
            picReturn.Location = new Point(865, 0);
            picReturn.Name = "picReturn";
            picReturn.Size = new Size(120, 22);
            picReturn.SizeMode = PictureBoxSizeMode.StretchImage;
            picReturn.TabIndex = 5;
            picReturn.TabStop = false;
            picReturn.Visible = false;
            picReturn.Click += picReturn_Click;
            // 
            // pictureBox25
            // 
            pictureBox25.Image = (Image)resources.GetObject("pictureBox25.Image");
            pictureBox25.Location = new Point(0, 61);
            pictureBox25.Name = "pictureBox25";
            pictureBox25.Size = new Size(982, 363);
            pictureBox25.TabIndex = 6;
            pictureBox25.TabStop = false;
            // 
            // lblScore
            // 
            lblScore.AutoSize = true;
            lblScore.Location = new Point(12, 454);
            lblScore.Name = "lblScore";
            lblScore.Size = new Size(0, 15);
            lblScore.TabIndex = 7;
            // 
            // tmrScore
            // 
            tmrScore.Enabled = true;
            tmrScore.Interval = 500;
            tmrScore.Tick += tmrScore_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 192, 0);
            ClientSize = new Size(982, 478);
            Controls.Add(lblScore);
            Controls.Add(picReturn);
            Controls.Add(picWakeyWines);
            Controls.Add(picHudson);
            Controls.Add(pictureBox25);
            Name = "Form1";
            ShowIcon = false;
            Load += Form1_Load;
            KeyUp += Form1_KeyUp;
            ((System.ComponentModel.ISupportInitialize)picHudson).EndInit();
            ((System.ComponentModel.ISupportInitialize)picWakeyWines).EndInit();
            ((System.ComponentModel.ISupportInitialize)picReturn).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox25).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Timer tmrSwerv;
        private System.Windows.Forms.Timer tmrSwerving;
        private System.Windows.Forms.Timer tmrFall;
        private PictureBox picWakeyWines;
        private System.Windows.Forms.Timer tmrEnemySpawnFast;
        private System.Windows.Forms.Timer tmrEnemySpawnSlow;
        private PictureBox picReturn;
        private PictureBox pictureBox25;
        private Label lblScore;
        private System.Windows.Forms.Timer tmrScore;
        public PictureBox picHudson;
    }
}