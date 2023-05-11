using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Hogwarts_Project
{

    public partial class Form2 : Form
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
        public Form2()
        {
            InitializeComponent();

        }
        public void Label1Text(string Username)
        {
            label1.Text = Username;
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            int Index = IndexFinder();
            label2.Text = $"Welcome {globals.Student[Index].FirstName} {globals.Student[Index].LastName}";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }






        private void label2_Click(object sender, EventArgs e)
        {

            label2.Text = globals.Student[0].HasLuggage.ToString();

        }



        private void button3_Click(object sender, EventArgs e)
        {
            //  if(textBox1.Text ==admin.MassageReceiver)
            //  {
            MessageBox.Show(admin.Message);
            //}
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DateTime Now = DateTime.Now;
            TimeSpan timeSpan = admin.TicketTime - Now;
            if (timeSpan.TotalSeconds > 0)
            {
                int Index = IndexFinder();
                globals.Student[Index].IsInHogwarts = true;
                globals.Student[Index].Term++;
                MessageBox.Show("Welcome to Hogwarts,Please sign in again to enter hogwarts.");
                this.DialogResult = DialogResult.OK;

            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
