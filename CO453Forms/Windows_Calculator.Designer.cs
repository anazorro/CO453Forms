namespace CO453Forms
{
    partial class Windows_Calculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Windows_Calculator));
            this.displayTextBox = new System.Windows.Forms.TextBox();
            this.buttonNumber7 = new System.Windows.Forms.Button();
            this.buttonNumber8 = new System.Windows.Forms.Button();
            this.buttonNumber9 = new System.Windows.Forms.Button();
            this.divideButton = new System.Windows.Forms.Button();
            this.multiplyButton = new System.Windows.Forms.Button();
            this.buttonNumber6 = new System.Windows.Forms.Button();
            this.buttonNumber5 = new System.Windows.Forms.Button();
            this.buttonNumber4 = new System.Windows.Forms.Button();
            this.subtractButton = new System.Windows.Forms.Button();
            this.buttonNumber3 = new System.Windows.Forms.Button();
            this.buttonNumber2 = new System.Windows.Forms.Button();
            this.buttonNumber1 = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.equalToButton = new System.Windows.Forms.Button();
            this.toClearButton = new System.Windows.Forms.Button();
            this.buttonNumber0 = new System.Windows.Forms.Button();
            this.operationLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // displayTextBox
            // 
            this.displayTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayTextBox.Location = new System.Drawing.Point(59, 58);
            this.displayTextBox.Name = "displayTextBox";
            this.displayTextBox.Size = new System.Drawing.Size(266, 44);
            this.displayTextBox.TabIndex = 0;
            this.displayTextBox.Text = "0";
            this.displayTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // buttonNumber7
            // 
            this.buttonNumber7.BackColor = System.Drawing.Color.Plum;
            this.buttonNumber7.Location = new System.Drawing.Point(59, 117);
            this.buttonNumber7.Name = "buttonNumber7";
            this.buttonNumber7.Size = new System.Drawing.Size(62, 40);
            this.buttonNumber7.TabIndex = 1;
            this.buttonNumber7.Text = "7";
            this.buttonNumber7.UseVisualStyleBackColor = false;
            this.buttonNumber7.Click += new System.EventHandler(this.NumberButtons);
            // 
            // buttonNumber8
            // 
            this.buttonNumber8.BackColor = System.Drawing.Color.Plum;
            this.buttonNumber8.Location = new System.Drawing.Point(127, 117);
            this.buttonNumber8.Name = "buttonNumber8";
            this.buttonNumber8.Size = new System.Drawing.Size(62, 40);
            this.buttonNumber8.TabIndex = 2;
            this.buttonNumber8.Text = "8";
            this.buttonNumber8.UseVisualStyleBackColor = false;
            this.buttonNumber8.Click += new System.EventHandler(this.NumberButtons);
            // 
            // buttonNumber9
            // 
            this.buttonNumber9.BackColor = System.Drawing.Color.Plum;
            this.buttonNumber9.Location = new System.Drawing.Point(195, 117);
            this.buttonNumber9.Name = "buttonNumber9";
            this.buttonNumber9.Size = new System.Drawing.Size(62, 40);
            this.buttonNumber9.TabIndex = 3;
            this.buttonNumber9.Text = "9";
            this.buttonNumber9.UseVisualStyleBackColor = false;
            this.buttonNumber9.Click += new System.EventHandler(this.NumberButtons);
            // 
            // divideButton
            // 
            this.divideButton.BackColor = System.Drawing.Color.Plum;
            this.divideButton.Location = new System.Drawing.Point(263, 117);
            this.divideButton.Name = "divideButton";
            this.divideButton.Size = new System.Drawing.Size(62, 40);
            this.divideButton.TabIndex = 4;
            this.divideButton.Text = "/";
            this.divideButton.UseVisualStyleBackColor = false;
            this.divideButton.Click += new System.EventHandler(this.OperatorButtons);
            // 
            // multiplyButton
            // 
            this.multiplyButton.BackColor = System.Drawing.Color.Plum;
            this.multiplyButton.Location = new System.Drawing.Point(263, 163);
            this.multiplyButton.Name = "multiplyButton";
            this.multiplyButton.Size = new System.Drawing.Size(62, 40);
            this.multiplyButton.TabIndex = 8;
            this.multiplyButton.Text = "*";
            this.multiplyButton.UseVisualStyleBackColor = false;
            this.multiplyButton.Click += new System.EventHandler(this.OperatorButtons);
            // 
            // buttonNumber6
            // 
            this.buttonNumber6.BackColor = System.Drawing.Color.Plum;
            this.buttonNumber6.Location = new System.Drawing.Point(195, 163);
            this.buttonNumber6.Name = "buttonNumber6";
            this.buttonNumber6.Size = new System.Drawing.Size(62, 40);
            this.buttonNumber6.TabIndex = 7;
            this.buttonNumber6.Text = "6";
            this.buttonNumber6.UseVisualStyleBackColor = false;
            this.buttonNumber6.Click += new System.EventHandler(this.NumberButtons);
            // 
            // buttonNumber5
            // 
            this.buttonNumber5.BackColor = System.Drawing.Color.Plum;
            this.buttonNumber5.Location = new System.Drawing.Point(127, 163);
            this.buttonNumber5.Name = "buttonNumber5";
            this.buttonNumber5.Size = new System.Drawing.Size(62, 40);
            this.buttonNumber5.TabIndex = 6;
            this.buttonNumber5.Text = "5";
            this.buttonNumber5.UseVisualStyleBackColor = false;
            this.buttonNumber5.Click += new System.EventHandler(this.NumberButtons);
            // 
            // buttonNumber4
            // 
            this.buttonNumber4.BackColor = System.Drawing.Color.Plum;
            this.buttonNumber4.Location = new System.Drawing.Point(59, 163);
            this.buttonNumber4.Name = "buttonNumber4";
            this.buttonNumber4.Size = new System.Drawing.Size(62, 40);
            this.buttonNumber4.TabIndex = 5;
            this.buttonNumber4.Text = "4";
            this.buttonNumber4.UseVisualStyleBackColor = false;
            this.buttonNumber4.Click += new System.EventHandler(this.NumberButtons);
            // 
            // subtractButton
            // 
            this.subtractButton.BackColor = System.Drawing.Color.Plum;
            this.subtractButton.Location = new System.Drawing.Point(263, 209);
            this.subtractButton.Name = "subtractButton";
            this.subtractButton.Size = new System.Drawing.Size(62, 40);
            this.subtractButton.TabIndex = 12;
            this.subtractButton.Text = "-";
            this.subtractButton.UseVisualStyleBackColor = false;
            this.subtractButton.Click += new System.EventHandler(this.OperatorButtons);
            // 
            // buttonNumber3
            // 
            this.buttonNumber3.BackColor = System.Drawing.Color.Plum;
            this.buttonNumber3.Location = new System.Drawing.Point(195, 209);
            this.buttonNumber3.Name = "buttonNumber3";
            this.buttonNumber3.Size = new System.Drawing.Size(62, 40);
            this.buttonNumber3.TabIndex = 11;
            this.buttonNumber3.Text = "3";
            this.buttonNumber3.UseVisualStyleBackColor = false;
            this.buttonNumber3.Click += new System.EventHandler(this.NumberButtons);
            // 
            // buttonNumber2
            // 
            this.buttonNumber2.BackColor = System.Drawing.Color.Plum;
            this.buttonNumber2.Location = new System.Drawing.Point(127, 209);
            this.buttonNumber2.Name = "buttonNumber2";
            this.buttonNumber2.Size = new System.Drawing.Size(62, 40);
            this.buttonNumber2.TabIndex = 10;
            this.buttonNumber2.Text = "2";
            this.buttonNumber2.UseVisualStyleBackColor = false;
            this.buttonNumber2.Click += new System.EventHandler(this.NumberButtons);
            // 
            // buttonNumber1
            // 
            this.buttonNumber1.BackColor = System.Drawing.Color.Plum;
            this.buttonNumber1.Location = new System.Drawing.Point(59, 209);
            this.buttonNumber1.Name = "buttonNumber1";
            this.buttonNumber1.Size = new System.Drawing.Size(62, 40);
            this.buttonNumber1.TabIndex = 9;
            this.buttonNumber1.Text = "1";
            this.buttonNumber1.UseVisualStyleBackColor = false;
            this.buttonNumber1.Click += new System.EventHandler(this.NumberButtons);
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.Plum;
            this.addButton.Location = new System.Drawing.Point(263, 255);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(62, 40);
            this.addButton.TabIndex = 16;
            this.addButton.Text = "+";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.OperatorButtons);
            // 
            // equalToButton
            // 
            this.equalToButton.BackColor = System.Drawing.Color.Plum;
            this.equalToButton.Location = new System.Drawing.Point(195, 255);
            this.equalToButton.Name = "equalToButton";
            this.equalToButton.Size = new System.Drawing.Size(62, 40);
            this.equalToButton.TabIndex = 15;
            this.equalToButton.Text = "=";
            this.equalToButton.UseVisualStyleBackColor = false;
            this.equalToButton.Click += new System.EventHandler(this.EqualTo);
            // 
            // toClearButton
            // 
            this.toClearButton.BackColor = System.Drawing.Color.Plum;
            this.toClearButton.Location = new System.Drawing.Point(127, 255);
            this.toClearButton.Name = "toClearButton";
            this.toClearButton.Size = new System.Drawing.Size(62, 40);
            this.toClearButton.TabIndex = 14;
            this.toClearButton.Text = "C";
            this.toClearButton.UseVisualStyleBackColor = false;
            this.toClearButton.Click += new System.EventHandler(this.ClearButton);
            // 
            // buttonNumber0
            // 
            this.buttonNumber0.BackColor = System.Drawing.Color.Plum;
            this.buttonNumber0.Location = new System.Drawing.Point(59, 255);
            this.buttonNumber0.Name = "buttonNumber0";
            this.buttonNumber0.Size = new System.Drawing.Size(62, 40);
            this.buttonNumber0.TabIndex = 13;
            this.buttonNumber0.Text = "0";
            this.buttonNumber0.UseVisualStyleBackColor = false;
            this.buttonNumber0.Click += new System.EventHandler(this.NumberButtons);
            // 
            // operationLabel
            // 
            this.operationLabel.AutoSize = true;
            this.operationLabel.BackColor = System.Drawing.SystemColors.Window;
            this.operationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.operationLabel.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.operationLabel.Location = new System.Drawing.Point(63, 29);
            this.operationLabel.Name = "operationLabel";
            this.operationLabel.Size = new System.Drawing.Size(0, 25);
            this.operationLabel.TabIndex = 17;
            // 
            // Windows_Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orchid;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.operationLabel);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.equalToButton);
            this.Controls.Add(this.toClearButton);
            this.Controls.Add(this.buttonNumber0);
            this.Controls.Add(this.subtractButton);
            this.Controls.Add(this.buttonNumber3);
            this.Controls.Add(this.buttonNumber2);
            this.Controls.Add(this.buttonNumber1);
            this.Controls.Add(this.multiplyButton);
            this.Controls.Add(this.buttonNumber6);
            this.Controls.Add(this.buttonNumber5);
            this.Controls.Add(this.buttonNumber4);
            this.Controls.Add(this.divideButton);
            this.Controls.Add(this.buttonNumber9);
            this.Controls.Add(this.buttonNumber8);
            this.Controls.Add(this.buttonNumber7);
            this.Controls.Add(this.displayTextBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "Windows_Calculator";
            this.Text = "Windows_Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox displayTextBox;
        private System.Windows.Forms.Button buttonNumber7;
        private System.Windows.Forms.Button buttonNumber8;
        private System.Windows.Forms.Button buttonNumber9;
        private System.Windows.Forms.Button divideButton;
        private System.Windows.Forms.Button multiplyButton;
        private System.Windows.Forms.Button buttonNumber6;
        private System.Windows.Forms.Button buttonNumber5;
        private System.Windows.Forms.Button buttonNumber4;
        private System.Windows.Forms.Button subtractButton;
        private System.Windows.Forms.Button buttonNumber3;
        private System.Windows.Forms.Button buttonNumber2;
        private System.Windows.Forms.Button buttonNumber1;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button equalToButton;
        private System.Windows.Forms.Button toClearButton;
        private System.Windows.Forms.Button buttonNumber0;
        private System.Windows.Forms.Label operationLabel;
    }
}