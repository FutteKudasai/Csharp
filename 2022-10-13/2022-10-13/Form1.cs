using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2022_10_13
{
    public partial class Form1 : Form
    {
        int student_number_int, i, j;
        string student_number_string, result, add, number, ITC, history, geography;

        private void check()
        {
            DialogResult myResult = MessageBox.Show(result, "這是成績表?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (myResult == DialogResult.Yes)
            {
                label1.Text = result;
            }
            else
            {
                calculate();
            }
        }

        private void calculate()
        {
            result = "座號    計概  歷史  地理\n";
            student_number_string = Microsoft.VisualBasic.Interaction.InputBox("學生人數", "成績輸入");
            student_number_int = Convert.ToInt32(student_number_string);
            for (i = 1; i <= student_number_int; i++)
            {
                ITC = Microsoft.VisualBasic.Interaction.InputBox("請輸入計概分數", i + "號學生");
                if(ITC == "q")
                {
                    this.Close();
                }
                history = Microsoft.VisualBasic.Interaction.InputBox("請輸入歷史分數", i + "號學生");
                if (history == "q")
                {
                    this.Close();
                }
                geography = Microsoft.VisualBasic.Interaction.InputBox("請輸入地理分數", i + "號學生");
                if (geography == "q")
                {
                    this.Close();
                }
                number = Convert.ToString(i);
                add = "座號" + number + "    " + ITC + "     " + history + "     " + geography + "\n";
                result += add;
            }
            check();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Q)
            {
                //this.Close();
                System.Environment.Exit(0);
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            calculate();
        }
    }
}
