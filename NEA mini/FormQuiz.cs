using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.Generic;

namespace NEA_mini
{
    public partial class FormQuiz : Form
    {
        public FormQuiz(int lvl)
        {

            InitializeComponent(lvl);
        }

        private void FormQuiz_Load(object sender, EventArgs e)
        {
            Question q1 = new Question(lvl);
            this.Controls.Add(q1.lblQuestion);
            //this.Controls.Add(q1.correctAnswer);
            //this.Controls.Add(q1.answer1);
            //this.Controls.Add(q1.answer2);
            //this.Controls.Add(q1.answer3);
        }
    }
    public class Question
    {
        public Label lblQuestion;
        public Button correctAnswer;
        public Button answer1;
        public Button answer2;
        public Button answer3;
        public Question(int level)
        {
            //this.txtQuestion.Location = new Point(100, 200);
            //this.correctAnswer.Location = new Point(50, 300);




            Random rnd = new Random();


            switch (level)
            {
                case 0:
                    int i = (int)rnd.NextInt64(1, 2);
                    this.lblQuestion = new Label
                    {
                        Text = questionsAndAnswers.getQ(i),
                        AutoSize = true,
                    };
                    lblQuestion.Location = new Point(150 - (lblQuestion.Width / 2), 75);

                    //this.txtQuestion.Text = questionsAndAnswers.getQ(i);
                    //this.correctAnswer.Text = questionsAndAnswers.getCA(i);
                    //this.answer1.Text = questionsAndAnswers.getA1(i);
                    //this.answer2.Text = questionsAndAnswers.getA2(i);
                    //this.answer3.Text = questionsAndAnswers.getA3(i);

                    break;
                case 1:
                    break;
                case 2:
                    break;
            }


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
