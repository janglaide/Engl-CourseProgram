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
    public partial class Form3 : Form
    {
        LearningSystem learningsystem;
        Test test;
        public Form3()
        {
            InitializeComponent();
        }

        public Form3(LearningSystem ls)
        {
            
            learningsystem = ls;
            InitializeComponent();
            test = new Test();
            labelYS.Hide();
            labelScore.Hide();
            LLbutton.Hide();
            levelup.Hide();
            button1.Hide();
            label1.BackColor = Color.Transparent;
            labelYS.BackColor = Color.Transparent;
            labelScore.BackColor = Color.Transparent;
            label2.BackColor = Color.Transparent;
            label3.BackColor = Color.Transparent;
            label4.BackColor = Color.Transparent;
            label5.BackColor = Color.Transparent;
            label6.BackColor = Color.Transparent;
            label7.BackColor = Color.Transparent;
            label8.BackColor = Color.Transparent;
            label9.BackColor = Color.Transparent;
            label10.BackColor = Color.Transparent;
            label11.BackColor = Color.Transparent;
        }

        private void ReadFileRTB_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void startButton_Click(object sender, EventArgs e)
        {
            string filename_t = learningsystem.GetSyllabus()[0].StudentInfo.Level + "test1.txt";
            StreamReader sr = new StreamReader(filename_t);
            ReadFileRTB.Text = sr.ReadToEnd();
            sr.Close();
            startButton.Enabled = false;
        }

        private void q4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void checkButton_Click(object sender, EventArgs e)
        {
            bool flag = true, flag1 = true;
            string[] answers = {"","","","","","","","","",""};

            flag = Checkemptycombobox();
            flag1 = CheckComboBox();

            try
            {
                if (flag == false)
                {
                    if (flag1 == false)
                        throw new Exept(2);
                }
                if (flag1 == false)
                    throw new Exept(2);
                if (flag == true)
                {
                    answers[0] = q1.SelectedItem.ToString();
                    answers[1] = q2.SelectedItem.ToString();
                    answers[2] = q3.SelectedItem.ToString();
                    answers[3] = q4.SelectedItem.ToString();
                    answers[4] = q5.SelectedItem.ToString();
                    answers[5] = q6.SelectedItem.ToString();
                    answers[6] = q7.SelectedItem.ToString();
                    answers[7] = q8.SelectedItem.ToString();
                    answers[8] = q9.SelectedItem.ToString();
                    answers[9] = q10.SelectedItem.ToString();
                }
                else
                {
                    answers[0] = q1.Text;
                    answers[1] = q2.Text;
                    answers[2] = q3.Text;
                    answers[3] = q4.Text;
                    answers[4] = q5.Text;
                    answers[5] = q6.Text;
                    answers[6] = q7.Text;
                    answers[7] = q8.Text;
                    answers[8] = q9.Text;
                    answers[9] = q10.Text;
                }

                labelYS.Show();
                int s = test.Testing(learningsystem, answers);
                labelScore.Text = s.ToString();
                labelScore.Show();
                if (s != 10)
                {
                    LLbutton.Show();
                    button1.Show();
                }
                else
                    levelup.Show();

                checkButton.Enabled = false;
            }
            catch (Exept er)
            {
                er.SearchError();
            }

        }

        public bool CheckComboBox()
        {
            if (q1.Text == "")
                return false;
            else
            {
                if (q1.Text == "1" || q1.Text == "2" || q1.Text == "3") { }
                else return false;

                if (q2.Text == "1" || q2.Text == "2" || q2.Text == "3") { }
                else return false;

                if (q3.Text == "1" || q3.Text == "2" || q3.Text == "3") { }
                else return false;

                if (q4.Text == "1" || q4.Text == "2" || q4.Text == "3") { }
                else return false;

                if (q5.Text == "1" || q5.Text == "2" || q5.Text == "3") { }
                else return false;

                if (q6.Text == "1" || q6.Text == "2" || q6.Text == "3") { }
                else return false;

                if (q7.Text == "1" || q7.Text == "2" || q7.Text == "3") { }
                else return false;

                if (q8.Text == "1" || q8.Text == "2" || q8.Text == "3") { }
                else return false;

                if (q9.Text == "1" || q9.Text == "2" || q9.Text == "3") { }
                else return false;

                if (q10.Text == "1" || q10.Text == "2" || q10.Text == "3") { }
                else return false;

            }
            return true;
        }

        public bool Checkemptycombobox() {
            if (null == q1.SelectedItem)
                return false;
            if (null == q2.SelectedItem)
                return false;
            if (null == q3.SelectedItem)
                return false;
            if (null == q4.SelectedItem)
                return false;
            if (null == q5.SelectedItem)
                return false;
            if (null == q6.SelectedItem)
                return false;
            if (null == q7.SelectedItem)
                return false;
            if (null == q8.SelectedItem)
                return false;
            if (null == q9.SelectedItem)
                return false;
            if (null == q10.SelectedItem)
                return false;
            return true;
        }

        private void LLbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 newform4 = new Form4(learningsystem);
            newform4.Dock = DockStyle.Fill;
            newform4.ShowDialog();
        }

        private void levelup_Click(object sender, EventArgs e)
        {
            string lev = learningsystem.GetSyllabus()[0].StudentInfo.Level;
            if (lev[0] == 'a' && lev[1] == '2')
                learningsystem.GetSyllabus()[0].StudentInfo.Level = "b1";
            else if (lev[0] == 'b' && lev[1] == '1')
                learningsystem.GetSyllabus()[0].StudentInfo.Level = "b2";
            else if (lev[0] == 'b' && lev[1] == '2')
                learningsystem.GetSyllabus()[0].StudentInfo.Level = "c1";
            else if (lev[0] == 'c' && lev[1] == '1')
                learningsystem.GetSyllabus()[0].StudentInfo.Level = "c2";
            else if (lev[0] == 'c' && lev[1] == '2') 
                MessageBox.Show("You`ve passed all levels!\n Congratulations!");
            this.Hide();
            Form2 newform = new Form2(learningsystem);
            newform.Dock = DockStyle.Fill;
            newform.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 newform2 = new Form2(learningsystem);
            newform2.Dock = DockStyle.Fill;
            newform2.ShowDialog();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 newform2 = new Form2(learningsystem);
            newform2.Dock = DockStyle.Fill;
            newform2.ShowDialog();
        }

        private void q1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
