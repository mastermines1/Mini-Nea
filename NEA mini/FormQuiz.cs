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
        public  FormQuiz(int lvl,int qAnswered)
        {
            
            InitializeComponent(lvl,qAnswered);
        }

        private void FormQuiz_Load(object sender, EventArgs e)
        {
            if (this.qAnswered < 3)
            {
                this.Size = new Size(500, 400); this.MaximumSize = new Size(500, 400); this.MinimumSize = new Size(500, 400);
                Question q1 = new Question(lvl, qAnswered);
                this.Controls.Add(q1.lblQuestion);
                this.Controls.Add(q1.correctAnswer);
                this.Controls.Add(q1.answer1);
                this.Controls.Add(q1.answer2);
                this.Controls.Add(q1.answer3);
            }
            else
            {
                Form1 frm1 = new Form1();
                this.Hide();
                frm1.Show();
            }
        }

    }
    public class Question
    {
        public Label lblQuestion;
        public Button correctAnswer;
        public Button answer1;
        public Button answer2;
        public Button answer3;
        int lvl;
        int qAnswered;
        public Question(int level,int qAnswered)
        {
            this.lvl = level;
            Random rnd = new Random();
            Point[] pointsList = { };
                    this.lblQuestion = new Label
                    {
                        TextAlign = ContentAlignment.TopCenter,
                        Width = 500,
                        Top = 50,
                        Left = 0,
                    };
                    this.correctAnswer = new Button
                    { 
                        Width = 60,
                        Height = 60,
                        Location = new Point(135,110),
                        
                    };
                    this.answer1 = new Button
                    { 
                        Width = 60,
                        Height = 60,
                        Location = new Point(320,110),
                    };
                    this.answer2 = new Button
                    { 
                        Width = 60,
                        Height = 60,
                        Location = new Point(135,200),
                    };
                    this.answer3 = new Button
                    { 
                        Width = 60,
                        Height = 60,
                        Location = new Point(320,200),
                    };
            this.correctAnswer.Click += new EventHandler(correctAnswer_click);
            this.answer1.Click += new EventHandler(wrongAnswer_click);
            this.answer2.Click += new EventHandler(wrongAnswer_click);
            this.answer3.Click += new EventHandler(wrongAnswer_click);

            switch (level)
            {
                case 0:
                    int i = (int)rnd.NextInt64(0, 2);
                    this.lblQuestion.Text = questionsAndAnswers.getQ(i);
                    this.correctAnswer.Text = questionsAndAnswers.getCA(i);
                    this.answer1.Text = questionsAndAnswers.getA1(i);
                    this.answer2.Text = questionsAndAnswers.getA2(i);
                    this.answer3.Text = questionsAndAnswers.getA3(i);
                    break;
                case 1:
                    break;
                case 2:
                    break;
            }


        }
        private void correctAnswer_click(object sender, EventArgs e)
        {
            this.correctAnswer.Dispose();this.answer1.Dispose();this.lblQuestion.Dispose();this.answer2.Dispose();this.answer3.Dispose();
            FormQuiz frm2 = new FormQuiz(this.lvl,qAnswered+=1);
            
            frm2.Show();
            
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
