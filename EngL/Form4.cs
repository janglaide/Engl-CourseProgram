using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace EngL
{
    public partial class Form4 : Form
    {
        LearningSystem learningsystem;
        public Form4()
        {
            InitializeComponent();
        }
        public Form4(LearningSystem ls)
        {
            InitializeComponent();
            learningsystem = ls;

        }

        private void ReadFileRTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ///////what is it??
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            int max = learningsystem.GetSyllabus()[0].GetTest().Count();
            if (learningsystem.GetSyllabus()[0].Current_th < max)
            {
                string filename_th = learningsystem.GetSyllabus()[0].GetTest()[learningsystem.GetSyllabus()[0].Current_th] + ".txt";
                StreamReader sr = new StreamReader(filename_th);
                ReadFileRTB.Text = sr.ReadToEnd();
                sr.Close();
            }
            else
            {
                showButton.Hide();
            }
            showButton.Enabled = false;
            practiceButton.Enabled = true;
        }

        private void practiceButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form5 newform5 = new Form5(learningsystem);
            newform5.Dock = DockStyle.Fill;
            newform5.ShowDialog();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 newform2 = new Form2(learningsystem);
            newform2.Dock = DockStyle.Fill;
            newform2.ShowDialog();
        }
    }
}
