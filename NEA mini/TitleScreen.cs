﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NEA_mini
{
    public partial class TitleScreen : Form
    {
        public TitleScreen()
        {
            InitializeComponent();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            Form1 frmMain = new Form1(0,3,30000);

            frmMain.Show();
            this.Hide();
            
        }

        private void btnHighScores_Click(object sender, EventArgs e)
        {
            FormBoard frmBoard = new FormBoard(10000000);
            frmBoard.Show();
            this.Hide();

        }

        private void btnHelp_Click(object sender, EventArgs e)
        {

        }
    }
}
