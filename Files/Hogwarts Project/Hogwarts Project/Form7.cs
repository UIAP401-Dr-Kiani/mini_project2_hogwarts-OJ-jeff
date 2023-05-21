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
    public partial class Form7 : Form
    {
        Globals globals = new Globals();
        public Form7()
        {
            InitializeComponent();
        }
        int Index = -1;
        public void LabelText(int Index)
        {
            label1.Text = Index.ToString();
        }
        private void Form7_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = ColorsClass.colors;
            comboBox2.DataSource = ColorsClass.colors;
            comboBox3.DataSource = ColorsClass.colors;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (Courses.HasCHomework || Courses.CHomeworkStartTime < DateTime.Now || DateTime.Now < Courses.CHomeworkFinishTime)
                {
                    Index = int.Parse(label1.Text);
                    globals.ChemHomeworkReport.Add(textBox1.Text + $"......{globals.Student[Index].FirstName} {globals.Student[Index].LastName},final answer:{comboBox1.Text}+{comboBox2.Text}={comboBox3.Text}");
                    MessageBox.Show("Message Sent.");
                    this.DialogResult = DialogResult.OK;
                }
                else if (DateTime.Now >= Courses.BHomeworkFinishTime)
                {
                    MessageBox.Show("The submission deadline has passed.");
                }
                else
                {
                    MessageBox.Show("This course don't have homework currently.");
                }
            }
            catch (Exception)
            {
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Red + Yellow = Orange\r\nBlue + Green = Turquoise\r\nPurple + Pink = Magenta\r\nBlack + White = Gray\r\nGreen + Yellow = Lime Green\r\nRed + Blue = Purple\r\nOrange + Brown = Rust\r\nPink + Gray = Dusty Rose\r\nBlue + Purple = Indigo\r\nYellow + Orange = Peach");
        }
    }
}
