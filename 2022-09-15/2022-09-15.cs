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
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = new Bitmap("F:\\視窗程式設計\\2022-09-15\\man2_普通.gif");
            label1.Text = "你真沒趣!";
            label1.ForeColor = Color.Lime;
            label1.BackColor = Color.Red;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = new Bitmap("F:\\視窗程式設計\\2022-09-15\\man1_喜歡.gif");
            label1.Text = "謝謝你!";
            label1.ForeColor = Color.Yellow;
            label1.BackColor = Color.Blue;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = new Bitmap("F:\\視窗程式設計\\2022-09-15\\man5_不喜歡.jpg");
            label1.Text = "你閃一邊!";
            label1.ForeColor = Color.White;
            label1.BackColor = Color.Fuchsia;

        }
    }
}
