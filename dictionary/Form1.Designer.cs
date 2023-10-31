namespace dictionary
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
            this.addEnLabel = new System.Windows.Forms.Label();
            this.addEnTextBox = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.InquireTextBox = new System.Windows.Forms.TextBox();
            this.InquireLabel = new System.Windows.Forms.Label();
            this.InquireButton = new System.Windows.Forms.Button();
            this.ansTextBox = new System.Windows.Forms.TextBox();
            this.ansLabel = new System.Windows.Forms.Label();
            this.addChTextBox = new System.Windows.Forms.TextBox();
            this.addChLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // addEnLabel
            // 
            this.addEnLabel.AutoSize = true;
            this.addEnLabel.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.addEnLabel.Location = new System.Drawing.Point(12, 15);
            this.addEnLabel.Name = "addEnLabel";
            this.addEnLabel.Size = new System.Drawing.Size(107, 16);
            this.addEnLabel.TabIndex = 0;
            this.addEnLabel.Text = "新增英文單字:";
            // 
            // addEnTextBox
            // 
            this.addEnTextBox.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.addEnTextBox.Location = new System.Drawing.Point(125, 12);
            this.addEnTextBox.Name = "addEnTextBox";
            this.addEnTextBox.Size = new System.Drawing.Size(139, 27);
            this.addEnTextBox.TabIndex = 1;
            // 
            // addButton
            // 
            this.addButton.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.addButton.Location = new System.Drawing.Point(270, 27);
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
            this.InquireTextBox.Location = new System.Drawing.Point(93, 130);
            this.InquireTextBox.Name = "InquireTextBox";
            this.InquireTextBox.Size = new System.Drawing.Size(139, 27);
            this.InquireTextBox.TabIndex = 6;
            // 
            // InquireLabel
            // 
            this.InquireLabel.AutoSize = true;
            this.InquireLabel.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.InquireLabel.Location = new System.Drawing.Point(12, 133);
            this.InquireLabel.Name = "InquireLabel";
            this.InquireLabel.Size = new System.Drawing.Size(75, 16);
            this.InquireLabel.TabIndex = 5;
            this.InquireLabel.Text = "查詢單字:";
            // 
            // InquireButton
            // 
            this.InquireButton.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.InquireButton.Location = new System.Drawing.Point(238, 130);
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
            this.ansTextBox.Location = new System.Drawing.Point(15, 190);
            this.ansTextBox.Name = "ansTextBox";
            this.ansTextBox.Size = new System.Drawing.Size(291, 27);
            this.ansTextBox.TabIndex = 8;
            // 
            // ansLabel
            // 
            this.ansLabel.AutoSize = true;
            this.ansLabel.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ansLabel.Location = new System.Drawing.Point(12, 166);
            this.ansLabel.Name = "ansLabel";
            this.ansLabel.Size = new System.Drawing.Size(75, 16);
            this.ansLabel.TabIndex = 9;
            this.ansLabel.Text = "查詢結果:";
            // 
            // addChTextBox
            // 
            this.addChTextBox.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.addChTextBox.Location = new System.Drawing.Point(125, 45);
            this.addChTextBox.Name = "addChTextBox";
            this.addChTextBox.Size = new System.Drawing.Size(139, 27);
            this.addChTextBox.TabIndex = 10;
            // 
            // addChLabel
            // 
            this.addChLabel.AutoSize = true;
            this.addChLabel.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.addChLabel.Location = new System.Drawing.Point(12, 48);
            this.addChLabel.Name = "addChLabel";
            this.addChLabel.Size = new System.Drawing.Size(107, 16);
            this.addChLabel.TabIndex = 11;
            this.addChLabel.Text = "新增中文說明:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.addChLabel);
            this.Controls.Add(this.addChTextBox);
            this.Controls.Add(this.ansLabel);
            this.Controls.Add(this.ansTextBox);
            this.Controls.Add(this.InquireButton);
            this.Controls.Add(this.InquireTextBox);
            this.Controls.Add(this.InquireLabel);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.addEnTextBox);
            this.Controls.Add(this.addEnLabel);
            this.Name = "Form1";
            this.Text = "字典";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label addEnLabel;
        private System.Windows.Forms.TextBox addEnTextBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.TextBox InquireTextBox;
        private System.Windows.Forms.Label InquireLabel;
        private System.Windows.Forms.Button InquireButton;
        private System.Windows.Forms.TextBox ansTextBox;
        private System.Windows.Forms.Label ansLabel;
        private System.Windows.Forms.TextBox addChTextBox;
        private System.Windows.Forms.Label addChLabel;
    }
}

