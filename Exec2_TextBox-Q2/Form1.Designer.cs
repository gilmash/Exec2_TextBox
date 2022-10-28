namespace Exec2_TextBox_Q2
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
            this.chkButton = new System.Windows.Forms.Button();
            this.enterTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // chkButton
            // 
            this.chkButton.Location = new System.Drawing.Point(460, 252);
            this.chkButton.Name = "chkButton";
            this.chkButton.Size = new System.Drawing.Size(75, 23);
            this.chkButton.TabIndex = 0;
            this.chkButton.Text = "確認結果";
            this.chkButton.UseVisualStyleBackColor = true;
            this.chkButton.Click += new System.EventHandler(this.chkButton_Click);
            // 
            // enterTextBox
            // 
            this.enterTextBox.Location = new System.Drawing.Point(205, 127);
            this.enterTextBox.Name = "enterTextBox";
            this.enterTextBox.Size = new System.Drawing.Size(183, 22);
            this.enterTextBox.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.enterTextBox);
            this.Controls.Add(this.chkButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button chkButton;
        private System.Windows.Forms.TextBox enterTextBox;
    }
}

