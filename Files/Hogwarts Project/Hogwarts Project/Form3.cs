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
        public Form3()
        {
            InitializeComponent();
        }
        public void Label1Text(string Username)
        {
            label1.Text = Username;
            comboBox1.DataSource = globals.Courses;
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
            comboBox1.Text = null;
            label2.Text = $"Welcome {globals.Teachers[Index].FirstName} {globals.Teachers[Index].LastName}";
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
                    button1.Hide();
                    Exception exception = new Exception();
                    throw exception;
                }
                int Index = IndexFinder();
                if (globals.Courses[comboBox1.SelectedIndex].Teacher == null)
                {
                    globals.Courses[comboBox1.SelectedIndex].Teacher = $"{globals.Teachers[Index].FirstName} {globals.Teachers[Index].LastName}";
                    listBox1.Items.Add(globals.Courses[comboBox1.SelectedIndex].ToString());
                    comboBox1.Text = null;
                    ++Check;

                }
                else
                {
                    Exception exception = new Exception();
                    throw exception;
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
    }
}
