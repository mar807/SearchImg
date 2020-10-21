using System;
using System.Windows.Forms;

// TODO: 
// make a form -- DONE
// allow title and text input -- DONE
// search images using Google API -- DONE
// display in powerpoint

namespace InterviewProblem
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // getting user input text, then going to use wordSearch to search for images
            string wordSearch = textTxt.Text;
            using (Form2 f2 = new Form2())
            {
                // passing the value from the first form to the second form
                f2.wordSearch = textTxt.Text;
                f2.ShowDialog();
            }
        }
    }
}
