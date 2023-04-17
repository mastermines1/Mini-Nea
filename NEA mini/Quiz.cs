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
    public partial class Quiz : Form
    {
        public Quiz(int lvl)
        {
            InitializeComponent(lvl);
        }

        private void Quiz_Load(object sender, EventArgs e)
        {






        }
    }
    public class Questions
    {


        public Questions(int level) 
        {
            switch (level)
            {
                case 0:

                    break;
                case 1:
                    break;
                case 2:
                    break;
            }


        }
    }

   
}
