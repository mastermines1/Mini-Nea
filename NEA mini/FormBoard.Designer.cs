namespace NEA_mini
{
    partial class FormBoard
    {
        int newScore;
        public List<string> stringScores;
        public List<string> stringPlayers;


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
            tblScores = new TableLayoutPanel();
            lblName1 = new Label();
            lblScore = new Label();
            lblName = new Label();
            lblScore1 = new Label();
            lblName2 = new Label();
            lblScore2 = new Label();
            lblName3 = new Label();
            lblScore3 = new Label();
            lblName4 = new Label();
            lblScore4 = new Label();
            lblName5 = new Label();
            lblScore5 = new Label();
            lblNewHS = new Label();
            txtInput = new TextBox();
            btnSubmit = new Button();
            tblScores.SuspendLayout();
            SuspendLayout();
            // 
            // tblScores
            // 
            tblScores.ColumnCount = 2;
            tblScores.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblScores.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblScores.Controls.Add(lblName1, 0, 1);
            tblScores.Controls.Add(lblScore, 1, 0);
            tblScores.Controls.Add(lblName, 0, 0);
            tblScores.Controls.Add(lblScore1, 1, 1);
            tblScores.Controls.Add(lblName2, 0, 2);
            tblScores.Controls.Add(lblScore2, 1, 2);
            tblScores.Controls.Add(lblName3, 0, 3);
            tblScores.Controls.Add(lblScore3, 1, 3);
            tblScores.Controls.Add(lblName4, 0, 4);
            tblScores.Controls.Add(lblScore4, 1, 4);
            tblScores.Controls.Add(lblName5, 0, 5);
            tblScores.Controls.Add(lblScore5, 1, 5);
            tblScores.Location = new Point(62, 12);
            tblScores.Name = "tblScores";
            tblScores.RowCount = 6;
            tblScores.RowStyles.Add(new RowStyle(SizeType.Percent, 10.71429F));
            tblScores.RowStyles.Add(new RowStyle(SizeType.Percent, 17.85714F));
            tblScores.RowStyles.Add(new RowStyle(SizeType.Percent, 17.85714F));
            tblScores.RowStyles.Add(new RowStyle(SizeType.Percent, 17.85714F));
            tblScores.RowStyles.Add(new RowStyle(SizeType.Percent, 17.85714F));
            tblScores.RowStyles.Add(new RowStyle(SizeType.Percent, 17.85715F));
            tblScores.Size = new Size(248, 313);
            tblScores.TabIndex = 0;
            tblScores.Visible = false;
            // 
            // lblName1
            // 
            lblName1.Location = new Point(3, 33);
            lblName1.Name = "lblName1";
            lblName1.Size = new Size(118, 55);
            lblName1.TabIndex = 1;
            lblName1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblScore
            // 
            lblScore.BackColor = SystemColors.ActiveBorder;
            lblScore.Location = new Point(127, 0);
            lblScore.Name = "lblScore";
            lblScore.Size = new Size(118, 33);
            lblScore.TabIndex = 1;
            lblScore.Text = "Score";
            lblScore.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblName
            // 
            lblName.BackColor = SystemColors.ActiveBorder;
            lblName.Location = new Point(3, 0);
            lblName.Name = "lblName";
            lblName.Size = new Size(118, 33);
            lblName.TabIndex = 1;
            lblName.Text = "Name";
            lblName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblScore1
            // 
            lblScore1.Location = new Point(127, 33);
            lblScore1.Name = "lblScore1";
            lblScore1.Size = new Size(118, 55);
            lblScore1.TabIndex = 1;
            lblScore1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblName2
            // 
            lblName2.Location = new Point(3, 88);
            lblName2.Name = "lblName2";
            lblName2.Size = new Size(118, 55);
            lblName2.TabIndex = 1;
            lblName2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblScore2
            // 
            lblScore2.Location = new Point(127, 88);
            lblScore2.Name = "lblScore2";
            lblScore2.Size = new Size(118, 55);
            lblScore2.TabIndex = 1;
            lblScore2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblName3
            // 
            lblName3.Location = new Point(3, 143);
            lblName3.Name = "lblName3";
            lblName3.Size = new Size(118, 55);
            lblName3.TabIndex = 1;
            lblName3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblScore3
            // 
            lblScore3.Location = new Point(127, 143);
            lblScore3.Name = "lblScore3";
            lblScore3.Size = new Size(118, 55);
            lblScore3.TabIndex = 1;
            lblScore3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblName4
            // 
            lblName4.Location = new Point(3, 198);
            lblName4.Name = "lblName4";
            lblName4.Size = new Size(118, 55);
            lblName4.TabIndex = 1;
            lblName4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblScore4
            // 
            lblScore4.Location = new Point(127, 198);
            lblScore4.Name = "lblScore4";
            lblScore4.Size = new Size(118, 55);
            lblScore4.TabIndex = 1;
            lblScore4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblName5
            // 
            lblName5.Location = new Point(3, 253);
            lblName5.Name = "lblName5";
            lblName5.Size = new Size(118, 55);
            lblName5.TabIndex = 1;
            lblName5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblScore5
            // 
            lblScore5.Location = new Point(127, 253);
            lblScore5.Name = "lblScore5";
            lblScore5.Size = new Size(118, 55);
            lblScore5.TabIndex = 1;
            lblScore5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblNewHS
            // 
            lblNewHS.Location = new Point(62, 3);
            lblNewHS.Name = "lblNewHS";
            lblNewHS.Size = new Size(248, 139);
            lblNewHS.TabIndex = 1;
            lblNewHS.Text = "New high score!";
            lblNewHS.TextAlign = ContentAlignment.MiddleCenter;
            lblNewHS.Visible = false;
            // 
            // txtInput
            // 
            txtInput.Location = new Point(62, 160);
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(248, 23);
            txtInput.TabIndex = 2;
            txtInput.Visible = false;
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(232, 189);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(78, 21);
            btnSubmit.TabIndex = 3;
            btnSubmit.Text = "Submit name";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Visible = false;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // FormBoard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(392, 358);
            Controls.Add(btnSubmit);
            Controls.Add(txtInput);
            Controls.Add(lblNewHS);
            Controls.Add(tblScores);
            Name = "FormBoard";
            Text = "LeaderBoard";
            Load += FormBoard_Load;
            tblScores.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
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
        private Label lblNewHS;
        private TextBox txtInput;
        private Button btnSubmit;
    }
}