using System;
using System.Windows.Forms;

// TODO: 
// make a form -- DONE
// allow title and text input -- DONE
// search images using Google API -- DONE
// display in powerpoint -- DONE
// include title on form 2 -- DONE
// Title being included in powerpoint -- DONE
// Bold the description -- DONE 
// Description being added to powerpoint and form 2 

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
            string title = titleTxt.Text;

            // passing the title text box to the second form that holds the google pictures
            using (Form2 f2 = new Form2(titleTxt.Text, descrBox.Text))
            {
                // passing the value from the first form to the second form
                f2.title = titleTxt.Text;
                f2.wordSearch = textTxt.Text;
                f2.ShowDialog();
            }
        }


    }
}
