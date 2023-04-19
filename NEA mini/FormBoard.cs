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
            List<int> intScores = new List<int>();
            List<string> listPlayers = players.ToList();
            Dictionary<int, string> dictScores = new Dictionary<int, string>();
            

            for (int i = 0; i < scores.Length; i++)
            {
                intScores.Add(Convert.ToInt32(scores[i]));
                //dictScores.Add(intScores[i],listPlayers[i]);
            }
            if(newScore > intScores[scores.Length-1])
            {
                intScores.Add(newScore);
                intScores.Sort();
                intScores.Reverse();
                listPlayers.Add("");listPlayers.Add("");listPlayers.Add("");listPlayers.Add("");listPlayers.Add("");
                intScores.Add(-1);intScores.Add(-1);intScores.Add(-1);intScores.Add(-1);intScores.Add(-1);



            }
            else
            {
                addToBoard(listPlayers, intScores);
            }






            





        }

        private void addToBoard(List<string> listPlayers,List<int> intScores)
        {
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
        }

    }

}
