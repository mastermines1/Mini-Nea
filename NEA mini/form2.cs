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
    public partial class form2 : Form
    {
        public form2(int lvl,int qAnswered)
        {
            InitializeComponent(lvl,qAnswered);
        }

        private void form2_Load(object sender, EventArgs e)
        {
            
            FormQuiz frm = new FormQuiz(lvl,qAnswered);
            this.Dispose();
            frm.Show();
            
        }
    }
}
