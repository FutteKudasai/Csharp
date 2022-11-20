using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2022_11_17
{
    public partial class Form1 : Form
    {
        string[] books = new string[] { "三國演義", "水滸傳", "西遊記", "紅樓夢", "聊齋志異", "鏡花緣", "封神榜", "老殘遊記", "山海經", "史記", "神鵰俠侶", "笑傲江湖" };
        string[] cook = { "漢堡", "雞堡", "魚堡", "薯條", "沙拉", "雞塊", "薯餅", "可樂", "汽水", "紅茶", "咖啡", "冰淇淋" };
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            checkedListBox1.Items.AddRange(books);
            listBox1.Items.AddRange(books);
            comboBox1.Items.AddRange(cook);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkedListBox1.CheckedItems.Count + checkedListBox2.Items.Count > 5)
            {
                MessageBox.Show("最多5本");
            }
            else
            {
                for (int i = checkedListBox1.Items.Count - 1; i >= 0; i--)
                {
                    if (checkedListBox1.GetItemChecked(i) == true)
                    {
                        checkedListBox2.Items.Add(Convert.ToString(checkedListBox1.Items[i]));
                        checkedListBox1.Items.RemoveAt(i);
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = checkedListBox2.Items.Count - 1; i >= 0; i--)
            {
                if (checkedListBox2.GetItemChecked(i) == true)
                {
                    checkedListBox1.Items.Add(Convert.ToString(checkedListBox2.Items[i]));
                    checkedListBox2.Items.RemoveAt(i);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItems.Count + listBox2.Items.Count > 5)
            {
                MessageBox.Show("最多5本");
            }
            else
            {
                for (int i = listBox1.Items.Count - 1; i >= 0; i--)
                {
                    if (listBox1.GetSelected(i) == true)
                    {
                        listBox2.Items.Add(Convert.ToString(listBox1.Items[i]));
                        listBox1.Items.RemoveAt(i);
                    }
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            for (int i = listBox2.Items.Count - 1; i >= 0; i--)
            {
                if (listBox2.GetSelected(i) == true)
                {
                    listBox1.Items.Add(Convert.ToString(listBox2.Items[i]));
                    listBox2.Items.RemoveAt(i);
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            listBox3.Items.Add(Convert.ToString(comboBox1.SelectedItem));
        }

        private void button6_Click(object sender, EventArgs e)
        {
            for (int i = listBox3.Items.Count - 1; i >= 0; i--)
            {
                if (listBox3.GetSelected(i) == true)
                {
                    listBox3.Items.RemoveAt(i);
                }
            }
        }
    }
}
