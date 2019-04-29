namespace CO453Forms
{
    partial class GameForm
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
            this.userGroupBox = new System.Windows.Forms.GroupBox();
            this.stoneRadioButton = new System.Windows.Forms.RadioButton();
            this.paperRadioButton = new System.Windows.Forms.RadioButton();
            this.scissorsRadioButton = new System.Windows.Forms.RadioButton();
            this.userPictureBox = new System.Windows.Forms.PictureBox();
            this.computerGroupBox = new System.Windows.Forms.GroupBox();
            this.playButton = new System.Windows.Forms.Button();
            this.computerPictureBox = new System.Windows.Forms.PictureBox();
            this.resultsGroupBox = new System.Windows.Forms.GroupBox();
            this.computerScoreLabel = new System.Windows.Forms.Label();
            this.userScoreLabel = new System.Windows.Forms.Label();
            this.resultsLabel = new System.Windows.Forms.Label();
            this.quitButton = new System.Windows.Forms.Button();
            this.userGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userPictureBox)).BeginInit();
            this.computerGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.computerPictureBox)).BeginInit();
            this.resultsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // userGroupBox
            // 
            this.userGroupBox.BackColor = System.Drawing.Color.MistyRose;
            this.userGroupBox.Controls.Add(this.stoneRadioButton);
            this.userGroupBox.Controls.Add(this.paperRadioButton);
            this.userGroupBox.Controls.Add(this.scissorsRadioButton);
            this.userGroupBox.Controls.Add(this.userPictureBox);
            this.userGroupBox.Location = new System.Drawing.Point(37, 15);
            this.userGroupBox.Margin = new System.Windows.Forms.Padding(6);
            this.userGroupBox.Name = "userGroupBox";
            this.userGroupBox.Padding = new System.Windows.Forms.Padding(6);
            this.userGroupBox.Size = new System.Drawing.Size(201, 338);
            this.userGroupBox.TabIndex = 0;
            this.userGroupBox.TabStop = false;
            this.userGroupBox.Text = "User Choice";
            // 
            // stoneRadioButton
            // 
            this.stoneRadioButton.AutoSize = true;
            this.stoneRadioButton.Location = new System.Drawing.Point(24, 270);
            this.stoneRadioButton.Name = "stoneRadioButton";
            this.stoneRadioButton.Size = new System.Drawing.Size(87, 30);
            this.stoneRadioButton.TabIndex = 3;
            this.stoneRadioButton.Text = "Stone";
            this.stoneRadioButton.UseVisualStyleBackColor = true;
            this.stoneRadioButton.CheckedChanged += new System.EventHandler(this.SelectStone);
            // 
            // paperRadioButton
            // 
            this.paperRadioButton.AutoSize = true;
            this.paperRadioButton.Location = new System.Drawing.Point(24, 234);
            this.paperRadioButton.Name = "paperRadioButton";
            this.paperRadioButton.Size = new System.Drawing.Size(88, 30);
            this.paperRadioButton.TabIndex = 2;
            this.paperRadioButton.Text = "Paper";
            this.paperRadioButton.UseVisualStyleBackColor = true;
            this.paperRadioButton.CheckedChanged += new System.EventHandler(this.SelectPaper);
            // 
            // scissorsRadioButton
            // 
            this.scissorsRadioButton.AutoSize = true;
            this.scissorsRadioButton.Location = new System.Drawing.Point(24, 198);
            this.scissorsRadioButton.Name = "scissorsRadioButton";
            this.scissorsRadioButton.Size = new System.Drawing.Size(113, 30);
            this.scissorsRadioButton.TabIndex = 1;
            this.scissorsRadioButton.Text = "Scissors";
            this.scissorsRadioButton.UseVisualStyleBackColor = true;
            this.scissorsRadioButton.CheckedChanged += new System.EventHandler(this.SelectScissors);
            // 
            // userPictureBox
            // 
            this.userPictureBox.Location = new System.Drawing.Point(9, 48);
            this.userPictureBox.Name = "userPictureBox";
            this.userPictureBox.Size = new System.Drawing.Size(183, 119);
            this.userPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.userPictureBox.TabIndex = 0;
            this.userPictureBox.TabStop = false;
            // 
            // computerGroupBox
            // 
            this.computerGroupBox.BackColor = System.Drawing.Color.MistyRose;
            this.computerGroupBox.Controls.Add(this.playButton);
            this.computerGroupBox.Controls.Add(this.computerPictureBox);
            this.computerGroupBox.Location = new System.Drawing.Point(250, 15);
            this.computerGroupBox.Margin = new System.Windows.Forms.Padding(6);
            this.computerGroupBox.Name = "computerGroupBox";
            this.computerGroupBox.Padding = new System.Windows.Forms.Padding(6);
            this.computerGroupBox.Size = new System.Drawing.Size(201, 338);
            this.computerGroupBox.TabIndex = 1;
            this.computerGroupBox.TabStop = false;
            this.computerGroupBox.Text = "Computer Choice";
            // 
            // playButton
            // 
            this.playButton.Enabled = false;
            this.playButton.Location = new System.Drawing.Point(44, 222);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(109, 54);
            this.playButton.TabIndex = 1;
            this.playButton.Text = "Play";
            this.playButton.UseVisualStyleBackColor = true;
            this.playButton.Click += new System.EventHandler(this.SelectComputerChoice);
            // 
            // computerPictureBox
            // 
            this.computerPictureBox.Location = new System.Drawing.Point(9, 48);
            this.computerPictureBox.Name = "computerPictureBox";
            this.computerPictureBox.Size = new System.Drawing.Size(183, 119);
            this.computerPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.computerPictureBox.TabIndex = 0;
            this.computerPictureBox.TabStop = false;
            // 
            // resultsGroupBox
            // 
            this.resultsGroupBox.BackColor = System.Drawing.Color.MistyRose;
            this.resultsGroupBox.Controls.Add(this.computerScoreLabel);
            this.resultsGroupBox.Controls.Add(this.userScoreLabel);
            this.resultsGroupBox.Controls.Add(this.resultsLabel);
            this.resultsGroupBox.Location = new System.Drawing.Point(463, 15);
            this.resultsGroupBox.Margin = new System.Windows.Forms.Padding(6);
            this.resultsGroupBox.Name = "resultsGroupBox";
            this.resultsGroupBox.Padding = new System.Windows.Forms.Padding(6);
            this.resultsGroupBox.Size = new System.Drawing.Size(201, 275);
            this.resultsGroupBox.TabIndex = 2;
            this.resultsGroupBox.TabStop = false;
            this.resultsGroupBox.Text = "Results";
            // 
            // computerScoreLabel
            // 
            this.computerScoreLabel.AutoSize = true;
            this.computerScoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.computerScoreLabel.Location = new System.Drawing.Point(21, 198);
            this.computerScoreLabel.Name = "computerScoreLabel";
            this.computerScoreLabel.Size = new System.Drawing.Size(148, 24);
            this.computerScoreLabel.TabIndex = 4;
            this.computerScoreLabel.Text = "Computer Score";
            // 
            // userScoreLabel
            // 
            this.userScoreLabel.AutoSize = true;
            this.userScoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userScoreLabel.Location = new System.Drawing.Point(21, 158);
            this.userScoreLabel.Name = "userScoreLabel";
            this.userScoreLabel.Size = new System.Drawing.Size(104, 24);
            this.userScoreLabel.TabIndex = 3;
            this.userScoreLabel.Text = "User Score";
            // 
            // resultsLabel
            // 
            this.resultsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultsLabel.Location = new System.Drawing.Point(21, 48);
            this.resultsLabel.Name = "resultsLabel";
            this.resultsLabel.Size = new System.Drawing.Size(137, 59);
            this.resultsLabel.TabIndex = 2;
            this.resultsLabel.Text = "You have won!";
            // 
            // quitButton
            // 
            this.quitButton.Location = new System.Drawing.Point(513, 299);
            this.quitButton.Name = "quitButton";
            this.quitButton.Size = new System.Drawing.Size(109, 54);
            this.quitButton.TabIndex = 1;
            this.quitButton.Text = "Quit";
            this.quitButton.UseVisualStyleBackColor = true;
            this.quitButton.Click += new System.EventHandler(this.CloseForm);
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCoral;
            this.ClientSize = new System.Drawing.Size(700, 386);
            this.Controls.Add(this.resultsGroupBox);
            this.Controls.Add(this.computerGroupBox);
            this.Controls.Add(this.userGroupBox);
            this.Controls.Add(this.quitButton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "GameForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ana\'s SPS Game";
            this.userGroupBox.ResumeLayout(false);
            this.userGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userPictureBox)).EndInit();
            this.computerGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.computerPictureBox)).EndInit();
            this.resultsGroupBox.ResumeLayout(false);
            this.resultsGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox userGroupBox;
        private System.Windows.Forms.PictureBox userPictureBox;
        private System.Windows.Forms.RadioButton stoneRadioButton;
        private System.Windows.Forms.RadioButton paperRadioButton;
        private System.Windows.Forms.RadioButton scissorsRadioButton;
        private System.Windows.Forms.GroupBox computerGroupBox;
        private System.Windows.Forms.PictureBox computerPictureBox;
        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.GroupBox resultsGroupBox;
        private System.Windows.Forms.Button quitButton;
        private System.Windows.Forms.Label resultsLabel;
        private System.Windows.Forms.Label computerScoreLabel;
        private System.Windows.Forms.Label userScoreLabel;
    }
}