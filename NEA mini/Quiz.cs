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
    public partial class Quiz : Form
    {
        public Quiz(int lvl)
        {
            InitializeComponent(lvl);
        }

        private void Quiz_Load(object sender, EventArgs e)
        {
            Question q1 = new Question(0);





        }
    }
    public class Question
    {
        TextBox txtQuestion;
        Button correctAnswer;
        Button answer1;
        Button answer2;
        Button answer3;
        public Question(int level) 
        {
            txtQuestion.Location = new Point(100, 200);
            correctAnswer.Location = new Point(50, 300);




            Random rnd = new Random();
            

            switch (level)
            {
                case 0:
                    int i = (int)rnd.NextInt64(1, 2);
                    txtQuestion.Text = questionsAndAnswers.getQ(i);
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


        }
    }
    public class questionsAndAnswers
    {
        static string[] questions = { "What is the legal drinking age in the US?", "What is the alcahol limit for driving? In the US" };
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
