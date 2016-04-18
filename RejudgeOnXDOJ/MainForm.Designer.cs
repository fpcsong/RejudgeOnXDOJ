namespace RejudgeOnXDOJ
{
    partial class MainFom
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.page = new System.Windows.Forms.TextBox();
            this.startByPage = new System.Windows.Forms.Button();
            this.output = new System.Windows.Forms.TextBox();
            this.cookie = new System.Windows.Forms.TextBox();
            this.num = new System.Windows.Forms.TextBox();
            this.startByNum = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.opacity = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // page
            // 
            this.page.Location = new System.Drawing.Point(25, 64);
            this.page.Name = "page";
            this.page.Size = new System.Drawing.Size(232, 21);
            this.page.TabIndex = 1;
            // 
            // startByPage
            // 
            this.startByPage.Location = new System.Drawing.Point(316, 63);
            this.startByPage.Name = "startByPage";
            this.startByPage.Size = new System.Drawing.Size(75, 23);
            this.startByPage.TabIndex = 3;
            this.startByPage.Text = "Start";
            this.startByPage.UseVisualStyleBackColor = true;
            this.startByPage.Click += new System.EventHandler(this.startByPage_Click);
            // 
            // output
            // 
            this.output.Location = new System.Drawing.Point(25, 129);
            this.output.Multiline = true;
            this.output.Name = "output";
            this.output.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.output.Size = new System.Drawing.Size(366, 109);
            this.output.TabIndex = 2;
            // 
            // cookie
            // 
            this.cookie.Location = new System.Drawing.Point(25, 23);
            this.cookie.Name = "cookie";
            this.cookie.Size = new System.Drawing.Size(232, 21);
            this.cookie.TabIndex = 0;
            // 
            // num
            // 
            this.num.Location = new System.Drawing.Point(25, 102);
            this.num.Name = "num";
            this.num.Size = new System.Drawing.Size(232, 21);
            this.num.TabIndex = 2;
            // 
            // startByNum
            // 
            this.startByNum.Location = new System.Drawing.Point(316, 100);
            this.startByNum.Name = "startByNum";
            this.startByNum.Size = new System.Drawing.Size(75, 23);
            this.startByNum.TabIndex = 4;
            this.startByNum.Text = "Start";
            this.startByNum.UseVisualStyleBackColor = true;
            this.startByNum.Click += new System.EventHandler(this.startByNum_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 6;
            this.label1.Text = "管理员cookie";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 12);
            this.label2.TabIndex = 7;
            this.label2.Text = "比赛的某个状态页面";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 12);
            this.label3.TabIndex = 8;
            this.label3.Text = "运行编号（空格间隔）";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 9;
            this.label4.Text = "label4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(263, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 10;
            this.label5.Text = "透明度";
            // 
            // opacity
            // 
            this.opacity.Location = new System.Drawing.Point(316, 23);
            this.opacity.Name = "opacity";
            this.opacity.Size = new System.Drawing.Size(75, 21);
            this.opacity.TabIndex = 11;
            this.opacity.TextChanged += new System.EventHandler(this.opacity_TextChanged);
            // 
            // MainFom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(424, 261);
            this.Controls.Add(this.opacity);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.startByNum);
            this.Controls.Add(this.num);
            this.Controls.Add(this.cookie);
            this.Controls.Add(this.output);
            this.Controls.Add(this.startByPage);
            this.Controls.Add(this.page);
            this.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "MainFom";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "西电ACMrejudge工具";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox page;
        private System.Windows.Forms.Button startByPage;
        public System.Windows.Forms.TextBox output;
        private System.Windows.Forms.TextBox cookie;
        private System.Windows.Forms.TextBox num;
        private System.Windows.Forms.Button startByNum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox opacity;
    }
}

