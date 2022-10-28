namespace Exec2_TextBox_Q4
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
            this.resultButton = new System.Windows.Forms.Button();
            this.carTextBox = new System.Windows.Forms.TextBox();
            this.personTextBox = new System.Windows.Forms.TextBox();
            this.carResultLabel = new System.Windows.Forms.Label();
            this.personResultLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // resultButton
            // 
            this.resultButton.Location = new System.Drawing.Point(351, 261);
            this.resultButton.Name = "resultButton";
            this.resultButton.Size = new System.Drawing.Size(75, 23);
            this.resultButton.TabIndex = 0;
            this.resultButton.Text = "計算";
            this.resultButton.UseVisualStyleBackColor = true;
            this.resultButton.Click += new System.EventHandler(this.resultButton_Click);
            // 
            // carTextBox
            // 
            this.carTextBox.Location = new System.Drawing.Point(122, 103);
            this.carTextBox.MaxLength = 3;
            this.carTextBox.Name = "carTextBox";
            this.carTextBox.Size = new System.Drawing.Size(100, 22);
            this.carTextBox.TabIndex = 1;
            // 
            // personTextBox
            // 
            this.personTextBox.Location = new System.Drawing.Point(122, 155);
            this.personTextBox.MaxLength = 3;
            this.personTextBox.Name = "personTextBox";
            this.personTextBox.Size = new System.Drawing.Size(100, 22);
            this.personTextBox.TabIndex = 2;
            // 
            // carResultLabel
            // 
            this.carResultLabel.Location = new System.Drawing.Point(272, 113);
            this.carResultLabel.Name = "carResultLabel";
            this.carResultLabel.Size = new System.Drawing.Size(122, 22);
            this.carResultLabel.TabIndex = 3;
            this.carResultLabel.Text = "label1";
            this.carResultLabel.Click += new System.EventHandler(this.carResultLabel_Click);
            // 
            // personResultLabel
            // 
            this.personResultLabel.Location = new System.Drawing.Point(272, 165);
            this.personResultLabel.Name = "personResultLabel";
            this.personResultLabel.Size = new System.Drawing.Size(109, 19);
            this.personResultLabel.TabIndex = 3;
            this.personResultLabel.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "請輸入車的數量";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "請輸入人的數量";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.personResultLabel);
            this.Controls.Add(this.carResultLabel);
            this.Controls.Add(this.personTextBox);
            this.Controls.Add(this.carTextBox);
            this.Controls.Add(this.resultButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button resultButton;
        private System.Windows.Forms.TextBox carTextBox;
        private System.Windows.Forms.TextBox personTextBox;
        private System.Windows.Forms.Label carResultLabel;
        private System.Windows.Forms.Label personResultLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

