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
            Index = int.Parse(label1.Text);
        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            int Result = random.Next(1, 5);
            label3.Text = Result.ToString();
            if (globals.Student[int.Parse(label1.Text)].Term == 1)
                label2.Text = $"Please bring back {Result} of {Botanical.FirstTermPlants[Result].Name}";
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (numericUpDown1.Value == int.Parse(label3.Text))
            {
                globals.Student[int.Parse(label1.Text)].HasDoneBHomework = true;
                MessageBox.Show("Well done!");
                this.DialogResult = DialogResult.OK;

            }
            else
            {
                MessageBox.Show("Better luck next time!");
                this.DialogResult = DialogResult.OK;

            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
