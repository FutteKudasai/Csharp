namespace picture_a
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
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
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
            this.components = new System.ComponentModel.Container();
            this.PicShow = new System.Windows.Forms.PictureBox();
            this.PicDemo1 = new System.Windows.Forms.PictureBox();
            this.PicDemo2 = new System.Windows.Forms.PictureBox();
            this.PicDemo3 = new System.Windows.Forms.PictureBox();
            this.PicDemo4 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnstr = new System.Windows.Forms.RadioButton();
            this.btnnor = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnup = new System.Windows.Forms.RadioButton();
            this.btnleft = new System.Windows.Forms.RadioButton();
            this.btnright = new System.Windows.Forms.RadioButton();
            this.btndown = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.PicShow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicDemo1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicDemo2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicDemo3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicDemo4)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // PicShow
            // 
            this.PicShow.Location = new System.Drawing.Point(52, 143);
            this.PicShow.Name = "PicShow";
            this.PicShow.Size = new System.Drawing.Size(250, 200);
            this.PicShow.TabIndex = 0;
            this.PicShow.TabStop = false;
            // 
            // PicDemo1
            // 
            this.PicDemo1.Location = new System.Drawing.Point(52, 89);
            this.PicDemo1.Name = "PicDemo1";
            this.PicDemo1.Size = new System.Drawing.Size(51, 40);
            this.PicDemo1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicDemo1.TabIndex = 1;
            this.PicDemo1.TabStop = false;
            this.PicDemo1.Click += new System.EventHandler(this.PicDemo1_Click);
            // 
            // PicDemo2
            // 
            this.PicDemo2.Location = new System.Drawing.Point(123, 89);
            this.PicDemo2.Name = "PicDemo2";
            this.PicDemo2.Size = new System.Drawing.Size(48, 40);
            this.PicDemo2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicDemo2.TabIndex = 2;
            this.PicDemo2.TabStop = false;
            this.PicDemo2.Click += new System.EventHandler(this.PicDemo2_Click);
            // 
            // PicDemo3
            // 
            this.PicDemo3.Location = new System.Drawing.Point(188, 89);
            this.PicDemo3.Name = "PicDemo3";
            this.PicDemo3.Size = new System.Drawing.Size(49, 40);
            this.PicDemo3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicDemo3.TabIndex = 3;
            this.PicDemo3.TabStop = false;
            this.PicDemo3.Click += new System.EventHandler(this.PicDemo3_Click);
            // 
            // PicDemo4
            // 
            this.PicDemo4.Location = new System.Drawing.Point(254, 89);
            this.PicDemo4.Name = "PicDemo4";
            this.PicDemo4.Size = new System.Drawing.Size(48, 40);
            this.PicDemo4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicDemo4.TabIndex = 4;
            this.PicDemo4.TabStop = false;
            this.PicDemo4.Click += new System.EventHandler(this.PicDemo4_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnstr);
            this.groupBox1.Controls.Add(this.btnnor);
            this.groupBox1.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox1.Location = new System.Drawing.Point(397, 67);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(276, 62);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "size mode";
            // 
            // btnstr
            // 
            this.btnstr.AutoSize = true;
            this.btnstr.Location = new System.Drawing.Point(155, 26);
            this.btnstr.Name = "btnstr";
            this.btnstr.Size = new System.Drawing.Size(74, 20);
            this.btnstr.TabIndex = 1;
            this.btnstr.Text = "strech";
            this.btnstr.UseVisualStyleBackColor = true;
            // 
            // btnnor
            // 
            this.btnnor.AutoSize = true;
            this.btnnor.Checked = true;
            this.btnnor.Location = new System.Drawing.Point(27, 26);
            this.btnnor.Name = "btnnor";
            this.btnnor.Size = new System.Drawing.Size(74, 20);
            this.btnnor.TabIndex = 0;
            this.btnnor.TabStop = true;
            this.btnnor.Text = "normal";
            this.btnnor.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnup);
            this.groupBox2.Controls.Add(this.btnleft);
            this.groupBox2.Controls.Add(this.btnright);
            this.groupBox2.Controls.Add(this.btndown);
            this.groupBox2.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox2.Location = new System.Drawing.Point(406, 183);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(249, 176);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "相片推拉顯示模式";
            // 
            // btnup
            // 
            this.btnup.AutoSize = true;
            this.btnup.Location = new System.Drawing.Point(33, 131);
            this.btnup.Name = "btnup";
            this.btnup.Size = new System.Drawing.Size(58, 20);
            this.btnup.TabIndex = 3;
            this.btnup.Text = "向上";
            this.btnup.UseVisualStyleBackColor = true;
            // 
            // btnleft
            // 
            this.btnleft.AutoSize = true;
            this.btnleft.Location = new System.Drawing.Point(32, 96);
            this.btnleft.Name = "btnleft";
            this.btnleft.Size = new System.Drawing.Size(90, 20);
            this.btnleft.TabIndex = 2;
            this.btnleft.Text = "由右向左";
            this.btnleft.UseVisualStyleBackColor = true;
            // 
            // btnright
            // 
            this.btnright.AutoSize = true;
            this.btnright.Location = new System.Drawing.Point(32, 60);
            this.btnright.Name = "btnright";
            this.btnright.Size = new System.Drawing.Size(90, 20);
            this.btnright.TabIndex = 1;
            this.btnright.Text = "由左向右";
            this.btnright.UseVisualStyleBackColor = true;
            // 
            // btndown
            // 
            this.btndown.AutoSize = true;
            this.btndown.Checked = true;
            this.btndown.Location = new System.Drawing.Point(32, 26);
            this.btndown.Name = "btndown";
            this.btndown.Size = new System.Drawing.Size(58, 20);
            this.btndown.TabIndex = 0;
            this.btndown.TabStop = true;
            this.btndown.Text = "向下";
            this.btndown.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("新細明體", 20F);
            this.button1.Location = new System.Drawing.Point(494, 370);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 51);
            this.button1.TabIndex = 7;
            this.button1.Text = "輪播";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 433);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.PicDemo4);
            this.Controls.Add(this.PicDemo3);
            this.Controls.Add(this.PicDemo2);
            this.Controls.Add(this.PicDemo1);
            this.Controls.Add(this.PicShow);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PicShow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicDemo1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicDemo2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicDemo3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicDemo4)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PicShow;
        private System.Windows.Forms.PictureBox PicDemo1;
        private System.Windows.Forms.PictureBox PicDemo2;
        private System.Windows.Forms.PictureBox PicDemo3;
        private System.Windows.Forms.PictureBox PicDemo4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton btnstr;
        private System.Windows.Forms.RadioButton btnnor;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton btnup;
        private System.Windows.Forms.RadioButton btnleft;
        private System.Windows.Forms.RadioButton btnright;
        private System.Windows.Forms.RadioButton btndown;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timer1;
    }
}

