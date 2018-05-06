using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication2
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

        private void 取消_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int i;
            int DOY = 0;
            int WN = 0;
            int TOW = 0;
            if (numericUpDown1.Text == "" || numericUpDown2.Text == "" || numericUpDown3.Text == "" || numericUpDown4.Text == "" || numericUpDown5.Text == "" || numericUpDown6.Text == "" || numericUpDown1.Text == "0" || numericUpDown2.Text == "0" || numericUpDown3.Text == "0" || numericUpDown4.Text == "0" || numericUpDown5.Text == "0" || numericUpDown6.Text == "0")
            {
                MessageBox.Show("ERROR");
            }
            else
            {
                int year = Convert.ToInt32(numericUpDown1.Text);
                int month = Convert.ToInt32(numericUpDown2.Text);
                int day = Convert.ToInt32(numericUpDown4.Text);
                int hour = Convert.ToInt32(numericUpDown3.Text);
                int minute = Convert.ToInt32(numericUpDown5.Text);
                int second = Convert.ToInt32(numericUpDown6.Text);
                int g = 0;
                int sumday = 0;
                int [ ]a= new int[12]{31,29,31,30,31,30,31,31,30,31,30,31};
                int [ ]b= new int[12]{31,28,31,30,31,30,31,31,30,31,30,31};
                for (i = 1980; i < year; i++)
                {
                    if ((i % 100 != 0 && i % 4 == 0) || (i % 400 == 0))
                        sumday += 366;
                    else sumday += 365;
                }
                if ((year  % 100 != 0 && year  % 4 == 0) || (year % 400 == 0))
                {
                    for (i = 0; i < month - 1; i++)
                        g = g + a[i];
                }
                else
                {
                    for (i = 0; i < month  - 1; i++)
                        g = g + b[i];
                }
                DOY = g + day;
                sumday = sumday + DOY - 6;
                WN = sumday / 7;
                TOW = sumday % 7 * 24 * 60 * 60 + hour * 60 * 60 + minute * 60 + second;
                string  out1  =(DOY).ToString() ;
                string out2 = (WN).ToString(); 
                string out3 = (TOW).ToString();
                textBox1.Text = out1;
                textBox2.Text = out2;
                textBox3.Text = out3;
            }
               
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown4_ValueChanged_1(object sender, EventArgs e)
        {

        }

        private void numericUpDown5_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown6_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
