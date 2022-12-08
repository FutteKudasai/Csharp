using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2022_11_24
{
    public partial class Form1 : Form
    {
        int round, number, win=0, draw=0, lose=0;
        string choose;
        Random random_number = new Random();

        public Form1()
        {
            InitializeComponent();
            textBox1.Text = "1";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (0 == Convert.ToInt32(textBox1.Text))
                {
                    textBox1.Text = "1";
                }
                label2.Text = "還有" + textBox1.Text + "局";
                round = Convert.ToInt32(textBox1.Text);
                label9.Text = "請按鈕出拳！";
                button1.Enabled = true;
                button2.Enabled = true;
                button3.Enabled = true;
                win = draw = lose = 0;
                label6.Text = "0";
                label7.Text = "0";
                label8.Text = "0";
            }
            catch { }
        }

        private void button_Click(object sender, EventArgs e)
        {
            Button choose = (Button)sender;//偵測按鈕
            textBox1.ReadOnly = true;
            round--;
            label2.Text = "還有" + round + "局";
            number = random_number.Next(3);//生成亂數
            pictureBox2.Image = imageList1.Images[Convert.ToInt32(number)];
            if (choose == button1)
            {
                pictureBox1.Image = imageList1.Images[0];
                if(0 == number)
                {
                    draw++;
                    label7.Text = Convert.ToString(draw);
                }
                if (1 == number)
                {
                    lose++;
                    label8.Text = Convert.ToString(lose);
                }
                if (2 == number)
                {
                    win++;
                    label6.Text = Convert.ToString(win);
                }
            }
            if (choose == button2)
            {
                pictureBox1.Image = imageList1.Images[1];
                if (0 == number)
                {
                    win++;
                    label6.Text = Convert.ToString(win);
                    
                }
                if (1 == number)
                {
                    draw++;
                    label7.Text = Convert.ToString(draw);
                    
                }
                if (2 == number)
                {
                    lose++;
                    label8.Text = Convert.ToString(lose);
                }
            }
            if (choose == button3)
            {
                pictureBox1.Image = imageList1.Images[2];
                if (0 == number)
                {
                    lose++;
                    label8.Text = Convert.ToString(lose);
                    
                }
                if (1 == number)
                {
                    win++;
                    label6.Text = Convert.ToString(win);
                }
                if (2 == number)
                {
                    draw++;
                    label7.Text = Convert.ToString(draw);
                }
            }
            
            if (0 >= round)
            {
                textBox1.ReadOnly = false;
                if(win > lose)
                {
                    label9.Text = "你贏了";
                }
                if (win < lose)
                {
                    label9.Text = "你輸了";
                }
                if (win == lose)
                {
                    label9.Text = "平手";
                }
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
            }
        }
    }
}
