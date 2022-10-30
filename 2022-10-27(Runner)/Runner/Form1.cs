using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Runner
{
    public partial class Form1 : Form
    {
        int direction=1;
        int num=0;    //紀錄圖片的註標值
        int picX;    //圖框的X位置(左上角)
        int picY;   //圖框的Y位置(左上角)

        public Form1()
        {
            InitializeComponent();
        }
        public void run()
        {
            TmrRun.Enabled = true;  //啟動tmrRun計時器
            TmrMove.Enabled = true; //啟動tmrMove計時器
        }
        public void stop()
        {
            TmrRun.Enabled = false;  //關閉tmrRun計時器
            TmrMove.Enabled = false; //關閉tmrMove計時器
        }
        private void Form1_Load(object sender, EventArgs e)
        {
                num = 0;    //預設圖片的註標值為0
                PicRun.Image = ImgRun.Images[num];
                PicRun.SizeMode = PictureBoxSizeMode.StretchImage;//圖片調成和控制項同大小
                TmrRun.Interval = 200;  //tmrRun間隔為0.2秒
                TmrMove.Interval = 200; //tmrMove間隔為0.2秒
        }
        //在tmrRun_Tick事件中輪流播放8張圖片
        private void TmrRun_Tick(object sender, EventArgs e)
        {
            if (direction == 0)
            {
                if (num >= 4 && num <= 7)
                {
                    num++;
                }
                if (num < 4 || num > 7)
                {
                    num = 4;
                }
            }
            if (direction == 1)
            {
                if(num >= 0 && num <=3)
                {
                    num++;
                }
                if(num > 3)
                {
                    num = 0;
                }
            }
            PicRun.Image = ImgRun.Images[num];  // 顯示第num張圖
        }
        private void TmrMove_Tick(object sender, EventArgs e)
        {
            if(PicRun.Left >= 200)
            {
                direction = 1;
            }
            if (PicRun.Left <= 10)
            {
                direction = 0;
            }
            if (direction == 0 && PicRun.Left <= 200)
            {
                PicRun.Left += 10;//picRun右移10點
            }
            if (direction == 1 && PicRun.Left >= 10)
            {
                PicRun.Left -= 10;//picRun左移10點
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == "暫停")
            {
                button1.Text = "繼續跑步";
                stop();
            }
            else
            {
                button1.Text = "暫停";
                run();
            }
        }
        private void PicRun_MouseDown(object sender, MouseEventArgs e)
        {
            picX = PicRun.Location.X;
            label1.Location = new Point(picX, picY);
            label1.Text = "放開,矬蛋!";
            stop();
        }
        private void PicRun_MouseUp(object sender, MouseEventArgs e)
        {
            label1.Text = "";
            run();
        }
        private void PicRun_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (direction ==1)
            {
                direction = 0;
            }
            else
            {
                direction = 1;
            }
        }
    }
}
