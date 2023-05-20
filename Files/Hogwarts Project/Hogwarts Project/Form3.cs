using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hogwarts_Project
{
    public partial class Form3 : Form
    {
        Globals globals = Globals.Instance;
        int Check = 1;
        string TimeCheck = null;
        public Form3()
        {
            InitializeComponent();
        }
        public void Label1Text(string Username)
        {
            label1.Text = Username;

        }

        int IndexFinder()
        {
            int i = 0;
            for (i = 0; i < globals.Teachers.Length; i++)
            {
                if (globals.Teachers[i].Username == label1.Text)
                {
                    break;
                }
            }
            return i;
        }


        private void Form3_Load(object sender, EventArgs e)
        {

            int Index = IndexFinder();
            comboBox1.DataSource = globals.Courses;
            globals.Teachers[Index].CurrentCourses = new List<Courses>();
            comboBox1.Text = null;
            label2.Text = $"Welcome {globals.Teachers[Index].FirstName} {globals.Teachers[Index].LastName}";
            dateTimePicker1.Hide();
            dateTimePicker2.Hide();
            button5.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (Check == 5)
                {

                    Exception exception = new Exception();
                    throw exception;
                }
                int Index = IndexFinder();
                if (globals.Teachers[Index].CanTeachSimultaneously)
                {
                    if (globals.Courses[comboBox1.SelectedIndex].Teacher == null)
                    {
                        globals.Courses[comboBox1.SelectedIndex].Teacher = $"{globals.Teachers[Index].FirstName} {globals.Teachers[Index].LastName}";
                        listBox1.Items.Add(globals.Courses[comboBox1.SelectedIndex].ToString());
                        globals.Teachers[Index].CurrentCourses.Add(globals.Courses[comboBox1.SelectedIndex]);
                        comboBox1.Text = null;
                        ++Check;

                    }
                    else
                    {
                        Exception exception = new Exception();
                        throw exception;
                    }
                }
                else
                {
                    if (globals.Courses[comboBox1.SelectedIndex].Teacher == null && globals.Courses[comboBox1.SelectedIndex].Time != TimeCheck)
                    {
                        globals.Courses[comboBox1.SelectedIndex].Teacher = $"{globals.Teachers[Index].FirstName} {globals.Teachers[Index].LastName}";
                        listBox1.Items.Add(globals.Courses[comboBox1.SelectedIndex].ToString());
                        globals.Teachers[Index].CurrentCourses.Add(globals.Courses[comboBox1.SelectedIndex]);
                        TimeCheck = globals.Courses[comboBox1.SelectedIndex].Time;
                        comboBox1.Text = null;
                        ++Check;

                    }
                    else
                    {
                        Exception exception = new Exception();
                        throw exception;
                    }
                }






            }
            catch (Exception)
            {
                MessageBox.Show("Erorr!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

            int Index = IndexFinder();
            globals.Teachers[Index].CanTeachSimultaneously = true;
            checkBox1.AutoCheck = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                int Index = IndexFinder();
                for (int i = 0; i < listBox1.Items.Count; i++)
                {
                    if (globals.Teachers[Index].CurrentCourses[i].Name == "Botanical1" || globals.Teachers[Index].CurrentCourses[i].Name == "Botanical2" || globals.Teachers[Index].CurrentCourses[i].Name == "Botanical3" || globals.Teachers[Index].CurrentCourses[i].Name == "Botanical4")
                    {
                        Courses.HasBHomework = true;
                        dateTimePicker1.Show();
                        dateTimePicker2.Show();
                        button5.Show();

                    }
                }
                Courses.BHomeworkStartTime = dateTimePicker2.Value;
                Courses.BHomeworkFinishTime = dateTimePicker1.Value;
                if (Courses.BHomeworkStartTime > Courses.BHomeworkFinishTime)
                {
                    Courses.BHomeworkStartTime = DateTime.MinValue;
                    Courses.BHomeworkFinishTime = DateTime.MinValue;
                    Exception exception = new Exception();
                    throw exception;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Erorr!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {

            try
            {
                int Index = IndexFinder();
                for (int i = 0; i < listBox1.Items.Count; i++)
                {
                    if (globals.Teachers[Index].CurrentCourses[i].Name == "Chemistry1" || globals.Teachers[Index].CurrentCourses[i].Name == "Chemistry2" || globals.Teachers[Index].CurrentCourses[i].Name == "Chemistry3" || globals.Teachers[Index].CurrentCourses[i].Name == "Chemistry4")
                    {
                        Courses.HasCHomework = true;
                        dateTimePicker1.Show();
                        dateTimePicker2.Show();
                        button5.Show();
                    }
                }
                Courses.CHomeworkStartTime = dateTimePicker2.Value;
                Courses.CHomeworkFinishTime = dateTimePicker1.Value;
                if (Courses.CHomeworkStartTime > Courses.CHomeworkFinishTime)
                {
                    Courses.CHomeworkStartTime = DateTime.MinValue;
                    Courses.CHomeworkFinishTime = DateTime.MinValue;
                    Exception exception = new Exception();
                    throw exception;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Erorr!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("DONE!");
        }
    }
}
