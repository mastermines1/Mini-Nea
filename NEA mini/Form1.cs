namespace NEA_mini
{
    public partial class Form1 : Form
    {

        public int swerveCountDown = 100;

        public Form1(int Lvl,int LivesRemaining,int score)
        {
            level = Lvl;
            this.livesRemaining = LivesRemaining;
            this.score = score;
            InitializeComponent();
        }

        private void tmrSwerv_Tick(object sender, EventArgs e)
        {
            Random random = new Random();
            tmrSwerv.Interval = random.Next(4000, 6000);
            tmrSwerving.Enabled = true;
            tmrSwerv.Enabled = false;
        }

        private void tmrSwerving_Tick(object sender, EventArgs e)
        {
            if (swerveCountDown > 0)
            {
                Random random = new Random();
                int x = random.Next(2);
                if (x == 1)
                {
                    picHudson.Location = new Point(picHudson.Location.X + 1, picHudson.Location.Y);
                }
                else
                {
                    picHudson.Location = new Point(picHudson.Location.X - 1, picHudson.Location.Y);
                }
                swerveCountDown -= 1;
            }
            else
            {
                swerveCountDown = 100;
                tmrSwerving.Enabled = false;
                tmrSwerv.Enabled = true;
            }

        }

        private void tmrFall_Tick(object sender, EventArgs e)
        {
            if (picHudson.Top < 420 && picHudson.Top != 210)//dont fall off screen
            {
                picHudson.Top += 1;

            }
            if (picHudson.Top < 75)
            {
                if (level < 2)
                {
                picHudson.Top = 420;
                FormQuiz frmQuiz = new FormQuiz(level, 0,livesRemaining,score);
                frmQuiz.Show(); //got to questions
                this.Dispose();
                }
                else
                {
                    //victory
                }
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 32)
            {
                picHudson.Top -= 40;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblScore.Text = "Score: "+ score;
        }
           

        


        private void tmrEnemySpawnFast_Tick(object sender, EventArgs e)
        {
            tmrEnemySpawnFast.Interval = 1000;
            car Car1 = new car(false, true);
            this.Controls.Add(Car1.picCar);
            Car1.picCar.BringToFront();
            tmrEnemySpawnFast.Interval = 1000;
            car Car2 = new car(true, true);
            this.Controls.Add(Car2.picCar);
            Car2.picCar.BringToFront();

        }
         void hudsonHit()
         {
            livesRemaining += 1;
            if(livesRemaining == 0)
            {
                //gameover
            }
            else
            {
                Form1 frm = new Form1(level,livesRemaining,score);
                this.Dispose();
                frm.Show();
            }
         }


        private void tmrEnemySpawnSlow_Tick(object sender, EventArgs e)
        {
            tmrEnemySpawnSlow.Interval = 3000;
            car Car1 = new car(false, false);
            this.Controls.Add(Car1.picCar);
            Car1.picCar.BringToFront();
            tmrEnemySpawnSlow.Interval = 3000;
            car Car2 = new car(true, false);
            this.Controls.Add(Car2.picCar);
            Car2.picCar.BringToFront();
        }



        private void picReturn_Click(object sender, EventArgs e)
        {
            TitleScreen frmTitle = new TitleScreen();
            frmTitle.Show();
            this.Hide();
        }

        private void tmrScore_Tick(object sender, EventArgs e)
        {
            score -= 10;
            lblScore.Text = "Score: " +score;
        }
    }
}
    public class car
    {
        public bool travelsLeft { get; }
        public PictureBox picCar { get; }
        public System.Windows.Forms.Timer tmr { get; }
        public bool fastLane { get; }
        public car(bool left, bool fast)
        {

            this.travelsLeft = left;
            this.fastLane = fast;
            if (left && fast)
            {
                this.picCar = new PictureBox
                {
                    Name = "picCar",
                    Size = new Size(100, 50),
                    Location = new Point(900, 140),
                    ImageLocation = "Car top down.png",
                    SizeMode = PictureBoxSizeMode.StretchImage,
                    BackColor = Color.Black,
                };
                this.tmr = new System.Windows.Forms.Timer
                {
                    Interval = 10,
                    Enabled = true,
                };
            }
            else if (left && fast == false)
            {
                this.picCar = new PictureBox
                {
                    Name = "picCar",
                    Size = new Size(100, 50),
                    Location = new Point(900, 65),
                    ImageLocation = "Car top down.png",
                    SizeMode = PictureBoxSizeMode.StretchImage,
                    BackColor = Color.Black,
                };
                this.tmr = new System.Windows.Forms.Timer
                {
                    Interval = 20,
                    Enabled = true,
                };
            }
            else if (left == false && fast)
            {
                this.picCar = new PictureBox
                {
                    Name = "picCar",
                    Size = new Size(100, 50),
                    Location = new Point(-100, 275),
                    ImageLocation = "Car top down.png",
                    SizeMode = PictureBoxSizeMode.StretchImage,
                    BackColor = Color.Black,
                };
                this.tmr = new System.Windows.Forms.Timer
                {
                    Interval = 10,
                    Enabled = true,
                };
            }
            else if (left == false && fast == false)
            {
                this.picCar = new PictureBox
                {
                    Name = "picCar",
                    Size = new Size(100, 50),
                    Location = new Point(-100, 355),
                    ImageLocation = "Car top down.png",
                    SizeMode = PictureBoxSizeMode.StretchImage,
                    BackColor = Color.Black,
                };
                this.tmr = new System.Windows.Forms.Timer
                {
                    Interval = 20,
                    Enabled = true,
                };
            }
            this.tmr.Tick += new EventHandler(tmr_tick);
        }
        private void tmr_tick(Object sender, EventArgs e)
        {
            if (this.fastLane && this.travelsLeft == false)
            {
                picCar.Left += 10;
            }
            else if (this.fastLane == false && this.travelsLeft == false)
            {
                picCar.Left += 5;
            }
            else if (this.fastLane && this.travelsLeft == true)
            {
                picCar.Left -= 10;
            }
            else if (this.fastLane == false && this.travelsLeft == true)
            {
                picCar.Left -= 5;
            }
            if (this.picCar.Location.X > 900 || (this.picCar.Location.X < -100))
            {
                this.picCar.Dispose();
                this.tmr.Dispose();
            }
        }

    }
