using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2022_09_29
{
    public partial class Form1 : Form
    {
        int x, y, size, num1, num2, ans, r=0, g=0, b=0, count=0;
        string text;

        private void error()
        {
            count++;
            count = Convert.ToInt32(count);
            MessageBox.Show("輸入錯誤", "加法運算", MessageBoxButtons.OK, MessageBoxIcon.Error);
            label12.Text = "累計輸入錯誤" + count + "次";
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                x = Convert.ToInt32(textBox1.Text);
                Location = new Point(x, y);
            }
            catch
            {
                error();
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }



        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                y = Convert.ToInt32(textBox2.Text);
                Location = new Point(x, y);
            }
            catch
            {
                error();
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            try
            {
                text = Convert.ToString(textBox3.Text);
                label4.Text = text;
            }
            catch
            {
                error();
                count = Convert.ToInt32(count);
                label12.Text = "累計輸入錯誤" + count + "次";
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            try
            { 
                size = Convert.ToInt32(textBox4.Text);
                label4.Font = new Font("新細明體", size, FontStyle.Regular);
            }
            catch
            {
                error();
                count = Convert.ToInt32(count);
                label12.Text = "累計輸入錯誤" + count + "次";
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            num1 = Convert.ToInt32(textBox5.Text);
        }

        private void label13_MouseClick(object sender, MouseEventArgs e)
        {
            label13.Text = Microsoft.VisualBasic.Interaction.InputBox("請輸入數字", "標題");
        }

        private void label14_MouseClick(object sender, MouseEventArgs e)
        {
            num2 = Convert.ToInt32(label13.Text);
            ans = num1 + num2;
            label14.Text = ans.ToString();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            try
            {
                r = Convert.ToInt32(textBox6.Text);
                BackColor = Color.FromArgb(r, g, b);
            }
            catch
            {
                error();
            }
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            try
            {
                g = Convert.ToInt32(textBox7.Text);
                BackColor = Color.FromArgb(r, g, b);
            }
            catch
            {
                error();
            }
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            try
            {
                b = Convert.ToInt32(textBox8.Text);
                BackColor = Color.FromArgb(r, g, b);
            }
            catch
            {
                error();
            }
        }
    }
}