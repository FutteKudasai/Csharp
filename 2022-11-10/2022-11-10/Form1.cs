using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2022_11_10
{
    public partial class Form1 : Form
    {
        string show, button, original, name;
        public Form1()
        {
            InitializeComponent();
        }

        public void arrangement()
        {
            show = "姓名" + "\t" + "體重" + "\t" + "身高" + Environment.NewLine + "\n============================" + Environment.NewLine;
            string[] student = new string[] { "阿珠", "國強", "小花", "春嬌", "志明", "珠珠", "妞妞", "台生", "國賢" };
            string[] weigh = new string[] { "40", "34", "38", "40", "38", "34", "42", "30", "33" };
            string[] high = new string[] { "150", "133", "160", "153", "133", "145", "140", "145", "158" };
            string[] temp = new string[9];

            if (button == "name")
            {
                student.CopyTo(temp, 0);
                Array.Sort(student, weigh);
                Array.Sort(temp, high);
            }
            if(button == "weigh")
            {
                weigh.CopyTo(temp, 0);
                Array.Sort(weigh, student);
                Array.Sort(temp, high);
            }
            if(button == "high")
            {
                high.CopyTo(temp, 0);
                Array.Sort(high, student);
                Array.Sort(temp, weigh);
            }
            for (int i = 0; i < 9; i++)
            {
                show += student[i] + "\t" + weigh[i] + "\t" + high[i] + Environment.NewLine;
            }
            textBox2.Text = show;
        }

        private void search()
        {
            show = "姓名" + "\t" + "體重" + "\t" + "身高" + Environment.NewLine + "\n============================" + Environment.NewLine;
            string[] student = new string[] { "阿珠", "國強", "小花", "春嬌", "志明", "珠珠", "妞妞", "台生", "國賢" };
            string[] weigh = new string[] { "40", "34", "38", "40", "38", "34", "42", "30", "33" };
            string[] high = new string[] { "150", "133", "160", "153", "133", "145", "140", "145", "158" };
            int number=-1;
            if (button == "high")
            {
                number = Array.IndexOf(high, textBox1.Text);
            }
            if (button == "name")
            {
                number = Array.IndexOf(student, textBox1.Text);
            }
            while(number >= 0)
            {
                show += student[number] + "\t" + weigh[number] + "\t" + high[number] + Environment.NewLine + "\n";
                number = Array.IndexOf(high, textBox1.Text, number+1);
            }
            textBox2.Text = show;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button = "original";
            arrangement();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            button = "original";
            arrangement();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button = "name";
            arrangement();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button = "weigh";
            arrangement();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button = "high";
            arrangement();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            button = "high";
            search();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            button = "name";
            search();
        }
    }
}
