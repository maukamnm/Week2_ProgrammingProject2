using System;
using System.Windows.Forms;

namespace Week2_Assignment2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void computeButton_Click(object sender, EventArgs e)
        {
            output.Clear();
            dateOutput.Clear();
            dayOutput.Clear();
            timeOutput.Clear();

            if (radioButton1.Checked)
            {
                output.AppendText("The Red ");
            }
            if (radioButton2.Checked)
            {
                output.AppendText("The Yellow ");
            }
            if (radioButton3.Checked)
            {
                output.AppendText("The Green ");
            }
            output.AppendText(PickFruit.GetItemText(PickFruit.SelectedItem));           
           //When this is just erased, its gone back just enough
            if (date.Checked)
            {
                dateOutput.AppendText(" was created on May 18th, 2021");
                if (day.Checked)
                {
                    dayOutput.AppendText("Sunday");
                    if (time.Checked)
                    {
                        timeOutput.AppendText("9:00 am");
                    }
                }
                if (time.Checked)
                {
                    timeOutput.AppendText("9:00 am");
                }
            }
            if (day.Checked)
            {
                    dayOutput.AppendText("Sunday");
                    if (time.Checked)
                    {
                        timeOutput.AppendText("9:00 am");
                    }
               
            }
            if (time.Checked)
            {
                timeOutput.AppendText("9:00 am");                
            }
        }

    }
}
