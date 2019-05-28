namespace QRCodeTest
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
            this.PicQRCode = new System.Windows.Forms.PictureBox();
            this.BtnGenerate = new System.Windows.Forms.Button();
            this.TxtCode = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.PicQRCode)).BeginInit();
            this.SuspendLayout();
            // 
            // PicQRCode
            // 
            this.PicQRCode.Location = new System.Drawing.Point(318, 12);
            this.PicQRCode.Name = "PicQRCode";
            this.PicQRCode.Size = new System.Drawing.Size(150, 150);
            this.PicQRCode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicQRCode.TabIndex = 0;
            this.PicQRCode.TabStop = false;
            // 
            // BtnGenerate
            // 
            this.BtnGenerate.Location = new System.Drawing.Point(353, 216);
            this.BtnGenerate.Name = "BtnGenerate";
            this.BtnGenerate.Size = new System.Drawing.Size(75, 23);
            this.BtnGenerate.TabIndex = 1;
            this.BtnGenerate.Text = "生成二维码";
            this.BtnGenerate.UseVisualStyleBackColor = true;
            this.BtnGenerate.Click += new System.EventHandler(this.BtnGenerate_Click);
            // 
            // TxtCode
            // 
            this.TxtCode.Location = new System.Drawing.Point(287, 184);
            this.TxtCode.Name = "TxtCode";
            this.TxtCode.Size = new System.Drawing.Size(222, 21);
            this.TxtCode.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TxtCode);
            this.Controls.Add(this.BtnGenerate);
            this.Controls.Add(this.PicQRCode);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PicQRCode)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PicQRCode;
        private System.Windows.Forms.Button BtnGenerate;
        private System.Windows.Forms.TextBox TxtCode;
    }
}

