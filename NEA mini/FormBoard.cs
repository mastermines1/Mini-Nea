using System;
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
    public partial class FormBoard : Form
    {
        public FormBoard(int score)
        {
            newScore = score;
            InitializeComponent();
        }

        private async void FormBoard_Load(object sender, EventArgs e)
        {
            string[] scores = File.ReadAllLines("Scores.txt");
            string[] players = File.ReadAllLines("Players.txt");
            this.intScores = new List<int>();
            this.stringPlayers = players.ToList();
            Dictionary<int, string> dictScores = new Dictionary<int, string>();


            for (int i = 0; i < scores.Length; i++)
            {
                intScores.Add(Convert.ToInt32(scores[i]));
                //dictScores.Add(intScores[i],listPlayers[i]);
            }
            if (newScore > intScores[scores.Length - 1] || intScores.Count < 4 && newScore != 0)
            {
                intScores.Add(newScore);
                intScores.Sort();
                lblNewHS.Visible = true;
                txtInput.Visible = true;
                btnSubmit.Visible = true;
                lblNewHS.Text = $"New high score \n Your score of {newScore} now places at rank {Convert.ToString(intScores.Count - (intScores.BinarySearch(newScore)) + 2)} of the leaderboard! \n Please enter your name";
                intScores.Reverse();
                this.stringScores = new List<string>();
                for (int i = 0; i < intScores.Count; i++)
                {
                    this.stringScores.Add(intScores[i].ToString());
                }

                {
                    addToBoard(stringPlayers, intScores);
                }
            }
            else
            {
                addToBoard(stringPlayers, intScores);
            }
        }
        private void addToBoard(List<string> listPlayers, List<int> intScores)
        {
            listPlayers.Add(""); listPlayers.Add(""); listPlayers.Add(""); listPlayers.Add(""); listPlayers.Add("");
            intScores.Add(-1); intScores.Add(-1); intScores.Add(-1); intScores.Add(-1); intScores.Add(-1);
            lblName1.Text = listPlayers[0];
            lblName2.Text = listPlayers[1];
            lblName3.Text = listPlayers[2];
            lblName4.Text = listPlayers[3];
            lblName5.Text = listPlayers[4];
            if (intScores[0] != -1)
            {
                lblScore1.Text = intScores[0].ToString();
            }
            if (intScores[1] != -1)
            {
                lblScore2.Text = intScores[1].ToString();
            }
            if (intScores[2] != -1)
            {
                lblScore3.Text = intScores[2].ToString();
            }
            if (intScores[3] != -1)
            {
                lblScore4.Text = intScores[3].ToString();
            }
            if (intScores[4] != -1)
            {
                lblScore5.Text = intScores[4].ToString();
            }
            tblScores.Visible = true;
            btnReturn.Visible = true;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (txtInput.Text == "")
            {
                lblNewHS.Text = "Invalid Input. Try again";

            }
            else
            {
                string newName = txtInput.Text;
                stringPlayers.Add(""); stringPlayers.Add(""); stringPlayers.Add(""); stringPlayers.Add(""); stringPlayers.Add("");
                intScores.Reverse();
                int r = intScores.Count - (this.intScores.BinarySearch(newScore));
                intScores.Reverse();

                List<string> finalPlayers = new List<string>();

                for (int i = 0; i < r - 1; i++)
                {
                    finalPlayers.Add(stringPlayers[i]);
                }
                finalPlayers.Add(newName);
                for (int i = r; i < stringPlayers.Count - 2; i++)
                {
                    finalPlayers.Add(stringPlayers[i]);
                }
                File.WriteAllLines("Scores.txt", stringScores);
                File.WriteAllLines("Players.txt", finalPlayers);


                FormBoard frm = new FormBoard(0);
                this.Dispose();
                frm.Show();


            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            TitleScreen frm = new TitleScreen();
            this.Dispose();
            frm.Show();
        }
    }
}

