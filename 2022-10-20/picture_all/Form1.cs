using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace picture_a
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int w, h, i=0;
        private void Form1_Load(object sender, EventArgs e)
        {
            PicDemo1.Image = new Bitmap("pic1.jpg");    //小圖框載入圖檔
            PicDemo2.Image = new Bitmap("pic2.jpg");
            PicDemo3.Image = new Bitmap("pic3.jpg");
            PicDemo4.Image = new Bitmap("pic4.jpg");
            PicShow.Image = PicDemo1.Image; //大圖框預設顯示的圖形
        }

        private void Stretch()
        {
            if (btnnor.Checked == true)                 // 大圖框的size mode
            {
                PicShow.SizeMode = PictureBoxSizeMode.Normal;
            }
            else
            {
                PicShow.SizeMode = PictureBoxSizeMode.StretchImage;
            }

            if (btndown.Checked == true)               // 大圖框相片推拉顯示模式
            {
                for ( h = 20; h <= 200; h += 10)     //圖片高度由20到200，間距為10
                {
                    PicShow.Size = new Size(250, h);    //重設大小，
                    PicShow.Location = new Point(52, 143);    //大圖框左上角固定在(52, 143)位置
                    timewindow();                  //暫停
                }
            }

            else if (btnright.Checked == true)
            {
                for (w = 20; w <= 250; w += 10)     //圖片寬度由20增加到250，間距為10
                {
                    PicShow.Size = new Size(w, 200);    //   
                    PicShow.Location = new Point(52, 143);    //  大圖框左上角固定在(52, 143)位置 
                    timewindow();
                }
            }
            else if (btnleft.Checked == true)
            {
                for (w = 20; w <= 250; w += 10)     //圖片寬度由20增加到250，間距為10
                {
                    PicShow.Size = new Size(w, 200);    // 圖片寬度由20增加到250，間距為10
                    PicShow.Location = new Point(52 + 250 - w, 143);    //大圖框左上角由(282, 143)向左移動到(43,143)
                    timewindow();
                }

            }
            else
            {
                for (h = 20; h <= 200; h += 10)     //圖片高度由0到200，間距為10
                {
                    PicShow.Size = new Size(250, h);    //重設大小
                    PicShow.Location = new Point(53, 343 - h);  //大圖框左上角由(53, 323)向上移動到(43,143)
                    timewindow();
                }
            }
        }

        private void timewindow()
        {
            DateTime now = DateTime.Now;        //now記錄目前時間
            do     //時間間隔 < 0.1秒
            {
                Application.DoEvents();         //處理其他事件
            } while ((DateTime.Now - now).TotalSeconds < 0.5);   //檢查是否已超過0.1秒
        }

        private void PicDemo1_Click(object sender, EventArgs e)
        {
            PicShow.Image = PicDemo1.Image; //設顯示picDemo1的圖形
            Stretch();  //執行Stretch方法
        }

        private void PicDemo2_Click(object sender, EventArgs e)
        {
            PicShow.Image = PicDemo2.Image; //設顯示picDemo2的圖形
            Stretch();  //執行Stretch方法
        }

        private void PicDemo3_Click(object sender, EventArgs e)
        {
            PicShow.Image = PicDemo3.Image; //設顯示picDemo3的圖形
            Stretch();  //執行Stretch方法
        }

        private void PicDemo4_Click(object sender, EventArgs e)
        {
            PicShow.Image = PicDemo4.Image; //設顯示picDemo4的圖形
            Stretch();  //執行Stretch方法
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == "輪播")
            {
                button1.Text = "停播";
                while (button1.Text == "停播")
                {
                    timewindow();
                    i++;
                    if (i == 1)
                    {
                        PicShow.Image = PicDemo1.Image;
                    }
                    if (i == 2)
                    {
                        PicShow.Image = PicDemo2.Image;
                    }
                    if (i == 3)
                    {
                        PicShow.Image = PicDemo3.Image;
                    }
                    if (i == 4)
                    {
                        PicShow.Image = PicDemo4.Image;
                        i = 0;
                    }
                }
            }
            if (button1.Text == "停播")
            {
                button1.Text = "輪播";
            }
        }

        private void button1_UP(object sender, KeyEventArgs e)
        {

        }
    }
}
