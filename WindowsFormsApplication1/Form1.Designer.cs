namespace WindowsFormsApplication1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.textBoxYahooPV = new System.Windows.Forms.TextBox();
            this.textBoxQiitaPV = new System.Windows.Forms.TextBox();
            this.textBoxSFPV = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(70, 170);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Get";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "YahooPV";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "QiitaPV";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "SFPV";
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(47, 201);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(102, 21);
            this.webBrowser1.TabIndex = 7;
            this.webBrowser1.Visible = false;
            this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
            // 
            // textBoxYahooPV
            // 
            this.textBoxYahooPV.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxYahooPV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxYahooPV.Location = new System.Drawing.Point(129, 47);
            this.textBoxYahooPV.Name = "textBoxYahooPV";
            this.textBoxYahooPV.ReadOnly = true;
            this.textBoxYahooPV.Size = new System.Drawing.Size(71, 13);
            this.textBoxYahooPV.TabIndex = 8;
            // 
            // textBoxQiitaPV
            // 
            this.textBoxQiitaPV.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxQiitaPV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxQiitaPV.Location = new System.Drawing.Point(129, 75);
            this.textBoxQiitaPV.Name = "textBoxQiitaPV";
            this.textBoxQiitaPV.ReadOnly = true;
            this.textBoxQiitaPV.Size = new System.Drawing.Size(71, 13);
            this.textBoxQiitaPV.TabIndex = 9;
            // 
            // textBoxSFPV
            // 
            this.textBoxSFPV.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxSFPV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxSFPV.Location = new System.Drawing.Point(129, 107);
            this.textBoxSFPV.Name = "textBoxSFPV";
            this.textBoxSFPV.ReadOnly = true;
            this.textBoxSFPV.Size = new System.Drawing.Size(71, 13);
            this.textBoxSFPV.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(212, 229);
            this.Controls.Add(this.textBoxSFPV);
            this.Controls.Add(this.textBoxQiitaPV);
            this.Controls.Add(this.textBoxYahooPV);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "GetPV";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.TextBox textBoxYahooPV;
        private System.Windows.Forms.TextBox textBoxQiitaPV;
        private System.Windows.Forms.TextBox textBoxSFPV;
    }
}

