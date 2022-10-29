namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.TextBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RadioButton2 = new System.Windows.Forms.RadioButton();
            this.RadioButton1 = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.RadioButton4 = new System.Windows.Forms.RadioButton();
            this.RadioButton3 = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.RadioButton6 = new System.Windows.Forms.RadioButton();
            this.RadioButton5 = new System.Windows.Forms.RadioButton();
            this.CheckBox1 = new System.Windows.Forms.CheckBox();
            this.CheckBox2 = new System.Windows.Forms.CheckBox();
            this.CheckBox3 = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 20F);
            this.label1.Location = new System.Drawing.Point(67, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "學號:";
            // 
            // TextBox1
            // 
            this.TextBox1.Font = new System.Drawing.Font("新細明體", 20F);
            this.TextBox1.Location = new System.Drawing.Point(146, 65);
            this.TextBox1.Name = "TextBox1";
            this.TextBox1.Size = new System.Drawing.Size(302, 39);
            this.TextBox1.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.groupBox1.Controls.Add(this.RadioButton2);
            this.groupBox1.Controls.Add(this.RadioButton1);
            this.groupBox1.Font = new System.Drawing.Font("新細明體", 15F);
            this.groupBox1.ForeColor = System.Drawing.Color.Red;
            this.groupBox1.Location = new System.Drawing.Point(119, 163);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(249, 117);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "必選";
            // 
            // RadioButton2
            // 
            this.RadioButton2.AutoSize = true;
            this.RadioButton2.ForeColor = System.Drawing.Color.Black;
            this.RadioButton2.Location = new System.Drawing.Point(45, 72);
            this.RadioButton2.Name = "RadioButton2";
            this.RadioButton2.Size = new System.Drawing.Size(87, 24);
            this.RadioButton2.TabIndex = 1;
            this.RadioButton2.TabStop = true;
            this.RadioButton2.Text = "夜間部";
            this.RadioButton2.UseVisualStyleBackColor = true;
            // 
            // RadioButton1
            // 
            this.RadioButton1.AutoSize = true;
            this.RadioButton1.ForeColor = System.Drawing.Color.Black;
            this.RadioButton1.Location = new System.Drawing.Point(45, 30);
            this.RadioButton1.Name = "RadioButton1";
            this.RadioButton1.Size = new System.Drawing.Size(87, 24);
            this.RadioButton1.TabIndex = 0;
            this.RadioButton1.TabStop = true;
            this.RadioButton1.Text = "日間部";
            this.RadioButton1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupBox2.Controls.Add(this.RadioButton4);
            this.groupBox2.Controls.Add(this.RadioButton3);
            this.groupBox2.Font = new System.Drawing.Font("新細明體", 15F);
            this.groupBox2.ForeColor = System.Drawing.Color.Red;
            this.groupBox2.Location = new System.Drawing.Point(462, 163);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(317, 116);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "必選";
            // 
            // RadioButton4
            // 
            this.RadioButton4.AutoSize = true;
            this.RadioButton4.ForeColor = System.Drawing.Color.Black;
            this.RadioButton4.Location = new System.Drawing.Point(71, 72);
            this.RadioButton4.Name = "RadioButton4";
            this.RadioButton4.Size = new System.Drawing.Size(192, 24);
            this.RadioButton4.TabIndex = 3;
            this.RadioButton4.TabStop = true;
            this.RadioButton4.Text = "商科($37000/$20000)";
            this.RadioButton4.UseVisualStyleBackColor = true;
            // 
            // RadioButton3
            // 
            this.RadioButton3.AutoSize = true;
            this.RadioButton3.ForeColor = System.Drawing.Color.Black;
            this.RadioButton3.Location = new System.Drawing.Point(71, 30);
            this.RadioButton3.Name = "RadioButton3";
            this.RadioButton3.Size = new System.Drawing.Size(192, 24);
            this.RadioButton3.TabIndex = 2;
            this.RadioButton3.TabStop = true;
            this.RadioButton3.Text = "工科($42000/$21000)";
            this.RadioButton3.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.groupBox3.Controls.Add(this.RadioButton6);
            this.groupBox3.Controls.Add(this.RadioButton5);
            this.groupBox3.Font = new System.Drawing.Font("新細明體", 15F);
            this.groupBox3.Location = new System.Drawing.Point(906, 157);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(284, 122);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            // 
            // RadioButton6
            // 
            this.RadioButton6.AutoSize = true;
            this.RadioButton6.ForeColor = System.Drawing.Color.Black;
            this.RadioButton6.Location = new System.Drawing.Point(28, 78);
            this.RadioButton6.Name = "RadioButton6";
            this.RadioButton6.Size = new System.Drawing.Size(139, 24);
            this.RadioButton6.TabIndex = 5;
            this.RadioButton6.TabStop = true;
            this.RadioButton6.Text = "通勤(含外宿)";
            this.RadioButton6.UseVisualStyleBackColor = true;
            // 
            // RadioButton5
            // 
            this.RadioButton5.AutoSize = true;
            this.RadioButton5.ForeColor = System.Drawing.Color.Black;
            this.RadioButton5.Location = new System.Drawing.Point(28, 30);
            this.RadioButton5.Name = "RadioButton5";
            this.RadioButton5.Size = new System.Drawing.Size(133, 24);
            this.RadioButton5.TabIndex = 4;
            this.RadioButton5.TabStop = true;
            this.RadioButton5.Text = "住校($12000)";
            this.RadioButton5.UseVisualStyleBackColor = true;
            // 
            // CheckBox1
            // 
            this.CheckBox1.AutoSize = true;
            this.CheckBox1.Font = new System.Drawing.Font("新細明體", 15F);
            this.CheckBox1.Location = new System.Drawing.Point(164, 365);
            this.CheckBox1.Name = "CheckBox1";
            this.CheckBox1.Size = new System.Drawing.Size(185, 24);
            this.CheckBox1.TabIndex = 5;
            this.CheckBox1.Text = "機車通勤費($1000)";
            this.CheckBox1.UseVisualStyleBackColor = true;
            // 
            // CheckBox2
            // 
            this.CheckBox2.AutoSize = true;
            this.CheckBox2.Font = new System.Drawing.Font("新細明體", 15F);
            this.CheckBox2.Location = new System.Drawing.Point(164, 415);
            this.CheckBox2.Name = "CheckBox2";
            this.CheckBox2.Size = new System.Drawing.Size(165, 24);
            this.CheckBox2.TabIndex = 6;
            this.CheckBox2.Text = "健身會員($1800)";
            this.CheckBox2.UseVisualStyleBackColor = true;
            // 
            // CheckBox3
            // 
            this.CheckBox3.AutoSize = true;
            this.CheckBox3.Font = new System.Drawing.Font("新細明體", 15F);
            this.CheckBox3.Location = new System.Drawing.Point(164, 466);
            this.CheckBox3.Name = "CheckBox3";
            this.CheckBox3.Size = new System.Drawing.Size(185, 24);
            this.CheckBox3.TabIndex = 7;
            this.CheckBox3.Text = "機車通勤費($1000)";
            this.CheckBox3.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 20F);
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(528, 321);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(444, 27);
            this.label2.TabIndex = 8;
            this.label2.Text = "勾選您的需求，系統將計算您的費用";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button1.Font = new System.Drawing.Font("新細明體", 15F);
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(611, 429);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(430, 97);
            this.button1.TabIndex = 9;
            this.button1.Text = "勾選完畢，請按本按鈕";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("新細明體", 20F);
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(528, 377);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 27);
            this.label3.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1414, 635);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CheckBox3);
            this.Controls.Add(this.CheckBox2);
            this.Controls.Add(this.CheckBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.TextBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TextBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton RadioButton2;
        private System.Windows.Forms.RadioButton RadioButton1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton RadioButton4;
        private System.Windows.Forms.RadioButton RadioButton3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton RadioButton6;
        private System.Windows.Forms.RadioButton RadioButton5;
        private System.Windows.Forms.CheckBox CheckBox1;
        private System.Windows.Forms.CheckBox CheckBox2;
        private System.Windows.Forms.CheckBox CheckBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
    }
}

