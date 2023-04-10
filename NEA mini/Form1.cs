namespace NEA_mini
{
    public partial class Form1 : Form
    {

        public int swerveCountDown = 100;
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
            if (picHudson.Top < 420)//dont fall off screen
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
                picHudson.Top -= 40;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }


        private void tmrEnemySpawnFast_Tick(object sender, EventArgs e)
        { 
            tmrEnemySpawnFast.Interval = 1000;
            car Car1 = new car(false, true);
            this.Controls.Add(Car1.picCar);
            Car1.picCar.BringToFront();

        }

        private void tmrEnemySpawnSlow_Tick(object sender, EventArgs e)
        {
            tmrEnemySpawnSlow.Interval = 3000;
            car Car2 = new car(false, false);
            this.Controls.Add(Car2.picCar);
            Car2.picCar.BringToFront();

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
            if (left &&fast)
            {
                this.picCar = new PictureBox
                {
                    Name = "picCar",
                    Size = new Size(100, 50),
                    Location = new Point(-100, 230),//TO-DO new location for going left in fast lane
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
            else if(left && fast == false)
            {
                this.picCar = new PictureBox
                {
                    Name = "picCar",
                    Size = new Size(100, 50),
                    Location = new Point(-100, 230),//TO-DO new location for going left in slow lane
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
            else if(left == false && fast)
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
            }//done
            else if(left == false && fast == false)
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
            if (this.fastLane)
            {
            picCar.Left += 10;
            }
            else
            {
                picCar.Left += 5;
            }
        }
    }
}