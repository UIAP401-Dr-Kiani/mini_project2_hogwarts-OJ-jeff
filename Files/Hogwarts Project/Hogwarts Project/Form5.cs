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
    public partial class Form5 : Form
    {
        Dumbeldore admin = Dumbeldore.Instance;
        Globals globals = Globals.Instance;
        int IndexFinder()
        {
            //globals.StudentSort();
            int i = 0;
            for (i = 0; i < globals.Student.Length; i++)
            {
                if (globals.Student[i].Username == label1.Text)
                {
                    break;
                }
            }
            return i;
        }
        public void Label1Text(string Username)
        {
            label1.Text = Username;
        }
        public Form5()
        {
            InitializeComponent();
            int Index = IndexFinder();
            label3.Text = $"{globals.Student[Index].FirstName} {globals.Student[Index].LastName}";
        }

        private void Form5_Load(object sender, EventArgs e)
        {
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
