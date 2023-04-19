namespace NEA_mini
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.picHudson = new System.Windows.Forms.PictureBox();
            this.tmrSwerv = new System.Windows.Forms.Timer(this.components);
            this.tmrSwerving = new System.Windows.Forms.Timer(this.components);
            this.tmrFall = new System.Windows.Forms.Timer(this.components);
            this.picWakeyWines = new System.Windows.Forms.PictureBox();
            this.tmrEnemySpawnFast = new System.Windows.Forms.Timer(this.components);
            this.tmrEnemySpawnSlow = new System.Windows.Forms.Timer(this.components);
            this.picReturn = new System.Windows.Forms.PictureBox();
            this.pictureBox25 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picHudson)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWakeyWines)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picReturn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox25)).BeginInit();
            this.SuspendLayout();
            // 
            // picHudson
            // 
            this.picHudson.Image = ((System.Drawing.Image)(resources.GetObject("picHudson.Image")));
            this.picHudson.Location = new System.Drawing.Point(481, 425);
            this.picHudson.Name = "picHudson";
            this.picHudson.Size = new System.Drawing.Size(29, 44);
            this.picHudson.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picHudson.TabIndex = 0;
            this.picHudson.TabStop = false;
            // 
            // tmrSwerv
            // 
            this.tmrSwerv.Enabled = true;
            this.tmrSwerv.Interval = 4000;
            this.tmrSwerv.Tick += new System.EventHandler(this.tmrSwerv_Tick);
            // 
            // tmrSwerving
            // 
            this.tmrSwerving.Interval = 10;
            this.tmrSwerving.Tick += new System.EventHandler(this.tmrSwerving_Tick);
            // 
            // tmrFall
            // 
            this.tmrFall.Enabled = true;
            this.tmrFall.Interval = 10;
            this.tmrFall.Tick += new System.EventHandler(this.tmrFall_Tick);
            // 
            // picWakeyWines
            // 
            this.picWakeyWines.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picWakeyWines.BackgroundImage")));
            this.picWakeyWines.Image = ((System.Drawing.Image)(resources.GetObject("picWakeyWines.Image")));
            this.picWakeyWines.Location = new System.Drawing.Point(0, 0);
            this.picWakeyWines.Name = "picWakeyWines";
            this.picWakeyWines.Size = new System.Drawing.Size(982, 64);
            this.picWakeyWines.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picWakeyWines.TabIndex = 2;
            this.picWakeyWines.TabStop = false;
            // 
            // tmrEnemySpawnFast
            // 
            this.tmrEnemySpawnFast.Enabled = true;
            this.tmrEnemySpawnFast.Interval = 1;
            this.tmrEnemySpawnFast.Tick += new System.EventHandler(this.tmrEnemySpawnFast_Tick);
            // 
            // tmrEnemySpawnSlow
            // 
            this.tmrEnemySpawnSlow.Enabled = true;
            this.tmrEnemySpawnSlow.Interval = 1;
            this.tmrEnemySpawnSlow.Tick += new System.EventHandler(this.tmrEnemySpawnSlow_Tick);
            // 
            // picReturn
            // 
            this.picReturn.BackColor = System.Drawing.Color.White;
            this.picReturn.Image = ((System.Drawing.Image)(resources.GetObject("picReturn.Image")));
            this.picReturn.Location = new System.Drawing.Point(865, 0);
            this.picReturn.Name = "picReturn";
            this.picReturn.Size = new System.Drawing.Size(120, 22);
            this.picReturn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picReturn.TabIndex = 5;
            this.picReturn.TabStop = false;
            this.picReturn.Visible = false;
            this.picReturn.Click += new System.EventHandler(this.picReturn_Click);
            // 
            // pictureBox25
            // 
            this.pictureBox25.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox25.Image")));
            this.pictureBox25.Location = new System.Drawing.Point(0, 61);
            this.pictureBox25.Name = "pictureBox25";
            this.pictureBox25.Size = new System.Drawing.Size(982, 363);
            this.pictureBox25.TabIndex = 6;
            this.pictureBox25.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(982, 478);
            this.Controls.Add(this.picReturn);
            this.Controls.Add(this.picWakeyWines);
            this.Controls.Add(this.picHudson);
            this.Controls.Add(this.pictureBox25);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.picHudson)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWakeyWines)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picReturn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox25)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox picHudson;
        private System.Windows.Forms.Timer tmrSwerv;
        private System.Windows.Forms.Timer tmrSwerving;
        private System.Windows.Forms.Timer tmrFall;
        private PictureBox picWakeyWines;
        private System.Windows.Forms.Timer tmrEnemySpawnFast;
        private System.Windows.Forms.Timer tmrEnemySpawnSlow;
        private PictureBox picReturn;
        private PictureBox pictureBox25;
    }
}