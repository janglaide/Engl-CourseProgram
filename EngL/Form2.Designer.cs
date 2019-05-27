namespace EngL
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.label1 = new System.Windows.Forms.Label();
            this.labelstudent = new System.Windows.Forms.Label();
            this.infostudlabel = new System.Windows.Forms.Label();
            this.labellevel = new System.Windows.Forms.Label();
            this.label2level = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.themes = new System.Windows.Forms.Label();
            this.learnthemes = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.learn = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 0;
            // 
            // labelstudent
            // 
            this.labelstudent.AutoSize = true;
            this.labelstudent.Location = new System.Drawing.Point(251, 114);
            this.labelstudent.Name = "labelstudent";
            this.labelstudent.Size = new System.Drawing.Size(0, 20);
            this.labelstudent.TabIndex = 4;
            // 
            // infostudlabel
            // 
            this.infostudlabel.AutoSize = true;
            this.infostudlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.infostudlabel.Location = new System.Drawing.Point(37, 135);
            this.infostudlabel.Name = "infostudlabel";
            this.infostudlabel.Size = new System.Drawing.Size(172, 29);
            this.infostudlabel.TabIndex = 5;
            this.infostudlabel.Text = "name surname";
            // 
            // labellevel
            // 
            this.labellevel.AutoSize = true;
            this.labellevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labellevel.Location = new System.Drawing.Point(38, 188);
            this.labellevel.Name = "labellevel";
            this.labellevel.Size = new System.Drawing.Size(77, 29);
            this.labellevel.TabIndex = 6;
            this.labellevel.Text = "Level:";
            // 
            // label2level
            // 
            this.label2level.AutoSize = true;
            this.label2level.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2level.Location = new System.Drawing.Point(121, 188);
            this.label2level.Name = "label2level";
            this.label2level.Size = new System.Drawing.Size(57, 26);
            this.label2level.TabIndex = 7;
            this.label2level.Text = "level";
            this.label2level.Click += new System.EventHandler(this.label2level_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(461, 602);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 38);
            this.button2.TabIndex = 8;
            this.button2.Text = "Exit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(420, 504);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(158, 74);
            this.button1.TabIndex = 9;
            this.button1.Text = "Test";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(36, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(307, 32);
            this.label3.TabIndex = 11;
            this.label3.Text = "Student`s Information";
            // 
            // themes
            // 
            this.themes.AutoSize = true;
            this.themes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.themes.Location = new System.Drawing.Point(37, 245);
            this.themes.Name = "themes";
            this.themes.Size = new System.Drawing.Size(200, 29);
            this.themes.TabIndex = 12;
            this.themes.Text = "Themes to learn: ";
            // 
            // learnthemes
            // 
            this.learnthemes.AutoSize = true;
            this.learnthemes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.learnthemes.Location = new System.Drawing.Point(243, 247);
            this.learnthemes.Name = "learnthemes";
            this.learnthemes.Size = new System.Drawing.Size(70, 26);
            this.learnthemes.TabIndex = 13;
            this.learnthemes.Text = "label2";
            this.learnthemes.Click += new System.EventHandler(this.learnthemes_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(200, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 29);
            this.label2.TabIndex = 14;
            this.label2.Text = "label2";
            // 
            // learn
            // 
            this.learn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.learn.Location = new System.Drawing.Point(43, 312);
            this.learn.Name = "learn";
            this.learn.Size = new System.Drawing.Size(127, 51);
            this.learn.TabIndex = 15;
            this.learn.Text = "Learn";
            this.learn.UseVisualStyleBackColor = true;
            this.learn.Click += new System.EventHandler(this.learn_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(812, 649);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(108, 37);
            this.button3.TabIndex = 16;
            this.button3.Text = "About EngL";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::EngL.Properties.Resources._2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(978, 744);
            this.ControlBox = false;
            this.Controls.Add(this.button3);
            this.Controls.Add(this.learn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.learnthemes);
            this.Controls.Add(this.themes);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2level);
            this.Controls.Add(this.labellevel);
            this.Controls.Add(this.infostudlabel);
            this.Controls.Add(this.labelstudent);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EngL";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelstudent;
        private System.Windows.Forms.Label infostudlabel;
        private System.Windows.Forms.Label labellevel;
        private System.Windows.Forms.Label label2level;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label themes;
        private System.Windows.Forms.Label learnthemes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button learn;
        private System.Windows.Forms.Button button3;
    }
}