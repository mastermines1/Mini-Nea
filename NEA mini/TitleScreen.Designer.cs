namespace NEA_mini
{
    partial class TitleScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TitleScreen));
            picTitle = new PictureBox();
            btnPlay = new Button();
            btnHighScores = new Button();
            ((System.ComponentModel.ISupportInitialize)picTitle).BeginInit();
            SuspendLayout();
            // 
            // picTitle
            // 
            picTitle.Image = (Image)resources.GetObject("picTitle.Image");
            picTitle.Location = new Point(45, 10);
            picTitle.Name = "picTitle";
            picTitle.Size = new Size(375, 126);
            picTitle.SizeMode = PictureBoxSizeMode.StretchImage;
            picTitle.TabIndex = 0;
            picTitle.TabStop = false;
            // 
            // btnPlay
            // 
            btnPlay.Location = new Point(156, 177);
            btnPlay.Name = "btnPlay";
            btnPlay.Size = new Size(110, 29);
            btnPlay.TabIndex = 1;
            btnPlay.Text = "Play";
            btnPlay.UseVisualStyleBackColor = true;
            btnPlay.Click += btnPlay_Click;
            // 
            // btnHighScores
            // 
            btnHighScores.Location = new Point(156, 215);
            btnHighScores.Name = "btnHighScores";
            btnHighScores.Size = new Size(110, 32);
            btnHighScores.TabIndex = 1;
            btnHighScores.Text = "High scores";
            btnHighScores.UseVisualStyleBackColor = true;
            btnHighScores.Click += btnHighScores_Click;
            // 
            // TitleScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(422, 270);
            Controls.Add(btnHighScores);
            Controls.Add(btnPlay);
            Controls.Add(picTitle);
            Name = "TitleScreen";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = " ";
            ((System.ComponentModel.ISupportInitialize)picTitle).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox picTitle;
        private Button btnPlay;
        private Button btnHighScores;
    }
}