using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EngL
{
    public partial class Form1 : Form
    {
        LearningSystem learningsystem;
        public Form1()
        {
            InitializeComponent();
            learningsystem = new LearningSystem();
            label1.BackColor = Color.Transparent;
            label2.BackColor = Color.Transparent;
            label3.BackColor = Color.Transparent;
            label4.BackColor = Color.Transparent;
        }
        System.Windows.Forms.KeyEventArgs ek;

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                bool empty = false, flag = false;

                empty = CheckComboBox();

                if (textBox1.Text.ToString() == "" || textBox2.Text.ToString() == "")
                    throw new Exept(1);
                if (comboBox1.SelectedItem == null)
                {
                    if (empty == true)
                        throw new Exept(2);
                    flag = true;
                }


                learningsystem.GetSyllabus()[0].StudentInfo.Name = textBox1.Text.ToString();
                learningsystem.GetSyllabus()[0].StudentInfo.Surname = textBox2.Text.ToString();
                if (flag == false)
                    learningsystem.GetSyllabus()[0].StudentInfo.Level = comboBox1.SelectedItem.ToString();
                else
                    learningsystem.GetSyllabus()[0].StudentInfo.Level = comboBox1.Text;

                this.Hide();
                Form2 newform2 = new Form2(learningsystem);
                newform2.Dock = DockStyle.Fill;

                newform2.ShowDialog();
            }
            catch (Exept er)
            {
                er.SearchError();
            }
        }

        public bool CheckComboBox()
        {
            if(comboBox1.Text != "")
            {
                if (comboBox1.Text == "a1" || comboBox1.Text == "a2")
                    return false;
                if (comboBox1.Text == "b1" || comboBox1.Text == "b2")
                    return false;
                if (comboBox1.Text == "c1" || comboBox1.Text == "c2")
                    return false;
            }
                
            return true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
                
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            AboutBox1 about = new AboutBox1();
            about.Show();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }


    }
}
