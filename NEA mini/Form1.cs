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



        private void tmrFallTime_Tick(object sender, EventArgs e)
        {
            if (picHudson.Top < 400)//dont fall off screen
            {
                picHudson.Top += 1;

            }
            if (picHudson.Top < 75)
            {//victory?

            }
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

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 32)
            {
                picHudson.Top -= 20;
            }
        }
    }
}