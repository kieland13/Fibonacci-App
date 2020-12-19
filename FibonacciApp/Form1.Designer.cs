namespace FibonacciApp
{
    partial class AsynchronousTestForm
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
            this.startButton = new System.Windows.Forms.Button();
            this.resultsBox = new System.Windows.Forms.TextBox();
            this.callsLabel = new System.Windows.Forms.Label();
            this.numbersLabel = new System.Windows.Forms.Label();
            this.firstNmbrBox = new System.Windows.Forms.TextBox();
            this.secondNmbrBox = new System.Windows.Forms.TextBox();
            this.thirdNmbrBox = new System.Windows.Forms.TextBox();
            this.firstLabel = new System.Windows.Forms.Label();
            this.secondLabel = new System.Windows.Forms.Label();
            this.thirdLabel = new System.Windows.Forms.Label();
            this.resultsLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.clearButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(6, 211);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(504, 23);
            this.startButton.TabIndex = 0;
            this.startButton.Text = "Start Asynchronous Fibonacci Calls";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // resultsBox
            // 
            this.resultsBox.Location = new System.Drawing.Point(6, 59);
            this.resultsBox.Multiline = true;
            this.resultsBox.Name = "resultsBox";
            this.resultsBox.Size = new System.Drawing.Size(501, 269);
            this.resultsBox.TabIndex = 1;
            // 
            // callsLabel
            // 
            this.callsLabel.AutoSize = true;
            this.callsLabel.Location = new System.Drawing.Point(145, 16);
            this.callsLabel.Name = "callsLabel";
            this.callsLabel.Size = new System.Drawing.Size(217, 13);
            this.callsLabel.TabIndex = 2;
            this.callsLabel.Text = "Calls to all three numbers in seperate threads";
            // 
            // numbersLabel
            // 
            this.numbersLabel.AutoSize = true;
            this.numbersLabel.Location = new System.Drawing.Point(6, 61);
            this.numbersLabel.Name = "numbersLabel";
            this.numbersLabel.Size = new System.Drawing.Size(237, 13);
            this.numbersLabel.TabIndex = 3;
            this.numbersLabel.Text = "What three numbers would you like to calculate?";
            // 
            // firstNmbrBox
            // 
            this.firstNmbrBox.Location = new System.Drawing.Point(32, 148);
            this.firstNmbrBox.Name = "firstNmbrBox";
            this.firstNmbrBox.Size = new System.Drawing.Size(100, 20);
            this.firstNmbrBox.TabIndex = 4;
            // 
            // secondNmbrBox
            // 
            this.secondNmbrBox.Enabled = false;
            this.secondNmbrBox.Location = new System.Drawing.Point(193, 148);
            this.secondNmbrBox.Name = "secondNmbrBox";
            this.secondNmbrBox.Size = new System.Drawing.Size(100, 20);
            this.secondNmbrBox.TabIndex = 5;
            // 
            // thirdNmbrBox
            // 
            this.thirdNmbrBox.Enabled = false;
            this.thirdNmbrBox.Location = new System.Drawing.Point(366, 148);
            this.thirdNmbrBox.Name = "thirdNmbrBox";
            this.thirdNmbrBox.Size = new System.Drawing.Size(100, 20);
            this.thirdNmbrBox.TabIndex = 6;
            // 
            // firstLabel
            // 
            this.firstLabel.AutoSize = true;
            this.firstLabel.Location = new System.Drawing.Point(29, 110);
            this.firstLabel.Name = "firstLabel";
            this.firstLabel.Size = new System.Drawing.Size(97, 13);
            this.firstLabel.TabIndex = 7;
            this.firstLabel.Text = "First number(1-100)";
            // 
            // secondLabel
            // 
            this.secondLabel.AutoSize = true;
            this.secondLabel.Location = new System.Drawing.Point(190, 110);
            this.secondLabel.Name = "secondLabel";
            this.secondLabel.Size = new System.Drawing.Size(84, 13);
            this.secondLabel.TabIndex = 8;
            this.secondLabel.Text = "First Number + 1";
            // 
            // thirdLabel
            // 
            this.thirdLabel.AutoSize = true;
            this.thirdLabel.Location = new System.Drawing.Point(363, 110);
            this.thirdLabel.Name = "thirdLabel";
            this.thirdLabel.Size = new System.Drawing.Size(84, 13);
            this.thirdLabel.TabIndex = 9;
            this.thirdLabel.Text = "First Number + 2";
            // 
            // resultsLabel
            // 
            this.resultsLabel.AutoSize = true;
            this.resultsLabel.Location = new System.Drawing.Point(6, 33);
            this.resultsLabel.Name = "resultsLabel";
            this.resultsLabel.Size = new System.Drawing.Size(45, 13);
            this.resultsLabel.TabIndex = 10;
            this.resultsLabel.Text = "Results:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.startButton);
            this.groupBox1.Controls.Add(this.numbersLabel);
            this.groupBox1.Controls.Add(this.secondNmbrBox);
            this.groupBox1.Controls.Add(this.thirdNmbrBox);
            this.groupBox1.Controls.Add(this.firstNmbrBox);
            this.groupBox1.Controls.Add(this.thirdLabel);
            this.groupBox1.Controls.Add(this.secondLabel);
            this.groupBox1.Controls.Add(this.firstLabel);
            this.groupBox1.Controls.Add(this.callsLabel);
            this.groupBox1.Location = new System.Drawing.Point(58, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(516, 259);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Controls.Add(this.clearButton);
            this.groupBox2.Controls.Add(this.resultsBox);
            this.groupBox2.Controls.Add(this.resultsLabel);
            this.groupBox2.Location = new System.Drawing.Point(58, 310);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(516, 368);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(255, 23);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(252, 23);
            this.clearButton.TabIndex = 11;
            this.clearButton.Text = "Clear Top and Bottom";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // AsynchronousTestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(641, 717);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "AsynchronousTestForm";
            this.Text = "Asynchronous Test";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.TextBox resultsBox;
        private System.Windows.Forms.Label callsLabel;
        private System.Windows.Forms.Label numbersLabel;
        private System.Windows.Forms.TextBox firstNmbrBox;
        private System.Windows.Forms.TextBox secondNmbrBox;
        private System.Windows.Forms.TextBox thirdNmbrBox;
        private System.Windows.Forms.Label firstLabel;
        private System.Windows.Forms.Label secondLabel;
        private System.Windows.Forms.Label thirdLabel;
        private System.Windows.Forms.Label resultsLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button clearButton;
    }
}

