namespace NEA_mini
{
    public partial class FormQuiz : Form
    {
        public FormQuiz(int lvl, int qAnswered,int Lives,int score)
        {
            this.lvl = lvl;
            this.qAnswered = qAnswered;
            this.score = score;

            InitializeComponent(lvl, qAnswered);
        }

        private void FormQuiz_Load(object sender, EventArgs e)
        {
            this.Size = new Size(500, 400); this.MaximumSize = new Size(500, 400); this.MinimumSize = new Size(500, 400);
            this.CenterToScreen();

            if (this.qAnswered< 3)
            {
                Random rnd = new Random();
                Point[] pointsList = { new Point(135, 110), new Point(320, 110), new Point(135, 200), new Point(320, 200) };
                Point[] shuffledPoints = Shuffle(pointsList);
                Label lblQuestion = new Label
                {
                    TextAlign = ContentAlignment.TopCenter,
                    Width = 500,
                    Top = 50,
                    Left = 0,
                };
                Button correctAnswer = new Button
                {
                    Width = 60,
                    Height = 60,
                    Location = shuffledPoints[0],

                };
                Button answer1 = new Button
                {
                    Width = 60,
                    Height = 60,
                    Location = shuffledPoints[1],
                };
                Button answer2 = new Button
                {
                    Width = 60,
                    Height = 60,
                    Location = shuffledPoints[2],
                };
                Button answer3 = new Button
                {
                    Width = 60,
                    Height = 60,
                    Location = shuffledPoints[3],
                };
                correctAnswer.Click += new EventHandler(correctAnswer_click);
                answer1.Click += new EventHandler(wrongAnswer_click);
                answer2.Click += new EventHandler(wrongAnswer_click);
                answer3.Click += new EventHandler(wrongAnswer_click);

                switch (lvl)
                {
                    case 0:
                        int i = (int)rnd.NextInt64(0, 2);
                        lblQuestion.Text = questionsAndAnswers.getQ(i);
                        correctAnswer.Text = questionsAndAnswers.getCA(i);
                        answer1.Text = questionsAndAnswers.getA1(i);
                        answer2.Text = questionsAndAnswers.getA2(i);
                        answer3.Text = questionsAndAnswers.getA3(i);
                        break;
                    case 1:
                        break;
                    case 2:
                        break;
                }
                this.Controls.Add(lblQuestion);
                this.Controls.Add(correctAnswer);
                this.Controls.Add(answer1);
                this.Controls.Add(answer2);
                this.Controls.Add(answer3);
            }
        
            else
            {

            Form1 frm1 = new Form1(lvl+1,LivesRemaining,score);
            this.Close();
            frm1.Show();
            }
        }
        static Point[] Shuffle(Point[] array)
        {
            Random rnd = new Random();
            int n = array.Length;

            for (int i = n-1; i > 0; i--)
            {
                int r =rnd.Next(0,n - i);


                Point temp = array[i];
                array[i] = array[r];
                array[r] = temp;
            }
            return array;
        }

        private void correctAnswer_click(object sender, EventArgs e)
        {
            //qAnswered += 1;
            this.Dispose();
            FormQuiz frm = new FormQuiz(lvl,this.qAnswered+1,LivesRemaining,score);
            frm.Show();
        }
        private void wrongAnswer_click(object sender, EventArgs e)
        {

        }
    }
    public class questionsAndAnswers
    {
        static string[] questions = { "What is the legal drinking age in the US?", "What is the alcohol limit for driving in the US?" };
        static string[] correctAnswer = { "21", "0.08% BAC" };
        static string[] wrongAnswer1 = { "16", "1.00% BAC", };
        static string[] wrongAnswer2 = { "17", "0.02% BAC", };
        static string[] wrongAnswer3 = { "20", "0.05% BAC", };
        public static string getQ(int i)
        {
            return questions[i];
        }
        public static string getCA(int i)
        {
            return correctAnswer[i];
        }
        public static string getA1(int i)
        {
            return wrongAnswer1[i];
        }
        public static string getA2(int i)
        {
            return wrongAnswer2[i];
        }
        public static string getA3(int i)
        {
            return wrongAnswer3[i];
        }
    }

}
