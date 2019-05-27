namespace EngL
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.ReadFileRTB = new System.Windows.Forms.RichTextBox();
            this.showButton = new System.Windows.Forms.Button();
            this.practiceButton = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ReadFileRTB
            // 
            this.ReadFileRTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ReadFileRTB.Location = new System.Drawing.Point(39, 32);
            this.ReadFileRTB.Name = "ReadFileRTB";
            this.ReadFileRTB.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.ReadFileRTB.Size = new System.Drawing.Size(895, 590);
            this.ReadFileRTB.TabIndex = 0;
            this.ReadFileRTB.Text = "";
            this.ReadFileRTB.TextChanged += new System.EventHandler(this.ReadFileRTB_TextChanged);
            // 
            // showButton
            // 
            this.showButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.showButton.Location = new System.Drawing.Point(89, 628);
            this.showButton.Name = "showButton";
            this.showButton.Size = new System.Drawing.Size(173, 52);
            this.showButton.TabIndex = 1;
            this.showButton.Text = "Show theory";
            this.showButton.UseVisualStyleBackColor = true;
            this.showButton.Click += new System.EventHandler(this.showButton_Click);
            // 
            // practiceButton
            // 
            this.practiceButton.Enabled = false;
            this.practiceButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.practiceButton.Location = new System.Drawing.Point(731, 628);
            this.practiceButton.Name = "practiceButton";
            this.practiceButton.Size = new System.Drawing.Size(165, 52);
            this.practiceButton.TabIndex = 4;
            this.practiceButton.Text = "Practice";
            this.practiceButton.UseVisualStyleBackColor = true;
            this.practiceButton.Click += new System.EventHandler(this.practiceButton_Click);
            // 
            // exit
            // 
            this.exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exit.Location = new System.Drawing.Point(390, 631);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(199, 49);
            this.exit.TabIndex = 30;
            this.exit.Text = "Return to results";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::EngL.Properties.Resources._2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(978, 744);
            this.ControlBox = false;
            this.Controls.Add(this.exit);
            this.Controls.Add(this.practiceButton);
            this.Controls.Add(this.showButton);
            this.Controls.Add(this.ReadFileRTB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EngL";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox ReadFileRTB;
        private System.Windows.Forms.Button showButton;
        private System.Windows.Forms.Button practiceButton;
        private System.Windows.Forms.Button exit;
    }
}