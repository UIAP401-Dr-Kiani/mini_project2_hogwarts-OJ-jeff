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
    public partial class Form6 : Form
    {
        Globals globals = Globals.Instance;
        int Index = -1;
        Random random = new Random();

        public void LabelText(int Index)
        {
            label1.Text = Index.ToString();
        }
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            label1.Hide();
            label3.Hide();
            label4.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Index = int.Parse(label1.Text);
            int Result = random.Next(1, 5);
            int RandomIndex = random.Next(1, 2);
            label4.Text = RandomIndex.ToString();
            label3.Text = Result.ToString();
            if (globals.Student[int.Parse(label1.Text)].Term == 1)
                label2.Text = $"Please bring back {Result} of {Botanical.FirstTermPlants[RandomIndex].Name}";
            else if (globals.Student[int.Parse(label1.Text)].Term == 2)
            {
                label2.Text = $"Please bring back {Result} of {Botanical.SecondTermPlants[Result].Name}";

            }
            else if (globals.Student[int.Parse(label1.Text)].Term == 3)
            {
                label2.Text = $"Please bring back {Result} of {Botanical.ThirdTermPlants[Result].Name}";

            }
            else if (globals.Student[int.Parse(label1.Text)].Term == 4)
            {
                label2.Text = $"Please bring back {Result} of {Botanical.FourthTermsPlants[Result].Name}";

            }
        }

        private NumericUpDown GetNumericUpDown1()
        {
            return numericUpDown1;
        }

        private void button1_Click(object sender, EventArgs e, NumericUpDown numericUpDown1)
        {
            if (Courses.HasBHomework || Courses.BHomeworkStartTime < DateTime.Now || DateTime.Now < Courses.BHomeworkFinishTime)
            {
                Index = int.Parse(label1.Text);
                if (numericUpDown1.Value == decimal.Parse(label3.Text))
                {
                    globals.Student[int.Parse(label1.Text)].HasDoneBHomework = true;
                    if (globals.Student[Index].Term==1)
                    {
                        //Botanical.FirstTermPlants[int.Parse(label4.Text)].Number -=numericUpDown1.Value;
                    }
                    MessageBox.Show("Well done!");
                    this.DialogResult = DialogResult.OK;

                }
                else
                {
                    MessageBox.Show("Better luck next time!");
                    this.DialogResult = DialogResult.OK;

                }
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

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
