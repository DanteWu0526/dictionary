namespace practise03
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
            this.addLabel = new System.Windows.Forms.Label();
            this.addTextBox = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.InquireTextBox = new System.Windows.Forms.TextBox();
            this.InquireLabel = new System.Windows.Forms.Label();
            this.InquireButton = new System.Windows.Forms.Button();
            this.ansTextBox = new System.Windows.Forms.TextBox();
            this.ansLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // addLabel
            // 
            this.addLabel.AutoSize = true;
            this.addLabel.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.addLabel.Location = new System.Drawing.Point(12, 15);
            this.addLabel.Name = "addLabel";
            this.addLabel.Size = new System.Drawing.Size(75, 16);
            this.addLabel.TabIndex = 0;
            this.addLabel.Text = "新增單字:";
            // 
            // addTextBox
            // 
            this.addTextBox.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.addTextBox.Location = new System.Drawing.Point(93, 12);
            this.addTextBox.Name = "addTextBox";
            this.addTextBox.Size = new System.Drawing.Size(139, 27);
            this.addTextBox.TabIndex = 1;
            // 
            // addButton
            // 
            this.addButton.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.addButton.Location = new System.Drawing.Point(238, 12);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(68, 27);
            this.addButton.TabIndex = 4;
            this.addButton.Text = "新增";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // InquireTextBox
            // 
            this.InquireTextBox.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.InquireTextBox.Location = new System.Drawing.Point(93, 123);
            this.InquireTextBox.Name = "InquireTextBox";
            this.InquireTextBox.Size = new System.Drawing.Size(139, 27);
            this.InquireTextBox.TabIndex = 6;
            // 
            // InquireLabel
            // 
            this.InquireLabel.AutoSize = true;
            this.InquireLabel.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.InquireLabel.Location = new System.Drawing.Point(12, 126);
            this.InquireLabel.Name = "InquireLabel";
            this.InquireLabel.Size = new System.Drawing.Size(75, 16);
            this.InquireLabel.TabIndex = 5;
            this.InquireLabel.Text = "查詢單字:";
            // 
            // InquireButton
            // 
            this.InquireButton.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.InquireButton.Location = new System.Drawing.Point(238, 123);
            this.InquireButton.Name = "InquireButton";
            this.InquireButton.Size = new System.Drawing.Size(68, 27);
            this.InquireButton.TabIndex = 7;
            this.InquireButton.Text = "查詢";
            this.InquireButton.UseVisualStyleBackColor = true;
            this.InquireButton.Click += new System.EventHandler(this.InquireButton_Click);
            // 
            // ansTextBox
            // 
            this.ansTextBox.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ansTextBox.Location = new System.Drawing.Point(15, 183);
            this.ansTextBox.Multiline = true;
            this.ansTextBox.Name = "ansTextBox";
            this.ansTextBox.Size = new System.Drawing.Size(291, 142);
            this.ansTextBox.TabIndex = 8;
            // 
            // ansLabel
            // 
            this.ansLabel.AutoSize = true;
            this.ansLabel.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ansLabel.Location = new System.Drawing.Point(12, 159);
            this.ansLabel.Name = "ansLabel";
            this.ansLabel.Size = new System.Drawing.Size(75, 16);
            this.ansLabel.TabIndex = 9;
            this.ansLabel.Text = "查詢結果:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ansLabel);
            this.Controls.Add(this.ansTextBox);
            this.Controls.Add(this.InquireButton);
            this.Controls.Add(this.InquireTextBox);
            this.Controls.Add(this.InquireLabel);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.addTextBox);
            this.Controls.Add(this.addLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label addLabel;
        private System.Windows.Forms.TextBox addTextBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.TextBox InquireTextBox;
        private System.Windows.Forms.Label InquireLabel;
        private System.Windows.Forms.Button InquireButton;
        private System.Windows.Forms.TextBox ansTextBox;
        private System.Windows.Forms.Label ansLabel;
    }
}

