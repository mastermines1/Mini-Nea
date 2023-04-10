using System.Runtime.CompilerServices;

namespace NEA_mini
{
    public partial class Form1 : Form
    {

        public int swerveCountDown = 100;
        //public int upCountdown = 100;
        public Form1()
        {
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
                if (random.NextInt64(-1, 1) == 0)
                {
                    picHudson.Location = new Point(picHudson.Location.X + 1, picHudson.Location.Y - 1);
                }
                else
                {
                    picHudson.Location = new Point(picHudson.Location.X - 1, picHudson.Location.Y - 1);
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
            if (picHudson.Top < 400)//dont fall off screen
            {
                picHudson.Top += 1;

            }
            if (picHudson.Top < 75)
            {//victory?

            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 32)
            {
                picHudson.Top -= 20;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {



            car Car1 = new car(false,true);
            this.Controls.Add(Car1.picCar);
            Car1.picCar.BringToFront();
        }

        private void tmrEnemySpawn_Tick(object sender, EventArgs e)
        {



        }

        private void tmrCarMove_Tick(object sender, EventArgs e)
        {
            
        }
    }
    public class car
    {
        public bool travelsLeft { get; }
        public PictureBox picCar { get; }
        public System.Windows.Forms.Timer Timer { get; }
        public bool fastLane { get; }

        public car(bool left,bool fast)
        {

            this.travelsLeft = left;
            this.fastLane = fast;
            if(left)
            {
               picCar = new PictureBox
                {
                    Name = "picCar",
                    Size = new Size(100, 50),
                    Location = new Point(-100, 230),
                    ImageLocation = "Car top down.png",
                    SizeMode = PictureBoxSizeMode.StretchImage,
                    BackColor = Color.Black,
                };
            }
            else
            {
                picCar = new PictureBox
                {
                    Name = "picCar",
                    Size = new Size(100, 50),
                    Location = new Point(00, 230),
                    ImageLocation = "Car top down.png",
                    SizeMode = PictureBoxSizeMode.StretchImage,
                    BackColor = Color.Black,
                };
            }
            if(fast)
            {
                this.Timer = new System.Windows.Forms.Timer
                {
                    Interval = 10,
                    Enabled = true,
                };
            }
            else
            {
                this.Timer = new System.Windows.Forms.Timer
                {
                    Interval = 20,
                    Enabled = true,
                };
            }    

        }
    }
}