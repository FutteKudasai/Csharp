namespace Runner
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.PicRun = new System.Windows.Forms.PictureBox();
            this.ImgRun = new System.Windows.Forms.ImageList(this.components);
            this.TmrRun = new System.Windows.Forms.Timer(this.components);
            this.TmrMove = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PicRun)).BeginInit();
            this.SuspendLayout();
            // 
            // PicRun
            // 
            this.PicRun.Location = new System.Drawing.Point(220, 30);
            this.PicRun.Name = "PicRun";
            this.PicRun.Size = new System.Drawing.Size(45, 45);
            this.PicRun.TabIndex = 0;
            this.PicRun.TabStop = false;
            this.PicRun.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.PicRun_MouseDoubleClick);
            this.PicRun.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PicRun_MouseDown);
            this.PicRun.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PicRun_MouseUp);
            // 
            // ImgRun
            // 
            this.ImgRun.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImgRun.ImageStream")));
            this.ImgRun.TransparentColor = System.Drawing.Color.Transparent;
            this.ImgRun.Images.SetKeyName(0, "man1.gif");
            this.ImgRun.Images.SetKeyName(1, "man2.gif");
            this.ImgRun.Images.SetKeyName(2, "man3.gif");
            this.ImgRun.Images.SetKeyName(3, "man4.gif");
            this.ImgRun.Images.SetKeyName(4, "man5.gif");
            this.ImgRun.Images.SetKeyName(5, "man6.gif");
            this.ImgRun.Images.SetKeyName(6, "man7.gif");
            this.ImgRun.Images.SetKeyName(7, "man8.gif");
            // 
            // TmrRun
            // 
            this.TmrRun.Tick += new System.EventHandler(this.TmrRun_Tick);
            // 
            // TmrMove
            // 
            this.TmrMove.Tick += new System.EventHandler(this.TmrMove_Tick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(181, 110);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 39);
            this.button1.TabIndex = 1;
            this.button1.Text = "開始";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 161);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.PicRun);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PicRun)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PicRun;
        private System.Windows.Forms.ImageList ImgRun;
        private System.Windows.Forms.Timer TmrRun;
        private System.Windows.Forms.Timer TmrMove;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
    }
}

