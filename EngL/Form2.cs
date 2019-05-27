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
    public partial class Form2 : Form
    {

        LearningSystem learningsystem;

        public Form2()
        {
            InitializeComponent();
            
        }
        public Form2(LearningSystem ls)
        {
            InitializeComponent();
            learningsystem = ls;
            label1.BackColor = Color.Transparent;
            label2.BackColor = Color.Transparent;
            label2level.BackColor = Color.Transparent;
            label3.BackColor = Color.Transparent;
            labellevel.BackColor = Color.Transparent;
            labelstudent.BackColor = Color.Transparent;
            infostudlabel.BackColor = Color.Transparent;
            themes.BackColor = Color.Transparent;
            learnthemes.BackColor = Color.Transparent;
            infostudlabel.Text = learningsystem.GetSyllabus()[0].StudentInfo.Name + " " + learningsystem.GetSyllabus()[0].StudentInfo.Surname;
            label2level.Text = learningsystem.GetSyllabus()[0].StudentInfo.Level;
            if (learningsystem.GetSyllabus()[0].GetTest().Count() != 0)
            {
                if (learningsystem.GetSyllabus()[0].GetTest()[0] == "DefaultTest")
                {
                    learn.Enabled = false;
                    learnthemes.Text = "Pass the test firstly";
                }

                else
                {
                    button1.Enabled = false;
                    string message = learningsystem.GetSyllabus()[0].GetTest().Count().ToString() + ":";
                    string thms = "";
                    for (int i = 0; i < learningsystem.GetSyllabus()[0].GetTest().Count(); i++)
                    {
                        thms += "   " + learningsystem.GetSyllabus()[0].GetTest()[i];
                        if (i != learningsystem.GetSyllabus()[0].GetTest().Count() - 1)
                            thms += ",";
                    }

                    learnthemes.Text = message + thms;

                }
            }
            else
            {
                learn.Enabled = false;
                learnthemes.Text = "0. Pass the test";
            }

            if (learningsystem.GetSyllabus()[0].StudentInfo.Level == "a1")
            {
                label2.Text = "Sorry! You need to have a2 level to use our system.";
                button1.Hide();
            }
            else
            {
                label2.Hide();
                StreamWriter sw = new StreamWriter(learningsystem.GetSyllabus()[0].StudentInfo.Surname + "_" + learningsystem.GetSyllabus()[0].StudentInfo.Name + ".txt");
                sw.WriteLine("Name: " + learningsystem.GetSyllabus()[0].StudentInfo.Name);
                sw.WriteLine("Surname: " + learningsystem.GetSyllabus()[0].StudentInfo.Surname);
                sw.WriteLine("Level: " + learningsystem.GetSyllabus()[0].StudentInfo.Level);
                sw.Close();
            }

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(learningsystem.GetSyllabus()[0].StudentInfo.Name + "   " + 
                learningsystem.GetSyllabus()[0].StudentInfo.Surname);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2level_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form3 newform3 = new Form3(learningsystem);
            newform3.Dock = DockStyle.Fill;
            newform3.ShowDialog();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            System.Environment.Exit(0);     
        }

        private void learnthemes_Click(object sender, EventArgs e)
        {

        }

        private void learn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 newform4 = new Form4(learningsystem);
            newform4.Dock = DockStyle.Fill;
            newform4.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AboutBox1 about = new AboutBox1();
            about.Show();
        }
    }
}
