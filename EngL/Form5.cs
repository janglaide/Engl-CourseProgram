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
    public partial class Form5 : Form
    {
        LearningSystem learningsystem;
        Test test;
        public Form5()
        {
            InitializeComponent();
        }

        public Form5(LearningSystem ls)
        {
            InitializeComponent();
            learningsystem = ls;
            test = new Test();
            labelYS.Hide();
            labelScore.Hide();
            resultButton.Hide();
            nextTestButton.Hide();
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

        private void startButton_Click(object sender, EventArgs e)
        {
            /////////////////////////////////////
            string filename_t = learningsystem.GetSyllabus()[0].GetTest()[learningsystem.GetSyllabus()[0].Current_th] + "_test1.txt";
            StreamReader sr = new StreamReader(filename_t);
            ReadFileRTB.Text = sr.ReadToEnd();
            sr.Close();
            startButton.Enabled = false;
        }

        public bool Checkemptycombobox(bool flag)
        {
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
        private void checkButton_Click(object sender, EventArgs e)
        {
            bool flag = true;
            string[] answers = { "", "", "", "", "", "", "", "", "", "" };

            flag = Checkemptycombobox(flag);

            try
            {
                if (flag == false)
                    throw new Exept(3);
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
                labelYS.Show();
                if (test.Check(learningsystem, answers) == true)
                {
                    //delete theory from test list 
                    learningsystem.GetSyllabus()[0].GetTest().RemoveAt(0);

                }
                int s = 10 - learningsystem.GetSyllabus()[0].Incorrect;
                labelScore.Text = s.ToString();
                labelScore.Show();
                resultButton.Show();
                nextTestButton.Show();
                checkButton.Enabled = false;

                if (learningsystem.GetSyllabus()[0].GetTest().Count == 0)       //if there is no theory to learn
                {
                    nextTestButton.Enabled = false;
                    MessageBox.Show(" You`ve learnt all themes you needed!\n Pass the level test in the result page");
                }
            }
            catch (Exept er)
            {
                er.SearchError();
            }
        }

        private void nextTestButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            //Form5 newform5 = new Form5(learningsystem);
            Form4 newform5 = new Form4(learningsystem);
            newform5.Dock = DockStyle.Fill;
            newform5.ShowDialog();
        }

        private void resultButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 newform2 = new Form2(learningsystem);
            newform2.Dock = DockStyle.Fill;
            newform2.ShowDialog();
        }

        private void Form5_Load(object sender, EventArgs e)
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
