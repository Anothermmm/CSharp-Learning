namespace DialogueExample
{
    partial class MainForm
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.xm = new System.Windows.Forms.TextBox();
            this.nl = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 10F);
            this.label1.Location = new System.Drawing.Point(31, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "姓名：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 14);
            this.label2.TabIndex = 1;
            this.label2.Text = "年龄：";
            // 
            // xm
            // 
            this.xm.Location = new System.Drawing.Point(86, 56);
            this.xm.Name = "xm";
            this.xm.Size = new System.Drawing.Size(179, 23);
            this.xm.TabIndex = 2;
            // 
            // nl
            // 
            this.nl.Location = new System.Drawing.Point(87, 97);
            this.nl.Name = "nl";
            this.nl.Size = new System.Drawing.Size(178, 23);
            this.nl.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(86, 180);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(178, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "从对话框中获取";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 284);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.nl);
            this.Controls.Add(this.xm);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("宋体", 10F);
            this.Name = "MainForm";
            this.Text = "对话框用法举例";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox xm;
        private System.Windows.Forms.TextBox nl;
        private System.Windows.Forms.Button button1;
    }
}

