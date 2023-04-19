namespace NEA_mini
{
    partial class FormBoard
    {
        int newScore;


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
            this.tblScores = new System.Windows.Forms.TableLayoutPanel();
            this.lblName1 = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblScore1 = new System.Windows.Forms.Label();
            this.lblName2 = new System.Windows.Forms.Label();
            this.lblScore2 = new System.Windows.Forms.Label();
            this.lblName3 = new System.Windows.Forms.Label();
            this.lblScore3 = new System.Windows.Forms.Label();
            this.lblName4 = new System.Windows.Forms.Label();
            this.lblScore4 = new System.Windows.Forms.Label();
            this.lblName5 = new System.Windows.Forms.Label();
            this.lblScore5 = new System.Windows.Forms.Label();
            this.tblScores.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblScores
            // 
            this.tblScores.ColumnCount = 2;
            this.tblScores.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblScores.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblScores.Controls.Add(this.lblName1, 0, 1);
            this.tblScores.Controls.Add(this.lblScore, 1, 0);
            this.tblScores.Controls.Add(this.lblName, 0, 0);
            this.tblScores.Controls.Add(this.lblScore1, 1, 1);
            this.tblScores.Controls.Add(this.lblName2, 0, 2);
            this.tblScores.Controls.Add(this.lblScore2, 1, 2);
            this.tblScores.Controls.Add(this.lblName3, 0, 3);
            this.tblScores.Controls.Add(this.lblScore3, 1, 3);
            this.tblScores.Controls.Add(this.lblName4, 0, 4);
            this.tblScores.Controls.Add(this.lblScore4, 1, 4);
            this.tblScores.Controls.Add(this.lblName5, 0, 5);
            this.tblScores.Controls.Add(this.lblScore5, 1, 5);
            this.tblScores.Location = new System.Drawing.Point(62, 12);
            this.tblScores.Name = "tblScores";
            this.tblScores.RowCount = 6;
            this.tblScores.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.71429F));
            this.tblScores.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.85714F));
            this.tblScores.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.85714F));
            this.tblScores.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.85714F));
            this.tblScores.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.85714F));
            this.tblScores.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.85715F));
            this.tblScores.Size = new System.Drawing.Size(248, 313);
            this.tblScores.TabIndex = 0;
            this.tblScores.Visible = false;
            // 
            // lblName1
            // 
            this.lblName1.Location = new System.Drawing.Point(3, 33);
            this.lblName1.Name = "lblName1";
            this.lblName1.Size = new System.Drawing.Size(118, 55);
            this.lblName1.TabIndex = 1;
            this.lblName1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblScore
            // 
            this.lblScore.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblScore.Location = new System.Drawing.Point(127, 0);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(118, 33);
            this.lblScore.TabIndex = 1;
            this.lblScore.Text = "Score";
            this.lblScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblName
            // 
            this.lblName.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblName.Location = new System.Drawing.Point(3, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(118, 33);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblScore1
            // 
            this.lblScore1.Location = new System.Drawing.Point(127, 33);
            this.lblScore1.Name = "lblScore1";
            this.lblScore1.Size = new System.Drawing.Size(118, 55);
            this.lblScore1.TabIndex = 1;
            this.lblScore1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblName2
            // 
            this.lblName2.Location = new System.Drawing.Point(3, 88);
            this.lblName2.Name = "lblName2";
            this.lblName2.Size = new System.Drawing.Size(118, 55);
            this.lblName2.TabIndex = 1;
            this.lblName2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblScore2
            // 
            this.lblScore2.Location = new System.Drawing.Point(127, 88);
            this.lblScore2.Name = "lblScore2";
            this.lblScore2.Size = new System.Drawing.Size(118, 55);
            this.lblScore2.TabIndex = 1;
            this.lblScore2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblName3
            // 
            this.lblName3.Location = new System.Drawing.Point(3, 143);
            this.lblName3.Name = "lblName3";
            this.lblName3.Size = new System.Drawing.Size(118, 55);
            this.lblName3.TabIndex = 1;
            this.lblName3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblScore3
            // 
            this.lblScore3.Location = new System.Drawing.Point(127, 143);
            this.lblScore3.Name = "lblScore3";
            this.lblScore3.Size = new System.Drawing.Size(118, 55);
            this.lblScore3.TabIndex = 1;
            this.lblScore3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblName4
            // 
            this.lblName4.Location = new System.Drawing.Point(3, 198);
            this.lblName4.Name = "lblName4";
            this.lblName4.Size = new System.Drawing.Size(118, 55);
            this.lblName4.TabIndex = 1;
            this.lblName4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblScore4
            // 
            this.lblScore4.Location = new System.Drawing.Point(127, 198);
            this.lblScore4.Name = "lblScore4";
            this.lblScore4.Size = new System.Drawing.Size(118, 55);
            this.lblScore4.TabIndex = 1;
            this.lblScore4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblName5
            // 
            this.lblName5.Location = new System.Drawing.Point(3, 253);
            this.lblName5.Name = "lblName5";
            this.lblName5.Size = new System.Drawing.Size(118, 55);
            this.lblName5.TabIndex = 1;
            this.lblName5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblScore5
            // 
            this.lblScore5.Location = new System.Drawing.Point(127, 253);
            this.lblScore5.Name = "lblScore5";
            this.lblScore5.Size = new System.Drawing.Size(118, 55);
            this.lblScore5.TabIndex = 1;
            this.lblScore5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 358);
            this.Controls.Add(this.tblScores);
            this.Name = "FormBoard";
            this.Text = "LeaderBoard";
            this.Load += new System.EventHandler(this.FormBoard_Load);
            this.tblScores.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tblScores;
        private Label lblName1;
        private Label lblScore;
        private Label lblName;
        private Label lblScore1;
        private Label lblName2;
        private Label lblScore2;
        private Label lblName3;
        private Label lblScore3;
        private Label lblName4;
        private Label lblScore4;
        private Label lblName5;
        private Label lblScore5;
    }
}