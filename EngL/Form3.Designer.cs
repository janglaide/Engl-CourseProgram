﻿namespace EngL
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.label1 = new System.Windows.Forms.Label();
            this.ReadFileRTB = new System.Windows.Forms.RichTextBox();
            this.startButton = new System.Windows.Forms.Button();
            this.q1 = new System.Windows.Forms.ComboBox();
            this.q2 = new System.Windows.Forms.ComboBox();
            this.q3 = new System.Windows.Forms.ComboBox();
            this.q4 = new System.Windows.Forms.ComboBox();
            this.q5 = new System.Windows.Forms.ComboBox();
            this.q6 = new System.Windows.Forms.ComboBox();
            this.q7 = new System.Windows.Forms.ComboBox();
            this.q8 = new System.Windows.Forms.ComboBox();
            this.q9 = new System.Windows.Forms.ComboBox();
            this.q10 = new System.Windows.Forms.ComboBox();
            this.checkButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.labelScore = new System.Windows.Forms.Label();
            this.labelYS = new System.Windows.Forms.Label();
            this.LLbutton = new System.Windows.Forms.Button();
            this.levelup = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(147, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(729, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Read the test and choose answers. You need to answer all of them.\r\n";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ReadFileRTB
            // 
            this.ReadFileRTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ReadFileRTB.Location = new System.Drawing.Point(36, 125);
            this.ReadFileRTB.Name = "ReadFileRTB";
            this.ReadFileRTB.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.ReadFileRTB.Size = new System.Drawing.Size(513, 520);
            this.ReadFileRTB.TabIndex = 1;
            this.ReadFileRTB.Text = "";
            this.ReadFileRTB.TextChanged += new System.EventHandler(this.ReadFileRTB_TextChanged);
            // 
            // startButton
            // 
            this.startButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.startButton.Location = new System.Drawing.Point(36, 75);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(115, 35);
            this.startButton.TabIndex = 2;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // q1
            // 
            this.q1.FormattingEnabled = true;
            this.q1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.q1.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.q1.Location = new System.Drawing.Point(643, 125);
            this.q1.Name = "q1";
            this.q1.Size = new System.Drawing.Size(81, 28);
            this.q1.TabIndex = 3;
            this.q1.SelectedIndexChanged += new System.EventHandler(this.q1_SelectedIndexChanged);
            // 
            // q2
            // 
            this.q2.FormattingEnabled = true;
            this.q2.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.q2.Location = new System.Drawing.Point(643, 189);
            this.q2.Name = "q2";
            this.q2.Size = new System.Drawing.Size(81, 28);
            this.q2.TabIndex = 4;
            // 
            // q3
            // 
            this.q3.FormattingEnabled = true;
            this.q3.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.q3.Location = new System.Drawing.Point(643, 250);
            this.q3.Name = "q3";
            this.q3.Size = new System.Drawing.Size(81, 28);
            this.q3.TabIndex = 5;
            // 
            // q4
            // 
            this.q4.FormattingEnabled = true;
            this.q4.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.q4.Location = new System.Drawing.Point(643, 311);
            this.q4.Name = "q4";
            this.q4.Size = new System.Drawing.Size(81, 28);
            this.q4.TabIndex = 6;
            this.q4.SelectedIndexChanged += new System.EventHandler(this.q4_SelectedIndexChanged);
            // 
            // q5
            // 
            this.q5.FormattingEnabled = true;
            this.q5.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.q5.Location = new System.Drawing.Point(643, 370);
            this.q5.Name = "q5";
            this.q5.Size = new System.Drawing.Size(81, 28);
            this.q5.TabIndex = 7;
            // 
            // q6
            // 
            this.q6.FormattingEnabled = true;
            this.q6.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.q6.Location = new System.Drawing.Point(829, 125);
            this.q6.Name = "q6";
            this.q6.Size = new System.Drawing.Size(81, 28);
            this.q6.TabIndex = 8;
            // 
            // q7
            // 
            this.q7.FormattingEnabled = true;
            this.q7.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.q7.Location = new System.Drawing.Point(829, 189);
            this.q7.Name = "q7";
            this.q7.Size = new System.Drawing.Size(80, 28);
            this.q7.TabIndex = 9;
            // 
            // q8
            // 
            this.q8.FormattingEnabled = true;
            this.q8.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.q8.Location = new System.Drawing.Point(830, 250);
            this.q8.Name = "q8";
            this.q8.Size = new System.Drawing.Size(80, 28);
            this.q8.TabIndex = 10;
            // 
            // q9
            // 
            this.q9.FormattingEnabled = true;
            this.q9.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.q9.Location = new System.Drawing.Point(830, 311);
            this.q9.Name = "q9";
            this.q9.Size = new System.Drawing.Size(80, 28);
            this.q9.TabIndex = 11;
            // 
            // q10
            // 
            this.q10.FormattingEnabled = true;
            this.q10.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.q10.Location = new System.Drawing.Point(830, 370);
            this.q10.Name = "q10";
            this.q10.Size = new System.Drawing.Size(80, 28);
            this.q10.TabIndex = 12;
            // 
            // checkButton
            // 
            this.checkButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkButton.Location = new System.Drawing.Point(706, 435);
            this.checkButton.Name = "checkButton";
            this.checkButton.Size = new System.Drawing.Size(132, 70);
            this.checkButton.TabIndex = 13;
            this.checkButton.Text = "Check";
            this.checkButton.UseVisualStyleBackColor = true;
            this.checkButton.Click += new System.EventHandler(this.checkButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(615, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "1.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(615, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = "2.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(615, 258);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 20);
            this.label4.TabIndex = 16;
            this.label4.Text = "3.";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(615, 319);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(22, 20);
            this.label5.TabIndex = 17;
            this.label5.Text = "4.";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(615, 378);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(22, 20);
            this.label6.TabIndex = 18;
            this.label6.Text = "5.";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(801, 133);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(22, 20);
            this.label7.TabIndex = 19;
            this.label7.Text = "6.";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(802, 197);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(22, 20);
            this.label8.TabIndex = 20;
            this.label8.Text = "7.";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(802, 258);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(22, 20);
            this.label9.TabIndex = 21;
            this.label9.Text = "8.";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(801, 319);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(22, 20);
            this.label10.TabIndex = 22;
            this.label10.Text = "9.";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(793, 378);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(31, 20);
            this.label11.TabIndex = 23;
            this.label11.Text = "10.";
            // 
            // labelScore
            // 
            this.labelScore.AutoSize = true;
            this.labelScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelScore.Location = new System.Drawing.Point(810, 535);
            this.labelScore.Name = "labelScore";
            this.labelScore.Size = new System.Drawing.Size(99, 29);
            this.labelScore.TabIndex = 24;
            this.labelScore.Text = "label12";
            // 
            // labelYS
            // 
            this.labelYS.AutoSize = true;
            this.labelYS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelYS.Location = new System.Drawing.Point(657, 535);
            this.labelYS.Name = "labelYS";
            this.labelYS.Size = new System.Drawing.Size(147, 29);
            this.labelYS.TabIndex = 25;
            this.labelYS.Text = "Your score:";
            // 
            // LLbutton
            // 
            this.LLbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LLbutton.Location = new System.Drawing.Point(643, 599);
            this.LLbutton.Name = "LLbutton";
            this.LLbutton.Size = new System.Drawing.Size(102, 46);
            this.LLbutton.TabIndex = 26;
            this.LLbutton.Text = "Learn";
            this.LLbutton.UseVisualStyleBackColor = true;
            this.LLbutton.Click += new System.EventHandler(this.LLbutton_Click);
            // 
            // levelup
            // 
            this.levelup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.levelup.Location = new System.Drawing.Point(791, 599);
            this.levelup.Name = "levelup";
            this.levelup.Size = new System.Drawing.Size(156, 46);
            this.levelup.TabIndex = 27;
            this.levelup.Text = "Level Up!";
            this.levelup.UseVisualStyleBackColor = true;
            this.levelup.Click += new System.EventHandler(this.levelup_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(791, 599);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 46);
            this.button1.TabIndex = 28;
            this.button1.Text = "Results";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // exit
            // 
            this.exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exit.Location = new System.Drawing.Point(173, 75);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(182, 35);
            this.exit.TabIndex = 29;
            this.exit.Text = "Return to results";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::EngL.Properties.Resources._2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(978, 744);
            this.ControlBox = false;
            this.Controls.Add(this.exit);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.levelup);
            this.Controls.Add(this.LLbutton);
            this.Controls.Add(this.labelYS);
            this.Controls.Add(this.labelScore);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.checkButton);
            this.Controls.Add(this.q10);
            this.Controls.Add(this.q9);
            this.Controls.Add(this.q8);
            this.Controls.Add(this.q7);
            this.Controls.Add(this.q6);
            this.Controls.Add(this.q5);
            this.Controls.Add(this.q4);
            this.Controls.Add(this.q3);
            this.Controls.Add(this.q2);
            this.Controls.Add(this.q1);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.ReadFileRTB);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EngL";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox ReadFileRTB;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.ComboBox q1;
        private System.Windows.Forms.ComboBox q2;
        private System.Windows.Forms.ComboBox q3;
        private System.Windows.Forms.ComboBox q4;
        private System.Windows.Forms.ComboBox q5;
        private System.Windows.Forms.ComboBox q6;
        private System.Windows.Forms.ComboBox q7;
        private System.Windows.Forms.ComboBox q8;
        private System.Windows.Forms.ComboBox q9;
        private System.Windows.Forms.ComboBox q10;
        private System.Windows.Forms.Button checkButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label labelScore;
        private System.Windows.Forms.Label labelYS;
        private System.Windows.Forms.Button LLbutton;
        private System.Windows.Forms.Button levelup;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button exit;
    }
}