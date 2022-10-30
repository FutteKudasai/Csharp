using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        int money = 0;
        string text, ID, Strmoney, text1, text2, text3;
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (RadioButton1.Checked == false && RadioButton2.Checked == false || RadioButton3.Checked == false && RadioButton4.Checked == false)
            {
                label2.Text = "請完成必選項目之勾選";
            }
            else
            {
                if (RadioButton1.Checked == true && RadioButton3.Checked == true)
                {
                    money = 42000;
                    text = "日間部工科";
                }
                if (RadioButton1.Checked == true && RadioButton4.Checked == true)
                {
                    money = 37000;
                    text = "日間部商科";
                }
                if (RadioButton2.Checked == true && RadioButton3.Checked == true)
                {
                    money = 21000;
                    text = "夜間部工科";
                }
                if (RadioButton2.Checked == true && RadioButton4.Checked == true)
                {
                    money = 20000;
                    text = "夜間部商科";

                }
                if (RadioButton5.Checked == true)
                {
                    money = money + 12000;
                }
                if (CheckBox1.Checked == true)
                {
                    money = money + 1000;
                    text1 = "機車停車費";
                }
                if (CheckBox2.Checked == true)
                {
                    money = money + 2500;
                    text2 = "汽車停車費";
                }
                if (CheckBox3.Checked == true)
                {
                    money = money + 1800;
                    text3 = "健身會員費";
                }
                ID = Convert.ToString(TextBox1.Text);
                Strmoney = Convert.ToString(money);
                label2.Text = "學號:" + ID + " 您是 " + text + "\n" + text1 + " " + text2 + " " + text3;
                label3.Text = "您需繳費$"+Strmoney+"元";
            }
        }
    }
}
