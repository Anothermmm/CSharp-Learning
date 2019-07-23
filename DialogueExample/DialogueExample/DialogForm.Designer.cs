namespace DialogueExample
{
    partial class DialogForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.nl = new System.Windows.Forms.Label();
            this.xm2 = new System.Windows.Forms.TextBox();
            this.nl2 = new System.Windows.Forms.TextBox();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonNO = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 10F);
            this.label1.Location = new System.Drawing.Point(33, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "姓名：";
            // 
            // nl
            // 
            this.nl.AutoSize = true;
            this.nl.Font = new System.Drawing.Font("宋体", 10F);
            this.nl.Location = new System.Drawing.Point(33, 97);
            this.nl.Name = "nl";
            this.nl.Size = new System.Drawing.Size(49, 14);
            this.nl.TabIndex = 1;
            this.nl.Text = "年龄：";
            // 
            // xm2
            // 
            this.xm2.Location = new System.Drawing.Point(88, 52);
            this.xm2.Name = "xm2";
            this.xm2.Size = new System.Drawing.Size(135, 21);
            this.xm2.TabIndex = 2;
            // 
            // nl2
            // 
            this.nl2.Location = new System.Drawing.Point(88, 95);
            this.nl2.Name = "nl2";
            this.nl2.Size = new System.Drawing.Size(135, 21);
            this.nl2.TabIndex = 3;
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(36, 177);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 4;
            this.buttonOK.Text = "确定";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // buttonNO
            // 
            this.buttonNO.Location = new System.Drawing.Point(157, 177);
            this.buttonNO.Name = "buttonNO";
            this.buttonNO.Size = new System.Drawing.Size(75, 23);
            this.buttonNO.TabIndex = 5;
            this.buttonNO.Text = "取消";
            this.buttonNO.UseVisualStyleBackColor = true;
            this.buttonNO.Click += new System.EventHandler(this.buttonNO_Click);
            // 
            // DialogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.buttonNO);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.nl2);
            this.Controls.Add(this.xm2);
            this.Controls.Add(this.nl);
            this.Controls.Add(this.label1);
            this.Name = "DialogForm";
            this.Text = "DialogForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label nl;
        private System.Windows.Forms.TextBox xm2;
        private System.Windows.Forms.TextBox nl2;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonNO;
    }
}