namespace ThreadTest
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.but_Execute1 = new System.Windows.Forms.Button();
            this.but_Execute2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // but_Execute1
            // 
            this.but_Execute1.Location = new System.Drawing.Point(52, 254);
            this.but_Execute1.Name = "but_Execute1";
            this.but_Execute1.Size = new System.Drawing.Size(88, 32);
            this.but_Execute1.TabIndex = 0;
            this.but_Execute1.Text = "任务1";
            this.but_Execute1.UseVisualStyleBackColor = true;
            this.but_Execute1.Click += new System.EventHandler(this.but_Execute1_Click);
            // 
            // but_Execute2
            // 
            this.but_Execute2.Location = new System.Drawing.Point(224, 254);
            this.but_Execute2.Name = "but_Execute2";
            this.but_Execute2.Size = new System.Drawing.Size(88, 32);
            this.but_Execute2.TabIndex = 1;
            this.but_Execute2.Text = "任务2";
            this.but_Execute2.UseVisualStyleBackColor = true;
            this.but_Execute2.Click += new System.EventHandler(this.but_Execute2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 333);
            this.Controls.Add(this.but_Execute2);
            this.Controls.Add(this.but_Execute1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button but_Execute1;
        private System.Windows.Forms.Button but_Execute2;
    }
}

